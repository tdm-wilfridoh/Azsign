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
    public partial class AcuerdoTypeGrupoParticipante
    {

        private string emailField;

        private string nombreField;

        private string apellidoField;

        private string tipoIdentificacionField;

        private string numeroDocumentoField;

        private string celularField;

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

        /// <remarks/>
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
        public string TipoIdentificacion
        {
            get
            {
                return this.tipoIdentificacionField;
            }
            set
            {
                this.tipoIdentificacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NumeroDocumento
        {
            get
            {
                return this.numeroDocumentoField;
            }
            set
            {
                this.numeroDocumentoField = value;
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
    }
}
