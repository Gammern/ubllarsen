using System;
using System.IO;
using System.Xml.Schema;

namespace ublxsd
{
    public class UblXsdSettings
    {
        DirectoryInfo baseDir;
        DirectoryInfo commonDir;
        DirectoryInfo maindocDir;

        /// <summary>
        /// Parent of common and maindoc directories from the downloaded/unziped ubl package
        /// </summary>
        public string UblXsdInputPath
        {
            set
            {
                this.baseDir = new DirectoryInfo(value);
                try
                {
                    this.commonDir = baseDir.GetDirectories("common")[0];
                    this.maindocDir = baseDir.GetDirectories("maindoc")[0];
                }
                catch
                {
                    throw new ArgumentException($"{nameof(this.UblXsdInputPath)} must point to xsd folder that have common and maindoc subfolders.", nameof(this.UblXsdInputPath));
                }
                if (this.commonDir.GetFiles("*.xsd").Length == 0 || this.maindocDir.GetFiles("*.xsd").Length == 0)
                    throw new ArgumentException($"{nameof(UblXsdInputPath)} Can't find *.xsd files in common and maindoc subfolders.", nameof(this.UblXsdInputPath));
            }
        }

        public enum FieldTypesEnum { Field, Property, AutoProperty };

        public FieldTypesEnum OptionMemberTypeToGenerate { get; set; }

        public DirectoryInfo MaindocDirectory => maindocDir;

        public DirectoryInfo CommonDirectory => commonDir;

        public ValidationEventHandler XsdValidationEvent { get; set; }

        /// <summary>
        /// Generated codefiles are written to this path
        /// </summary>
        public string CodeGenOutputPath { get; set; }
        
        /// <summary>
        /// Default code namespace used in generated code
        /// </summary>
        public string CSharpDefaultNamespace { get; set; }

        public bool OptionOptimizeCommonBasicComponents { get; internal set; }
    }
}
