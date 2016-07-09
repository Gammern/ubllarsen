using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace UblLarsen.Tools
{
    public class UblDoc<T> where T : Ubl2.UblBaseDocumentType
    {
        public static T Create(string filename)
        {
            T doc = default(T);
            using (XmlReader xr = XmlReader.Create(filename))
            {
                XmlSerializer xs = new XmlSerializer(typeof(T));
                doc = (T)xs.Deserialize(xr);
            }
            return doc;
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
                xs.Serialize(writer, doc, doc.Xmlns);
            }
        }
    }
}
