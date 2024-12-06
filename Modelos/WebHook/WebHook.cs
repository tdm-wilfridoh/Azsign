using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azsign.Modelos.SolicitudAcuerdoInfo.Response;

namespace Azsign.Modelos.WebHook
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    [System.Xml.Serialization.XmlRootAttribute()]
    public partial class WebHook
    {

        private CuentaType cuentaField;

        private WebHookAmbito ambitoField;

        private EventoType eventoField;

        private AcuerdoInfo acuerdoInfoField;

        private string idField;

        private string nombreField;

        private string urlField;

        private System.DateTime fechaHoraField;

        /// <remarks/>
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WebHookAmbito Ambito
        {
            get
            {
                return this.ambitoField;
            }
            set
            {
                this.ambitoField = value;
            }
        }

        /// <remarks/>
        public EventoType Evento
        {
            get
            {
                return this.eventoField;
            }
            set
            {
                this.eventoField = value;
            }
        }

        /// <remarks/>
        public AcuerdoInfo AcuerdoInfo
        {
            get
            {
                return this.acuerdoInfoField;
            }
            set
            {
                this.acuerdoInfoField = value;
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
        public string Url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime FechaHora
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
    }
}
