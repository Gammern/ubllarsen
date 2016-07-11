using Microsoft.XmlDiffPatch;
using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace UblLarsen.Tools
{
    public class UblXmlComparer
    {
        private static readonly XNamespace cbcNamespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
        private static readonly XName schemaLocationAttrName = XName.Get("schemaLocation", XmlSchema.InstanceNamespace);
        private static readonly XName extensionsElementName = XName.Get("Extensions", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
        private static XmlReaderSettings closeInputSettings = new XmlReaderSettings { CloseInput = true };

        /// <summary>
        /// Compare a ubl document class instance with a xml file on disk.
        /// </summary>
        public static bool IsCopyEqual<T>(string filename, T ublLarsenDoc) where T : UblLarsen.Ubl2.UblBaseDocumentType
        {
            bool areEqual = true;

            using (XmlReader fileReader = CreateReaderForFile(filename))
            using (XmlReader docReader = CreateReaderForDoc(ublLarsenDoc))
            {
                XmlDiffOptions options = XmlDiffOptions.IgnoreComments | XmlDiffOptions.IgnoreWhitespace | XmlDiffOptions.IgnoreNamespaces | XmlDiffOptions.IgnorePI | XmlDiffOptions.IgnoreXmlDecl;
                XmlDiff xmlDiff = new XmlDiff(options);

                using (MemoryStream diffgramStream = new MemoryStream())
                {
                    string diff = "";
                    using (XmlTextWriter diffgramWriter = new XmlTextWriter(new StreamWriter(diffgramStream)))
                    {
                        areEqual = xmlDiff.Compare(fileReader, docReader, diffgramWriter);
                        if (!areEqual)
                        {
                            diffgramStream.Position = 0;
                            using (XmlTextReader tr = new XmlTextReader(diffgramStream))
                            {
                                XDocument xdoc = XDocument.Load(tr);
                                diff = xdoc.ToString();
                                Console.WriteLine(diff);
                            }
                        }
                    }
                }
            }
            return areEqual;
        }

        private static XmlReader CreateReaderForDoc<T>(T ublLarsenDoc) where T : Ubl2.UblBaseDocumentType
        {
            MemoryStream changedMs = new MemoryStream();
            UblDoc<T>.Save(changedMs, ublLarsenDoc);
            changedMs.Position = 0;
            return XmlReader.Create(changedMs, closeInputSettings);
        }

        private static XmlReader CreateReaderForFile(string filename)
        {
            XDocument xDocLoadedFile = XDocument.Load(filename);
            RemoveSchemaLocationAndFormatTime(xDocLoadedFile);
            MemoryStream moddedOrgMs = new MemoryStream();
            using (XmlWriter moddedOrgXw = XmlWriter.Create(moddedOrgMs))
            {
                xDocLoadedFile.WriteTo(moddedOrgXw);
            }
            moddedOrgMs.Position = 0;
            return XmlReader.Create(moddedOrgMs, closeInputSettings);
        }

        private static void RemoveSchemaLocationAndFormatTime(XDocument xDoc)
        {
            XAttribute schemaLocationAttr = xDoc.Root.Attribute(schemaLocationAttrName);
            if (schemaLocationAttr != null)
            {
                schemaLocationAttr.Remove();
            }

            // Format the time string in the inputfile to make XmlComparer happy
            foreach (XElement node in xDoc.Root.Descendants().Where(n => n.Name.Namespace == cbcNamespace && n.Name.LocalName.EndsWith("Time")))
            {
                Ubl2.Udt.TimeType ublTimeType = node.Value; // assigning string will trigger implicit assignment function
                node.Value = ublTimeType.ValueAsXmlString;
            }

            // remove empty elements.
            // http://docs.oasis-open.org/ubl/os-UBL-2.1/UBL-2.1.html#S-EMPTY-ELEMENTS
            foreach (XElement node in xDoc.Root.Elements().Where(e => e.Name != extensionsElementName).Descendants().Where(n => n.IsEmpty).ToList())
            {
                node.Remove();
            }
        }
    }
}
