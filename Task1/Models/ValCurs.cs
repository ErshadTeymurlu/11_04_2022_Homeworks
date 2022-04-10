using System.Collections.Generic;
using System.Xml.Serialization;

namespace Task1.Models
{
    [XmlRoot(ElementName = "ValCurs")]
    public class ValCurs
    {
        [XmlElement(ElementName = "ValType")]
        public List<ValType> ValType { get; set; }
        [XmlAttribute(AttributeName = "Date")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }
    }
}
