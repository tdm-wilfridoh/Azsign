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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public partial class AcuerdoInfoTypeDocumento
    {

        private string idField;

        private string naturalezaField;

        private string nombreField;

        private int ordenField;

        private System.DateTime? fechaCargaField;

        private bool fechaCargaFieldSpecified;

        private string usuarioCargaField;

        private string aplicacionCargaField;

        private bool eliminadoField;

        private bool eliminadoFieldSpecified;

        private byte[] valueField;

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
        public string Naturaleza
        {
            get
            {
                return this.naturalezaField;
            }
            set
            {
                this.naturalezaField = value;
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
        public int Orden
        {
            get
            {
                return this.ordenField;
            }
            set
            {
                this.ordenField = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute("FechaCarga")]
        public string FechaCargaString
        {
            get
            {
                return this.fechaCargaField.HasValue ? XmlConvert.ToString(fechaCargaField.Value, XmlDateTimeSerializationMode.Unspecified)
                : string.Empty;
            }
            set
            {
                this.fechaCargaField = !string.IsNullOrEmpty(value) ? XmlConvert.ToDateTime(Utility.ConvertirFechaToW3C(value), XmlDateTimeSerializationMode.Unspecified) : (System.DateTime?)null;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public System.DateTime? FechaCarga
        {
            get
            {
                return this.fechaCargaField;
            }
            set
            {
                this.fechaCargaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FechaCargaSpecified
        {
            get
            {
                return this.fechaCargaFieldSpecified;
            }
            set
            {
                this.fechaCargaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UsuarioCarga
        {
            get
            {
                return this.usuarioCargaField;
            }
            set
            {
                this.usuarioCargaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AplicacionCarga
        {
            get
            {
                return this.aplicacionCargaField;
            }
            set
            {
                this.aplicacionCargaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Eliminado
        {
            get
            {
                return this.eliminadoField;
            }
            set
            {
                this.eliminadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EliminadoSpecified
        {
            get
            {
                return this.eliminadoFieldSpecified;
            }
            set
            {
                this.eliminadoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
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
}
