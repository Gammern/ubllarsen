using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLTransportationStatus21Example
    {
        public static TransportationStatusType Create()
        {
            return new TransportationStatusType
            {
                UBLVersionID = "2.1",
                ID = "TS_1",
                IssueDate = XmlConvert.ToDateTime("2011-10-06", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "09:29:30+01:00",
                TransportationStatusTypeCode = "All deviations",
                TransportExecutionStatusCode = "35",
                Consignment = new ConsignmentType[]
                {
                    new ConsignmentType
                    {
                        ID = "CON_1",
                        TransportHandlingUnit = new TransportHandlingUnitType[]
                        {
                            new TransportHandlingUnitType
                            {
                                ID = "CON_THU_1",
                                TransportEquipment = new TransportEquipmentType[]
                                {
                                    new TransportEquipmentType
                                    {
                                        ID = "CON_TE_1"
                                    }
                                },
                                Status = new StatusType[]
                                {
                                    new StatusType
                                    {
                                        ConditionCode = "4",
                                        StatusReasonCode = "23",
                                        StatusReason = new TextType[]
                                        {
                                            new TextType
                                            {
                                                Value = "Reefer container lost power - cargo of fish destroyed"
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                TransportExecutionPlanDocumentReference = new DocumentReferenceType
                {
                    ID = "TEP_1"
                }
            }
;
        }
    }
}
