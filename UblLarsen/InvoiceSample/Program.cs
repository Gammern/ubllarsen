// ------------------------------------------------------------------------------
//  This is a sample that show the following:
//   - How to Validate xml file against UBL 2.1 invoice schema
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
            LoadAndValidateInvoice("NotAnUblDocument.xml", invoiceSchemaSet); // WTF! Validates ok but fail serialization
        }

        private static void LoadAndValidateInvoice(string xmlFilename, XmlSchemaSet invoiceSchemaSet)
        {
            UblLarsen.Ubl2.InvoiceType invoice = null;
            using (FileStream fs = File.OpenRead(xmlFilename))
            {
                Console.WriteLine($"Processing {xmlFilename} ...");
                // XDocument can contain any valid xml, don't know if it is an ubl invoice yet
                XDocument xmlInvoice = XDocument.Load(fs);
                if (!ValidateUblInvoiceDocument(xmlInvoice, invoiceSchemaSet))
                {
                    Console.WriteLine("Invalid ubl invoice document, but I will try and read it anyway...");
                }

                // Reuse filestream and load into an InvoiceType instance by using XmlSerializer
                fs.Position = 0;
                XmlSerializer xs = new XmlSerializer(typeof(UblLarsen.Ubl2.InvoiceType));
                try
                {
                    invoice = (UblLarsen.Ubl2.InvoiceType)xs.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Deserialize: " + ex.Message);
                }
            }

            if (invoice != null)
            {
                ShowInvoice(invoice);
            }
        }

        private static bool ValidateUblInvoiceDocument(XDocument ublDocument, XmlSchemaSet invoiceSchemaSet)
        {
            bool res = false;

            try
            {
                invoiceSchemaSet = CreateInvoiceValidationSchemaSet();
                System.Xml.Schema.Extensions.Validate(ublDocument, invoiceSchemaSet, null, false);
                res = true;
            }
            catch (XmlSchemaValidationException ex)
            {
                Console.WriteLine("Validation: " + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Validation: Unknown error. " + ex.Message);
            }

            return res;
        }

        private static XmlSchemaSet CreateInvoiceValidationSchemaSet()
        {
            string ublXsdDir = @"..\..\..\UBL-2.1\xsd\";
            string preloadToAvoidExceptionFilename = Path.Combine(ublXsdDir, @"common\UBL-xmldsig-core-schema-2.1.xsd");
            string invoiceSchemaFilename = Path.Combine(ublXsdDir, @"maindoc\UBL-Invoice-2.1.xsd");

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
