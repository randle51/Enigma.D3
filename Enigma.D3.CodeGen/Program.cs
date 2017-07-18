using Enigma.D3.MemoryModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.CodeGen
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            if (args.Contains("-core"))
            {
                MemoryContext.Current = MemoryContext.FromMiniDump();
                Core.Generator.Run();
            }
            if (args.Contains("-sno") || args.Contains("-assets"))
            {
                MemoryContext.Current = MemoryContext.FromMiniDump();
                Assets.Generator.Run();
            }
        }

        public static DirectoryInfo SolutionDirectory
        {
            get
            {
                var solutionDir = new DirectoryInfo(Environment.CurrentDirectory);
                while (File.Exists(Path.Combine(solutionDir.FullName, "Enigma.D3.sln")) == false)
                {
                    if (solutionDir.Parent == null)
                        throw new InvalidOperationException("Unable to locate solution directory.");
                    solutionDir = solutionDir.Parent;
                }
                return solutionDir;
            }
        }

        public static bool DeployGeneratedCode => Environment.GetCommandLineArgs().Contains("-deploy");
    }
}
