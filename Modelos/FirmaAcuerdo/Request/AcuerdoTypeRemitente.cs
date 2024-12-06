using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azsign.Modelos.FirmaAcuerdo.Request
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public partial class AcuerdoTypeRemitente
    {

        private string idRemitenteField;

        private string nombreField;

        private string emailField;

        private string organizacionField;

        private string dependenciaField;

        private string telefonoField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IdRemitente
        {
            get
            {
                return this.idRemitenteField;
            }
            set
            {
                this.idRemitenteField = value;
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
        public string Dependencia
        {
            get
            {
                return this.dependenciaField;
            }
            set
            {
                this.dependenciaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Telefono
        {
            get
            {
                return this.telefonoField;
            }
            set
            {
                this.telefonoField = value;
            }
        }
    }
}
