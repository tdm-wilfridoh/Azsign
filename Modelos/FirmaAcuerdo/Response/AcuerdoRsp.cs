using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Azsign.Modelos.FirmaAcuerdo.Response
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    [XmlRoot(Namespace = "http://www.analitica.com.co/AZSign/Esquemas", ElementName = "AcuerdoRsp")]
    public partial class AcuerdoRsp
    {

        //[XmlNamespaceDeclarations]
        //public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces(new[] {
        //    new XmlQualifiedName("azs", "http://www.analitica.com.co/AZSign/Esquemas")
        //});

        private AcuerdoRspDocumentos[] documentosField;

        private string cuentaField;

        private string aplicacionField;

        private string acuerdoIdField;

        private string acuerdoNombreField;

        private System.DateTime? fechaHoraField;

        private string vencimientoField;

        /// <remarks/>
        //[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Documento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public AcuerdoRspDocumentos[] Documentos
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Cuenta
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AcuerdoId
        {
            get
            {
                return this.acuerdoIdField;
            }
            set
            {
                this.acuerdoIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AcuerdoNombre
        {
            get
            {
                return this.acuerdoNombreField;
            }
            set
            {
                this.acuerdoNombreField = value;
            }
        }


        [System.Xml.Serialization.XmlAttributeAttribute("FechaHora")]
        public string FechaHoraString
        {
            get
            {
                return this.fechaHoraField.HasValue ? XmlConvert.ToString(fechaHoraField.Value, XmlDateTimeSerializationMode.Unspecified)
                : string.Empty;
            }
            set
            {
                this.fechaHoraField = !string.IsNullOrEmpty(value) ? XmlConvert.ToDateTime(Utility.ConvertirFechaToW3C(value), XmlDateTimeSerializationMode.Unspecified) : (System.DateTime?)null;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public System.DateTime? FechaHora
        {
            get
            {
                return this.fechaHoraField;
            }
            set
            {
                this.fechaHoraField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Vencimiento
        {
            get
            {
                return this.vencimientoField;
            }
            set
            {
                this.vencimientoField = value;
            }
        }
    }
}
