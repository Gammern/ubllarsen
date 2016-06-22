using System;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;
using System.Collections.Generic;

namespace UblLarsen.Ubl2
{
    public abstract partial class UblBaseDocumentType
    {
        private static XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("cac","urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
                new XmlQualifiedName("cbc","urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")
            });

        /// <summary>
        /// Takes care of namespace prefix in saved xml documents
        /// </summary>
        [System.Xml.Serialization.XmlNamespaceDeclarations()]
        public XmlSerializerNamespaces Xmlns = xmlns;

        /// <summary>
        /// Only need this dictionary when maindoc node is at top level. 
        /// Read the first node name and create a XmlReader(type) with a type picked from this collection.
        /// </summary>
        public static readonly Dictionary<string, Type> MaindocTypesDictionary = new Dictionary<string, Type>
        {
            ["Waybill"] = typeof(WaybillType),
            ["UtilityStatement"] = typeof(UtilityStatementType),
            ["UnawardedNotification"] = typeof(UnawardedNotificationType),
            ["TransportServiceDescriptionRequest"] = typeof(TransportServiceDescriptionRequestType),
            ["TransportServiceDescription"] = typeof(TransportServiceDescriptionType),
            ["TransportProgressStatusRequest"] = typeof(TransportProgressStatusRequestType),
            ["TransportProgressStatus"] = typeof(TransportProgressStatusType),
            ["TransportExecutionPlanRequest"] = typeof(TransportExecutionPlanRequestType),
            ["TransportExecutionPlan"] = typeof(TransportExecutionPlanType),
            ["TransportationStatusRequest"] = typeof(TransportationStatusRequestType),
            ["TransportationStatus"] = typeof(TransportationStatusType),
            ["TradeItemLocationProfile"] = typeof(TradeItemLocationProfileType),
            ["TenderReceipt"] = typeof(TenderReceiptType),
            ["TendererQualificationResponse"] = typeof(TendererQualificationResponseType),
            ["TendererQualification"] = typeof(TendererQualificationType),
            ["Tender"] = typeof(TenderType),
            ["StockAvailabilityReport"] = typeof(StockAvailabilityReportType),
            ["Statement"] = typeof(StatementType),
            ["SelfBilledInvoice"] = typeof(SelfBilledInvoiceType),
            ["SelfBilledCreditNote"] = typeof(SelfBilledCreditNoteType),
            ["RetailEvent"] = typeof(RetailEventType),
            ["RequestForQuotation"] = typeof(RequestForQuotationType),
            ["RemittanceAdvice"] = typeof(RemittanceAdviceType),
            ["Reminder"] = typeof(ReminderType),
            ["ReceiptAdvice"] = typeof(ReceiptAdviceType),
            ["Quotation"] = typeof(QuotationType),
            ["ProductActivity"] = typeof(ProductActivityType),
            ["PriorInformationNotice"] = typeof(PriorInformationNoticeType),
            ["PackingList"] = typeof(PackingListType),
            ["OrderResponseSimple"] = typeof(OrderResponseSimpleType),
            ["OrderResponse"] = typeof(OrderResponseType),
            ["OrderChange"] = typeof(OrderChangeType),
            ["OrderCancellation"] = typeof(OrderCancellationType),
            ["Order"] = typeof(OrderType),
            ["ItemInformationRequest"] = typeof(ItemInformationRequestType),
            ["Invoice"] = typeof(InvoiceType),
            ["InventoryReport"] = typeof(InventoryReportType),
            ["InstructionForReturns"] = typeof(InstructionForReturnsType),
            ["GuaranteeCertificate"] = typeof(GuaranteeCertificateType),
            ["GoodsItemItinerary"] = typeof(GoodsItemItineraryType),
            ["FulfilmentCancellation"] = typeof(FulfilmentCancellationType),
            ["FreightInvoice"] = typeof(FreightInvoiceType),
            ["ForwardingInstructions"] = typeof(ForwardingInstructionsType),
            ["ForecastRevision"] = typeof(ForecastRevisionType),
            ["Forecast"] = typeof(ForecastType),
            ["ExceptionNotification"] = typeof(ExceptionNotificationType),
            ["ExceptionCriteria"] = typeof(ExceptionCriteriaType),
            ["DocumentStatusRequest"] = typeof(DocumentStatusRequestType),
            ["DocumentStatus"] = typeof(DocumentStatusType),
            ["DespatchAdvice"] = typeof(DespatchAdviceType),
            ["DebitNote"] = typeof(DebitNoteType),
            ["CreditNote"] = typeof(CreditNoteType),
            ["ContractNotice"] = typeof(ContractNoticeType),
            ["ContractAwardNotice"] = typeof(ContractAwardNoticeType),
            ["CertificateOfOrigin"] = typeof(CertificateOfOriginType),
            ["CatalogueRequest"] = typeof(CatalogueRequestType),
            ["CataloguePricingUpdate"] = typeof(CataloguePricingUpdateType),
            ["CatalogueItemSpecificationUpdate"] = typeof(CatalogueItemSpecificationUpdateType),
            ["CatalogueDeletion"] = typeof(CatalogueDeletionType),
            ["Catalogue"] = typeof(CatalogueType),
            ["CallForTenders"] = typeof(CallForTendersType),
            ["BillOfLading"] = typeof(BillOfLadingType),
            ["AwardedNotification"] = typeof(AwardedNotificationType),
            ["AttachedDocument"] = typeof(AttachedDocumentType),
            ["ApplicationResponse"] = typeof(ApplicationResponseType)
        };
            //= typeof(UblBaseDocumentType).GetCustomAttributes(typeof(XmlIncludeAttribute), false)
            //.Cast<XmlIncludeAttribute>().Where(a => a.Type.Name.EndsWith("Type")).ToDictionary(key => key.Type.Name.Substring(0, key.Type.Name.Length - 4), val => val.Type);
    }
}
