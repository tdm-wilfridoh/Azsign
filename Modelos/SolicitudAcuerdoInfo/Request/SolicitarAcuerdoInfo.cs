using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Azsign.Modelos.SolicitudAcuerdoInfo.Request
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    [XmlRoot(Namespace = "http://www.analitica.com.co/AZSign/Esquemas", ElementName = "SolicitarAcuerdoInfo")]
    public partial class SolicitarAcuerdoInfo
    {

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces(new[] {
            new XmlQualifiedName("azs", "http://www.analitica.com.co/AZSign/Esquemas")
        });

        private string cuentaField;

        private string aplicativoField;

        private string acuerdoIdField;

        private bool incluirDocsField;

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
        public string Aplicativo
        {
            get
            {
                return this.aplicativoField;
            }
            set
            {
                this.aplicativoField = value;
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
        public bool IncluirDocs
        {
            get
            {
                return this.incluirDocsField;
            }
            set
            {
                this.incluirDocsField = value;
            }
        }
    }
}
