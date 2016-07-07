using System.Xml;
using UblLarsen.Ubl2;
using UblLarsen.Ubl2.Cac;
using UblLarsen.Ubl2.Ext;
using UblLarsen.Ubl2.Udt;

namespace UblLarsen.Test.UblClass
{
    internal class UBLOrderCancellation21Example
    {
        public static OrderCancellationType Create()
        {
            return new OrderCancellationType
            {
                UBLVersionID = "2.1",
                CustomizationID = "urn:www.cenbii.eu:transaction:biicoretrdmXYZ:ver1.0",
                ProfileID = new IdentifierType
                {
                    schemeAgencyID = "BII",
                    schemeID = "Profile",
                    Value = "urn:www.cenbii.eu:profile:BIIXYZ:ver1.0"
                },
                ID = "7",
                IssueDate = XmlConvert.ToDateTime("2010-01-21", XmlDateTimeSerializationMode.RoundtripKind),
                IssueTime = "12:30:00",
                CancellationNote = new TextType[]
                {
                    new TextType
                    {
                        Value = "With reference to phone call"
                    }
                },
                OrderReference = new OrderReferenceType[]
                {
                    new OrderReferenceType
                    {
                        ID = "34"
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
                        }
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
                        }
                    }
                }
            }
;
        }
    }
}
