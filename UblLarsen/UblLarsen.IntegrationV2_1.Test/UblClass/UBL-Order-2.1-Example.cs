using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLOrder21Example
    {
        public static OrderType Create()
        {
            return new OrderType
            {
                UBLVersionID = "2.1",
                CustomizationID = "urn:www.cenbii.eu:transaction:biicoretrdm001:ver1.0",
                ProfileID = new IdentifierType
                {
                    schemeAgencyID = "BII",
                    schemeID = "Profile",
                    Value = "urn:www.cenbii.eu:profile:BII01:ver1.0"
                },
                ID = "34",
                IssueDate = XmlConvert.ToDateTime("2010-01-20", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "12:30:00",
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "Information text for the whole order"
                    }
                },
                DocumentCurrencyCode = "SEK",
                AccountingCostCode = "Project123",
                ValidityPeriod = new PeriodType[]
                {
                    new PeriodType
                    {
                        EndDate = XmlConvert.ToDateTime("2010-01-31", XmlDateTimeSerializationMode.RoundtripKind)
                    }
                },
                QuotationDocumentReference = new DocumentReferenceType
                {
                    ID = "QuoteID123"
                },
                OrderDocumentReference = new DocumentReferenceType[]
                {
                    new DocumentReferenceType
                    {
                        ID = "RjectedOrderID123"
                    }
                },
                OriginatorDocumentReference = new DocumentReferenceType
                {
                    ID = "MAFO"
                },
                AdditionalDocumentReference = new DocumentReferenceType[]
                {
                    new DocumentReferenceType
                    {
                        ID = "Doc1",
                        DocumentType = "Timesheet",
                        Attachment = new AttachmentType
                        {
                            ExternalReference = new ExternalReferenceType
                            {
                                URI = "http://www.suppliersite.eu/sheet001.html"
                            }
                        }
                    },
                    new DocumentReferenceType
                    {
                        ID = "Doc2",
                        DocumentType = "Drawing",
                        Attachment = new AttachmentType
                        {
                            EmbeddedDocumentBinaryObject = new BinaryObjectType
                            {
                                mimeCode = "application/pdf",
                                Value = System.Text.Encoding.UTF8.GetBytes("UjBsR09EbGhjZ0dTQUxNQUFBUUNBRU1tQ1p0dU1GUXhEUzhi")
                            }
                        }
                    }
                },
                Contract = new ContractType[]
                {
                    new ContractType
                    {
                        ID = "34322",
                        ContractType1 = "FrameworkAgreementID123"
                    }
                },
                BuyerCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeAgencyID = "9",
                            schemeID = "GLN",
                            Value = "7300072311115"
                        },
                        PartyIdentification = new PartyIdentificationType[]
                        {
                            new PartyIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeAgencyID = "9",
                                    schemeID = "GLN",
                                    Value = "7300070011115"
                                }
                            },
                            new PartyIdentificationType
                            {
                                ID = "PartyID123"
                            }
                        },
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "Johnssons byggvaror"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            ID = new IdentifierType
                            {
                                schemeAgencyID = "9",
                                schemeID = "GLN",
                                Value = "1234567890123"
                            },
                            Postbox = "PoBox123",
                            StreetName = "Rådhusgatan",
                            AdditionalStreetName = "2nd floor",
                            BuildingNumber = "5",
                            Department = "Purchasing department",
                            CityName = "Stockholm",
                            PostalZone = "11000",
                            CountrySubentity = "RegionX",
                            Country = new CountryType
                            {
                                IdentificationCode = "SE"
                            }
                        },
                        PartyTaxScheme = new PartyTaxSchemeType[]
                        {
                            new PartyTaxSchemeType
                            {
                                RegistrationName = "Herra Johnssons byggvaror AS",
                                CompanyID = "SE1234567801",
                                RegistrationAddress = new AddressType
                                {
                                    CityName = "Stockholm",
                                    Country = new CountryType
                                    {
                                        IdentificationCode = "SE"
                                    }
                                },
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeID = "UN/ECE 5153",
                                        schemeAgencyID = "6",
                                        Value = "VAT"
                                    }
                                }
                            }
                        },
                        PartyLegalEntity = new PartyLegalEntityType[]
                        {
                            new PartyLegalEntityType
                            {
                                RegistrationName = "Johnssons Byggvaror AB",
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "SE:ORGNR",
                                    Value = "5532331183"
                                },
                                RegistrationAddress = new AddressType
                                {
                                    CityName = "Stockholm",
                                    CountrySubentity = "RegionX",
                                    Country = new CountryType
                                    {
                                        IdentificationCode = "SE"
                                    }
                                }
                            }
                        },
                        Contact = new ContactType
                        {
                            Telephone = "123456",
                            Telefax = "123456",
                            ElectronicMail = "pelle@johnsson.se"
                        },
                        Person = new PersonType[]
                        {
                            new PersonType
                            {
                                FirstName = "Pelle",
                                FamilyName = "Svensson",
                                MiddleName = "X",
                                JobTitle = "Boss"
                            }
                        }
                    },
                    DeliveryContact = new ContactType
                    {
                        Name = "Eva Johnsson",
                        Telephone = "1234356",
                        Telefax = "123455",
                        ElectronicMail = "eva@johnsson.se"
                    }
                },
                SellerSupplierParty = new SupplierPartyType
                {
                    Party = new PartyType
                    {
                        EndpointID = new IdentifierType
                        {
                            schemeAgencyID = "9",
                            schemeID = "GLN",
                            Value = "7302347231111"
                        },
                        PartyIdentification = new PartyIdentificationType[]
                        {
                            new PartyIdentificationType
                            {
                                ID = "SellerPartyID123"
                            }
                        },
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "Moderna Produkter AB"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            ID = new IdentifierType
                            {
                                schemeAgencyID = "9",
                                schemeID = "GLN",
                                Value = "0987654321123"
                            },
                            Postbox = "321",
                            StreetName = "Kungsgatan",
                            AdditionalStreetName = "suite12",
                            BuildingNumber = "22",
                            Department = "Sales department",
                            CityName = "Stockholm",
                            PostalZone = "11000",
                            CountrySubentity = "RegionX",
                            Country = new CountryType
                            {
                                IdentificationCode = "SE"
                            }
                        },
                        PartyLegalEntity = new PartyLegalEntityType[]
                        {
                            new PartyLegalEntityType
                            {
                                RegistrationName = "Moderna Produkter AB",
                                CompanyID = new IdentifierType
                                {
                                    schemeID = "SE:ORGNR",
                                    Value = "5532332283"
                                },
                                RegistrationAddress = new AddressType
                                {
                                    CityName = "Stockholm",
                                    CountrySubentity = "RegionX",
                                    Country = new CountryType
                                    {
                                        IdentificationCode = "SE"
                                    }
                                }
                            }
                        },
                        Contact = new ContactType
                        {
                            Telephone = "34557",
                            Telefax = "3456767",
                            ElectronicMail = "lars@moderna.se"
                        },
                        Person = new PersonType[]
                        {
                            new PersonType
                            {
                                FirstName = "Lars",
                                FamilyName = "Petersen",
                                MiddleName = "M",
                                JobTitle = "Sales manager"
                            }
                        }
                    }
                },
                OriginatorCustomerParty = new CustomerPartyType
                {
                    Party = new PartyType
                    {
                        PartyIdentification = new PartyIdentificationType[]
                        {
                            new PartyIdentificationType
                            {
                                ID = new IdentifierType
                                {
                                    schemeAgencyID = "9",
                                    schemeID = "GLN",
                                    Value = "0987678321123"
                                }
                            }
                        },
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = "Moderna Produkter AB"
                            }
                        },
                        Contact = new ContactType
                        {
                            Telephone = "346788",
                            Telefax = "8567443",
                            ElectronicMail = "sven@moderna.se"
                        },
                        Person = new PersonType[]
                        {
                            new PersonType
                            {
                                FirstName = "Sven",
                                FamilyName = "Pereson",
                                MiddleName = "N",
                                JobTitle = "Stuffuser"
                            }
                        }
                    }
                },
                Delivery = new DeliveryType[]
                {
                    new DeliveryType
                    {
                        DeliveryLocation = new LocationType
                        {
                            Address = new AddressType
                            {
                                ID = new IdentifierType
                                {
                                    schemeAgencyID = "9",
                                    schemeID = "GLN",
                                    Value = "1234567890123"
                                },
                                Postbox = "123",
                                StreetName = "Rådhusgatan",
                                AdditionalStreetName = "2nd floor",
                                BuildingNumber = "5",
                                Department = "Purchasing department",
                                CityName = "Stockholm",
                                PostalZone = "11000",
                                CountrySubentity = "RegionX",
                                Country = new CountryType
                                {
                                    IdentificationCode = "SE"
                                }
                            }
                        },
                        RequestedDeliveryPeriod = new PeriodType
                        {
                            StartDate = XmlConvert.ToDateTime("2010-02-10", XmlDateTimeSerializationMode.RoundtripKind),
                            EndDate = XmlConvert.ToDateTime("2010-02-25", XmlDateTimeSerializationMode.RoundtripKind)
                        },
                        DeliveryParty = new PartyType
                        {
                            PartyIdentification = new PartyIdentificationType[]
                            {
                                new PartyIdentificationType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyID = "9",
                                        schemeID = "GLN",
                                        Value = "67654328394567"
                                    }
                                }
                            },
                            PartyName = new PartyNameType[]
                            {
                                new PartyNameType
                                {
                                    Name = "Swedish trucking"
                                }
                            },
                            Contact = new ContactType
                            {
                                Name = "Per",
                                Telephone = "987098709",
                                Telefax = "34673435",
                                ElectronicMail = "bill@svetruck.se"
                            }
                        }
                    }
                },
                DeliveryTerms = new DeliveryTermsType[]
                {
                    new DeliveryTermsType
                    {
                        ID = new IdentifierType
                        {
                            schemeAgencyID = "6",
                            schemeID = "IMCOTERM",
                            Value = "FOT"
                        },
                        SpecialTerms = new TextType[]
                        {
                            new TextType
                            {
                                Value = "CAD"
                            }
                        },
                        DeliveryLocation = new LocationType
                        {
                            ID = "STO"
                        }
                    }
                },
                AllowanceCharge = new AllowanceChargeType[]
                {
                    new AllowanceChargeType
                    {
                        ChargeIndicator = true,
                        AllowanceChargeReason = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Transport documents"
                            }
                        },
                        Amount = new AmountType
                        {
                            currencyID = "SEK",
                            Value = 100M
                        }
                    },
                    new AllowanceChargeType
                    {
                        ChargeIndicator = false,
                        AllowanceChargeReason = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Total order value discount"
                            }
                        },
                        Amount = new AmountType
                        {
                            currencyID = "SEK",
                            Value = 100M
                        }
                    }
                },
                TaxTotal = new TaxTotalType[]
                {
                    new TaxTotalType
                    {
                        TaxAmount = new AmountType
                        {
                            currencyID = "SEK",
                            Value = 100M
                        }
                    }
                },
                AnticipatedMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = new AmountType
                    {
                        currencyID = "SEK",
                        Value = 6225M
                    },
                    AllowanceTotalAmount = new AmountType
                    {
                        currencyID = "SEK",
                        Value = 100M
                    },
                    ChargeTotalAmount = new AmountType
                    {
                        currencyID = "SEK",
                        Value = 100M
                    },
                    PayableAmount = new AmountType
                    {
                        currencyID = "SEK",
                        Value = 6225M
                    }
                },
                OrderLine = new OrderLineType[]
                {
                    new OrderLineType
                    {
                        Note = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Freetext note on line 1"
                            }
                        },
                        LineItem = new LineItemType
                        {
                            ID = "1",
                            Quantity = new QuantityType
                            {
                                unitCode = "LTR",
                                Value = 120M
                            },
                            LineExtensionAmount = new AmountType
                            {
                                currencyID = "SEK",
                                Value = 6000M
                            },
                            TotalTaxAmount = new AmountType
                            {
                                currencyID = "SEK",
                                Value = 10M
                            },
                            PartialDeliveryIndicator = false,
                            AccountingCostCode = "ProjectID123",
                            Delivery = new DeliveryType[]
                            {
                                new DeliveryType
                                {
                                    RequestedDeliveryPeriod = new PeriodType
                                    {
                                        StartDate = XmlConvert.ToDateTime("2010-02-10", XmlDateTimeSerializationMode.RoundtripKind),
                                        EndDate = XmlConvert.ToDateTime("2010-02-25", XmlDateTimeSerializationMode.RoundtripKind)
                                    }
                                }
                            },
                            OriginatorParty = new PartyType
                            {
                                PartyIdentification = new PartyIdentificationType[]
                                {
                                    new PartyIdentificationType
                                    {
                                        ID = new IdentifierType
                                        {
                                            schemeAgencyID = "ZZZ",
                                            schemeID = "ZZZ",
                                            Value = "EmployeeXXX"
                                        }
                                    }
                                },
                                PartyName = new PartyNameType[]
                                {
                                    new PartyNameType
                                    {
                                        Name = "Josef K."
                                    }
                                }
                            },
                            Price = new PriceType
                            {
                                PriceAmount = new AmountType
                                {
                                    currencyID = "SEK",
                                    Value = 50M
                                },
                                BaseQuantity = new QuantityType
                                {
                                    unitCode = "LTR",
                                    Value = 1M
                                }
                            },
                            Item = new ItemType
                            {
                                Description = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "Red paint"
                                    }
                                },
                                Name = "Falu Rödfärg",
                                SellersItemIdentification = new ItemIdentificationType
                                {
                                    ID = "SItemNo001"
                                },
                                StandardItemIdentification = new ItemIdentificationType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyID = "6",
                                        schemeID = "GTIN",
                                        Value = "1234567890123"
                                    }
                                },
                                AdditionalItemProperty = new ItemPropertyType[]
                                {
                                    new ItemPropertyType
                                    {
                                        Name = "Paint type",
                                        Value = "Acrylic"
                                    },
                                    new ItemPropertyType
                                    {
                                        Name = "Solvant",
                                        Value = "Water"
                                    }
                                }
                            }
                        }
                    },
                    new OrderLineType
                    {
                        Note = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Freetext note on line 2"
                            }
                        },
                        LineItem = new LineItemType
                        {
                            ID = "2",
                            Quantity = new QuantityType
                            {
                                unitCode = "C62",
                                Value = 15M
                            },
                            LineExtensionAmount = new AmountType
                            {
                                currencyID = "SEK",
                                Value = 225M
                            },
                            TotalTaxAmount = new AmountType
                            {
                                currencyID = "SEK",
                                Value = 10M
                            },
                            PartialDeliveryIndicator = false,
                            AccountingCostCode = "ProjectID123",
                            Delivery = new DeliveryType[]
                            {
                                new DeliveryType
                                {
                                    RequestedDeliveryPeriod = new PeriodType
                                    {
                                        StartDate = XmlConvert.ToDateTime("2010-02-10", XmlDateTimeSerializationMode.RoundtripKind),
                                        EndDate = XmlConvert.ToDateTime("2010-02-25", XmlDateTimeSerializationMode.RoundtripKind)
                                    }
                                }
                            },
                            OriginatorParty = new PartyType
                            {
                                PartyIdentification = new PartyIdentificationType[]
                                {
                                    new PartyIdentificationType
                                    {
                                        ID = new IdentifierType
                                        {
                                            schemeAgencyID = "ZZZ",
                                            schemeID = "ZZZ",
                                            Value = "EmployeeXXX"
                                        }
                                    }
                                },
                                PartyName = new PartyNameType[]
                                {
                                    new PartyNameType
                                    {
                                        Name = "Josef K."
                                    }
                                }
                            },
                            Price = new PriceType
                            {
                                PriceAmount = new AmountType
                                {
                                    currencyID = "SEK",
                                    Value = 15M
                                },
                                BaseQuantity = new QuantityType
                                {
                                    unitCode = "C62",
                                    Value = 1M
                                }
                            },
                            Item = new ItemType
                            {
                                Description = new TextType[]
                                {
                                    new TextType
                                    {
                                        Value = "Very good pencils for red paint."
                                    }
                                },
                                Name = "Pensel 20 mm",
                                SellersItemIdentification = new ItemIdentificationType
                                {
                                    ID = "SItemNo011"
                                },
                                StandardItemIdentification = new ItemIdentificationType
                                {
                                    ID = new IdentifierType
                                    {
                                        schemeAgencyID = "6",
                                        schemeID = "GTIN",
                                        Value = "123452340123"
                                    }
                                },
                                AdditionalItemProperty = new ItemPropertyType[]
                                {
                                    new ItemPropertyType
                                    {
                                        Name = "Hair color",
                                        Value = "Black"
                                    },
                                    new ItemPropertyType
                                    {
                                        Name = "Width",
                                        Value = "20mm"
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
