using System;
using System.Globalization;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace UblLarsen.Ubl2.Udt
{
    public partial class TimeType
    {
        [XmlText]
        public string ValueAsXmlString
        {
            get { return XmlConvert.ToString(Value, XmlDateTimeSerializationMode.RoundtripKind).Split('T').Last(); }
            set { Value = XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.RoundtripKind); }
        }

        /// <summary>
        /// Allow library users to assign a string to a datetime
        /// </summary>
        /// <param name="value"></param>
        public static implicit operator TimeType(System.String value)
        {
            return string.IsNullOrEmpty(value) ? null : new TimeType { ValueAsXmlString = value };
        }
    }

    public partial class DateType
    {
        public static implicit operator DateType(System.String value)
        {
            return string.IsNullOrEmpty(value) ? null : new DateType { Value = XmlConvert.ToDateTime(value, XmlDateTimeSerializationMode.RoundtripKind) };
        }
    }

}
