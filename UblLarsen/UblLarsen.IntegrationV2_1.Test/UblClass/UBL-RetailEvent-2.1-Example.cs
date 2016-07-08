// Generated by UblXml2CSharp
using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLRetailEvent21Example
    {
        public static RetailEventType Create()
        {
            var doc = new RetailEventType
            {
                UBLVersionID = "2.1",
                CustomizationID = "UBL-TR",
                ProfileID = "bpid:urn:oasis:names:draft:bpss:ubl-2-1-cpfr-retail-event",
                ID = "RE758494",
                CopyIndicator = false,
                UUID = "349ABBAE-DF9D-40B4-849F-94C5FF9D1AF4",
                IssueDate = "2009-12-01",
                IssueTime = "12:00:01.000",
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "sample"
                    }
                },
                RetailEventName = "ACME NEW BRANCH OPENNING",
                RetailEventStatusCode = "PLANNED",
                Description = new TextType[]
                {
                    new TextType
                    {
                        Value = "ACME NEW BRANCH will be opened in Brusells on May 12, 2010"
                    }
                },
                Period = new PeriodType
                {
                    StartDate = "2010-05-12",
                    EndDate = "2010-06-12"
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
                PromotionalEvent = new PromotionalEventType
                {
                    PromotionalEventTypeCode = "STORE_OPENING",
                    SubmissionDate = "2009-12-01",
                    LatestProposalAcceptanceDate = "2010-01-06",
                    PromotionalSpecification = new PromotionalSpecificationType[]
                    {
                        new PromotionalSpecificationType
                        {
                            SpecificationID = "ACME_STROP_0023823",
                            PromotionalEventLineItem = new PromotionalEventLineItemType[]
                            {
                                new PromotionalEventLineItemType
                                {
                                    Amount = new AmountType
                                    {
                                        currencyID = "GBP",
                                        Value = 100.0M
                                    },
                                    EventLineItem = new EventLineItemType
                                    {
                                        LineNumberNumeric = 1M,
                                        ParticipatingLocationsLocation = new LocationType
                                        {
                                            ID = "ACME_BR_BE_0023"
                                        },
                                        RetailPlannedImpact = new RetailPlannedImpactType[]
                                        {
                                            new RetailPlannedImpactType
                                            {
                                                Amount = new AmountType
                                                {
                                                    currencyID = "GBP",
                                                    Value = 0.0M
                                                },
                                                ForecastPurposeCode = "SALES_FORECAST",
                                                ForecastTypeCode = "PROMOTIONAL",
                                                Period = new PeriodType
                                                {
                                                    StartDate = "2010-05-12",
                                                    EndDate = "2010-06-12"
                                                }
                                            }
                                        },
                                        SupplyItem = new ItemType
                                        {
                                            Description = new TextType[]
                                            {
                                                new TextType
                                                {
                                                    Value = "Acme knitwear scarf"
                                                }
                                            },
                                            Name = "scarf",
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
                            },
                            EventTactic = new EventTacticType[]
                            {
                                new EventTacticType
                                {
                                    EventTacticEnumeration = new EventTacticEnumerationType
                                    {
                                        DisplayTacticTypeCode = "DISPLAY_GENERAL"
                                    },
                                    Period = new PeriodType
                                    {
                                        StartDate = "2010-04-01",
                                        EndDate = "2010-06-12"
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
