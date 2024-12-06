using System.Xml.Serialization;

namespace Azsign.Modelos.SolicitudAcuerdoInfo.Response
{
	[XmlRoot(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", ElementName = "Envelope")]
	public class SolicitudAcuerdoInfoEnvelopeResponse
	{

		[XmlElement(ElementName = "Header")]
		public object Header { get; set; }

		[XmlElement(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", ElementName = "Body")]
		public Body Body { get; set; }

		[XmlAttribute(AttributeName = "soap-enc")]
		public string SoapEnc { get; set; }

		[XmlAttribute(AttributeName = "soap")]
		public string Soap { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

    public class Body
    {
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public AcuerdoInfo AcuerdoInfo { get; set; }
    }

}
