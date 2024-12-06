using ServiceReference2;
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace Azsign
{

    [XmlRoot(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", ElementName = "Envelope")]
    public class ErrorEnvelopeResponse
    {
        [XmlElement(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", ElementName = "Body")]
        public SoapBody Body { get; set; }
    }

    public class SoapBody
    {
        [XmlElement("Fault")]
        public SoapFault Fault { get; set; }
    }

    public class SoapFault
    {
       
        [System.Xml.Serialization.XmlElementAttribute(ElementName = "faultcode", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public string FaultCode { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "faultstring", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public string FaultString { get; set; } 

        [System.Xml.Serialization.XmlElementAttribute(ElementName = "detail", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public SoapFaultDetail Detail { get; set; }
    }

    public class SoapFaultDetail
    {
        [XmlElementAttribute("Errores", Namespace = "http://www.analitica.com.co/Esquemas/Errores/")]
        public Errores Errores { get; set; }
    }


    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/Esquemas/Errores/")]
    public partial class Errores
    {

        private ErroresError[] errorField;

        private string tipoField;

        private string aplicacionField;

        [System.Xml.Serialization.XmlElementAttribute("Error", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ErroresError[] Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tipo
        {
            get
            {
                return this.tipoField;
            }
            set
            {
                this.tipoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Aplicacion
        {
            get
            {
                return this.aplicacionField;
            }
            set
            {
                this.aplicacionField = value;
            }
        }
    }


    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/Esquemas/Errores/")]
    public partial class ErroresError
    {

        private string codigoField;

        private uint lineaField;

        private bool lineaFieldSpecified;

        private string referenciaField;

        private string valueField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Codigo
        {
            get
            {
                return this.codigoField;
            }
            set
            {
                this.codigoField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Linea
        {
            get
            {
                return this.lineaField;
            }
            set
            {
                this.lineaField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LineaSpecified
        {
            get
            {
                return this.lineaFieldSpecified;
            }
            set
            {
                this.lineaFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Referencia
        {
            get
            {
                return this.referenciaField;
            }
            set
            {
                this.referenciaField = value;
            }
        }

        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

   // public class FaultErrors
   // {
   //     [XmlAttribute("Tipo")]
   //     public string Type { get; set; }

   //     [XmlAttribute("Aplicacion")]
   //     public string Application { get; set; }

   //     //[XmlElement("Error", Namespace = "http://www.analitica.com.co/Esquemas/Errores/")]
   //     //[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
   //     //[System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
   //     [System.Xml.Serialization.XmlElementAttribute("Error", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
   //     public FaultError[] ErrorList { get; set; }
   // }

   //// [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/Esquemas/Errores/")]
   // public class FaultError
   // {
   //     [XmlAttribute("Codigo")]
   //     public string Code { get; set; }

   //     [XmlText]
   //     public string Message { get; set; }
   // }
}
