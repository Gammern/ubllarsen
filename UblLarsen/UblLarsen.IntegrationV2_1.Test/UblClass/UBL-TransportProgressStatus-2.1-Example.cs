using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLTransportProgressStatus21Example
    {
        public static TransportProgressStatusType Create()
        {
            return new TransportProgressStatusType
            {
                UBLVersionID = "2.1",
                ID = "TPSR_1",
                IssueDate = XmlConvert.ToDateTime("2011-10-03", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "14:30:10+01:00",
                StatusAvailableIndicator = true,
                SenderParty = new PartyType
                {
                    PartyIdentification = new PartyIdentificationType[]
                    {
                        new PartyIdentificationType
                        {
                            ID = new IdentifierType
                            {
                                schemeAgencyName = "GS1",
                                schemeName = "GLN",
                                Value = "4058673821325"
                            }
                        }
                    },
                    PartyName = new PartyNameType[]
                    {
                        new PartyNameType
                        {
                            Name = "ARRIVA"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "SomeName",
                        Telephone = "+49450557888",
                        ElectronicMail = "SomeName@arriva.de"
                    }
                },
                ReceiverParty = new PartyType
                {
                    PartyIdentification = new PartyIdentificationType[]
                    {
                        new PartyIdentificationType
                        {
                            ID = new IdentifierType
                            {
                                schemeAgencyName = "GS1",
                                schemeName = "GLN",
                                Value = "4058673827641"
                            }
                        }
                    },
                    PartyName = new PartyNameType[]
                    {
                        new PartyNameType
                        {
                            Name = "NECOSS"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "SomeName",
                        Telephone = "+49450557000",
                        ElectronicMail = "SomeName@necoss.de"
                    }
                },
                SourceIssuerParty = new PartyType
                {
                    PartyIdentification = new PartyIdentificationType[]
                    {
                        new PartyIdentificationType
                        {
                            ID = new IdentifierType
                            {
                                schemeAgencyName = "GS1",
                                schemeName = "GLN",
                                Value = "4058673821325"
                            }
                        }
                    },
                    PartyName = new PartyNameType[]
                    {
                        new PartyNameType
                        {
                            Name = "ARRIVA"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "SomeName",
                        Telephone = "+49450557888",
                        ElectronicMail = "SomeName@arriva.de"
                    }
                },
                TransportProgressStatusRequestDocumentReference = new DocumentReferenceType
                {
                    ID = new IdentifierType
                    {
                        schemeName = "MovementReferenceNumber",
                        Value = "TPS_1"
                    }
                },
                TransportMeans = new TransportMeansType
                {
                    JourneyID = "RHamBrem",
                    RegistrationNationalityID = "DE",
                    TransportMeansTypeCode = "230",
                    RailTransport = new RailTransportType
                    {
                        TrainID = "RID01235"
                    }
                },
                TransportSchedule = new TransportScheduleType[]
                {
                    new TransportScheduleType
                    {
                        SequenceNumeric = 1M,
                        ReliabilityPercent = 80M,
                        StatusLocation = new LocationType
                        {
                            LocationTypeCode = "13",
                            Address = new AddressType
                            {
                                ID = new IdentifierType
                                {
                                    schemeAgencyName = "GS1",
                                    schemeName = "GLN",
                                    Value = "4568763527610"
                                },
                                StreetName = "Ludwig-Erhard-Str. 15",
                                CityName = "Bremen",
                                Country = new CountryType
                                {
                                    IdentificationCode = "DE"
                                }
                            }
                        },
                        EstimatedArrivalTransportEvent = new TransportEventType
                        {
                            Period = new PeriodType[]
                            {
                                new PeriodType
                                {
                                    StartDate = XmlConvert.ToDateTime("2011-10-03", XmlDateTimeSerializationMode.RoundtripKind),
                                    StartTime = "18:30:10+01:00",
                                    EndDate = XmlConvert.ToDateTime("2011-10-03", XmlDateTimeSerializationMode.RoundtripKind),
                                    EndTime = "18:35:10+01:00"
                                }
                            }
                        }
                    }
                }
            }
;
        }
    }
}
