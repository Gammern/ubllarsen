using System;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.XmlDiffPatch;
using UblLarsen.Ubl2;

namespace UblLarsen.Test
{


    /// <summary>
    ///This is a test class for InvoiceTypeTest and is intended
    ///to contain all InvoiceTypeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UblDocLoadTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion



        [TestMethod()]
        public void ReadCreditNote()
        {
            string filename = "UBL-CreditNote-2.0-Example.xml";
            CreditNoteType doc = UblDoc<CreditNoteType>.Create(filename);
            string value = doc.AccountingCustomerParty.Party.PartyName[0].Name;
            Assert.AreEqual("IYT Corporation", value);

            bool areEqual = UblXmlComparer.IsCopyEqual<CreditNoteType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

        [TestMethod()]
        public void ReadInvoice()
        {
            string filename = "UBL-Invoice-2.0-Example.xml";
            InvoiceType doc = UblDoc<InvoiceType>.Create(filename);

            string name = doc.AccountingCustomerParty.Party.PartyName[0].Name; //.Value; use implicit string conversion
            Assert.AreEqual(name, "IYT Corporation");

            bool areEqual = UblXmlComparer.IsCopyEqual<InvoiceType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written invoice differs from the one read");

        }

        [TestMethod]
        public void ReadForwardingInstructionInternational()
        {
            string filename = "UBL-ForwardingInstructions-2.0-Example-International.xml";
            ForwardingInstructionsType doc = UblDoc<ForwardingInstructionsType>.Create(filename);
            Assert.AreEqual("Mr Fred Churchill", doc.Shipment.Consignment[0].ConsigneeParty.Contact.Name.Value);

            bool areEqual = UblXmlComparer.IsCopyEqual<ForwardingInstructionsType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

        [TestMethod]
        public void ReadOrderInternational()
        {
            string filename = "UBL-Order-2.0-Example-International.xml";
            OrderType doc = UblDoc<OrderType>.Create(filename);
            Assert.AreEqual("Mrs Bouquet", doc.SellerSupplierParty.Party.Contact.Name.Value);
            bool areEqual = UblXmlComparer.IsCopyEqual<OrderType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

        [TestMethod]
        public void ReadOrder()
        {
            string filename = "UBL-Order-2.0-Example.xml";
            OrderType doc = UblDoc<OrderType>.Create(filename);
            Assert.AreEqual("bouquet@fpconsortial.co.uk", doc.SellerSupplierParty.Party.Contact.ElectronicMail.Value);
            bool areEqual = UblXmlComparer.IsCopyEqual<OrderType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

        [TestMethod]
        public void ReadOrderresponseSimple()
        {
            string filename = "UBL-OrderResponseSimple-2.0-Example.xml";
            OrderResponseSimpleType doc = UblDoc<OrderResponseSimpleType>.Create(filename);
            Assert.AreEqual("Farthing Purchasing Consortia", doc.SellerSupplierParty.Party.PartyTaxScheme[0].RegistrationName.Value);
            bool areEqual = UblXmlComparer.IsCopyEqual<OrderResponseSimpleType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

        [TestMethod]
        public void ReadQuotation()
        {
            string filename = "UBL-Quotation-2.0-Example.xml";
            QuotationType doc = UblDoc<QuotationType>.Create(filename);
            Assert.AreEqual("Busy Street", doc.SellerSupplierParty.Party.PostalAddress.StreetName.Value);
            bool areEqual = UblXmlComparer.IsCopyEqual<QuotationType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

        [TestMethod]
        public void ReadReceiptAdvice()
        {
            string filename = "UBL-ReceiptAdvice-2.0-Example.xml";
            ReceiptAdviceType doc = UblDoc<ReceiptAdviceType>.Create(filename);
            Assert.AreEqual("Heremouthshire", (string)doc.DespatchSupplierParty.Party.PostalAddress.CountrySubentity);
            bool areEqual = UblXmlComparer.IsCopyEqual<ReceiptAdviceType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

        [TestMethod]
        public void ReadRemittanceAdvice()
        {
            string filename = "UBL-RemittanceAdvice-2.0-Example.xml";
            RemittanceAdviceType doc = UblDoc<RemittanceAdviceType>.Create(filename);
            Assert.AreEqual("849FBBCE-E081-40B4-906C-94C5FF9D1AC3", (string)doc.RemittanceAdviceLine[0].BillingReference[0].InvoiceDocumentReference.UUID);
            bool areEqual = UblXmlComparer.IsCopyEqual<RemittanceAdviceType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

        [TestMethod]
        public void ReadRequestForQuotation()
        {
            string filename = "UBL-RequestForQuotation-2.0-Example.xml";
            RequestForQuotationType doc = UblDoc<RequestForQuotationType>.Create(filename);
            Assert.AreEqual("56A", doc.Delivery[0].DeliveryAddress.BuildingNumber.Value);
            bool areEqual = UblXmlComparer.IsCopyEqual<RequestForQuotationType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

        [TestMethod]
        public void ReadStatement()
        {
            string filename = "UBL-Statement-2.0-Example.xml";
            StatementType doc = UblDoc<StatementType>.Create(filename);
            UblLarsen.Ubl2.Udt.AmountType line = doc.StatementLine[0].CreditLineAmount;
            Assert.AreEqual(107.50M, line.Value);
            Assert.AreEqual("GBP", line.currencyID); // Codelist is a problem
            bool areEqual = UblXmlComparer.IsCopyEqual<StatementType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

        [TestMethod]
        public void ReadWaybillInternational()
        {
            string filename = "UBL-Waybill-2.0-Example-International.xml";
            WaybillType doc = UblDoc<WaybillType>.Create(filename);
            Assert.AreEqual("urn:oasis:names:specification:ubl:xpath:Waybill-2.0:samples-2.0-draft", doc.CustomizationID.Value);
            bool areEqual = UblXmlComparer.IsCopyEqual<WaybillType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void ReadInvoiceBogusNode()
        {
            string filename = "InvoiceBogusXml.xml";
            InvoiceType doc = UblDoc<InvoiceType>.Create(filename);
            Assert.AreEqual(null, doc, "Should not be possible to read malformed xml");
        }

        [TestMethod]
        public void ReadNorwegianInvoice()
        {
            string filename = "BII04 T10 gyldig faktura med alle elementer.xml";
            InvoiceType doc = UblDoc<InvoiceType>.Create(filename);
            Assert.AreEqual("Accounting department", doc.AccountingCustomerParty.Party.PostalAddress.Department.Value);
            bool areEqual = UblXmlComparer.IsCopyEqual<InvoiceType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

        [TestMethod]
        public void ReadNorwegianCreditNote()
        {
            string filename = "BII05 T14 0 gyldig kreditnota med alle elementer.xml";
            CreditNoteType doc = UblDoc<CreditNoteType>.Create(filename);
            Assert.AreEqual("5645342123", doc.AccountingCustomerParty.Party.PartyLegalEntity[0].CompanyID.Value);
            bool areEqual = UblXmlComparer.IsCopyEqual<CreditNoteType>(filename, doc);
            Assert.AreEqual(areEqual, true, "Written UBL doc differs from original");
        }

        [TestMethod, ExpectedException(typeof(System.InvalidOperationException))]
        public void ReadWrongDocTypeByMistake()
        {
            string filename = "UBL-Invoice-2.0-Example.xml"; // This is not a credit note, next codeline must fail
            CreditNoteType doc = UblDoc<CreditNoteType>.Create(filename);
        }

        /// <summary>
        /// Test the xml parsing performance, not i/o subsystem. Conclusion: XmlSerializer won't become a "writer" bottleneck.
        /// Time writing 1000 invoices to memory: v2.0: 0:00:00:01,0611129 (Core 2 Duo T9400@2.53GHz)
        ///                                       v2.0: 0:00:00:00,6097625 (Xeon E31225@3.1GHz) 
        ///                                       v2.1: 0:00:00:00.5245539 (Xeon E31225@3.1GHz) Faster than 2.0 :-)
        ///                                       v2.1: 0:00:00:00.4848004 (i7-3820qm)
        /// </summary>
        [TestMethod]
        public void Write1000InvoicesToMem()
        {
            int count = 1000;
            MemoryStream[] buffer = new MemoryStream[count];
            for (int i = 0; i < count; i++)
            {
                buffer[i] = new MemoryStream(0x4000);
            }
            InvoiceType[] docs = 
            {
                UblDoc<InvoiceType>.Create("UBL-Invoice-2.0-Example.xml"),
                UblDoc<InvoiceType>.Create("BII04 T10 gyldig faktura med alle elementer.xml")
            };
            // Testrun to initialize just in case this is the only test we run
            using (MemoryStream ms = new MemoryStream(0x4000))
            {
                UblDoc<InvoiceType>.Save(ms, docs[0]);
            }

            // Now the real timed test
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < count; i++)
            {
                UblDoc<InvoiceType>.Save(buffer[i], docs[i % 2]);
            }
            stopWatch.Stop();

            for (int i = 0; i < count; i++)
            {
                buffer[i].Dispose();
            }
            this.TestContext.WriteLine("Time writing {0} invoices to memory: {1}", count, stopWatch.Elapsed.ToString("G"));
        }

    }
}
