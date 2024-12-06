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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public partial class AcuerdoType
    {

        private AcuerdoTypeGrupo[] gruposPartcipantesField;

        private AcuerdoTypeCopia[] copiasField;

        private string mensajeField;

        private AcuerdoTypeDocumento[] documentosField;

        private AcuerdoTypeRemitente remitenteField;

        private string cuentaField;

        private string grupoField;

        private string aplicativoField;

        private string nombreField;

        private AcuerdoTypeTipoFirma tipoFirmaField;

        private AcuerdoTypeEstado estadoField;

        private string refWebHookField;

        private string urlPostFirmaField;

        private AcuerdoTypeSegundoFacAut segundoFacAutField;

        private bool segundoFacAutFieldSpecified;

        private string estamparCronologicamenteField;

        private System.DateTime vencimientoField;

        private bool vencimientoFieldSpecified;

        private string notificarRemitenteField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Grupo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public AcuerdoTypeGrupo[] GruposPartcipantes
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
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Copia", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public AcuerdoTypeCopia[] Copias
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
        //[System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 2)]
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
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Documento", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public AcuerdoTypeDocumento[] Documentos
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
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 4)]
        public AcuerdoTypeRemitente Remitente
        {
            get
            {
                return this.remitenteField;
            }
            set
            {
                this.remitenteField = value;
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
        public string Grupo
        {
            get
            {
                return this.grupoField;
            }
            set
            {
                this.grupoField = value;
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
        public AcuerdoTypeTipoFirma TipoFirma
        {
            get
            {
                return this.tipoFirmaField;
            }
            set
            {
                this.tipoFirmaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AcuerdoTypeEstado Estado
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AcuerdoTypeSegundoFacAut SegundoFacAut
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
        public string EstamparCronologicamente
        {
            get
            {
                return this.estamparCronologicamenteField;
            }
            set
            {
                this.estamparCronologicamenteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Vencimiento
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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VencimientoSpecified
        {
            get
            {
                return this.vencimientoFieldSpecified;
            }
            set
            {
                this.vencimientoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NotificarRemitente
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public enum AcuerdoTypeTipoFirma
    {

        /// <remarks/>
        E,

        /// <remarks/>
        D,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public enum AcuerdoTypeEstado
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1-P")]
        Item1P,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2-T")]
        Item2T,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public enum AcuerdoTypeSegundoFacAut
    {

        /// <remarks/>
        OTP,

        /// <remarks/>
        VTU,

        /// <remarks/>
        NA,
    }
}
