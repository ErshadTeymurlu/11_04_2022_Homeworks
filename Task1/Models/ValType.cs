using System.Collections.Generic;
using System.Xml.Serialization;

namespace Task1.Models
{
	[XmlRoot(ElementName = "ValType")]
	public class ValType
	{
		[XmlElement(ElementName = "Valute")]
		public List<Valute> Valute { get; set; }
		[XmlAttribute(AttributeName = "Type")]
		public string Type { get; set; }
	}
}
