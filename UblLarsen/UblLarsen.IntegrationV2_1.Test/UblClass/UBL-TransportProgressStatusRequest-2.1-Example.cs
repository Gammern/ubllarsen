// Generated by UblXml2CSharp
using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLTransportProgressStatusRequest21Example
    {
        public static TransportProgressStatusRequestType Create()
        {
            return new TransportProgressStatusRequestType
            {
                UBLVersionID = "2.1",
                ID = "TPS_1",
                IssueDate = "2011-10-03",
                IssueTime = "14:30:10+01:00",
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
                StatusLocation = new LocationType[]
                {
                    new LocationType
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
                    }
                }
            };
        }
    }
}
