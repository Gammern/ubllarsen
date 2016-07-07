using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLGoodsItemItinerary21Example
    {
        public static GoodsItemItineraryType Create()
        {
            return new GoodsItemItineraryType
            {
                UBLVersionID = "2.1",
                ID = "1",
                IssueDate = XmlConvert.ToDateTime("2011-09-13", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "10:05:20+01:00",
                VersionID = "1",
                TransportExecutionPlanReferenceID = "TEP_1",
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
                ReferencedTransportEquipment = new TransportEquipmentType[]
                {
                    new TransportEquipmentType
                    {
                        ID = "1",
                        TransportEquipmentSeal = new TransportEquipmentSealType[]
                        {
                            new TransportEquipmentSealType
                            {
                                ID = "1_1",
                                Condition = "IN_RIGHT_CONDITION"
                            }
                        },
                        Package = new PackageType[]
                        {
                            new PackageType
                            {
                                Quantity = 10M,
                                PackagingTypeCode = "PX",
                                GoodsItem = new GoodsItemType[]
                                {
                                    new GoodsItemType
                                    {
                                        Item = new ItemType[]
                                        {
                                            new ItemType
                                            {
                                                CommodityClassification = new CommodityClassificationType[]
                                                {
                                                    new CommodityClassificationType
                                                    {
                                                        CargoTypeCode = "12"
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TransportEquipmentType
                    {
                        ID = "2",
                        TransportEquipmentSeal = new TransportEquipmentSealType[]
                        {
                            new TransportEquipmentSealType
                            {
                                ID = "2_1",
                                Condition = "IN_RIGHT_CONDITION"
                            }
                        },
                        Package = new PackageType[]
                        {
                            new PackageType
                            {
                                Quantity = 10M,
                                PackagingTypeCode = "PX",
                                GoodsItem = new GoodsItemType[]
                                {
                                    new GoodsItemType
                                    {
                                        Item = new ItemType[]
                                        {
                                            new ItemType
                                            {
                                                CommodityClassification = new CommodityClassificationType[]
                                                {
                                                    new CommodityClassificationType
                                                    {
                                                        CargoTypeCode = "12"
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                TransportationSegment = new TransportationSegmentType[]
                {
                    new TransportationSegmentType
                    {
                        SequenceNumeric = 1M,
                        TransportExecutionPlanReferenceID = "TEP_2",
                        TransportationService = new TransportationServiceType
                        {
                            TransportServiceCode = "3",
                            TransportationServiceDescription = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Rail transport service from Hamburg to Bremen"
                                }
                            }
                        },
                        TransportServiceProviderParty = new PartyType
                        {
                            PartyIdentification = new PartyIdentificationType[]
                            {
                                new PartyIdentificationType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyName = "GS1",
                                        schemeName = "GLN",
                                        Value = "4058673827100"
                                    }
                                }
                            },
                            PartyName = new PartyNameType[]
                            {
                                new PartyNameType
                                {
                                    Name = "NTT"
                                }
                            },
                            Contact = new ContactType
                            {
                                Name = "SomeName",
                                Telephone = "+49450557777",
                                ElectronicMail = "SomeName@ntt.de"
                            }
                        },
                        ReferencedConsignment = new ConsignmentType
                        {
                            ID = "NTT_1",
                            TransportHandlingUnit = new TransportHandlingUnitType[]
                            {
                                new TransportHandlingUnitType
                                {
                                    ID = "NTT_THU_1",
                                    TransportEquipment = new TransportEquipmentType[]
                                    {
                                        new TransportEquipmentType
                                        {
                                            ID = "NTT_THU_1",
                                            ContainedInTransportEquipment = new TransportEquipmentType[]
                                            {
                                                new TransportEquipmentType
                                                {
                                                    ID = "NTT_TE_1",
                                                    TransportEquipmentTypeCode = "RR",
                                                    TraceID = "12345678914564"
                                                }
                                            },
                                            Package = new PackageType[]
                                            {
                                                new PackageType
                                                {
                                                    ID = "CON_1",
                                                    Quantity = 10M
                                                }
                                            }
                                        }
                                    }
                                },
                                new TransportHandlingUnitType
                                {
                                    ID = "NTT_THU_2",
                                    TransportEquipment = new TransportEquipmentType[]
                                    {
                                        new TransportEquipmentType
                                        {
                                            ID = "CON_2",
                                            ContainedInTransportEquipment = new TransportEquipmentType[]
                                            {
                                                new TransportEquipmentType
                                                {
                                                    ID = "NTT_TE_2",
                                                    TransportEquipmentTypeCode = "RR",
                                                    TraceID = "12345678914565"
                                                }
                                            },
                                            Package = new PackageType[]
                                            {
                                                new PackageType
                                                {
                                                    ID = "CON_2",
                                                    Quantity = 10M
                                                }
                                            }
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
                                TransportModeCode = "2",
                                TransportMeansTypeCode = "230",
                                PlannedDepartureTransportEvent = new TransportEventType
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
                                            StartTime = "09:30:10+01:00",
                                            EndDate = XmlConvert.ToDateTime("2011-10-03", XmlDateTimeSerializationMode.RoundtripKind),
                                            EndTime = "12:30:10+01:00"
                                        }
                                    }
                                },
                                PlannedArrivalTransportEvent = new TransportEventType
                                {
                                    Location = new LocationType
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
                                    Period = new PeriodType[]
                                    {
                                        new PeriodType
                                        {
                                            StartDate = XmlConvert.ToDateTime("2011-10-03", XmlDateTimeSerializationMode.RoundtripKind),
                                            StartTime = "18:30:10+01:00",
                                            EndDate = XmlConvert.ToDateTime("2011-10-03", XmlDateTimeSerializationMode.RoundtripKind),
                                            EndTime = "21:30:10+01:00"
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TransportationSegmentType
                    {
                        SequenceNumeric = 2M,
                        TransportExecutionPlanReferenceID = "TEP_1",
                        TransportationService = new TransportationServiceType
                        {
                            TransportServiceCode = "3",
                            TransportationServiceDescription = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Rail transport service from Bremen to Nurnberg"
                                }
                            }
                        },
                        TransportServiceProviderParty = new PartyType
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
                        ReferencedConsignment = new ConsignmentType
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
                                            ID = "CON_1",
                                            ContainedInTransportEquipment = new TransportEquipmentType[]
                                            {
                                                new TransportEquipmentType
                                                {
                                                    ID = "NEC_TE_1",
                                                    TransportEquipmentTypeCode = "RR",
                                                    TraceID = "12345678914542"
                                                }
                                            },
                                            Package = new PackageType[]
                                            {
                                                new PackageType
                                                {
                                                    ID = "CON_1",
                                                    Quantity = 10M
                                                }
                                            }
                                        }
                                    }
                                },
                                new TransportHandlingUnitType
                                {
                                    ID = "CON_THU_2",
                                    TransportEquipment = new TransportEquipmentType[]
                                    {
                                        new TransportEquipmentType
                                        {
                                            ID = "CON_2",
                                            ContainedInTransportEquipment = new TransportEquipmentType[]
                                            {
                                                new TransportEquipmentType
                                                {
                                                    ID = "NEC_TE_2",
                                                    TransportEquipmentTypeCode = "RR",
                                                    TraceID = "12345678914543"
                                                }
                                            },
                                            Package = new PackageType[]
                                            {
                                                new PackageType
                                                {
                                                    ID = "CON_2",
                                                    Quantity = 10M
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        },
                        ShipmentStage = new ShipmentStageType[]
                        {
                            new ShipmentStageType
                            {
                                ID = "2",
                                PlannedDepartureTransportEvent = new TransportEventType
                                {
                                    Location = new LocationType
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
                                    Period = new PeriodType[]
                                    {
                                        new PeriodType
                                        {
                                            StartDate = XmlConvert.ToDateTime("2011-10-04", XmlDateTimeSerializationMode.RoundtripKind),
                                            StartTime = "09:30:10+01:00",
                                            EndDate = XmlConvert.ToDateTime("2011-10-04", XmlDateTimeSerializationMode.RoundtripKind),
                                            EndTime = "09:30:10+01:00"
                                        }
                                    }
                                },
                                PlannedArrivalTransportEvent = new TransportEventType
                                {
                                    Location = new LocationType
                                    {
                                        LocationTypeCode = "13",
                                        Address = new AddressType
                                        {
                                            StreetName = "Sandstr. 38-40",
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
                                            StartDate = XmlConvert.ToDateTime("2011-10-04", XmlDateTimeSerializationMode.RoundtripKind),
                                            StartTime = "15:30:10+01:00",
                                            EndDate = XmlConvert.ToDateTime("2011-10-04", XmlDateTimeSerializationMode.RoundtripKind),
                                            EndTime = "18:30:10+01:00"
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new TransportationSegmentType
                    {
                        SequenceNumeric = 3M,
                        TransportExecutionPlanReferenceID = "TEP_3",
                        TransportationService = new TransportationServiceType
                        {
                            TransportServiceCode = "3",
                            TransportationServiceDescription = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Road transport service from Hamburg to Bremen"
                                }
                            }
                        },
                        TransportServiceProviderParty = new PartyType
                        {
                            PartyIdentification = new PartyIdentificationType[]
                            {
                                new PartyIdentificationType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyName = "GS1",
                                        schemeName = "GLN",
                                        Value = "4058673827112"
                                    }
                                }
                            },
                            PartyName = new PartyNameType[]
                            {
                                new PartyNameType
                                {
                                    Name = "EXT-HAL"
                                }
                            },
                            Contact = new ContactType
                            {
                                Name = "SomeName",
                                Telephone = "+49450557234",
                                ElectronicMail = "SomeName@ext-hal.de"
                            }
                        },
                        ReferencedConsignment = new ConsignmentType
                        {
                            ID = "EXT_1",
                            TransportHandlingUnit = new TransportHandlingUnitType[]
                            {
                                new TransportHandlingUnitType
                                {
                                    ID = "EXT_THU_1",
                                    TransportEquipment = new TransportEquipmentType[]
                                    {
                                        new TransportEquipmentType
                                        {
                                            ID = "CON_1",
                                            ContainedInTransportEquipment = new TransportEquipmentType[]
                                            {
                                                new TransportEquipmentType
                                                {
                                                    ID = "EXT_TE_1",
                                                    TransportEquipmentTypeCode = "TE",
                                                    TraceID = "12345678914111"
                                                }
                                            },
                                            Package = new PackageType[]
                                            {
                                                new PackageType
                                                {
                                                    ID = "CON_1",
                                                    Quantity = 10M
                                                }
                                            }
                                        }
                                    },
                                    TransportMeans = new TransportMeansType[]
                                    {
                                        new TransportMeansType
                                        {
                                            RoadTransport = new RoadTransportType
                                            {
                                                LicensePlateID = "WFN667"
                                            }
                                        }
                                    }
                                },
                                new TransportHandlingUnitType
                                {
                                    ID = "EXT_THU_2",
                                    TransportEquipment = new TransportEquipmentType[]
                                    {
                                        new TransportEquipmentType
                                        {
                                            ID = "CON_2",
                                            ContainedInTransportEquipment = new TransportEquipmentType[]
                                            {
                                                new TransportEquipmentType
                                                {
                                                    ID = "EXT_TE_2",
                                                    TransportEquipmentTypeCode = "TE",
                                                    TraceID = "12345678914112"
                                                }
                                            },
                                            Package = new PackageType[]
                                            {
                                                new PackageType
                                                {
                                                    ID = "CON_2",
                                                    Quantity = 10M
                                                }
                                            }
                                        }
                                    },
                                    TransportMeans = new TransportMeansType[]
                                    {
                                        new TransportMeansType
                                        {
                                            RoadTransport = new RoadTransportType
                                            {
                                                LicensePlateID = "WFN667"
                                            }
                                        }
                                    }
                                }
                            }
                        },
                        ShipmentStage = new ShipmentStageType[]
                        {
                            new ShipmentStageType
                            {
                                ID = "3",
                                PlannedDepartureTransportEvent = new TransportEventType
                                {
                                    Location = new LocationType
                                    {
                                        LocationTypeCode = "13",
                                        Address = new AddressType
                                        {
                                            StreetName = "Sandstr. 38-40",
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
                                            StartTime = "09:30:10+01:00",
                                            EndDate = XmlConvert.ToDateTime("2011-10-06", XmlDateTimeSerializationMode.RoundtripKind),
                                            EndTime = "12:30:10+01:00"
                                        }
                                    }
                                },
                                PlannedArrivalTransportEvent = new TransportEventType
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
                                            StartTime = "12:30:10+01:00",
                                            EndDate = XmlConvert.ToDateTime("2011-10-06", XmlDateTimeSerializationMode.RoundtripKind),
                                            EndTime = "15:30:10+01:00"
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
