using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Azsign.Modelos.SolicitudAcuerdoInfo.Response
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public partial class AcuerdoInfoType
    {

        private AcuerdoInfoTypeEstado estadoField;

        private CuentaType cuentaField;

        private GrupoType grupoRegistroField;

        private AcuerdoInfoTypeOrigen origenField;

        private AcuerdoInfoTypeGrupo[] gruposPartcipantesField;

        private string mensajeField;

        private object observacionnesField;

        private AcuerdoInfoTypeDocumento[] documentosField;

        private AcuerdoInfoTypeCopias copiasField;

        private string idField;

        private string nombreField;

        private string refWebHookField;

        private string urlPostFirmaField;

        private System.DateTime? fechaRecepcionField;

        private bool fechaRecepcionFieldSpecified;

        private string fechaVencimientoField;

        private System.DateTime? fechaFinalizacionField;

        private bool fechaFinalizacionFieldSpecified;

        private System.DateTime? fechaFirmaDigitalField;

        private bool fechaFirmaDigitalFieldSpecified;

        private AcuerdoInfoTypeSegundoFacAut? segundoFacAutField;

        private bool segundoFacAutFieldSpecified;

        private bool estampadoCronologicoField;

        private bool estampadoCronologicoFieldSpecified;

        private bool? notificarRemitenteField;

        private bool notificarRemitenteFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public AcuerdoInfoTypeEstado Estado
        {
            get
            {
                return this.estadoField;
            }
            set
            {
                this.estadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        public CuentaType Cuenta
        {
            get
            {
                return this.cuentaField;
            }
            set
            {
                this.cuentaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
        public GrupoType GrupoRegistro
        {
            get
            {
                return this.grupoRegistroField;
            }
            set
            {
                this.grupoRegistroField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        public AcuerdoInfoTypeOrigen Origen
        {
            get
            {
                return this.origenField;
            }
            set
            {
                this.origenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Grupo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public AcuerdoInfoTypeGrupo[] GruposPartcipantes
        {
            get
            {
                return this.gruposPartcipantesField;
            }
            set
            {
                this.gruposPartcipantesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 5)]
        public string Mensaje
        {
            get
            {
                return this.mensajeField;
            }
            set
            {
                this.mensajeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 6)]
        public object Observacionnes
        {
            get
            {
                return this.observacionnesField;
            }
            set
            {
                this.observacionnesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Documento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public AcuerdoInfoTypeDocumento[] Documentos
        {
            get
            {
                return this.documentosField;
            }
            set
            {
                this.documentosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 8)]
        public AcuerdoInfoTypeCopias Copias
        {
            get
            {
                return this.copiasField;
            }
            set
            {
                this.copiasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RefWebHook
        {
            get
            {
                return this.refWebHookField;
            }
            set
            {
                this.refWebHookField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UrlPostFirma
        {
            get
            {
                return this.urlPostFirmaField;
            }
            set
            {
                this.urlPostFirmaField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("FechaRecepcion")]
        public string FechaRecepcionString
        {
            //get
            //{
            //    return fechaRecepcionField.ToString("yyyy-MM-ddTHH:mm:ss");
            //}
            //set { }

            get
            {
                return this.fechaRecepcionField.HasValue ? XmlConvert.ToString(fechaRecepcionField.Value, XmlDateTimeSerializationMode.Unspecified)
                : string.Empty;
            }
            set
            {
                this.fechaRecepcionField = !string.IsNullOrEmpty(value) ? XmlConvert.ToDateTime(Utility.ConvertirFechaToW3C(value), XmlDateTimeSerializationMode.Unspecified) : (System.DateTime?)System.DateTime.Now;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore]
        public System.DateTime? FechaRecepcion
        {
            get
            {
                return this.fechaRecepcionField;
            }
            set
            {
                this.fechaRecepcionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FechaRecepcionSpecified
        {
            get
            {
                return this.fechaRecepcionFieldSpecified;
            }
            set
            {
                this.fechaRecepcionFieldSpecified = value;
            }
        }


        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FechaVencimiento
        {
            get
            {
                return this.fechaVencimientoField;
            }
            set
            {
                this.fechaVencimientoField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute("FechaFinalizacion")]
        public string FechaFinalizacionString
        {
            get
            {
                return this.fechaFinalizacionField.HasValue ? XmlConvert.ToString(fechaFinalizacionField.Value, XmlDateTimeSerializationMode.Unspecified)
                : string.Empty;
            }
            set
            {
                this.fechaFinalizacionField = !string.IsNullOrEmpty(value) ? XmlConvert.ToDateTime(Utility.ConvertirFechaToW3C(value), XmlDateTimeSerializationMode.Unspecified) : (System.DateTime?)null;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public System.DateTime? FechaFinalizacion
        {
            get
            {
                return this.fechaFinalizacionField;
            }
            set
            {
                this.fechaFinalizacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FechaFinalizacionSpecified
        {
            get
            {
                return this.fechaFinalizacionFieldSpecified;
            }
            set
            {
                this.fechaFinalizacionFieldSpecified = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute("FechaFirmaDigital")]
        public string FechaFirmaDigitalString
        {
            get
            {
                return this.fechaFirmaDigitalField.HasValue ? XmlConvert.ToString(fechaFirmaDigitalField.Value, XmlDateTimeSerializationMode.Unspecified)
                : string.Empty;
            }
            set
            {
                this.fechaFirmaDigitalField = !string.IsNullOrEmpty(value) ? XmlConvert.ToDateTime(Utility.ConvertirFechaToW3C(value), XmlDateTimeSerializationMode.Unspecified) : (System.DateTime?)null;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.DateTime? FechaFirmaDigital
        {
            get
            {
                return this.fechaFirmaDigitalField;
            }
            set
            {
                this.fechaFirmaDigitalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FechaFirmaDigitalSpecified
        {
            get
            {
                return this.fechaFirmaDigitalFieldSpecified;
            }
            set
            {
                this.fechaFirmaDigitalFieldSpecified = value;
            }
        }

        //public AcuerdoInfoTypeSegundoFacAut funcT(object value)
        //{
        //    var e = value;
        //    if (Enum.IsDefined(typeof(AcuerdoInfoTypeSegundoFacAut), value))
        //        return (AcuerdoInfoTypeSegundoFacAut)value;

        //     return AcuerdoInfoTypeSegundoFacAut.Null;
        //}

        [System.Xml.Serialization.XmlAttributeAttribute("SegundoFacAut")]
        public string SegundoFacAutString
        {
            get
            {
                return this.segundoFacAutField.ToString();
            }
            set
            {
                this.segundoFacAutField = (AcuerdoInfoTypeSegundoFacAut?)(Enum.IsDefined(typeof(AcuerdoInfoTypeSegundoFacAut), value) ? Enum.Parse(typeof(AcuerdoInfoTypeSegundoFacAut), value) : null);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public AcuerdoInfoTypeSegundoFacAut? SegundoFacAut
        {
            get
            {
                return this.segundoFacAutField;
            }
            set
            {
                this.segundoFacAutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SegundoFacAutSpecified
        {
            get
            {
                return this.segundoFacAutFieldSpecified;
            }
            set
            {
                this.segundoFacAutFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool EstampadoCronologico
        {
            get
            {
                return this.estampadoCronologicoField;
            }
            set
            {
                this.estampadoCronologicoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EstampadoCronologicoSpecified
        {
            get
            {
                return this.estampadoCronologicoFieldSpecified;
            }
            set
            {
                this.estampadoCronologicoFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("NotificarRemitente")]
        public string NotificarRemitenteString
        {
            get
            {
                return this.notificarRemitenteField.ToString();
            }
            set
            {
                this.notificarRemitenteField = String.IsNullOrWhiteSpace(value) ? null : Boolean.Parse(value);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool? NotificarRemitente
        {
            get
            {
                return this.notificarRemitenteField;
            }
            set
            {
                this.notificarRemitenteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NotificarRemitenteSpecified
        {
            get
            {
                return this.notificarRemitenteFieldSpecified;
            }
            set
            {
                this.notificarRemitenteFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public enum AcuerdoInfoTypeSegundoFacAut
    {

        /// <remarks/>
        OTP
    }
}
