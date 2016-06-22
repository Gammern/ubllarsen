using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace ublxsd.Extensions
{
    public static class XmlSchemaExtensions
    {
        public static void Dump(this XmlSchema @this, string filename)
        {
            using (var writer = XmlWriter.Create(filename, new XmlWriterSettings { Indent = true }))
            {
                @this.Write(writer);
            }
        }

        /// <summary>
        /// Return "maindoc/somefile.xsd" or "common/someoterfile.xsd"
        /// </summary>
        /// <param name="this"></param>
        /// <returns>filname prefixed with common/ or maindoc/</returns>
        public static string GetFileNameWithSubDirectory(this XmlSchema @this)
        {
            string xsdFilename = new Uri(@this.SourceUri).LocalPath;
            FileInfo fi = new FileInfo(xsdFilename);
            return Path.Combine(fi.Directory.Name,fi.Name);
        }

        /// <summary>
        /// Construct a csharp filename for output code generation.
        /// Take the xsd filename and change exstension to .cs and append the filename to the settings outputDir.
        /// Maintains the "common" and "maindoc" sub dir structure.
        /// </summary>
        /// <param name="outputDir">csharp filename for output</param>
        /// <returns></returns>
        public static string GetCSharpFilename(this XmlSchema @this, string outputDir)
        {
            return Path.Combine(Path.Combine(outputDir, Path.ChangeExtension(GetFileNameWithSubDirectory(@this), ".cs")));
        }

    }
}
