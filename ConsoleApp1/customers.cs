using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    [XmlRoot("customers")]
    public class customers
    {
        [XmlElement("customer")]
        public List<customer> customersList { get; set; }
    }
}
