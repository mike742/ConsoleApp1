using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    [XmlType("customer")]
    public class customer
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "creditcard")]
        public string Creditcard { get; set; }
        [XmlElement(ElementName = "password")]
        public string Password { get; set; }
    }
}
