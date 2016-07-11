using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using UblLarsen.Ubl2;

namespace UblLarsen.Test
{
    [TestClass]
    public class IntegrationTests
    {
        public bool TestDocument<T>(string filename, Func<T> Create) where T:UblBaseDocumentType
        {
            string genFilename = Path.ChangeExtension(filename, ".generated.xml");
            T doc = Create();
            Tools.UblDoc<T>.Save(genFilename, doc);
            return Tools.UblXmlComparer.IsCopyEqual(filename, doc);
        }

        [TestMethod]
        public void MyTransportationStatusTest()
        {
            bool areEqual = TestDocument("MyTransportationStatus.xml", UblClass.MyTransportationStatus.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLCreditNote20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-CreditNote-2.0-Example.xml", UblClass.UBLCreditNote20Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLCreditNote21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-CreditNote-2.1-Example.xml", UblClass.UBLCreditNote21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLDebitNote21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-DebitNote-2.1-Example.xml", UblClass.UBLDebitNote21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLDespatchAdvice20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-DespatchAdvice-2.0-Example.xml", UblClass.UBLDespatchAdvice20Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLExceptionCriteria21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-ExceptionCriteria-2.1-Example.xml", UblClass.UBLExceptionCriteria21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLExceptionNotification21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-ExceptionNotification-2.1-Example.xml", UblClass.UBLExceptionNotification21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLForecast21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Forecast-2.1-Example.xml", UblClass.UBLForecast21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLForecastRevision21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-ForecastRevision-2.1-Example.xml", UblClass.UBLForecastRevision21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLForwardingInstructions20ExampleInternationalTest()
        {
            bool areEqual = TestDocument("UBL-ForwardingInstructions-2.0-Example-International.xml", UblClass.UBLForwardingInstructions20ExampleInternational.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLFreightInvoice21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-FreightInvoice-2.1-Example.xml", UblClass.UBLFreightInvoice21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLFulfilmentCancellation21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-FulfilmentCancellation-2.1-Example.xml", UblClass.UBLFulfilmentCancellation21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLGoodsItemItinerary21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-GoodsItemItinerary-2.1-Example.xml", UblClass.UBLGoodsItemItinerary21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLInstructionForReturns21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-InstructionForReturns-2.1-Example.xml", UblClass.UBLInstructionForReturns21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLInventoryReport21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-InventoryReport-2.1-Example.xml", UblClass.UBLInventoryReport21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLInvoice20DetachedTest()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Detached.xml", UblClass.UBLInvoice20Detached.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
            Assert.Fail("Signatures/extensions not implemented!");
        }

        [TestMethod]
        public void UBLInvoice20EnvelopedTest()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Enveloped.xml", UblClass.UBLInvoice20Enveloped.Create);
            Assert.Fail("Signatures/extensions not implemented!");
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLInvoice20ExampleNS1Test()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Example-NS1.xml", UblClass.UBLInvoice20ExampleNS1.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLInvoice20ExampleNS2Test()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Example-NS2.xml", UblClass.UBLInvoice20ExampleNS2.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLInvoice20ExampleNS3Test()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Example-NS3.xml", UblClass.UBLInvoice20ExampleNS3.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLInvoice20ExampleNS4Test()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Example-NS4.xml", UblClass.UBLInvoice20ExampleNS4.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLInvoice20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.0-Example.xml", UblClass.UBLInvoice20Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLInvoice21ExampleTrivialTest()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.1-Example-Trivial.xml", UblClass.UBLInvoice21ExampleTrivial.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLInvoice21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Invoice-2.1-Example.xml", UblClass.UBLInvoice21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLOrder20ExampleInternationalTest()
        {
            bool areEqual = TestDocument("UBL-Order-2.0-Example-International.xml", UblClass.UBLOrder20ExampleInternational.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLOrder20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Order-2.0-Example.xml", UblClass.UBLOrder20Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLOrder21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Order-2.1-Example.xml", UblClass.UBLOrder21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLOrderCancellation21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-OrderCancellation-2.1-Example.xml", UblClass.UBLOrderCancellation21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLOrderChange21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-OrderChange-2.1-Example.xml", UblClass.UBLOrderChange21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLOrderResponse21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-OrderResponse-2.1-Example.xml", UblClass.UBLOrderResponse21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLOrderResponseSimple20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-OrderResponseSimple-2.0-Example.xml", UblClass.UBLOrderResponseSimple20Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLOrderResponseSimple21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-OrderResponseSimple-2.1-Example.xml", UblClass.UBLOrderResponseSimple21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLProductActivity21Example1Test()
        {
            bool areEqual = TestDocument("UBL-ProductActivity-2.1-Example-1.xml", UblClass.UBLProductActivity21Example1.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLProductActivity21Example2Test()
        {
            bool areEqual = TestDocument("UBL-ProductActivity-2.1-Example-2.xml", UblClass.UBLProductActivity21Example2.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLProductActivity21Example3Test()
        {
            bool areEqual = TestDocument("UBL-ProductActivity-2.1-Example-3.xml", UblClass.UBLProductActivity21Example3.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLQuotation20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Quotation-2.0-Example.xml", UblClass.UBLQuotation20Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLQuotation21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Quotation-2.1-Example.xml", UblClass.UBLQuotation21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLReceiptAdvice20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-ReceiptAdvice-2.0-Example.xml", UblClass.UBLReceiptAdvice20Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLReminder21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Reminder-2.1-Example.xml", UblClass.UBLReminder21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLRemittanceAdvice20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-RemittanceAdvice-2.0-Example.xml", UblClass.UBLRemittanceAdvice20Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLRequestForQuotation20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-RequestForQuotation-2.0-Example.xml", UblClass.UBLRequestForQuotation20Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLRequestForQuotation21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-RequestForQuotation-2.1-Example.xml", UblClass.UBLRequestForQuotation21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLRetailEvent21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-RetailEvent-2.1-Example.xml", UblClass.UBLRetailEvent21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLSelfBilledCreditNote21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-SelfBilledCreditNote-2.1-Example.xml", UblClass.UBLSelfBilledCreditNote21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLStatement20ExampleTest()
        {
            bool areEqual = TestDocument("UBL-Statement-2.0-Example.xml", UblClass.UBLStatement20Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLStockAvailabilityReport21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-StockAvailabilityReport-2.1-Example.xml", UblClass.UBLStockAvailabilityReport21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLTradeItemLocationProfile21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TradeItemLocationProfile-2.1-Example.xml", UblClass.UBLTradeItemLocationProfile21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLTransportationStatus21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportationStatus-2.1-Example.xml", UblClass.UBLTransportationStatus21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLTransportationStatusRequest21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportationStatusRequest-2.1-Example.xml", UblClass.UBLTransportationStatusRequest21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLTransportExecutionPlan21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportExecutionPlan-2.1-Example.xml", UblClass.UBLTransportExecutionPlan21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLTransportExecutionPlanRequest21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportExecutionPlanRequest-2.1-Example.xml", UblClass.UBLTransportExecutionPlanRequest21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLTransportProgressStatus21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportProgressStatus-2.1-Example.xml", UblClass.UBLTransportProgressStatus21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLTransportProgressStatusRequest21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportProgressStatusRequest-2.1-Example.xml", UblClass.UBLTransportProgressStatusRequest21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLTransportServiceDescription21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportServiceDescription-2.1-Example.xml", UblClass.UBLTransportServiceDescription21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLTransportServiceDescriptionRequest21ExampleTest()
        {
            bool areEqual = TestDocument("UBL-TransportServiceDescriptionRequest-2.1-Example.xml", UblClass.UBLTransportServiceDescriptionRequest21Example.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }

        [TestMethod]
        public void UBLWaybill20ExampleInternationalTest()
        {
            bool areEqual = TestDocument("UBL-Waybill-2.0-Example-International.xml", UblClass.UBLWaybill20ExampleInternational.Create);
            Assert.IsTrue(areEqual, "Written invoice differs from the one read");
        }
    }
}
