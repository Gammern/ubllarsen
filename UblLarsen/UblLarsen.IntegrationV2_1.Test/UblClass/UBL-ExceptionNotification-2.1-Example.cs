using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLExceptionNotification21Example
    {
        public static ExceptionNotificationType Create()
        {
            return new ExceptionNotificationType
            {
                UBLVersionID = "2.1",
                ProfileID = "bpid:urn:oasis:names:draft:bpss:ubl-2-1-cpfr-exception-notification-draft",
                ID = "EN758494",
                CopyIndicator = false,
                UUID = "349ABBAE-DF9D-40B4-849F-94C5FF9D1AF4",
                IssueDate = XmlConvert.ToDateTime("2010-04-26", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "12:00:01.000",
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "sample"
                    }
                },
                ExceptionObservationPeriod = new PeriodType
                {
                    StartDate = XmlConvert.ToDateTime("2010-03-26", XmlDateTimeSerializationMode.RoundtripKind),
                    EndDate = XmlConvert.ToDateTime("2010-04-26", XmlDateTimeSerializationMode.RoundtripKind)
                },
                SenderParty = new PartyType
                {
                    PartyIdentification = new PartyIdentificationType[]
                    {
                        new PartyIdentificationType
                        {
                            ID = "6903148000007"
                        }
                    },
                    PartyName = new PartyNameType[]
                    {
                        new PartyNameType
                        {
                            Name = "Consortial"
                        }
                    },
                    PostalAddress = new AddressType
                    {
                        StreetName = "Busy Street",
                        BuildingName = "Thereabouts",
                        BuildingNumber = "56A",
                        CityName = "Farthing",
                        PostalZone = "AA99 1BB",
                        CountrySubentity = "Heremouthshire",
                        AddressLine = new AddressLineType[]
                        {
                            new AddressLineType
                            {
                                Line = "The Roundabout"
                            }
                        },
                        Country = new CountryType
                        {
                            IdentificationCode = "GB"
                        }
                    },
                    PartyTaxScheme = new PartyTaxSchemeType[]
                    {
                        new PartyTaxSchemeType
                        {
                            RegistrationName = "Farthing Purchasing Consortium",
                            CompanyID = "175 269 2355",
                            ExemptionReason = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "N/A"
                                }
                            },
                            TaxScheme = new TaxSchemeType
                            {
                                ID = "VAT",
                                TaxTypeCode = "VAT"
                            }
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "Mrs Bouquet",
                        Telephone = "0158 1233714",
                        Telefax = "0158 1233856",
                        ElectronicMail = "bouquet@fpconsortial.co.uk"
                    }
                },
                ReceiverParty = new PartyType
                {
                    PartyIdentification = new PartyIdentificationType[]
                    {
                        new PartyIdentificationType
                        {
                            ID = "2203148000007"
                        }
                    },
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
                    PartyTaxScheme = new PartyTaxSchemeType[]
                    {
                        new PartyTaxSchemeType
                        {
                            RegistrationName = "Bridgtow District Council",
                            CompanyID = "12356478",
                            ExemptionReason = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Local Authority"
                                }
                            },
                            TaxScheme = new TaxSchemeType
                            {
                                ID = "UK VAT",
                                TaxTypeCode = "VAT"
                            }
                        }
                    },
                    Contact = new ContactType
                    {
                        Name = "Mr Fred Churchill",
                        Telephone = "0127 2653214",
                        Telefax = "0127 2653215",
                        ElectronicMail = "fred@iytcorporation.gov.uk"
                    }
                },
                BuyerCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyIdentification = new PartyIdentificationType[]
                        {
                            new PartyIdentificationType
                            {
                                ID = "0012345000359"
                            }
                        }
                    }
                },
                SellerSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        PartyIdentification = new PartyIdentificationType[]
                        {
                            new PartyIdentificationType
                            {
                                ID = "0012345000058"
                            }
                        }
                    }
                },
                ExceptionNotificationLine = new ExceptionNotificationLineType[]
                {
                    new ExceptionNotificationLineType
                    {
                        ID = "exceptionNotificationLineID",
                        ExceptionStatusCode = "NEW",
                        CollaborationPriorityCode = "HIGH",
                        ResolutionCode = "LOCAL_INTERPOLATED_VALUE",
                        ComparedValueMeasure = new MeasureType
                        {
                            unitCode = "KGM",
                            Value = 2M
                        },
                        SourceValueMeasure = new MeasureType
                        {
                            unitCode = "KGM",
                            Value = 2.1M
                        },
                        VarianceQuantity = new QuantityType
                        {
                            unitCode = "KGM",
                            Value = 20M
                        },
                        ExceptionObservationPeriod = new PeriodType
                        {
                            StartDate = XmlConvert.ToDateTime("2010-03-26", XmlDateTimeSerializationMode.RoundtripKind),
                            EndDate = XmlConvert.ToDateTime("2010-04-10", XmlDateTimeSerializationMode.RoundtripKind)
                        },
                        ForecastException = new ForecastExceptionType
                        {
                            ForecastPurposeCode = "ORDER_FORECAST",
                            ForecastTypeCode = "TOTAL",
                            IssueDate = XmlConvert.ToDateTime("2010-04-17", XmlDateTimeSerializationMode.RoundtripKind),
                            IssueTime = "10:00:00.000",
                            DataSourceCode = "BUYER"
                        },
                        SupplyItem = new ItemType
                        {
                            Description = new TextType[]
                            {
                                new TextType
                                {
                                    Value = "Acme beeswax"
                                }
                            },
                            Name = "beeswax",
                            BuyersItemIdentification = new ItemIdentificationType
                            {
                                ID = "6578489"
                            },
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "17589683"
                            },
                            StandardItemIdentification = new ItemIdentificationType
                            {
                                ID = "00123450000584"
                            }
                        }
                    }
                }
            }
;
        }
    }
}
