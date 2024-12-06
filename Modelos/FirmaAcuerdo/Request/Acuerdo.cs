using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Azsign.Modelos.FirmaAcuerdo.Request
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    [XmlRoot(Namespace = "http://www.analitica.com.co/AZSign/Esquemas", ElementName = "Acuerdo")]
    public partial class Acuerdo : AcuerdoType
    {
        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns = new XmlSerializerNamespaces(new[] {
            new XmlQualifiedName("azs", "http://www.analitica.com.co/AZSign/Esquemas")
        });
    }
}
