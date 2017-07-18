using Enigma.D3.CodeGen.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Enigma.D3.CodeGen
{
    internal class SharedProject
    {
        private readonly string _guid;
        private readonly string _rootNamespace;
        private readonly List<string> _compileFiles;

        public SharedProject(string guid, string rootNamespace)
        {
            _guid = guid;
            _rootNamespace = rootNamespace;
            _compileFiles = new List<string>();
        }

        public string Guid => _guid;
        public string RootNamespace => _rootNamespace;
        public IReadOnlyList<string> CompileFiles => _compileFiles.AsReadOnly();

        public void AddCompileFile(string fileName)
        {
            _compileFiles.Add(fileName);
        }

        public void Save(string filePath, DirectoryInfo rootDir = null)
        {
            rootDir = rootDir ?? new DirectoryInfo(Path.GetDirectoryName(filePath));
            SaveProjectItemsFile(Path.Combine(
                Path.GetDirectoryName(filePath),
                Path.GetFileNameWithoutExtension(filePath) + ".projitems"),
                rootDir);

            SaveSharedProjectFile(Path.Combine(
                Path.GetDirectoryName(filePath),
                Path.GetFileNameWithoutExtension(filePath) + ".shproj"));
        }

        public void SaveProjectItemsFile(string filePath, DirectoryInfo rootDir = null)
        {
            rootDir = rootDir ?? new FileInfo(filePath).Directory;
            var ns = (XNamespace)"http://schemas.microsoft.com/developer/msbuild/2003";
            var doc = new XDocument(
                new XDeclaration("1.0", "utf-8", null),
                new XElement(ns + "Project",
                    new XElement(ns + "PropertyGroup",
                        new XElement(ns + "MSBuildAllProjects", "$(MSBuildAllProjects);$(MSBuildThisFileFullPath)"),
                        new XElement(ns + "HasSharedItems", true),
                        new XElement(ns + "SharedGUID", _guid)
                    ),
                    new XElement(ns + "PropertyGroup", new XAttribute("Label", "Configuration"),
                        new XElement(ns + "Import_RootNamespace", _rootNamespace)
                    ),
                    new XElement(ns + "ItemGroup", _compileFiles.Select(a =>
                        new XElement(ns + "Compile", new XAttribute("Include", "$(MSBuildThisFileDirectory)" + rootDir.GetRelativePathTo(new FileInfo(a))))).ToArray()
                    )
                )
            );

            var writer = new Utf8StringWriter();
            doc.Save(writer);
            var xml = writer.GetStringBuilder().ToString();

            File.WriteAllText(filePath, xml, writer.Encoding);
        }

        internal void Deploy(DirectoryInfo outputDir, DirectoryInfo projectDir)
        {
            foreach (var file in CompileFiles)
            {
                var relative = Path.IsPathRooted(file) ? outputDir.GetRelativePathTo(new FileInfo(file)) : file;
                var source = Path.IsPathRooted(file) ? file : Path.Combine(outputDir.FullName, relative);
                var destination = Path.Combine(projectDir.FullName, relative);
                Directory.CreateDirectory(Path.GetDirectoryName(destination));
                File.Copy(source, destination, true);
            }
            Save(Path.Combine(projectDir.FullName, projectDir.Name + ".*"), outputDir);
        }

        public void SaveSharedProjectFile(string filePath)
        {
            var projitems = Path.GetFileNameWithoutExtension(filePath) + ".projitems";
            var ns = (XNamespace)"http://schemas.microsoft.com/developer/msbuild/2003";
            var doc = new XDocument(
                new XDeclaration("1.0", "utf-8", null),
                new XElement(ns + "Project", new XAttribute("ToolsVersion", "14.0"), new XAttribute("DefaultTargets", "Build"),
                    new XElement(ns + "PropertyGroup", new XAttribute("Label", "Globals"),
                        new XElement(ns + "ProjectGuid", _guid),
                        new XElement(ns + "MinimumVisualStudioVersion", "14.0")
                    ),
                    new XElement(ns + "Import",
                        new XAttribute("Project", @"$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props"),
                        new XAttribute("Condition", @"Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')")
                    ),
                    new XElement(ns + "Import",
                        new XAttribute("Project", @"$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v$(VisualStudioVersion)\CodeSharing\Microsoft.CodeSharing.Common.Default.props")
                    ),
                    new XElement(ns + "Import",
                        new XAttribute("Project", @"$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v$(VisualStudioVersion)\CodeSharing\Microsoft.CodeSharing.Common.props")
                    ),
                    new XElement(ns + "PropertyGroup"),
                    new XElement(ns + "Import",
                        new XAttribute("Project", projitems),
                        new XAttribute("Label", "Shared")
                    ),
                    new XElement(ns + "Import",
                        new XAttribute("Project", @"$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v$(VisualStudioVersion)\CodeSharing\Microsoft.CodeSharing.CSharp.targets")
                    )
                )
            );

            var writer = new Utf8StringWriter();
            doc.Save(writer);
            var xml = writer.GetStringBuilder().ToString();

            File.WriteAllText(filePath, xml, writer.Encoding);
        }

        class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding
                => Encoding.UTF8;
        }
    }
}
