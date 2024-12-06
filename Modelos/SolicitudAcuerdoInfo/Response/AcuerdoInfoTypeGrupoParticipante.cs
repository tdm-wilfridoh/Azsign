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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public partial class AcuerdoInfoTypeGrupoParticipante
    {

        private AcuerdoInfoTypeGrupoParticipanteEstado estadoField;

        private object observacionesField;

        private string idField;

        private string emailField;

        private string nombreField;

        private string apellidoField;


        private string celularField;

        private System.DateTime? fechaEnvioParaFirmaField;

        private bool fechaEnvioParaFirmaFieldSpecified;

        private System.DateTime? fechaLecturaParaFirmaField;

        private bool fechaLecturaParaFirmaFieldSpecified;

        private string ipLecturaParaFirmaField;

        private System.DateTime? fechaRespuestaField;

        private bool fechaRespuestaFieldSpecified;

        private string ipRespuestaField;

        private System.DateTime? fechaEnvioDocumentoFirmadoField;

        private bool fechaEnvioDocumentoFirmadoFieldSpecified;

        private System.DateTime? fechaDescargaDocumentoFirmadoField;

        private bool fechaDescargaDocumentoFirmadoFieldSpecified;

        private string ipDescargaDocumentoFirmadoField;

        private string nombreEnFirmaField;

        private string identificacionField;

        private string organizacionField;

        private string cargoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public AcuerdoInfoTypeGrupoParticipanteEstado Estado
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
        public object Observaciones
        {
            get
            {
                return this.observacionesField;
            }
            set
            {
                this.observacionesField = value;
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
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
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

        ///No viene  por defecto en el archivo XSD
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Apellido
        {
            get
            {
                return this.apellidoField;
            }
            set
            {
                this.apellidoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Celular
        {
            get
            {
                return this.celularField;
            }
            set
            {
                this.celularField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("FechaEnvioParaFirma")]
        public string FechaEnvioParaFirmaString
        {
            get
            {
                return this.fechaEnvioParaFirmaField.HasValue ? XmlConvert.ToString(fechaEnvioParaFirmaField.Value, XmlDateTimeSerializationMode.Unspecified)
                : string.Empty;
            }
            set
            {
                this.fechaEnvioParaFirmaField = !string.IsNullOrEmpty(value) ? XmlConvert.ToDateTime(Utility.ConvertirFechaToW3C(value), XmlDateTimeSerializationMode.Unspecified) : (System.DateTime?)null;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public System.DateTime? FechaEnvioParaFirma
        {
            get
            {
                return this.fechaEnvioParaFirmaField;
            }
            set
            {
                this.fechaEnvioParaFirmaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FechaEnvioParaFirmaSpecified
        {
            get
            {
                return this.fechaEnvioParaFirmaFieldSpecified;
            }
            set
            {
                this.fechaEnvioParaFirmaFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("FechaLecturaParaFirma")]
        public string FechaLecturaParaFirmaString
        {
            get
            {
                return this.fechaLecturaParaFirmaField.HasValue ? XmlConvert.ToString(fechaLecturaParaFirmaField.Value, XmlDateTimeSerializationMode.Unspecified)
                : string.Empty;
            }
            set
            {
                this.fechaLecturaParaFirmaField = !string.IsNullOrEmpty(value) ? XmlConvert.ToDateTime(Utility.ConvertirFechaToW3C(value), XmlDateTimeSerializationMode.Unspecified) : (System.DateTime?)null;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public System.DateTime? FechaLecturaParaFirma
        {
            get
            {
                return this.fechaLecturaParaFirmaField;
            }
            set
            {
                this.fechaLecturaParaFirmaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FechaLecturaParaFirmaSpecified
        {
            get
            {
                return this.fechaLecturaParaFirmaFieldSpecified;
            }
            set
            {
                this.fechaLecturaParaFirmaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IpLecturaParaFirma
        {
            get
            {
                return this.ipLecturaParaFirmaField;
            }
            set
            {
                this.ipLecturaParaFirmaField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute("FechaRespuesta")]
        public string FechaRespuestaString
        {
            get
            {
                return this.fechaRespuestaField.HasValue ? XmlConvert.ToString(fechaRespuestaField.Value, XmlDateTimeSerializationMode.Unspecified)
                : string.Empty;
            }
            set
            {
                this.fechaRespuestaField = !string.IsNullOrEmpty(value) ? XmlConvert.ToDateTime(Utility.ConvertirFechaToW3C(value), XmlDateTimeSerializationMode.Unspecified) : (System.DateTime?)null;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public System.DateTime? FechaRespuesta
        {
            get
            {
                return this.fechaRespuestaField;
            }
            set
            {
                this.fechaRespuestaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FechaRespuestaSpecified
        {
            get
            {
                return this.fechaRespuestaFieldSpecified;
            }
            set
            {
                this.fechaRespuestaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IpRespuesta
        {
            get
            {
                return this.ipRespuestaField;
            }
            set
            {
                this.ipRespuestaField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("FechaEnvioDocumentoFirmado")]
        public string FechaEnvioDocumentoFirmadoString
        {
            get
            {
                return this.fechaEnvioDocumentoFirmadoField.HasValue ? XmlConvert.ToString(fechaEnvioDocumentoFirmadoField.Value, XmlDateTimeSerializationMode.Unspecified)
                : string.Empty;
            }
            set
            {
                this.fechaEnvioDocumentoFirmadoField = !string.IsNullOrEmpty(value) ? XmlConvert.ToDateTime(Utility.ConvertirFechaToW3C(value), XmlDateTimeSerializationMode.Unspecified) : (System.DateTime?)null;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public System.DateTime? FechaEnvioDocumentoFirmado
        {
            get
            {
                return this.fechaEnvioDocumentoFirmadoField;
            }
            set
            {
                this.fechaEnvioDocumentoFirmadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FechaEnvioDocumentoFirmadoSpecified
        {
            get
            {
                return this.fechaEnvioDocumentoFirmadoFieldSpecified;
            }
            set
            {
                this.fechaEnvioDocumentoFirmadoFieldSpecified = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("FechaDescargaDocumentoFirmado")]
        public string FechaDescargaDocumentoFirmadoString
        {
            get
            {
                return this.fechaDescargaDocumentoFirmadoField.HasValue ? XmlConvert.ToString(fechaDescargaDocumentoFirmadoField.Value, XmlDateTimeSerializationMode.Unspecified)
                : string.Empty;
            }
            set
            {
                this.fechaDescargaDocumentoFirmadoField = !string.IsNullOrEmpty(value) ? XmlConvert.ToDateTime(Utility.ConvertirFechaToW3C(value), XmlDateTimeSerializationMode.Unspecified) : (System.DateTime?)null;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public System.DateTime? FechaDescargaDocumentoFirmado
        {
            get
            {
                return this.fechaDescargaDocumentoFirmadoField;
            }
            set
            {
                this.fechaDescargaDocumentoFirmadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FechaDescargaDocumentoFirmadoSpecified
        {
            get
            {
                return this.fechaDescargaDocumentoFirmadoFieldSpecified;
            }
            set
            {
                this.fechaDescargaDocumentoFirmadoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IpDescargaDocumentoFirmado
        {
            get
            {
                return this.ipDescargaDocumentoFirmadoField;
            }
            set
            {
                this.ipDescargaDocumentoFirmadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NombreEnFirma
        {
            get
            {
                return this.nombreEnFirmaField;
            }
            set
            {
                this.nombreEnFirmaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Identificacion
        {
            get
            {
                return this.identificacionField;
            }
            set
            {
                this.identificacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Organizacion
        {
            get
            {
                return this.organizacionField;
            }
            set
            {
                this.organizacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Cargo
        {
            get
            {
                return this.cargoField;
            }
            set
            {
                this.cargoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    //  [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public partial class AcuerdoInfoTypeGrupoParticipanteEstado
    {

        private string idField;

        private string nombreField;

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
    }
}
