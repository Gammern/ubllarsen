using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLDespatchAdvice20Example
    {
        public static DespatchAdviceType Create()
        {
            return new DespatchAdviceType
            {
                UBLVersionID = "2.0",
                CustomizationID = "urn:oasis:names:specification:ubl:xpath:DespatchAdvice-2.0:sbs-1.0-draft",
                ProfileID = "bpid:urn:oasis:names:draft:bpss:ubl-2-sbs-despatch-advice-notification-draft",
                ID = "565899",
                CopyIndicator = false,
                UUID = "88C7280E-8F10-419F-9949-8EFFFA2842B8",
                IssueDate = XmlConvert.ToDateTime("2005-06-20", XmlDateTimeSerializationMode.RoundtripKind),
                DocumentStatusCode = "NoStatus",
                DespatchAdviceTypeCode = "delivery",
                Note = new TextType[]
                {
                    new TextType
                    {
                        Value = "sample"
                    }
                },
                OrderReference = new OrderReferenceType[]
                {
                    new OrderReferenceType
                    {
                        ID = "AEG012345",
                        SalesOrderID = "CON0095678",
                        UUID = "6E09886B-DC6E-439F-82D1-7CCAC7F4E3B1",
                        IssueDate = XmlConvert.ToDateTime("2005-06-20", XmlDateTimeSerializationMode.RoundtripKind)
                    }
                },
                DespatchSupplierParty = new SupplierPartyType
                {
                    CustomerAssignedAccountID = "CO001",
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
                    }
                },
                DeliveryCustomerParty = new CustomerPartyType
                {
                    CustomerAssignedAccountID = "XFB01",
                    SupplierAssignedAccountID = "GT00978567",
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
                    }
                },
                Shipment = new ShipmentType
                {
                    ID = "1",
                    Consignment = new ConsignmentType[]
                    {
                        new ConsignmentType
                        {
                            ID = "1"
                        }
                    },
                    Delivery = new DeliveryType
                    {
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
                            StartDate = XmlConvert.ToDateTime("2005-06-20", XmlDateTimeSerializationMode.RoundtripKind),
                            StartTime = "10:30:47.0Z",
                            EndDate = XmlConvert.ToDateTime("2005-06-21", XmlDateTimeSerializationMode.RoundtripKind),
                            EndTime = "10:30:47.0Z"
                        }
                    }
                },
                DespatchLine = new DespatchLineType[]
                {
                    new DespatchLineType
                    {
                        ID = "1",
                        Note = new TextType[]
                        {
                            new TextType
                            {
                                Value = "Mrs Green agreed to waive charge"
                            }
                        },
                        LineStatusCode = "NoStatus",
                        DeliveredQuantity = new QuantityType
                        {
                            unitCode = "KGM",
                            Value = 90M
                        },
                        BackorderQuantity = new QuantityType
                        {
                            unitCode = "KGM",
                            Value = 10M
                        },
                        BackorderReason = new TextType[]
                        {
                            new TextType
                            {
                                Value = "lack of stock as explained on telephone today"
                            }
                        },
                        OrderLineReference = new OrderLineReferenceType[]
                        {
                            new OrderLineReferenceType
                            {
                                LineID = "1",
                                SalesOrderLineID = "A",
                                OrderReference = new OrderReferenceType
                                {
                                    ID = "AEG012345",
                                    SalesOrderID = "CON0095678",
                                    UUID = "6E09886B-DC6E-439F-82D1-7CCAC7F4E3B1",
                                    IssueDate = XmlConvert.ToDateTime("2005-06-20", XmlDateTimeSerializationMode.RoundtripKind)
                                }
                            }
                        },
                        Item = new ItemType
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
                            ItemInstance = new ItemInstanceType[]
                            {
                                new ItemInstanceType
                                {
                                    LotIdentification = new LotIdentificationType
                                    {
                                        LotNumberID = "546378239",
                                        ExpiryDate = XmlConvert.ToDateTime("2010-01-01", XmlDateTimeSerializationMode.RoundtripKind)
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
