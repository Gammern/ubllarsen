using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using UblLarsen.Ubl2;

// Insert the ubl xml document into a dummy envelope like the following
//
//   <?xml version="1.0" encoding="UTF-8"?>
//   <envl:UblDummyEnvelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" 
//                          xmlns:xsd="http://www.w3.org/2001/XMLSchema" 
//                          xmlns:envl="http://ubllarsen/ublsample/envelope">
//     <envl:Documents>
//        ----------- ubl xml document goes in here -----------
//     </envl:Documents>
//   </envl:UblDummyEnvelope>
//
namespace UblLarsen.Tools
{
    public static class Constants
    {
        public const string DummyEnvelopeNamespace = "http://ubllarsen/ublsample/dummyenvelope";
    }

    [System.Xml.Serialization.XmlRootAttribute(Namespace = Constants.DummyEnvelopeNamespace, IsNullable = false)]
    public class DummyEnvelope
    {
        [XmlArrayItem("Waybill", typeof(WaybillType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Waybill-2")]
        [XmlArrayItem("UtilityStatement", typeof(UtilityStatementType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UtilityStatement-2")]
        [XmlArrayItem("UnawardedNotification", typeof(UnawardedNotificationType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UnawardedNotification-2")]
        [XmlArrayItem("TransportServiceDescriptionRequest", typeof(TransportServiceDescriptionRequestType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportServiceDescriptionRequest-2")]
        [XmlArrayItem("TransportServiceDescription", typeof(TransportServiceDescriptionType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportServiceDescription-2")]
        [XmlArrayItem("TransportProgressStatusRequest", typeof(TransportProgressStatusRequestType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportProgressStatusRequest-2")]
        [XmlArrayItem("TransportProgressStatus", typeof(TransportProgressStatusType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportProgressStatus-2")]
        [XmlArrayItem("TransportExecutionPlanRequest", typeof(TransportExecutionPlanRequestType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportExecutionPlanRequest-2")]
        [XmlArrayItem("TransportExecutionPlan", typeof(TransportExecutionPlanType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportExecutionPlan-2")]
        [XmlArrayItem("TransportationStatusRequest", typeof(TransportationStatusRequestType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportationStatusRequest-2")]
        [XmlArrayItem("TransportationStatus", typeof(TransportationStatusType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportationStatus-2")]
        [XmlArrayItem("TradeItemLocationProfile", typeof(TradeItemLocationProfileType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TradeItemLocationProfile-2")]
        [XmlArrayItem("TenderReceipt", typeof(TenderReceiptType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TenderReceipt-2")]
        [XmlArrayItem("TendererQualificationResponse", typeof(TendererQualificationResponseType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TendererQualificationResponse-2")]
        [XmlArrayItem("TendererQualification", typeof(TendererQualificationType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TendererQualification-2")]
        [XmlArrayItem("Tender", typeof(TenderType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Tender-2")]
        [XmlArrayItem("StockAvailabilityReport", typeof(StockAvailabilityReportType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:StockAvailabilityReport-2")]
        [XmlArrayItem("Statement", typeof(StatementType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Statement-2")]
        [XmlArrayItem("SelfBilledInvoice", typeof(SelfBilledInvoiceType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SelfBilledInvoice-2")]
        [XmlArrayItem("SelfBilledCreditNote", typeof(SelfBilledCreditNoteType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SelfBilledCreditNote-2")]
        [XmlArrayItem("RetailEvent", typeof(RetailEventType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:RetailEvent-2")]
        [XmlArrayItem("RequestForQuotation", typeof(RequestForQuotationType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:RequestForQuotation-2")]
        [XmlArrayItem("RemittanceAdvice", typeof(RemittanceAdviceType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:RemittanceAdvice-2")]
        [XmlArrayItem("Reminder", typeof(ReminderType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Reminder-2")]
        [XmlArrayItem("ReceiptAdvice", typeof(ReceiptAdviceType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ReceiptAdvice-2")]
        [XmlArrayItem("Quotation", typeof(QuotationType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Quotation-2")]
        [XmlArrayItem("ProductActivity", typeof(ProductActivityType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ProductActivity-2")]
        [XmlArrayItem("PriorInformationNotice", typeof(PriorInformationNoticeType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:PriorInformationNotice-2")]
        [XmlArrayItem("PackingList", typeof(PackingListType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:PackingList-2")]
        [XmlArrayItem("OrderResponseSimple", typeof(OrderResponseSimpleType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:OrderResponseSimple-2")]
        [XmlArrayItem("OrderResponse", typeof(OrderResponseType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:OrderResponse-2")]
        [XmlArrayItem("OrderChange", typeof(OrderChangeType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:OrderChange-2")]
        [XmlArrayItem("OrderCancellation", typeof(OrderCancellationType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:OrderCancellation-2")]
        [XmlArrayItem("Order", typeof(OrderType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Order-2")]
        [XmlArrayItem("ItemInformationRequest", typeof(ItemInformationRequestType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ItemInformationRequest-2")]
        [XmlArrayItem("Invoice", typeof(InvoiceType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
        [XmlArrayItem("InventoryReport", typeof(InventoryReportType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:InventoryReport-2")]
        [XmlArrayItem("InstructionForReturns", typeof(InstructionForReturnsType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:InstructionForReturns-2")]
        [XmlArrayItem("GuaranteeCertificate", typeof(GuaranteeCertificateType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GuaranteeCertificate-2")]
        [XmlArrayItem("GoodsItemItinerary", typeof(GoodsItemItineraryType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GoodsItemItinerary-2")]
        [XmlArrayItem("FulfilmentCancellation", typeof(FulfilmentCancellationType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:FulfilmentCancellation-2")]
        [XmlArrayItem("FreightInvoice", typeof(FreightInvoiceType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:FreightInvoice-2")]
        [XmlArrayItem("ForwardingInstructions", typeof(ForwardingInstructionsType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ForwardingInstructions-2")]
        [XmlArrayItem("ForecastRevision", typeof(ForecastRevisionType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ForecastRevision-2")]
        [XmlArrayItem("Forecast", typeof(ForecastType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Forecast-2")]
        [XmlArrayItem("ExceptionNotification", typeof(ExceptionNotificationType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ExceptionNotification-2")]
        [XmlArrayItem("ExceptionCriteria", typeof(ExceptionCriteriaType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ExceptionCriteria-2")]
        [XmlArrayItem("DocumentStatusRequest", typeof(DocumentStatusRequestType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DocumentStatusRequest-2")]
        [XmlArrayItem("DocumentStatus", typeof(DocumentStatusType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DocumentStatus-2")]
        [XmlArrayItem("DespatchAdvice", typeof(DespatchAdviceType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2")]
        [XmlArrayItem("DebitNote", typeof(DebitNoteType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2")]
        [XmlArrayItem("CreditNote", typeof(CreditNoteType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2")]
        [XmlArrayItem("ContractNotice", typeof(ContractNoticeType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ContractNotice-2")]
        [XmlArrayItem("ContractAwardNotice", typeof(ContractAwardNoticeType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ContractAwardNotice-2")]
        [XmlArrayItem("CertificateOfOrigin", typeof(CertificateOfOriginType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CertificateOfOrigin-2")]
        [XmlArrayItem("CatalogueRequest", typeof(CatalogueRequestType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CatalogueRequest-2")]
        [XmlArrayItem("CataloguePricingUpdate", typeof(CataloguePricingUpdateType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CataloguePricingUpdate-2")]
        [XmlArrayItem("CatalogueItemSpecificationUpdate", typeof(CatalogueItemSpecificationUpdateType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CatalogueItemSpecificationUpdate-2")]
        [XmlArrayItem("CatalogueDeletion", typeof(CatalogueDeletionType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CatalogueDeletion-2")]
        [XmlArrayItem("Catalogue", typeof(CatalogueType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Catalogue-2")]
        [XmlArrayItem("CallForTenders", typeof(CallForTendersType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CallForTenders-2")]
        [XmlArrayItem("BillOfLading", typeof(BillOfLadingType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:BillOfLading-2")]
        [XmlArrayItem("AwardedNotification", typeof(AwardedNotificationType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:AwardedNotification-2")]
        [XmlArrayItem("AttachedDocument", typeof(AttachedDocumentType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:AttachedDocument-2")]
        [XmlArrayItem("ApplicationResponse", typeof(ApplicationResponseType), Namespace = "urn:oasis:names:specification:ubl:schema:xsd:ApplicationResponse-2")]
        public List<UblBaseDocumentType> Documents = new List<UblBaseDocumentType>();

        //[System.Xml.Serialization.XmlNamespaceDeclarations()]
        //public XmlSerializerNamespaces Xmlns = new XmlSerializerNamespaces(new []
        //    {
        //        new XmlQualifiedName("envl",Constants.DummyEnvelopeNamespace),
        //    });

        static string[] envelopeHeaderXml =
        {
            "<envl:" + nameof(DummyEnvelope),
            "  xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"",
            "  xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"",
            "  xmlns:envl=\"" + Constants.DummyEnvelopeNamespace + "\">",
            "  <envl:Documents>"
        };
        static string[] envelopeFooterXml =
        {
            "  </envl:Documents>",
            "</envl:" + nameof(DummyEnvelope)+ ">"
        };

        public static Stream CreateWrappedEnvelopeStream(FileInfo fileInfo)
        {
            List<string> lines = new List<string>(File.ReadAllLines(fileInfo.FullName));
            lines.InsertRange(1, envelopeHeaderXml); // insert after xml declaration in lines[0]
            lines.AddRange(envelopeFooterXml);

            int capacity = lines.Select(s => s.Length + 2).Sum();
            capacity = (int)Math.Ceiling(capacity / (double)0x100) * 0x100;
            MemoryStream memStream = new MemoryStream(capacity);
            using (var writer = new StreamWriter(memStream, Encoding.UTF8, capacity, true))
            {
                lines.ForEach(l => writer.WriteLine(l));
            }
            memStream.Position = 0;
            return memStream;
        }
    }
}
