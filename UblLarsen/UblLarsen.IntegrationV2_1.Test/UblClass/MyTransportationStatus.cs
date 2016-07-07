using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class MyTransportationStatus
    {
        public static TransportationStatusType Create()
        {
            return new TransportationStatusType
            {
                UBLExtensions = new UBLExtensionType[]
                {
                    new UBLExtensionType
                    {
                    }
                },
                UBLVersionID = "2.1",
                CustomizationID = "urn:X-demo:TransportShipments",
                ProfileID = "urn:X-demo:CoreElement",
                ID = "1234",
                IssueDate = XmlConvert.ToDateTime("2010-08-13", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "15:30:00.0Z",
                Description = new TextType[]
                {
                    new TextType
                    {
                        Value = "En route"
                    }
                },
                Consignment = new ConsignmentType[]
                {
                    new ConsignmentType
                    {
                        ID = "XYZ987",
                        SummaryDescription = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Electronic components"
                            }
                        }
                    }
                },
                TransportEvent = new TransportEventType[]
                {
                    new TransportEventType
                    {
                        CurrentStatus = new StatusType[]
                        {
                            new StatusType
                            {
                                ConditionCode = "31",
                                Description = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "En route"
                                    }
                                }
                            }
                        },
                        Contact = new ContactType[]
                        {
                            new ContactType
                            {
                                Name = "John Smith",
                                ElectronicMail = "jsmith@example.com"
                            }
                        }
                    }
                }
            }
;
        }
    }
}
