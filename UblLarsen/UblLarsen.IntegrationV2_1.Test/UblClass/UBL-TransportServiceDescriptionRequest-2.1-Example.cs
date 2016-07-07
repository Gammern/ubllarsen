using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLTransportServiceDescriptionRequest21Example
    {
        public static TransportServiceDescriptionRequestType Create()
        {
            return new TransportServiceDescriptionRequestType
            {
                UBLVersionID = "2.1",
                ID = "TSD_REQ_1",
                IssueDate = XmlConvert.ToDateTime("2011-09-12", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "11:01:10+01:00",
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
                                Value = "4058673827000"
                            }
                        }
                    },
                    PartyName = new PartyNameType[]
                    {
                        new PartyNameType
                        {
                            Name = "Consignor"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "SomeName",
                        Telephone = "+8687878763",
                        ElectronicMail = "SomeName@consignor.cn"
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
                TransportationService = new TransportationServiceType[]
                {
                    new TransportationServiceType
                    {
                        TransportServiceCode = "3",
                        TransportEquipment = new TransportEquipmentType[]
                        {
                            new TransportEquipmentType
                            {
                                ID = "1",
                                TransportEquipmentTypeCode = "CN",
                                MeasurementDimension = new DimensionType[]
                                {
                                    new DimensionType
                                    {
                                        AttributeID = "Length",
                                        Measure = new MeasureType
                                        {
                                            unitCode = "MTR",
                                            Value = 6.1M
                                        }
                                    },
                                    new DimensionType
                                    {
                                        AttributeID = "Height",
                                        Measure = new MeasureType
                                        {
                                            unitCode = "MTR",
                                            Value = 2.6M
                                        }
                                    },
                                    new DimensionType
                                    {
                                        AttributeID = "Width",
                                        Measure = new MeasureType
                                        {
                                            unitCode = "MTR",
                                            Value = 2.44M
                                        }
                                    }
                                }
                            },
                            new TransportEquipmentType
                            {
                                ID = "1",
                                TransportEquipmentTypeCode = "CN",
                                MeasurementDimension = new DimensionType[]
                                {
                                    new DimensionType
                                    {
                                        AttributeID = "Length",
                                        Measure = new MeasureType
                                        {
                                            unitCode = "MTR",
                                            Value = 6.1M
                                        }
                                    },
                                    new DimensionType
                                    {
                                        AttributeID = "Height",
                                        Measure = new MeasureType
                                        {
                                            unitCode = "MTR",
                                            Value = 2.6M
                                        }
                                    },
                                    new DimensionType
                                    {
                                        AttributeID = "Width",
                                        Measure = new MeasureType
                                        {
                                            unitCode = "MTR",
                                            Value = 2.44M
                                        }
                                    }
                                }
                            }
                        },
                        ShipmentStage = new ShipmentStageType[]
                        {
                            new ShipmentStageType
                            {
                                ID = "1",
                                RequestedDepartureTransportEvent = new TransportEventType
                                {
                                    Location = new LocationType
                                    {
                                        Address = new AddressType
                                        {
                                            ID = new IdentifierType
                                            {
                                                schemeAgencyName = "UN",
                                                schemeName = "UN/LOCODE",
                                                Value = "DEHAM"
                                            },
                                            StreetName = "Neuer Wandrahm 4",
                                            CityName = "Hamburg",
                                            Country = new CountryType
                                            {
                                                IdentificationCode = "DE"
                                            }
                                        }
                                    },
                                    Period = new PeriodType[]
                                    {
                                        new PeriodType
                                        {
                                            StartDate = XmlConvert.ToDateTime("2011-10-03", XmlDateTimeSerializationMode.RoundtripKind),
                                            EndDate = XmlConvert.ToDateTime("2011-10-03", XmlDateTimeSerializationMode.RoundtripKind)
                                        }
                                    }
                                },
                                RequestedArrivalTransportEvent = new TransportEventType
                                {
                                    Location = new LocationType
                                    {
                                        Address = new AddressType
                                        {
                                            StreetName = "Grosse strasse 34",
                                            CityName = "Nurnberg",
                                            Country = new CountryType
                                            {
                                                IdentificationCode = "DE"
                                            }
                                        }
                                    },
                                    Period = new PeriodType[]
                                    {
                                        new PeriodType
                                        {
                                            StartDate = XmlConvert.ToDateTime("2011-10-06", XmlDateTimeSerializationMode.RoundtripKind),
                                            EndDate = XmlConvert.ToDateTime("2011-10-06", XmlDateTimeSerializationMode.RoundtripKind)
                                        }
                                    }
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
