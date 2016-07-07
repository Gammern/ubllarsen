using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLTransportExecutionPlan21Example
    {
        public static TransportExecutionPlanType Create()
        {
            return new TransportExecutionPlanType
            {
                UBLVersionID = "2.1",
                ID = "TEP_1",
                VersionID = "1",
                IssueDate = XmlConvert.ToDateTime("2011-09-13", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "10:00:30+01:00",
                DocumentStatusCode = "Confirmed",
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
                TransportUserParty = new PartyType
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
                TransportServiceDescriptionDocumentReference = new DocumentReferenceType
                {
                    ID = "2"
                },
                TransportContract = new ContractType
                {
                    Note = new TextType[]
                    {
                        new TextType
                        {
                            Value = "Framework Agreement"
                        }
                    },
                    ContractDocumentReference = new DocumentReferenceType[]
                    {
                        new DocumentReferenceType
                        {
                            ID = "TC101",
                            IssueDate = XmlConvert.ToDateTime("2010-01-01", XmlDateTimeSerializationMode.RoundtripKind),
                            DocumentTypeCode = "315",
                            DocumentType = "Contract",
                            DocumentDescription = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Framework Agreement between Consignor and NECOSS"
                                }
                            }
                        }
                    }
                },
                TransportUserResponseRequiredPeriod = new PeriodType[]
                {
                    new PeriodType
                    {
                        EndDate = XmlConvert.ToDateTime("2011-09-13", XmlDateTimeSerializationMode.RoundtripKind),
                        EndTime = "12:00:10+01:00"
                    }
                },
                MainTransportationService = new TransportationServiceType
                {
                    TransportServiceCode = "3",
                    TransportationServiceDescription = new TextType[]
                    {
                        new TextType
                        {
                            Value = "Transport from Hamburg to Nurnberg"
                        }
                    }
                },
                ServiceEndTimePeriod = new PeriodType
                {
                    EndDate = XmlConvert.ToDateTime("2011-10-06", XmlDateTimeSerializationMode.RoundtripKind),
                    EndTime = "16:00:10+01:00"
                },
                FromLocation = new LocationType
                {
                    LocationTypeCode = "13",
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
                        PostalZone = "29400",
                        Country = new CountryType
                        {
                            IdentificationCode = "DE"
                        }
                    }
                },
                ToLocation = new LocationType
                {
                    LocationTypeCode = "7",
                    Address = new AddressType
                    {
                        StreetName = "Grosse strasse 34",
                        CityName = "Nurnberg",
                        PostalZone = "28400",
                        Country = new CountryType
                        {
                            IdentificationCode = "DE"
                        }
                    }
                },
                TransportExecutionTerms = new TransportExecutionTermsType
                {
                    DeliveryTerms = new DeliveryTermsType[]
                    {
                        new DeliveryTermsType
                        {
                            ID = new IdentifierType
                            {
                                schemeAgencyName = "INCOTERMS",
                                Value = "EXW"
                            },
                            DeliveryLocation = new LocationType
                            {
                                Address = new AddressType
                                {
                                    CityName = "Hamburg"
                                }
                            }
                        }
                    },
                    NotificationRequirement = new NotificationRequirementType[]
                    {
                        new NotificationRequirementType
                        {
                            NotificationTypeCode = "TIME_SCHEDULE_DEVIATIONS",
                            NotifyParty = new PartyType[]
                            {
                                new PartyType
                                {
                                    EndpointID = "www.consignee.de/statusnotifications/",
                                    PartyName = new PartyNameType[]
                                    {
                                        new PartyNameType
                                        {
                                            Name = "Consignee"
                                        }
                                    },
                                    Contact = new ContactType
                                    {
                                        ElectronicMail = "someName@consignee.de"
                                    }
                                },
                                new PartyType
                                {
                                    EndpointID = "www.consignor.cn/statusnotifications/",
                                    PartyName = new PartyNameType[]
                                    {
                                        new PartyNameType
                                        {
                                            Name = "Consignor"
                                        }
                                    },
                                    Contact = new ContactType
                                    {
                                        ElectronicMail = "someName@consignor.cn"
                                    }
                                }
                            }
                        },
                        new NotificationRequirementType
                        {
                            NotificationTypeCode = "ITEM_CONDITION_DEVIATIONS",
                            PostEventNotificationDurationMeasure = new MeasureType
                            {
                                unitCode = "MIN",
                                Value = 10M
                            },
                            NotifyParty = new PartyType[]
                            {
                                new PartyType
                                {
                                    EndpointID = "www.consignee.com/statusnotifications/",
                                    PartyName = new PartyNameType[]
                                    {
                                        new PartyNameType
                                        {
                                            Name = "Consignee"
                                        }
                                    },
                                    Contact = new ContactType
                                    {
                                        ElectronicMail = "someName@consignee.de"
                                    }
                                },
                                new PartyType
                                {
                                    EndpointID = "www.consignor.cn/statusnotifications/",
                                    PartyName = new PartyNameType[]
                                    {
                                        new PartyNameType
                                        {
                                            Name = "Consignor"
                                        }
                                    },
                                    Contact = new ContactType
                                    {
                                        ElectronicMail = "someName@consignor.cn"
                                    }
                                }
                            }
                        }
                    }
                },
                Consignment = new ConsignmentType[]
                {
                    new ConsignmentType
                    {
                        ID = "CON_1",
                        GrossWeightMeasure = new MeasureType
                        {
                            unitCode = "KGM",
                            Value = 50000M
                        },
                        NetWeightMeasure = new MeasureType
                        {
                            unitCode = "KGM",
                            Value = 3000M
                        },
                        GrossVolumeMeasure = new MeasureType
                        {
                            unitCode = "MTQ",
                            Value = 78M
                        },
                        LoadingLengthMeasure = new MeasureType
                        {
                            unitCode = "MTR",
                            Value = 12M
                        },
                        HazardousRiskIndicator = false,
                        TotalTransportHandlingUnitQuantity = 2M,
                        ConsolidatedShipment = new ShipmentType[]
                        {
                            new ShipmentType
                            {
                                ID = "GSIN_1"
                            },
                            new ShipmentType
                            {
                                ID = "GSIN_2"
                            }
                        },
                        PlannedPickupTransportEvent = new TransportEventType
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
                                    PostalZone = "29400",
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
                        PlannedDeliveryTransportEvent = new TransportEventType
                        {
                            Location = new LocationType
                            {
                                Address = new AddressType
                                {
                                    StreetName = "Grosse strasse 34",
                                    CityName = "Nurnberg",
                                    PostalZone = "28400",
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
                        },
                        ConsigneeParty = new PartyType
                        {
                            PartyIdentification = new PartyIdentificationType[]
                            {
                                new PartyIdentificationType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyName = "GS1",
                                        schemeName = "GLN",
                                        Value = "4058673827123"
                                    }
                                }
                            },
                            PartyName = new PartyNameType[]
                            {
                                new PartyNameType
                                {
                                    Name = "Consignee"
                                }
                            },
                            Contact = new ContactType
                            {
                                Name = "SomeName",
                                Telephone = "+4987878763",
                                ElectronicMail = "SomeName@consignee.de"
                            }
                        },
                        ConsignorParty = new PartyType
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
                            PostalAddress = new AddressType
                            {
                                ID = new IdentifierType
                                {
                                    schemeAgencyName = "GS1",
                                    schemeName = "GLN",
                                    Value = "4058673827000"
                                }
                            },
                            Contact = new ContactType
                            {
                                Name = "SomeName",
                                Telephone = "+8676576456",
                                ElectronicMail = "SomeName@consignor.cn"
                            }
                        },
                        OriginalDepartureCountry = new CountryType
                        {
                            IdentificationCode = "CN"
                        },
                        FinalDestinationCountry = new CountryType
                        {
                            IdentificationCode = "DE"
                        },
                        MainCarriageShipmentStage = new ShipmentStageType[]
                        {
                            new ShipmentStageType
                            {
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
                                            PostalZone = "29400",
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
                                        Address = new AddressType
                                        {
                                            StreetName = "Grosse strasse 34",
                                            CityName = "Nurnberg",
                                            PostalZone = "28400",
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
                        },
                        PreCarriageShipmentStage = new ShipmentStageType[]
                        {
                            new ShipmentStageType
                            {
                                TransportModeCode = "1",
                                TransportMeansTypeCode = "83",
                                CarrierParty = new PartyType[]
                                {
                                    new PartyType
                                    {
                                        PartyName = new PartyNameType[]
                                        {
                                            new PartyNameType
                                            {
                                                Name = "MAERSK"
                                            }
                                        },
                                        Contact = new ContactType
                                        {
                                            Name = "SomeName",
                                            Telephone = "+4598786765",
                                            ElectronicMail = "SomeName@maersk.dk"
                                        }
                                    }
                                },
                                TransportMeans = new TransportMeansType
                                {
                                    JourneyID = "M22",
                                    RegistrationNationalityID = "DK",
                                    RegistrationNationality = new TextType[]
                                    {
                                        new TextType
                                        {
                                            Value = "Denmark"
                                        }
                                    },
                                    TransportMeansTypeCode = "83",
                                    MaritimeTransport = new MaritimeTransportType
                                    {
                                        VesselID = "SomeIMONr",
                                        VesselName = "SomeVesselName"
                                    }
                                },
                                PlannedDepartureTransportEvent = new TransportEventType
                                {
                                    Location = new LocationType
                                    {
                                        ID = new IdentifierType
                                        {
                                            schemeAgencyName = "UN",
                                            schemeName = "UN/LOCODE",
                                            Value = "CNSHA"
                                        }
                                    },
                                    Period = new PeriodType[]
                                    {
                                        new PeriodType
                                        {
                                            StartDate = XmlConvert.ToDateTime("2011-09-20", XmlDateTimeSerializationMode.RoundtripKind),
                                            StartTime = "09:30:10+01:00",
                                            EndDate = XmlConvert.ToDateTime("2011-09-20", XmlDateTimeSerializationMode.RoundtripKind),
                                            EndTime = "12:30:10+01:00"
                                        }
                                    }
                                },
                                PlannedArrivalTransportEvent = new TransportEventType
                                {
                                    Location = new LocationType
                                    {
                                        ID = new IdentifierType
                                        {
                                            schemeAgencyName = "UN",
                                            schemeName = "UN/LOCODE",
                                            Value = "DEHAM"
                                        }
                                    },
                                    Period = new PeriodType[]
                                    {
                                        new PeriodType
                                        {
                                            StartDate = XmlConvert.ToDateTime("2011-10-01", XmlDateTimeSerializationMode.RoundtripKind),
                                            StartTime = "09:30:10+01:00",
                                            EndDate = XmlConvert.ToDateTime("2011-10-01", XmlDateTimeSerializationMode.RoundtripKind),
                                            EndTime = "12:30:10+01:00"
                                        }
                                    }
                                }
                            }
                        },
                        TransportHandlingUnit = new TransportHandlingUnitType[]
                        {
                            new TransportHandlingUnitType
                            {
                                ID = "CON_THU_1",
                                TransportHandlingUnitTypeCode = "4",
                                HazardousRiskIndicator = false,
                                TotalGoodsItemQuantity = 500M,
                                TotalPackageQuantity = 10M,
                                ShippingMarks = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "General Cargo"
                                    }
                                },
                                TransportEquipment = new TransportEquipmentType[]
                                {
                                    new TransportEquipmentType
                                    {
                                        ID = "CON_TE_1",
                                        TransportEquipmentTypeCode = "CN",
                                        FullnessIndicationCode = "1",
                                        ReturnabilityIndicator = true,
                                        RefrigeratedIndicator = false,
                                        Description = new TextType[]
                                        {
                                            new TextType
                                            {
                                                Value = "SomeDescription"
                                            }
                                        },
                                        GrossWeightMeasure = new MeasureType
                                        {
                                            unitCode = "KGM",
                                            Value = 25000M
                                        },
                                        GrossVolumeMeasure = new MeasureType
                                        {
                                            unitCode = "MTQ",
                                            Value = 39M
                                        },
                                        PowerIndicator = false,
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
                                        },
                                        Package = new PackageType[]
                                        {
                                            new PackageType
                                            {
                                                ID = "CON_P_1",
                                                Quantity = 10M,
                                                PackagingTypeCode = "PL",
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
                                }
                            },
                            new TransportHandlingUnitType
                            {
                                ID = "CON_THU_2",
                                TransportHandlingUnitTypeCode = "4",
                                HazardousRiskIndicator = false,
                                TotalGoodsItemQuantity = 500M,
                                TotalPackageQuantity = 10M,
                                ShippingMarks = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "General Cargo"
                                    }
                                },
                                TransportEquipment = new TransportEquipmentType[]
                                {
                                    new TransportEquipmentType
                                    {
                                        ID = "CON_TE_2",
                                        TransportEquipmentTypeCode = "CN",
                                        FullnessIndicationCode = "1",
                                        ReturnabilityIndicator = true,
                                        RefrigeratedIndicator = false,
                                        Description = new TextType[]
                                        {
                                            new TextType
                                            {
                                                Value = "SomeDescription"
                                            }
                                        },
                                        GrossWeightMeasure = new MeasureType
                                        {
                                            unitCode = "KGM",
                                            Value = 25000M
                                        },
                                        GrossVolumeMeasure = new MeasureType
                                        {
                                            unitCode = "MTQ",
                                            Value = 39M
                                        },
                                        PowerIndicator = false,
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
                                        },
                                        Package = new PackageType[]
                                        {
                                            new PackageType
                                            {
                                                ID = "CON_P_2",
                                                Quantity = 10M,
                                                PackagingTypeCode = "PL",
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
