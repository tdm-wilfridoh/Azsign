﻿using Azsign.Modelos.FirmaAcuerdo.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Azsign.Modelos.FirmaAcuerdo.Response
{

    [XmlRoot(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", ElementName = "Envelope")]
    public class FirmaAcuerdoResponse
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

   // [XmlRoot(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", ElementName = "Body")]
    public class Body
    {

        //[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [XmlElementAttribute("AcuerdoRsp", Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
        public AcuerdoRsp AcuerdoRsp { get; set; }
    }
}

