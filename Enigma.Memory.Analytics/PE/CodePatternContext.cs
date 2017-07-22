using Enigma.Memory.Analytics.Patterns;
using Enigma.Memory.PE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Memory.Analytics.PE
{
    public class Import
    {
        public string Library;
        public string Name;
        public int Ordinal;
        public MemoryAddress Address;

        public override string ToString()
            => $"{Library}.{Name} (ordinal: {Ordinal})";
    }

    public class CodePatternContext
    {
        public readonly MiniDumpMemoryReader Dump;
        private readonly PEHeaderReader _pe;

        public PEHeaderReader PE => _pe;

        public CodePatternContext(MiniDumpMemoryReader dump, PEHeaderReader pe)
        {
            Dump = dump;
            _pe = pe;

            Text = new Range(Dump.ImageBase, _pe.ImageSectionHeaders.First(s => new string(s.Name).StartsWith(".text")));
            Data = new Range(Dump.ImageBase, _pe.ImageSectionHeaders.First(s => new string(s.Name).StartsWith(".data")));
            Resources = new Range(Dump.ImageBase, _pe.ImageSectionHeaders.First(s => new string(s.Name).StartsWith(".rdata")));

            TextBuffer = Dump.ReadBytes(Text.Start, (int)Text.Size);
            DataBuffer = Dump.ReadBytes(Data.Start, (int)Data.Size);
            ResourcesBuffer = Dump.ReadBytes(Resources.Start, (int)Resources.Size);

            Imports = LoadImports();
            EntryPoint = _pe.OptionalHeader32.ImageBase + _pe.OptionalHeader32.AddressOfEntryPoint;
        }

        private List<Import> LoadImports()
        {
            var imports = new List<Import>();
            if (_pe.OptionalHeader32.ImportTable.Size > 0)
            {
                var va = _pe.OptionalHeader32.ImageBase + _pe.OptionalHeader32.ImportTable.VirtualAddress;
                var import_descriptors = Dump.Read<IMAGE_IMPORT_DESCRIPTOR>(
                    va, (int)_pe.OptionalHeader32.ImportTable.Size / StructHelper<IMAGE_IMPORT_DESCRIPTOR>.SizeOf - 1);
                foreach (var import_descriptor in import_descriptors)
                {
                    var lib_name = Dump.ReadString(_pe.OptionalHeader32.ImageBase + import_descriptor.Name, 256);
                    var import_name = _pe.OptionalHeader32.ImageBase + import_descriptor.OriginalFirstThunk;
                    var itd = default(uint);
                    var address = _pe.OptionalHeader32.ImageBase + import_descriptor.FirstThunk;
                    while ((itd = Dump.Read<uint>(import_name)) != 0)
                    {
                        var loc = _pe.OptionalHeader32.ImageBase + itd;

                        int ordinal;
                        string name;

                        if ((itd & 0x80000000) == 0)
                        {
                            ordinal = Dump.Read<ushort>(loc);
                            name = Dump.ReadString(loc + 2, 256);
                        }
                        else
                        {
                            ordinal = (int)(itd & 0x7FFFFFFF);
                            name = "";
                        }
                        imports.Add(new Import { Library = lib_name, Name = name, Ordinal = ordinal, Address = address });
                        import_name += 4;
                        address += 4;
                    }
                }
            }
            if (_pe.OptionalHeader64.ImportTable.Size > 0)
            {
                var va = _pe.OptionalHeader64.ImageBase + _pe.OptionalHeader64.ImportTable.VirtualAddress;
                var import_descriptors = Dump.Read<IMAGE_IMPORT_DESCRIPTOR>(
                    va, (int)_pe.OptionalHeader64.ImportTable.Size / StructHelper<IMAGE_IMPORT_DESCRIPTOR>.SizeOf - 1);
                foreach (var import_descriptor in import_descriptors)
                {
                    var lib_name = Dump.ReadString(_pe.OptionalHeader64.ImageBase + (ulong)import_descriptor.Name, 256);
                    var import_name = _pe.OptionalHeader64.ImageBase + (ulong)import_descriptor.OriginalFirstThunk;
                    var itd = default(uint);
                    var address = _pe.OptionalHeader64.ImageBase + (ulong)import_descriptor.FirstThunk;
                    while ((itd = Dump.Read<uint>(import_name)) != 0)
                    {
                        var loc = _pe.OptionalHeader64.ImageBase + itd;

                        int ordinal;
                        string name;

                        if ((itd & 0x80000000) == 0)
                        {
                            ordinal = Dump.Read<ushort>(loc);
                            name = Dump.ReadString(loc + 2, 256);
                        }
                        else
                        {
                            ordinal = (int)(itd & 0x7FFFFFFF);
                            name = "";
                        }
                        imports.Add(new Import { Library = lib_name, Name = name, Ordinal = ordinal, Address = address });
                        import_name += 8;
                        address += 8;
                    }
                }
            }
            return imports;
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
        private struct IMAGE_IMPORT_DESCRIPTOR
        {
            [System.Runtime.InteropServices.FieldOffset(0)]
            public int Characteristics;
            [System.Runtime.InteropServices.FieldOffset(0)]
            public int OriginalFirstThunk;
            [System.Runtime.InteropServices.FieldOffset(4)]
            public int TimeDateStamp;
            [System.Runtime.InteropServices.FieldOffset(8)]
            public int ForwarderChain;
            [System.Runtime.InteropServices.FieldOffset(12)]
            public int Name;
            [System.Runtime.InteropServices.FieldOffset(16)]
            public int FirstThunk;
        }

        public Range Text { get; }
        public Range Data { get; }
        public Range Resources { get; }
        public byte[] TextBuffer { get; }
        public byte[] DataBuffer { get; }
        public byte[] ResourcesBuffer { get; }
        public List<Import> Imports { get; }
        public MemoryAddress EntryPoint { get; }

        public CodePatternMatch FirstMatchInTextSegment(MemoryAddress start, int length, string pattern)
        {
            if (start < Text.Start ||
                start >= Text.Start + Text.Size)
                throw new ArgumentOutOfRangeException(nameof(start));
            if (length <= 0)
                throw new ArgumentOutOfRangeException(nameof(length));
            if (pattern == null)
                throw new ArgumentNullException(nameof(pattern));

            return CodePattern.Parse(pattern).Matches(Text.Start, TextBuffer, start, length).First();
        }

        public CodePatternMatch FirstMatchInTextSegment(string pattern)
            => FirstMatchInTextSegment(Text.Start, (int)Text.Size, pattern);

        public T FirstMatchInTextSegment<T>(string pattern, string label)
            => FirstMatchInTextSegment<T>(Text.Start, (int)Text.Size, pattern, label);

        public T FirstMatchInTextSegment<T>(MemoryAddress start, int length, string pattern, string label)
            => FirstMatchInTextSegment(start, length, pattern).Read<T>(Dump, label);

        public CodePatternMatch FirstMatchInResourcesSegment(string pattern)
            => FirstMatchInResourcesSegment(Resources.Start, (int)Resources.Size, pattern);

        public CodePatternMatch FirstMatchInResourcesSegment(MemoryAddress start, int length, string pattern)
        {
            if (start < Resources.Start ||
                start >= Resources.Start + Resources.Size)
                throw new ArgumentOutOfRangeException(nameof(start));
            if (length <= 0)
                throw new ArgumentOutOfRangeException(nameof(length));
            if (pattern == null)
                throw new ArgumentNullException(nameof(pattern));

            return CodePattern.Parse(pattern).Matches(Resources.Start, ResourcesBuffer, start, length).First();
        }

        public MemoryAddress FindResourceString(string value)
        {
            // \0{value}\0
            if (!value.StartsWith("\0") && !value.EndsWith("\0"))
            {
                var pText = new BinaryPattern(Encoding.ASCII.GetBytes("\0" + value + "\0"))
                    .NextMatch(ResourcesBuffer, 0);
                if (pText != -1)
                    return 1 + pText + Resources.Start;
            }

            // \0{value}
            if (!value.StartsWith("\0"))
            {
                var pText = new BinaryPattern(Encoding.ASCII.GetBytes("\0" + value))
                    .NextMatch(ResourcesBuffer, 0);
                if (pText != -1)
                    return 1 + pText + Resources.Start;
            }

            // {value}\0
            if (!value.EndsWith("\0"))
            {
                var pText = new BinaryPattern(Encoding.ASCII.GetBytes(value + "\0"))
                    .NextMatch(ResourcesBuffer, 0);
                if (pText != -1)
                    return pText + Resources.Start;
            }

            // fallback
            {
                var pText = new BinaryPattern(Encoding.ASCII.GetBytes(value))
                   .NextMatch(ResourcesBuffer, 0);
                if (pText == -1)
                    return -1;
                return pText + Resources.Start;
            }
        }

        public CodePatternMatch FirstMatchInDataSegment(string pattern)
        {
            return CodePattern.Parse(pattern)
                .Matches(Data.Start, DataBuffer)
                .First();
        }

        public IEnumerable<CodePatternMatch> MatchesInTextSegment(string pattern)
        {
            return CodePattern.Parse(pattern)
                .Matches(Text.Start, TextBuffer);
        }
    }
}
