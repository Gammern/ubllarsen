using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Microsoft.XmlDiffPatch;
using System.Globalization;
using System.Threading;

namespace UblLarsen.Test
{
    public class UblXmlComparer
    {
        /// <summary>
        /// Compare a ubl document class instance with a xml file on disk.
        /// </summary>
        /// <typeparam name="T">ubl document class</typeparam>
        /// <param name="filename">filname to compare the instance with</param>
        /// <param name="originalDoc">class instance</param>
        /// <returns></returns>
        public static bool IsCopyEqual<T>(string filename, T originalDoc) where T : UblLarsen.Ubl2.UblBaseDocumentType
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            string copyFilename = Path.ChangeExtension(filename, ".copy.xml");

            MemoryStream changedMs = new MemoryStream();
            UblDoc<T>.Save(changedMs, originalDoc);
            changedMs.Position = 0;
            XmlReader xrChanged = XmlReader.Create(changedMs);

            // Modify Utc nodes to localtime and remove schema location
            XDocument xDocOrg = XDocument.Load(filename);
            XName schemaLocationAttrName = (XNamespace)"http://www.w3.org/2001/XMLSchema-instance" + "schemaLocation";
            XAttribute schemaLocationAttr = xDocOrg.Root.Attribute(schemaLocationAttrName);
            if (schemaLocationAttr != null)
            {
                schemaLocationAttr.Remove();
            }
            // TimeType props declared under cbc namespace
            XNamespace cbc = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
            foreach (XElement node in xDocOrg.Root.Descendants().Where(n => n.Name.Namespace == cbc && n.Name.LocalName.EndsWith("Time")))
            {
                // Format timestring on sourcedoc to make XmlComparer happy
                Ubl2.Udt.TimeType ublTimeType = new Ubl2.Udt.TimeType { ValueAsXmlString = node.Value };
                // Debugger won't stop on breakpoint for ubl types! 
                string tempNonDebuggerStepThrough = ublTimeType.ValueAsXmlString;
                node.Value = tempNonDebuggerStepThrough;
            }

            MemoryStream moddedOrgMs = new MemoryStream();
            XmlWriter moddedOrgXw = XmlWriter.Create(moddedOrgMs);
            xDocOrg.WriteTo(moddedOrgXw);
            moddedOrgXw.Flush();
            moddedOrgMs.Position = 0;
            XmlReader xrOrg = XmlReader.Create(moddedOrgMs);

            XmlDiffOptions options = XmlDiffOptions.IgnoreComments | XmlDiffOptions.IgnoreWhitespace | XmlDiffOptions.IgnoreNamespaces | XmlDiffOptions.IgnorePI | XmlDiffOptions.IgnoreXmlDecl;
            XmlDiff xmlDiff = new XmlDiff(options);

            bool areEqual = true;
            using (MemoryStream diffgram = new MemoryStream())
            {
                string diff = "";
                using (XmlTextWriter diffgramWriter = new XmlTextWriter(new StreamWriter(diffgram)))
                {
                    areEqual = xmlDiff.Compare(xrOrg, xrChanged, diffgramWriter);
                    if (!areEqual)
                    {
                        diffgram.Position = 0;
                        using (XmlTextReader tr = new XmlTextReader(diffgram))
                        {
                            XDocument xdoc = XDocument.Load(tr);
                            diff = xdoc.ToString();
                            Console.WriteLine(diff);
                        }
                    }
                }
            }
            // Unit test! Not prod code.
            xrOrg.Close();
            xrChanged.Close();
            changedMs.Close();
            moddedOrgXw.Close();
            moddedOrgMs.Close();
            return areEqual;
        }

    }
}
