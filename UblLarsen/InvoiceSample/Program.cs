// ------------------------------------------------------------------------------
//  This is a sample that show the following:
//   - How to Validate xml file against UBL 2.1 invoice schema file
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
            XmlSchemaSet invoiceSchemaSet = CreateInvoiceValidationSchemaSet();

            LoadAndValidateInvoice("UBL-Invoice-2_0-Example.xml", invoiceSchemaSet);
            LoadAndValidateInvoice("UBL-Invoice-2_0-ExampleWithError.xml", invoiceSchemaSet);
        }

        private static void LoadAndValidateInvoice(string xmlFilename, XmlSchemaSet invoiceSchemaSet)
        {
            UblLarsen.Ubl2.InvoiceType invoice = null;
            using (FileStream fs = File.OpenRead(xmlFilename))
            {
                // XDocument can contain any valid xml, dont know if it is an ubl invoice yet
                XDocument xmlInvoice = XDocument.Load(fs);
                if (!ValidateUblInvoiceDocument(xmlInvoice, invoiceSchemaSet))
                {
                    Console.WriteLine("Invalid ubl invoice document, but I will try and read it anyway...");
                }

                // Reuse filestream and load into an InvoiceType instance by using XmlSerializer
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

        private static bool ValidateUblInvoiceDocument(XDocument ublDocument, XmlSchemaSet invoiceSchemaSet)
        {
            bool res = true;

            ValidationEventHandler valHandler = (s, e) =>
            {
                Console.WriteLine("Validation: {0}: {1}", e.Severity.ToString(), e.Message);
                if (e.Severity == XmlSeverityType.Error) res = false;
            };

            try
            {
                System.Xml.Schema.Extensions.Validate(ublDocument, invoiceSchemaSet, valHandler);
            }
            catch (Exception e)
            {
                // Errors should be handled by valHandler above, but you never know...
                res = false;
                Console.WriteLine("Schema validation blew up. " + e.Message);
            };

            return res;
        }

        private static XmlSchemaSet CreateInvoiceValidationSchemaSet()
        {
            string preloadToAvoidExceptionFilename = @"..\..\..\UBL-2.1\xsd\common\UBL-xmldsig-core-schema-2.1.xsd";
            string invoiceSchemaFilename = @"..\..\..\UBL-2.1\xsd\maindoc\UBL-Invoice-2.1.xsd";

            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.ValidationEventHandler += (s, e) =>
            {
                Console.WriteLine("XmlSchemaSet: {0}: {1}", e.Severity.ToString(), e.Message);
            };

            ValidationEventHandler valHandler = (s, e) =>
            {
                Console.WriteLine("XmlTextReader: {0}: {1}", e.Severity.ToString(), e.Message);
            };

            using (XmlTextReader tr = new XmlTextReader(preloadToAvoidExceptionFilename))
            {
                schemaSet.Add(XmlSchema.Read(tr, valHandler));
            }

            using (XmlTextReader tr = new XmlTextReader(invoiceSchemaFilename))
            {
                schemaSet.Add(XmlSchema.Read(tr, valHandler));
            }
            schemaSet.Compile();
            return schemaSet;
        }

        private static void ShowInvoice(UblLarsen.Ubl2.InvoiceType invoice)
        {
            Console.WriteLine("Invoice id: {0}", invoice.ID.Value);
            Console.WriteLine("Issue date: {0}", invoice.IssueDate.Value.ToShortDateString());
            Console.WriteLine("  Due Date: {0}", invoice.PaymentMeans[0].PaymentDueDate.Value.ToShortDateString());
            Console.WriteLine("Amount due: {0} ({1})", invoice.LegalMonetaryTotal.PayableAmount.Value, invoice.LegalMonetaryTotal.PayableAmount.currencyID);
            Console.WriteLine();
        }
    }
}
