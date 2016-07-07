using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLWaybill20ExampleInternational
    {
        public static WaybillType Create()
        {
            return new WaybillType
            {
                UBLVersionID = "2.0",
                CustomizationID = "urn:oasis:names:specification:ubl:xpath:Waybill-2.0:samples-2.0-draft",
                ProfileID = "bpid:urn:oasis:names:draft:bpss:ubl-2-sample-international-scenario",
                ID = "KHN23-44044-1",
                CarrierAssignedID = "123456789987654321",
                UUID = "74638995-D67E-002F-436-8G17366352B1",
                IssueDate = XmlConvert.ToDateTime("2005-06-25", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "09:00:00.0Z",
                Name = "Air Waybill",
                ShippingOrderID = "KHN23-44044",
                AdValoremIndicator = false,
                DeclaredCarriageValueAmount = new AmountType
                {
                    currencyID = "USD",
                    Value = 1500.00M
                },
                ConsignorParty = new PartyType
                {
                    PartyName = new PartyNameType[]
                    {
                        new PartyNameType
                        {
                            Name = "Consortial"
                        }
                    },
                    PostalAddress = new AddressType
                    {
                        StreetName = "Boston Road",
                        BuildingName = "Suite M-102",
                        BuildingNumber = "630",
                        CityName = "Billerica",
                        PostalZone = "01821",
                        CountrySubentity = "Massachusetts",
                        CountrySubentityCode = "MA",
                        Country = new CountryType
                        {
                            IdentificationCode = "US"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "Mrs Bouquet",
                        Telephone = " +1 158 1233714",
                        Telefax = "+ 1 158 1233856",
                        ElectronicMail = "bouquet@fpconsortial.com"
                    }
                },
                CarrierParty = new PartyType
                {
                    PartyName = new PartyNameType[]
                    {
                        new PartyNameType
                        {
                            Name = "United Airfreight"
                        }
                    },
                    Contact = new ContactType
                    {
                        ID = "Freight Bookings",
                        Telephone = "+1 3362 4788",
                        ElectronicMail = "bookings@unitedfreight.com"
                    }
                },
                FreightForwarderParty = new PartyType
                {
                    PartyName = new PartyNameType[]
                    {
                        new PartyNameType
                        {
                            Name = "One-Stop Forwarders"
                        }
                    },
                    PostalAddress = new AddressType
                    {
                        Postbox = "99043",
                        CityName = "Boston",
                        PostalZone = "02210",
                        CountrySubentityCode = "MA",
                        Country = new CountryType
                        {
                            IdentificationCode = "US"
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "Con Solidador",
                        Telephone = " +1 343 1453654",
                        Telefax = "+1 343 1453655",
                        ElectronicMail = "ctanner@onestopfreight.com"
                    }
                },
                Shipment = new ShipmentType
                {
                    ID = "CONS-0001",
                    GrossWeightMeasure = new MeasureType
                    {
                        unitCode = "KGM",
                        Value = 130M
                    },
                    NetWeightMeasure = new MeasureType
                    {
                        unitCode = "KGM",
                        Value = 110M
                    },
                    NetNetWeightMeasure = new MeasureType
                    {
                        unitCode = "KGM",
                        Value = 100M
                    },
                    GrossVolumeMeasure = new MeasureType
                    {
                        unitCode = "MTQ",
                        Value = 2M
                    },
                    NetVolumeMeasure = new MeasureType
                    {
                        unitCode = "MTQ",
                        Value = 2.235M
                    },
                    TotalGoodsItemQuantity = 1M,
                    TotalTransportHandlingUnitQuantity = 10M,
                    InsuranceValueAmount = new AmountType
                    {
                        currencyID = "USD",
                        Value = 1000.00M
                    },
                    DeclaredCustomsValueAmount = new AmountType
                    {
                        currencyID = "GBP",
                        Value = 524.80M
                    },
                    FreeOnBoardValueAmount = new AmountType
                    {
                        currencyID = "USD",
                        Value = 1200.00M
                    },
                    SpecialInstructions = new TextType[]
                    {
                        new TextType
                        {
                            Value = "Beeswax becomes liquid at 50'C"
                        }
                    },
                    Consignment = new ConsignmentType[]
                    {
                        new ConsignmentType
                        {
                            ID = new IdentifierType
                            {
                                schemeAgencyName = "WCO",
                                schemeName = "Unique Consignment Reference",
                                Value = "2005US12345678998765432112345678"
                            },
                            TariffDescription = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Beeswax, other insect waxes and spermacetti"
                                }
                            },
                            TariffCode = "15219000",
                            HazardousRiskIndicator = false,
                            ConsigneeParty = new PartyType
                            {
                                PartyName = new PartyNameType[]
                                {
                                    new PartyNameType
                                    {
                                        Name = "IYT Corporation"
                                    }
                                },
                                PostalAddress = new AddressType
                                {
                                    StreetName = "Avon Way",
                                    BuildingName = "Thereabouts",
                                    BuildingNumber = "56A",
                                    CityName = "Bridgtow",
                                    PostalZone = "ZZ99 1ZZ",
                                    CountrySubentity = "Avon",
                                    AddressLine = new AddressLineType[]
                                    {
                                        new AddressLineType
                                        {
                                            Line = "3rd Floor, Room 5"
                                        }
                                    },
                                    Country = new CountryType
                                    {
                                        IdentificationCode = "GB"
                                    }
                                },
                                Contact = new ContactType
                                {
                                    Name = "Mr Fred Churchill",
                                    Telephone = "+44 127 2653214",
                                    Telefax = "+44 127 2653215",
                                    ElectronicMail = "fred@iytcorporation.gov.uk"
                                }
                            },
                            NotifyParty = new PartyType
                            {
                                PartyName = new PartyNameType[]
                                {
                                    new PartyNameType
                                    {
                                        Name = "IYT Corporation"
                                    }
                                },
                                PostalAddress = new AddressType
                                {
                                    StreetName = "Avon Way",
                                    BuildingName = "Thereabouts",
                                    BuildingNumber = "56A",
                                    CityName = "Bridgtow",
                                    PostalZone = "ZZ99 1ZZ",
                                    CountrySubentity = "Avon",
                                    AddressLine = new AddressLineType[]
                                    {
                                        new AddressLineType
                                        {
                                            Line = "3rd Floor, Room 5"
                                        }
                                    },
                                    Country = new CountryType
                                    {
                                        IdentificationCode = "GB"
                                    }
                                },
                                Contact = new ContactType
                                {
                                    Name = "Mr Fred Churchill",
                                    Telephone = "+44 127 2653214",
                                    Telefax = "+44 127 2653215",
                                    ElectronicMail = "fred@iytcorporation.gov.uk"
                                }
                            },
                            FinalDeliveryParty = new PartyType
                            {
                                PartyName = new PartyNameType[]
                                {
                                    new PartyNameType
                                    {
                                        Name = "The Terminus"
                                    }
                                },
                                PostalAddress = new AddressType
                                {
                                    StreetName = "Avon Way",
                                    BuildingName = "Thereabouts",
                                    BuildingNumber = "56A",
                                    CityName = "Bridgtow",
                                    PostalZone = "ZZ99 1ZZ",
                                    CountrySubentity = "Avon",
                                    AddressLine = new AddressLineType[]
                                    {
                                        new AddressLineType
                                        {
                                            Line = "3rd Floor, Room 5"
                                        }
                                    },
                                    Country = new CountryType
                                    {
                                        IdentificationCode = "GB"
                                    }
                                },
                                Contact = new ContactType
                                {
                                    Name = "S Massiah",
                                    Telephone = "+ 44 127 98876545",
                                    Telefax = "+ 44 127 98876546",
                                    ElectronicMail = "smassiah@the-email.co.uk"
                                }
                            },
                            OriginalDepartureCountry = new CountryType
                            {
                                IdentificationCode = "US"
                            },
                            FinalDestinationCountry = new CountryType
                            {
                                IdentificationCode = "GB"
                            },
                            TransportContract = new ContractType
                            {
                                ID = "CONS-001",
                                IssueDate = XmlConvert.ToDateTime("2005-06-24", XmlDateTimeSerializationMode.RoundtripKind),
                                ContractType1 = "Forwarding Instructions",
                                ValidityPeriod = new PeriodType
                                {
                                    StartDate = XmlConvert.ToDateTime("2005-06-25", XmlDateTimeSerializationMode.RoundtripKind),
                                    StartTime = "01:00:00.0Z",
                                    EndDate = XmlConvert.ToDateTime("2005-06-30", XmlDateTimeSerializationMode.RoundtripKind),
                                    EndTime = "18:00:00.0Z"
                                },
                                ContractDocumentReference = new DocumentReferenceType[]
                                {
                                    new DocumentReferenceType
                                    {
                                        ID = "normalizedString",
                                        CopyIndicator = false,
                                        UUID = "normalizedString",
                                        IssueDate = XmlConvert.ToDateTime("1967-08-13", XmlDateTimeSerializationMode.RoundtripKind),
                                        DocumentTypeCode = "normalizedString",
                                        DocumentType = "String",
                                        XPath = new TextType[]
                                        {
                                            new TextType
                                            {
                                                Value = "String"
                                            },
                                            new TextType
                                            {
                                                Value = "String"
                                            }
                                        },
                                        Attachment = new AttachmentType
                                        {
                                            EmbeddedDocumentBinaryObject = new BinaryObjectType
                                            {
                                                mimeCode = "application/CSTAdata+xml",
                                                Value = System.Text.Encoding.UTF8.GetBytes("UjBsR09EbGhjZ0dTQUxNQUFBUUNBRU1tQ1p0dU1GUXhEUzhi")
                                            },
                                            ExternalReference = new ExternalReferenceType
                                            {
                                                URI = "normalizedString",
                                                DocumentHash = "String",
                                                ExpiryDate = XmlConvert.ToDateTime("1967-08-13", XmlDateTimeSerializationMode.RoundtripKind),
                                                ExpiryTime = "14:20:00.0Z"
                                            }
                                        }
                                    },
                                    new DocumentReferenceType
                                    {
                                        ID = "normalizedString",
                                        CopyIndicator = false,
                                        UUID = "normalizedString",
                                        IssueDate = XmlConvert.ToDateTime("1967-08-13", XmlDateTimeSerializationMode.RoundtripKind),
                                        DocumentTypeCode = "normalizedString",
                                        DocumentType = "String",
                                        XPath = new TextType[]
                                        {
                                            new TextType
                                            {
                                                Value = "String"
                                            },
                                            new TextType
                                            {
                                                Value = "String"
                                            }
                                        },
                                        Attachment = new AttachmentType
                                        {
                                            EmbeddedDocumentBinaryObject = new BinaryObjectType
                                            {
                                                mimeCode = "application/CSTAdata+xml",
                                                Value = System.Text.Encoding.UTF8.GetBytes("UjBsR09EbGhjZ0dTQUxNQUFBUUNBRU1tQ1p0dU1GUXhEUzhi")
                                            },
                                            ExternalReference = new ExternalReferenceType
                                            {
                                                URI = "normalizedString",
                                                DocumentHash = "String",
                                                ExpiryDate = XmlConvert.ToDateTime("1967-08-13", XmlDateTimeSerializationMode.RoundtripKind),
                                                ExpiryTime = "14:20:00.0Z"
                                            }
                                        }
                                    }
                                }
                            },
                            OriginalDespatchTransportationService = new TransportationServiceType
                            {
                                TransportServiceCode = "Door to Pier"
                            },
                            FinalDeliveryTransportationService = new TransportationServiceType
                            {
                                TransportServiceCode = "Pier to Pier"
                            },
                            DeliveryTerms = new DeliveryTermsType
                            {
                                ID = "FOB Destination",
                                DeliveryLocation = new LocationType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyID = "6",
                                        schemeID = "UN/LOCODE",
                                        Value = "GBBRS"
                                    },
                                    Description = new TextType[]
                                    {
                                        new TextType
                                        {
                                            Value = "Bristol"
                                        }
                                    }
                                }
                            },
                            PaymentTerms = new PaymentTermsType
                            {
                                PaymentMeansID = new IdentifierType[]
                                {
                                    new IdentifierType
                                    {
                                        Value = "Bankers Cheque"
                                    }
                                }
                            },
                            FreightAllowanceCharge = new AllowanceChargeType[]
                            {
                                new AllowanceChargeType
                                {
                                    ChargeIndicator = true,
                                    AllowanceChargeReason = new TextType[]
                                    {
                                        new TextType
                                        {
                                            Value = "Freight charges"
                                        }
                                    },
                                    SequenceNumeric = 1M,
                                    Amount = new AmountType
                                    {
                                        currencyID = "USD",
                                        Value = 254.00M
                                    }
                                },
                                new AllowanceChargeType
                                {
                                    ChargeIndicator = false,
                                    AllowanceChargeReasonCode = "79",
                                    AllowanceChargeReason = new TextType[]
                                    {
                                        new TextType
                                        {
                                            Value = "Sundry discount"
                                        }
                                    },
                                    MultiplierFactorNumeric = 0.05M,
                                    SequenceNumeric = 2M,
                                    Amount = new AmountType
                                    {
                                        currencyID = "USD",
                                        Value = 12.70M
                                    },
                                    BaseAmount = new AmountType
                                    {
                                        currencyID = "USD",
                                        Value = 254.00M
                                    }
                                }
                            }
                        }
                    },
                    GoodsItem = new GoodsItemType[]
                    {
                        new GoodsItemType
                        {
                            ID = "1",
                            SequenceNumberID = "1",
                            Description = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Acme beeswax"
                                }
                            },
                            HazardousRiskIndicator = false,
                            DeclaredCustomsValueAmount = new AmountType
                            {
                                currencyID = "GBP",
                                Value = 524.80M
                            },
                            DeclaredStatisticsValueAmount = new AmountType
                            {
                                currencyID = "USD",
                                Value = 1000.00M
                            },
                            FreeOnBoardValueAmount = new AmountType
                            {
                                currencyID = "USD",
                                Value = 1241.30M
                            },
                            InsuranceValueAmount = new AmountType
                            {
                                currencyID = "USD",
                                Value = 1241.30M
                            },
                            ValueAmount = new AmountType
                            {
                                currencyID = "USD",
                                Value = 1000.00M
                            },
                            GrossWeightMeasure = new MeasureType
                            {
                                unitCode = "KGM",
                                Value = 130M
                            },
                            NetWeightMeasure = new MeasureType
                            {
                                unitCode = "KGM",
                                Value = 110M
                            },
                            NetNetWeightMeasure = new MeasureType
                            {
                                unitCode = "KGM",
                                Value = 100M
                            },
                            GrossVolumeMeasure = new MeasureType
                            {
                                unitCode = "MTQ",
                                Value = 2M
                            },
                            NetVolumeMeasure = new MeasureType
                            {
                                unitCode = "MTQ",
                                Value = 2.235M
                            },
                            Quantity = 10M,
                            RequiredCustomsID = "ECN12344566",
                            CustomsStatusCode = "Cleared",
                            CustomsTariffQuantity = 1000M,
                            Item = new ItemType[]
                            {
                                new ItemType
                                {
                                    Description = new TextType[]
                                    {
                                        new TextType
                                        {
                                            Value = "Beeswax"
                                        }
                                    },
                                    Name = "Acme Beeswax",
                                    BuyersItemIdentification = new ItemIdentificationType
                                    {
                                        ID = "6578489"
                                    },
                                    SellersItemIdentification = new ItemIdentificationType
                                    {
                                        ID = "17589683"
                                    },
                                    OriginCountry = new CountryType
                                    {
                                        IdentificationCode = "MX",
                                        Name = "Mexico"
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
                            TransportModeCode = new CodeType
                            {
                                listAgencyID = "6",
                                listID = "UN/ECE rec 16",
                                Value = "3"
                            },
                            TransportMeansTypeCode = "Truck",
                            PreCarriageIndicator = true,
                            OnCarriageIndicator = false,
                            TransitPeriod = new PeriodType
                            {
                                StartDate = XmlConvert.ToDateTime("2005-06-25", XmlDateTimeSerializationMode.RoundtripKind),
                                StartTime = "11:35:00.0Z",
                                EndDate = XmlConvert.ToDateTime("2005-06-25", XmlDateTimeSerializationMode.RoundtripKind),
                                EndTime = "16:00:00.0Z"
                            },
                            CarrierParty = new PartyType[]
                            {
                                new PartyType
                                {
                                    PartyName = new PartyNameType[]
                                    {
                                        new PartyNameType
                                        {
                                            Name = "Keep On Trucking"
                                        }
                                    },
                                    Contact = new ContactType
                                    {
                                        Telephone = "+1 36222 33847"
                                    }
                                }
                            },
                            TransportMeans = new TransportMeansType
                            {
                                RoadTransport = new RoadTransportType
                                {
                                    LicensePlateID = "2652 WE"
                                }
                            }
                        },
                        new ShipmentStageType
                        {
                            ID = "2",
                            TransportModeCode = new CodeType
                            {
                                listAgencyID = "6",
                                listID = "UN/ECE rec 16",
                                Value = "4"
                            },
                            TransportMeansTypeCode = "Plane",
                            PreCarriageIndicator = false,
                            OnCarriageIndicator = false,
                            TransitPeriod = new PeriodType
                            {
                                StartDate = XmlConvert.ToDateTime("2005-06-25", XmlDateTimeSerializationMode.RoundtripKind),
                                StartTime = "23:20:00.0Z"
                            },
                            CarrierParty = new PartyType[]
                            {
                                new PartyType
                                {
                                    PartyName = new PartyNameType[]
                                    {
                                        new PartyNameType
                                        {
                                            Name = "United Airfreight"
                                        }
                                    },
                                    Contact = new ContactType
                                    {
                                        ID = "Freight Bookings",
                                        Telephone = "+1 3362 4788",
                                        ElectronicMail = "bookings@unitedfreight.com"
                                    }
                                }
                            },
                            TransportMeans = new TransportMeansType
                            {
                                JourneyID = "UA 1234",
                                AirTransport = new AirTransportType
                                {
                                    AircraftID = "A-127763-747"
                                }
                            },
                            LoadingPortLocation = new LocationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeAgencyID = "6",
                                    schemeID = "UN/LOCODE",
                                    Value = "USBOS"
                                },
                                Description = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "Boston Airport"
                                    }
                                }
                            },
                            UnloadingPortLocation = new LocationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeAgencyID = "6",
                                    schemeID = "UN/LOCODE",
                                    Value = "GBBRS"
                                },
                                Description = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "Bristol Airport"
                                    }
                                }
                            },
                            TransshipPortLocation = new LocationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeAgencyID = "6",
                                    schemeID = "UN/LOCODE",
                                    Value = "GBLHR"
                                },
                                Description = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "Heathrow Apt/London"
                                    }
                                }
                            }
                        }
                    },
                    Delivery = new DeliveryType
                    {
                        Quantity = 1M,
                        LatestDeliveryDate = XmlConvert.ToDateTime("2005-06-30", XmlDateTimeSerializationMode.RoundtripKind),
                        LatestDeliveryTime = "18:00:00.0Z",
                        TrackingID = "NKH7712289-03339-000128",
                        DeliveryAddress = new AddressType
                        {
                            StreetName = "Avon Way",
                            BuildingName = "Thereabouts",
                            BuildingNumber = "56A",
                            CityName = "Bridgtow",
                            PostalZone = "ZZ99 1ZZ",
                            CountrySubentity = "Avon",
                            AddressLine = new AddressLineType[]
                            {
                                new AddressLineType
                                {
                                    Line = "3rd Floor, Room 5"
                                }
                            },
                            Country = new CountryType
                            {
                                IdentificationCode = "GB"
                            }
                        },
                        RequestedDeliveryPeriod = new PeriodType
                        {
                            StartDate = XmlConvert.ToDateTime("2005-06-29", XmlDateTimeSerializationMode.RoundtripKind),
                            StartTime = "01:00:00.0Z",
                            EndDate = XmlConvert.ToDateTime("2005-06-30", XmlDateTimeSerializationMode.RoundtripKind),
                            EndTime = "18:00:00.0Z"
                        },
                        EstimatedDeliveryPeriod = new PeriodType
                        {
                            StartDate = XmlConvert.ToDateTime("2005-06-30", XmlDateTimeSerializationMode.RoundtripKind),
                            StartTime = "01:00:00.0Z"
                        },
                        DeliveryParty = new PartyType
                        {
                            PartyName = new PartyNameType[]
                            {
                                new PartyNameType
                                {
                                    Name = "The Terminus"
                                }
                            },
                            Contact = new ContactType
                            {
                                Name = "S Massiah",
                                Telephone = "+ 44 127 98876545",
                                Telefax = "+ 44 127 98876546",
                                ElectronicMail = "smassiah@the-email.co.uk"
                            }
                        },
                        Despatch = new DespatchType
                        {
                            ActualDespatchDate = XmlConvert.ToDateTime("2005-06-25", XmlDateTimeSerializationMode.RoundtripKind),
                            ActualDespatchTime = "11:35:00.0Z",
                            DespatchAddress = new AddressType
                            {
                                StreetName = "Boston Road",
                                BuildingName = "Suite M-102",
                                BuildingNumber = "630",
                                CityName = "Billerica",
                                PostalZone = "01821",
                                CountrySubentity = "Massachusetts",
                                CountrySubentityCode = "MA",
                                Country = new CountryType
                                {
                                    IdentificationCode = "US"
                                }
                            },
                            DespatchParty = new PartyType
                            {
                                PartyName = new PartyNameType[]
                                {
                                    new PartyNameType
                                    {
                                        Name = "Consortial"
                                    }
                                }
                            },
                            Contact = new ContactType
                            {
                                Name = "Mrs Bouquet",
                                Telephone = " +1 158 1233714",
                                Telefax = "+ 1 158 1233856",
                                ElectronicMail = "bouquet@fpconsortial.com"
                            }
                        }
                    },
                    TransportHandlingUnit = new TransportHandlingUnitType[]
                    {
                        new TransportHandlingUnitType
                        {
                            ID = "1",
                            TransportHandlingUnitTypeCode = new CodeType
                            {
                                listAgencyName = "United Nations Economic Commission for Europe",
                                listID = "TRED 8053",
                                Value = "PA"
                            },
                            HazardousRiskIndicator = false,
                            TotalGoodsItemQuantity = 10M,
                            TotalPackageQuantity = 10M,
                            ActualPackage = new PackageType[]
                            {
                                new PackageType
                                {
                                    Quantity = 10M,
                                    PackagingTypeCode = new CodeType
                                    {
                                        listAgencyID = "6",
                                        listID = "UN/ECE rec 21",
                                        Value = "TB"
                                    }
                                }
                            }
                        }
                    },
                    OriginAddress = new AddressType
                    {
                        StreetName = "Boston Road",
                        BuildingName = "Suite M-102",
                        BuildingNumber = "630",
                        CityName = "Billerica",
                        PostalZone = "01821",
                        CountrySubentity = "Massachusetts",
                        CountrySubentityCode = "MA",
                        Country = new CountryType
                        {
                            IdentificationCode = "US"
                        }
                    },
                    FirstArrivalPortLocation = new LocationType
                    {
                        ID = new IdentifierType
                        {
                            schemeAgencyID = "6",
                            schemeID = "UN/LOCODE",
                            Value = "GBBRS"
                        },
                        Description = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Bristol"
                            }
                        }
                    },
                    LastExitPortLocation = new LocationType
                    {
                        ID = new IdentifierType
                        {
                            schemeAgencyID = "6",
                            schemeID = "UN/LOCODE",
                            Value = "USBOS"
                        },
                        Description = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Boston"
                            }
                        }
                    },
                    ExportCountry = new CountryType
                    {
                        IdentificationCode = "US"
                    },
                    FreightAllowanceCharge = new AllowanceChargeType[]
                    {
                        new AllowanceChargeType
                        {
                            ChargeIndicator = true,
                            AllowanceChargeReason = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Freight charges"
                                }
                            },
                            SequenceNumeric = 1M,
                            Amount = new AmountType
                            {
                                currencyID = "USD",
                                Value = 254.00M
                            }
                        },
                        new AllowanceChargeType
                        {
                            ChargeIndicator = false,
                            AllowanceChargeReasonCode = "79",
                            AllowanceChargeReason = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Sundry discount"
                                }
                            },
                            MultiplierFactorNumeric = 0.05M,
                            SequenceNumeric = 2M,
                            Amount = new AmountType
                            {
                                currencyID = "USD",
                                Value = 12.70M
                            },
                            BaseAmount = new AmountType
                            {
                                currencyID = "USD",
                                Value = 254.00M
                            }
                        }
                    }
                },
                DocumentReference = new DocumentReferenceType[]
                {
                    new DocumentReferenceType
                    {
                        ID = "AEG012345",
                        UUID = "6E09886B-DC6E-439F-82D1-7CCAC7F4E3B1",
                        IssueDate = XmlConvert.ToDateTime("2005-06-20", XmlDateTimeSerializationMode.RoundtripKind),
                        DocumentType = "Order"
                    },
                    new DocumentReferenceType
                    {
                        ID = "KHN23-44044",
                        UUID = "6E09886B-DC6E-439F-82D1-7C83746352B1",
                        IssueDate = XmlConvert.ToDateTime("2005-06-24", XmlDateTimeSerializationMode.RoundtripKind),
                        DocumentType = "Forwarding Instructions"
                    }
                },
                ExchangeRate = new ExchangeRateType[]
                {
                    new ExchangeRateType
                    {
                        SourceCurrencyCode = "USD",
                        SourceCurrencyBaseRate = 1.00M,
                        TargetCurrencyCode = "GBP",
                        TargetCurrencyBaseRate = 1.00M,
                        CalculationRate = 1.8947M,
                        MathematicOperatorCode = "Multiply",
                        Date = XmlConvert.ToDateTime("1967-08-13", XmlDateTimeSerializationMode.RoundtripKind)
                    }
                },
                DocumentDistribution = new DocumentDistributionType[]
                {
                    new DocumentDistributionType
                    {
                        PrintQualifier = "Copies allowed",
                        MaximumCopiesNumeric = 5M,
                        Party = new PartyType
                        {
                            PartyName = new PartyNameType[]
                            {
                                new PartyNameType
                                {
                                    Name = "Consortial"
                                }
                            },
                            PostalAddress = new AddressType
                            {
                                StreetName = "Boston Road",
                                BuildingName = "Suite M-102",
                                BuildingNumber = "630",
                                CityName = "Billerica",
                                PostalZone = "01821",
                                CountrySubentity = "Massachusetts",
                                CountrySubentityCode = "MA",
                                Country = new CountryType
                                {
                                    IdentificationCode = "US"
                                }
                            },
                            Contact = new ContactType
                            {
                                Name = "Mrs Bouquet",
                                Telephone = " +1 158 1233714",
                                Telefax = "+ 1 158 1233856",
                                ElectronicMail = "bouquet@fpconsortial.com"
                            }
                        }
                    },
                    new DocumentDistributionType
                    {
                        PrintQualifier = "Copies allowed",
                        MaximumCopiesNumeric = 4M,
                        Party = new PartyType
                        {
                            PartyName = new PartyNameType[]
                            {
                                new PartyNameType
                                {
                                    Name = "IYT Corporation"
                                }
                            },
                            PostalAddress = new AddressType
                            {
                                StreetName = "Avon Way",
                                BuildingName = "Thereabouts",
                                BuildingNumber = "56A",
                                CityName = "Bridgtow",
                                PostalZone = "ZZ99 1ZZ",
                                CountrySubentity = "Avon",
                                AddressLine = new AddressLineType[]
                                {
                                    new AddressLineType
                                    {
                                        Line = "3rd Floor, Room 5"
                                    }
                                },
                                Country = new CountryType
                                {
                                    IdentificationCode = "GB"
                                }
                            },
                            Contact = new ContactType
                            {
                                Name = "Mr Fred Churchill",
                                Telephone = "+44 127 2653214",
                                Telefax = "+44 127 2653215",
                                ElectronicMail = "fred@iytcorporation.gov.uk"
                            }
                        }
                    }
                }
            }
;
        }
    }
}
