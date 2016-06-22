using System;
using System.IO;
using System.Xml.Serialization;
using UblLarsen.Ubl2;

/// <summary>
/// Enumerate/read all ubl xml-files in a folder.
/// Original ubl xml doc is wrapped in dummy envelope prior to deserialize.
/// "Translating" to the correct ubl type is handled by XmlArrayItemAttribute (DummyEnvelope.cs)
/// </summary>
namespace EnumrateUblFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo xmlSamplesDir = new DirectoryInfo(@"..\..\..\UBL-2.1\xml");
            var dummyEnvelopeSerializer = new XmlSerializer(typeof(DummyEnvelope));

            foreach (var xmlFileInfo in xmlSamplesDir.GetFiles("*.xml"))
            {
                using (var stream = DummyEnvelope.CreateWrappedEnvelopeStream(xmlFileInfo))
                {
                    var envelope = (DummyEnvelope)dummyEnvelopeSerializer.Deserialize(stream);
                    if (envelope.Documents.Count > 0)
                    {
                        var ublMaindocBase = envelope.Documents[0];
                        Console.WriteLine($"{ublMaindocBase.GetType().Name,-27} Version:{ublMaindocBase.UBLVersionID?.Value}  {xmlFileInfo.Name}");

                        if (ublMaindocBase is InvoiceType)
                            ProcessInvoice(ublMaindocBase as InvoiceType);
                        else if (ublMaindocBase is ReminderType)
                            ProcessReminder(ublMaindocBase as ReminderType);
                        // ... and so on for other types
                    }
                    else
                    {
                        Console.WriteLine($"Error reading. '{xmlFileInfo.Name}' is not of ublmaindoc type.");
                    }
                }
            }
        }

        private static void ProcessReminder(ReminderType reminder)
        {
            Console.WriteLine("  Processing reminder.....");
        }

        private static void ProcessInvoice(InvoiceType invoice)
        {
            var pa = invoice.LegalMonetaryTotal.PayableAmount; // Cardinality:1, hence no error checking
            Console.WriteLine($"  Processing invoice ......... Payable amount: {pa.currencyID,3} {pa.Value} ");
        }
    }
}
