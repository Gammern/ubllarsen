using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLTransportationStatusRequest21Example
    {
        public static TransportationStatusRequestType Create()
        {
            return new TransportationStatusRequestType
            {
                UBLVersionID = "2.1",
                ID = "TSR_1",
                IssueDate = XmlConvert.ToDateTime("2011-10-06", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "09:29:10+01:00",
                TransportationStatusTypeCode = "All deviations",
                TransportExecutionPlanDocumentReference = new DocumentReferenceType
                {
                    ID = "TEP_1"
                },
                Consignment = new ConsignmentType[]
                {
                    new ConsignmentType
                    {
                        ID = "CON_1"
                    }
                }
            }
;
        }
    }
}
