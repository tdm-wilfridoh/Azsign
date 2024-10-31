using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Azsign.WS
{
	[XmlRoot(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", ElementName = "Envelope")]
	public class ResponseSolicitudAcuerdoInfo
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

    [XmlRoot(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", ElementName = "Body")]
    public class Body
    {

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public ServiceReference2.AcuerdoInfo AcuerdoInfo { get; set; }
    }

    //[XmlRoot(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", ElementName = "Body")]
    //public class Body<T>
    //{

    //    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    //    public T AcuerdoInfo { get; set; }
    //}


    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    //public partial class AcuerdoInfo : AcuerdoInfoType
    //{
    //}

    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    //public partial class AcuerdoInfoType
    //{

    //    private AcuerdoInfoTypeEstado estadoField;

    //    private CuentaType cuentaField;

    //    private GrupoType grupoRegistroField;

    //    private AcuerdoInfoTypeOrigen origenField;

    //    private AcuerdoInfoTypeGrupo[] gruposPartcipantesField;

    //    private string mensajeField;

    //    private object observacionnesField;

    //    private AcuerdoInfoTypeDocumento[] documentosField;

    //    private AcuerdoInfoTypeCopias copiasField;

    //    private string idField;

    //    private string nombreField;

    //    private string refWebHookField;

    //    private string urlPostFirmaField;

    //    private System.DateTime fechaRecepcionField;

    //    private bool fechaRecepcionFieldSpecified;

    //    private string fechaVencimientoField;

    //    private System.DateTime fechaFinalizacionField;

    //    private bool fechaFinalizacionFieldSpecified;

    //    private System.DateTime fechaFirmaDigitalField;

    //    private bool fechaFirmaDigitalFieldSpecified;

    //    private AcuerdoInfoTypeSegundoFacAut segundoFacAutField;

    //    private bool segundoFacAutFieldSpecified;

    //    private bool estampadoCronologicoField;

    //    private bool estampadoCronologicoFieldSpecified;

    //    private bool notificarRemitenteField;

    //    private bool notificarRemitenteFieldSpecified;

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
    //    public AcuerdoInfoTypeEstado Estado
    //    {
    //        get
    //        {
    //            return this.estadoField;
    //        }
    //        set
    //        {
    //            this.estadoField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
    //    public CuentaType Cuenta
    //    {
    //        get
    //        {
    //            return this.cuentaField;
    //        }
    //        set
    //        {
    //            this.cuentaField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
    //    public GrupoType GrupoRegistro
    //    {
    //        get
    //        {
    //            return this.grupoRegistroField;
    //        }
    //        set
    //        {
    //            this.grupoRegistroField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
    //    public AcuerdoInfoTypeOrigen Origen
    //    {
    //        get
    //        {
    //            return this.origenField;
    //        }
    //        set
    //        {
    //            this.origenField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
    //    [System.Xml.Serialization.XmlArrayItemAttribute("Grupo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    //    public AcuerdoInfoTypeGrupo[] GruposPartcipantes
    //    {
    //        get
    //        {
    //            return this.gruposPartcipantesField;
    //        }
    //        set
    //        {
    //            this.gruposPartcipantesField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
    //    public string Mensaje
    //    {
    //        get
    //        {
    //            return this.mensajeField;
    //        }
    //        set
    //        {
    //            this.mensajeField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
    //    public object Observacionnes
    //    {
    //        get
    //        {
    //            return this.observacionnesField;
    //        }
    //        set
    //        {
    //            this.observacionnesField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
    //    [System.Xml.Serialization.XmlArrayItemAttribute("Documento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
    //    public AcuerdoInfoTypeDocumento[] Documentos
    //    {
    //        get
    //        {
    //            return this.documentosField;
    //        }
    //        set
    //        {
    //            this.documentosField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
    //    public AcuerdoInfoTypeCopias Copias
    //    {
    //        get
    //        {
    //            return this.copiasField;
    //        }
    //        set
    //        {
    //            this.copiasField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string Id
    //    {
    //        get
    //        {
    //            return this.idField;
    //        }
    //        set
    //        {
    //            this.idField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string Nombre
    //    {
    //        get
    //        {
    //            return this.nombreField;
    //        }
    //        set
    //        {
    //            this.nombreField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string RefWebHook
    //    {
    //        get
    //        {
    //            return this.refWebHookField;
    //        }
    //        set
    //        {
    //            this.refWebHookField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string UrlPostFirma
    //    {
    //        get
    //        {
    //            return this.urlPostFirmaField;
    //        }
    //        set
    //        {
    //            this.urlPostFirmaField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public System.DateTime FechaRecepcion
    //    {
    //        get
    //        {
    //            return this.fechaRecepcionField;
    //        }
    //        set
    //        {
    //            this.fechaRecepcionField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool FechaRecepcionSpecified
    //    {
    //        get
    //        {
    //            return this.fechaRecepcionFieldSpecified;
    //        }
    //        set
    //        {
    //            this.fechaRecepcionFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public string FechaVencimiento
    //    {
    //        get
    //        {
    //            return this.fechaVencimientoField;
    //        }
    //        set
    //        {
    //            this.fechaVencimientoField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public System.DateTime FechaFinalizacion
    //    {
    //        get
    //        {
    //            return this.fechaFinalizacionField;
    //        }
    //        set
    //        {
    //            this.fechaFinalizacionField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool FechaFinalizacionSpecified
    //    {
    //        get
    //        {
    //            return this.fechaFinalizacionFieldSpecified;
    //        }
    //        set
    //        {
    //            this.fechaFinalizacionFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public System.DateTime FechaFirmaDigital
    //    {
    //        get
    //        {
    //            return this.fechaFirmaDigitalField;
    //        }
    //        set
    //        {
    //            this.fechaFirmaDigitalField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool FechaFirmaDigitalSpecified
    //    {
    //        get
    //        {
    //            return this.fechaFirmaDigitalFieldSpecified;
    //        }
    //        set
    //        {
    //            this.fechaFirmaDigitalFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public AcuerdoInfoTypeSegundoFacAut SegundoFacAut
    //    {
    //        get
    //        {
    //            return this.segundoFacAutField;
    //        }
    //        set
    //        {
    //            this.segundoFacAutField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool SegundoFacAutSpecified
    //    {
    //        get
    //        {
    //            return this.segundoFacAutFieldSpecified;
    //        }
    //        set
    //        {
    //            this.segundoFacAutFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public bool EstampadoCronologico
    //    {
    //        get
    //        {
    //            return this.estampadoCronologicoField;
    //        }
    //        set
    //        {
    //            this.estampadoCronologicoField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool EstampadoCronologicoSpecified
    //    {
    //        get
    //        {
    //            return this.estampadoCronologicoFieldSpecified;
    //        }
    //        set
    //        {
    //            this.estampadoCronologicoFieldSpecified = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlAttributeAttribute()]
    //    public bool NotificarRemitente
    //    {
    //        get
    //        {
    //            return this.notificarRemitenteField;
    //        }
    //        set
    //        {
    //            this.notificarRemitenteField = value;
    //        }
    //    }

    //    /// <remarks/>
    //    [System.Xml.Serialization.XmlIgnoreAttribute()]
    //    public bool NotificarRemitenteSpecified
    //    {
    //        get
    //        {
    //            return this.notificarRemitenteFieldSpecified;
    //        }
    //        set
    //        {
    //            this.notificarRemitenteFieldSpecified = value;
    //        }
    //    }
    //}





}
