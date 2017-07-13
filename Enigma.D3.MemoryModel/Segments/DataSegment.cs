using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.Memory;
using Enigma.D3.MemoryModel.Core;
using Enigma.D3.MemoryModel.Preferences;
using Enigma.D3.MemoryModel.TypeSystem;
using Enigma.D3.MemoryModel.MemoryManagement;
using Enigma.D3.MemoryModel.Assets;

namespace Enigma.D3.MemoryModel.Segments
{
    public class DataSegment : MemoryObject
    {
        public MemoryAddress End
            => throw new NotImplementedException();

        public MemoryAddress Start
            => SymbolTable.Current.DataSegment.Address;

        public VideoPreferences VideoPreferences
            => Memory.Reader.Read<VideoPreferences>(SymbolTable.Current.DataSegment.VideoPreferences);

        public SoundPreferences SoundPreferences
            => Memory.Reader.Read<SoundPreferences>(SymbolTable.Current.DataSegment.SoundPreferences);

        public HotkeyPreferences HotkeyPreferences
            => Memory.Reader.Read<HotkeyPreferences>(SymbolTable.Current.DataSegment.HotkeyPreferences);

        public GameplayPreferences GameplayPreferences
            => Memory.Reader.Read<GameplayPreferences>(SymbolTable.Current.DataSegment.GameplayPreferences);

        public SocialPreferences SocialPreferences
            => Memory.Reader.Read<SocialPreferences>(SymbolTable.Current.DataSegment.SocialPreferences);

        public ChatPreferences ChatPreferences
            => Memory.Reader.Read<ChatPreferences>(SymbolTable.Current.DataSegment.ChatPreferences);

        public LevelArea LevelArea
            => Memory.Reader.Read<Ptr<LevelArea>>(SymbolTable.Current.DataSegment.LevelArea).Dereference();

        public string LevelAreaName
            => Memory.Reader.ReadString(SymbolTable.Current.DataSegment.LevelAreaName, SymbolTable.Current.DataSegment.LevelAreaNameLength);

        public int MapActID
            => Memory.Reader.Read<int>(SymbolTable.Current.DataSegment.MapActID);

        public TrickleManager TrickleManager
            => Memory.Reader.Read<Ptr<TrickleManager>>(SymbolTable.Current.DataSegment.TrickleManager).Dereference();

        public LocalData LocalData
            => Memory.Reader.Read<LocalData>(SymbolTable.Current.DataSegment.LocalData);

        public ObjectManager ObjectManager
            => Memory.Reader.Read<Ptr<ObjectManager>>(SymbolTable.Current.DataSegment.ObjectManager).Dereference();

        public int ApplicationLoopCount
            => Memory.Reader.Read<int>(SymbolTable.Current.DataSegment.ApplicationLoopCount);

        public AttributeDescriptor[] AttributeDescriptors
            => Memory.Reader.Read<AttributeDescriptor>(SymbolTable.Current.DataSegment.AttributeDescriptors, SymbolTable.Current.DataSegment.AttributeDescriptorsCount);

        public MemoryManager MemoryManager
            => Memory.Reader.Read<Ptr<MemoryManager>>(SymbolTable.Current.DataSegment.MemoryManager).Dereference();

        public SNOFiles SNOFiles
            => Memory.Reader.Read<Ptr<SNOFiles>>(SymbolTable.Current.DataSegment.SNOFiles).Dereference();

        public Ptr[] SNOGroupStorage
            => Memory.Reader.Read<Ptr>(SymbolTable.Current.DataSegment.SNOGroupsByCode, 70);
    }
}
