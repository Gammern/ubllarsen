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
            LoadAndValidateInvoice("UBL-Invoice-2_0-Example.xml");
            LoadAndValidateInvoice("UBL-Invoice-2_0-ExampleWithError.xml");
        }

        private static void LoadAndValidateInvoice(string xmlFilename)
        {
            UblLarsen.Ubl2.InvoiceType invoice = null;
            using (FileStream fs = File.OpenRead(xmlFilename))
            {
                // Validation
                XDocument xmlInvoice = XDocument.Load(fs);
                if (!ValidateUblDocument(xmlInvoice))
                {
                    Console.WriteLine("Invalid document, but I will try and read it anyway...");
                }

                // Load xml into an invoiceType instance by using Xmlserializer
                XmlSerializer xs = new XmlSerializer(typeof(UblLarsen.Ubl2.InvoiceType));
                try
                {
                    fs.Position = 0;
                    invoice = (UblLarsen.Ubl2.InvoiceType)xs.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            if (invoice != null)
            {
                ShowInvoice(invoice);
            }
        }

        private static void ShowInvoice(UblLarsen.Ubl2.InvoiceType invoice)
        {
            Console.WriteLine("Invoice id: {0}", invoice.ID.Value);
            Console.WriteLine("Issue date: {0}", invoice.IssueDate.Value.ToShortDateString());
            Console.WriteLine("  Due Date: {0}", invoice.PaymentMeans[0].PaymentDueDate.Value.ToShortDateString());
            Console.WriteLine("Amount due: {0} ({1})", invoice.LegalMonetaryTotal.PayableAmount.Value, invoice.LegalMonetaryTotal.PayableAmount.currencyID);
            Console.WriteLine();
        }

        // Validation is not part of the UBL Larsen library.
        private static bool ValidateUblDocument(XDocument ublDocument)
        {
            string preLoadToAvoidExceptionFilename = @"..\..\..\UBL-2.1\xsd\common\UBL-xmldsig-core-schema-2.1.xsd";
            string xsdFilename = @"..\..\..\UBL-2.1\xsd\maindoc\UBL-Invoice-2.1.xsd";
            bool res = true;
            XmlSchemaSet schemaSet = new XmlSchemaSet();

            ValidationEventHandler valHandler = (s, e) =>
            {
                Console.WriteLine("{0}: {1}", e.Severity.ToString(), e.Message);
                if (e.Severity == XmlSeverityType.Error) res = false;
            };
            schemaSet.ValidationEventHandler += valHandler;

            using (XmlTextReader tr = new XmlTextReader(preLoadToAvoidExceptionFilename))
            {
                schemaSet.Add(XmlSchema.Read(tr, valHandler));
            }

            using (XmlTextReader tr = new XmlTextReader(xsdFilename))
            {
                schemaSet.Add(XmlSchema.Read(tr, valHandler));
            }
            schemaSet.Compile();

            try
            {
                System.Xml.Schema.Extensions.Validate(ublDocument, schemaSet, valHandler);
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
