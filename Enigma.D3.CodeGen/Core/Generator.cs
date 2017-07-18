using Enigma.D3.MemoryModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen.Core
{
    internal static class Generator
    {
        internal static void Run()
        {
            var dir = new DirectoryInfo("enigma-d3-core-" + MemoryContext.Current.MainModuleVersion);
            var enums = dir.CreateSubdirectory("Enums");
            var project = new SharedProject("da9978d2-8f71-4399-8a57-a789f082e501", "Enigma.D3.Core");

            File.WriteAllText(Path.Combine(enums.FullName, "AttributeId.cs"),
                "namespace Enigma.D3.Enums\r\n{\r\n\tpublic enum AttributeId\r\n\t{\r\n" +
                string.Join(",\r\n", MemoryContext.Current.DataSegment.AttributeDescriptors.Select(a => $"\t\t{GetCleanName(a.Name)} = {a.ID}").ToArray())
                + "\r\n\t}\r\n}\r\n");
            project.AddCompileFile(Path.Combine(enums.FullName, "AttributeId.cs"));

            if (Program.DeployGeneratedCode)
            {
                project.Deploy(
                    dir,
                    Program.SolutionDirectory.CreateSubdirectory(project.RootNamespace + ".Generated"));
            }
        }

        private static string GetCleanName(string attributeName)
        {
            attributeName = attributeName.Replace(' ', '_');
            attributeName = attributeName.Replace("(", "_Of_");
            attributeName = attributeName.Replace(",", "_And_");
            attributeName = attributeName.Replace("__", "_");
            attributeName = attributeName.Replace(")", "");

            attributeName = attributeName.Replace("_", "");
            return attributeName;
        }
    }
}
