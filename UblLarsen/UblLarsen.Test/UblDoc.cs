using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace UblLarsen.Test
{
    public class UblDoc<T> where T:Ubl2.UblBaseDocumentType
    {
        public static T Create(string filename)
        {
            T doc = default(T);
            string whereDoWeEndupInThisVersionOfVSTestFilename = Path.Combine("xml", filename);
            using (XmlReader xr = XmlReader.Create(whereDoWeEndupInThisVersionOfVSTestFilename))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                doc = (T)xs.Deserialize(xr);
            }
            return doc;
        }

        private static XmlSerializerNamespaces ublNamespaces;
        public static XmlSerializerNamespaces UblNamespaces
        {
            get
            {
                if (ublNamespaces == null)
                {
                    ublNamespaces = new XmlSerializerNamespaces(
                        new XmlQualifiedName[] 
                        {
                            new XmlQualifiedName("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
                            new XmlQualifiedName("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
                            new XmlQualifiedName("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"),
                            new XmlQualifiedName("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"),
                            new XmlQualifiedName("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"),
                            new XmlQualifiedName("", (typeof(T).GetCustomAttributes(typeof(XmlTypeAttribute), false).FirstOrDefault() as XmlTypeAttribute).Namespace)
                        });
                    
                }
                return ublNamespaces;
            }
        }

        public static void Save(string filename, T doc)
        {
            using (StreamWriter sw = File.CreateText(filename))
            {
                Save(sw.BaseStream, doc);
            }
        }

        public static void Save(Stream stream, T doc)
        {
            XmlWriterSettings setting = new XmlWriterSettings();
            setting.CloseOutput = false;
            setting.Indent = true;
            setting.IndentChars = "\t";
            setting.NamespaceHandling = NamespaceHandling.OmitDuplicates;
            XmlSerializer xs = new XmlSerializer(typeof(T));
            using (XmlWriter writer = XmlWriter.Create(stream, setting))
            {
                doc.Xmlns = UblNamespaces;
                xs.Serialize(writer, doc);//, UblNamespaces);
            }
        }
    }
}
