// ------------------------------------------------------------------------------
//  This is a sample that show the following:
//   - How to Validate xml file against UBL invoice schema file
//   - How to read an UBL 2.0 xml invoice in to a .NET type
// ------------------------------------------------------------------------------

using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace InvoiceSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please change the paths if you have a local copy of the UBL zip package (remote download is slow)
            string xmsschemaFilename = @"..\..\..\UBL-2.1\xsd\maindoc\UBL-Invoice-2.1.xsd";

            LoadAndValidateInvoice("UBL-Invoice-2_0-Example.xml", xmsschemaFilename);

            LoadAndValidateInvoice("UBL-Invoice-2_0-ExampleWithError.xml", xmsschemaFilename);
        }

        private static void LoadAndValidateInvoice(string xmlFilename, string xmlSchemaFilename )
        {
            UblLarsen.Ubl2.InvoiceType invoice = null;
            using (FileStream fs = File.OpenRead(xmlFilename))
            {
                // Validation
                XDocument xmlInvoice = XDocument.Load(fs);
                if (!ValidateUblDocument(xmlInvoice, xmlSchemaFilename))
                {
                    Console.WriteLine("Invalid document. Unable to continue");
                    return;
                }
                fs.Position = 0;

                // Load xml into an invoiceType instance by using Xmlserializer
                XmlSerializer xs = new XmlSerializer(typeof(UblLarsen.Ubl2.InvoiceType));
                invoice = (UblLarsen.Ubl2.InvoiceType)xs.Deserialize(fs);
            }

            // Show some values from the invoice
            if (invoice != null)
            {
                Console.WriteLine("Invoice id: {0}", invoice.ID.Value);
                Console.WriteLine("Issue date: {0}", invoice.IssueDate.Value.ToShortDateString());
                Console.WriteLine("  Due Date: {0}", invoice.PaymentMeans[0].PaymentDueDate.Value.ToShortDateString());
                Console.WriteLine("Amount due: {0} ({1})", invoice.LegalMonetaryTotal.PayableAmount.Value, invoice.LegalMonetaryTotal.PayableAmount.currencyID);
            }
        }

        // Validation is not part of the UBL Larsen library.
        private static bool ValidateUblDocument(XDocument ublDocument, string xsdFilename)
        {
            bool res = true;
            XmlSchemaSet ublDocSchemaSet = new XmlSchemaSet();

            ValidationEventHandler valHandler = (s, e) =>
            {
                Console.WriteLine("{0}: {1}", e.Severity.ToString(), e.Message);
                if (e.Severity == XmlSeverityType.Error) res = false;
            };

            string preLoadToAvoidExceptionFilename = @"..\..\..\UBL-2.1\xsd\common\UBL-xmldsig-core-schema-2.1.xsd";
            using (XmlTextReader tr = new XmlTextReader(preLoadToAvoidExceptionFilename))
            {
                ublDocSchemaSet.Add(XmlSchema.Read(tr, valHandler));
            }

            using (XmlTextReader tr = new XmlTextReader(xsdFilename))
            {
                ublDocSchemaSet.Add(XmlSchema.Read(tr, valHandler));
            }

            try
            {
                System.Xml.Schema.Extensions.Validate(ublDocument, ublDocSchemaSet, valHandler);
            }
            catch (Exception e)
            {
                // Errors should be handled by valHandler above
                res = false;
                Console.WriteLine("Schema validation blew up. " + e.Message);
            };

            return res;
        }
    }
}
