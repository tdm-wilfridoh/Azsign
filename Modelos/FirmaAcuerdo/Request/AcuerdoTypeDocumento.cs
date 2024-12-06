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
    public partial class AcuerdoTypeDocumento
    {

        private string nombreField;

        private AcuerdoTypeDocumentoTipoMime tipoMimeField;

        private AcuerdoTypeDocumentoCodificacion codificacionField;

        private string valueField;

        public AcuerdoTypeDocumento()
        {
            // this.tipoMimeField = AcuerdoTypeDocumentoTipoMime.applicationpdf;
            this.codificacionField = AcuerdoTypeDocumentoCodificacion.Base64;
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
        //[System.ComponentModel.DefaultValueAttribute(AcuerdoTypeDocumentoTipoMime.applicationpdf)]
        public AcuerdoTypeDocumentoTipoMime TipoMime
        {
            get
            {
                return this.tipoMimeField;
            }
            set
            {
                this.tipoMimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(AcuerdoTypeDocumentoCodificacion.Base64)]
        public AcuerdoTypeDocumentoCodificacion Codificacion
        {
            get
            {
                return this.codificacionField;
            }
            set
            {
                this.codificacionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public enum AcuerdoTypeDocumentoTipoMime
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/pdf")]
        applicationpdf,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application_vnd.ms/excel")]
        application_vndmsexcel,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.openxmlformats-officedocument.spreadsheetml.template")]
        applicationvndopenxmlformatsofficedocumentspreadsheetmltemplate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.ms-excel.sheet.macroEnabled.12")]
        applicationvndmsexcelsheetmacroEnabled12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.ms-excel.template.macroEnabled.12")]
        applicationvndmsexceltemplatemacroEnabled12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.ms-excel.addin.macroEnabled.12")]
        applicationvndmsexceladdinmacroEnabled12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.ms-excel.sheet.binary.macroEnabled.12")]
        applicationvndmsexcelsheetbinarymacroEnabled12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("text/html")]
        texthtml,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("image/pjpeg")]
        imagepjpeg,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/octet-stream")]
        applicationoctetstream,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("text/plain")]
        textplain,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/msword")]
        applicationmsword,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/msword")]
        applicationmsword1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("image/gif")]
        imagegif,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("text/xml")]
        textxml,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("image/x-png")]
        imagexpng,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("image/png")]
        imagepng,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.ms-powerpoint")]
        applicationvndmspowerpoint,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.openxmlformats-officedocument.presentationml.presentation")]
        applicationvndopenxmlformatsofficedocumentpresentationmlpresentation,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.openxmlformats-officedocument.presentationml.template")]
        applicationvndopenxmlformatsofficedocumentpresentationmltemplate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.openxmlformats-officedocument.presentationml.slideshow")]
        applicationvndopenxmlformatsofficedocumentpresentationmlslideshow,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.ms-powerpoint.addin.macroEnabled.12")]
        applicationvndmspowerpointaddinmacroEnabled12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.ms-powerpoint.presentation.macroEnabled.12")]
        applicationvndmspowerpointpresentationmacroEnabled12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.ms-powerpoint.template.macroEnabled.12")]
        applicationvndmspowerpointtemplatemacroEnabled12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.ms-powerpoint.slideshow.macroEnabled.12")]
        applicationvndmspowerpointslideshowmacroEnabled12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("image/tiff")]
        imagetiff,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("image/jpeg")]
        imagejpeg,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.openxmlformats_xlsx")]
        applicationvndopenxmlformats_xlsx,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.openxmlformats")]
        applicationvndopenxmlformats,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.openxmlformats-officedocument.wordprocessingml.template")]
        applicationvndopenxmlformatsofficedocumentwordprocessingmltemplate,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.ms-word.document.macroEnabled.12")]
        applicationvndmsworddocumentmacroEnabled12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.ms-word.document.macroEnabled.12")]
        applicationvndmsworddocumentmacroEnabled121,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("text/csv")]
        textcsv,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.oasis.opendocument.text")]
        applicationvndoasisopendocumenttext,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/rtf")]
        applicationrtf,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.oasis.opendocument.presentation")]
        applicationvndoasisopendocumentpresentation,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("application/vnd.oasis.opendocument.spreadsheet")]
        applicationvndoasisopendocumentspreadsheet,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.3")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.analitica.com.co/AZSign/Esquemas")]
    public enum AcuerdoTypeDocumentoCodificacion
    {

        /// <remarks/>
        Base64,

        /// <remarks/>
        IdDocAZSign,

        /// <remarks/>
        Path,
    }
}
