using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azsign.Modelos.SolicitudAcuerdoInfo.Response
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public partial class AcuerdoInfoTypeGrupo
    {

        private AcuerdoInfoTypeGrupoParticipante[] participanteField;

        private string idField;

        private uint ordenField;

        private AcuerdoInfoTypeGrupoRol rolField;

        private string nombreField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Participante", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, Order = 0)]
        public AcuerdoInfoTypeGrupoParticipante[] Participante
        {
            get
            {
                return this.participanteField;
            }
            set
            {
                this.participanteField = value;
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
        public uint Orden
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AcuerdoInfoTypeGrupoRol Rol
        {
            get
            {
                return this.rolField;
            }
            set
            {
                this.rolField = value;
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public enum AcuerdoInfoTypeGrupoRol
    {

        /// <remarks/>
        A,

        /// <remarks/>
        E,

        /// <remarks/>
        F,

        /// <remarks/>
        N,

        /// <remarks/>
        R,
    }
}
