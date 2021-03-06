// Generated by UblXml2CSharp
using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLForwardingInstructions20ExampleInternational
    {
        public static ForwardingInstructionsType Create()
        {
            var doc = new ForwardingInstructionsType
            {
                UBLVersionID = "2.0",
                CustomizationID = "urn:oasis:names:specification:ubl:xpath:ForwardingInstructions-2.0:samples-2.0-draft",
                ProfileID = "bpid:urn:oasis:names:draft:bpss:ubl-2-sample-international-scenario",
                ID = "KHN23-44044",
                UUID = "6E09886B-DC6E-439F-82D1-7C83746352B1",
                IssueDate = "2005-06-24",
                IssueTime = "14:20:00.0Z",
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
                            ID = "CONS-0001",
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
                            CustomsTariffQuantity = 100M,
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
                                    }
                                }
                            }
                        }
                    }
                }
            };
            doc.Xmlns = new System.Xml.Serialization.XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("cac","urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
                new XmlQualifiedName("cbc","urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
            });
            return doc;
        }
    }
}
