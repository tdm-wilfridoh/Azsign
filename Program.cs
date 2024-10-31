using Microsoft.IdentityModel.Tokens;
using ServiceReference2;
using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Security;
using System.Text;
using System.Xml.Linq;

namespace Azsign
{

    public class MyX509CertificateValidator : X509CertificateValidator
    {
        private string _allowedIssuerName;

        public MyX509CertificateValidator(string allowedIssuerName)
        {
            if (string.IsNullOrEmpty(allowedIssuerName))
            {
                throw new ArgumentNullException("allowedIssuerName", "[MyX509CertificateValidator] The string parameter allowedIssuerName was null or empty.");
            }

            _allowedIssuerName = allowedIssuerName;
        }

        public override void Validate(X509Certificate2 certificate)
        {
            // Check that there is a certificate.
            if (certificate == null)
            {
                throw new ArgumentNullException("certificate", "[MyX509CertificateValidator] The X509Certificate2 parameter certificate was null.");
            }

            // Check that the certificate issuer matches the configured issuer.
            if (!certificate.Subject.Contains("CN=azsign.analitica.com.co"))
            {
                throw new SecurityTokenValidationException
                  (string.Format("Certificate was not issued by a trusted issuer. Expected: {0}, Actual: {1}", _allowedIssuerName, certificate.IssuerName.Name));
            }
        }
    }

        class Program
    {


        private const int V = 3;


        static void Main(string[] args)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            //Console.WriteLine("Hello World!");
            //var c = new NumberConversionSoapTypeClient(NumberConversionSoapTypeClient.EndpointConfiguration.NumberConversionSoap);
            //var r = c.NumberToWordsAsync(ulong.Parse("938")).Result;

            //Azsign();
            //Azsign2();
            //SolicitarInfoAcuerdo();
            Test();
        }

        static void Azsign()
        {
            var client2 = new ServiceReference2.ServiciosAZSign_SOAPClient(ServiceReference2.ServiciosAZSign_SOAPClient.EndpointConfiguration.ServiciosAZSign_SOAP);

            client2.ClientCredentials.ServiceCertificate.SslCertificateAuthentication = new X509ServiceCertificateAuthentication();
            client2.ClientCredentials.ServiceCertificate.SslCertificateAuthentication.CertificateValidationMode = X509CertificateValidationMode.Custom;
            MyX509CertificateValidator myX509CertificateValidator = new MyX509CertificateValidator("CN=ServiceModelSamples-HTTPS-Server");
            client2.ClientCredentials.ServiceCertificate.SslCertificateAuthentication.CustomCertificateValidator = myX509CertificateValidator;

            var u = Convert.ToBase64String(Encoding.ASCII.GetBytes("20241022-124027-4fafe1-45992970:e20f6181814ba6eac7cb4e599d68dffc"));
            //client2.ClientCredentials.UserName.UserName ="20241022-124027-4fafe1-45992970";
            //client2.ClientCredentials.UserName.Password = "e20f6181814ba6eac7cb4e599d68dffc";

            client2.ClientCredentials.UserName.UserName = u;
            client2.ClientCredentials.UserName.Password = u;



            ServiceReference2.AcuerdoTypeGrupoParticipante[] ac = new ServiceReference2.AcuerdoTypeGrupoParticipante[]{
                new ServiceReference2.AcuerdoTypeGrupoParticipante()
                {
                    Nombre = "Wilfrido",
                    Apellido = "Herrera",
                    Email ="wilheba@hotmail.com",
                }
            };

            var d = new ServiceReference2.AcuerdoTypeDocumento()
            {
                Nombre = "Documento Prueba Analitica.pdf",
                //TipoMime = ServiceReference2.AcuerdoTypeDocumentoTipoMime.applicationpdf,
                Value = DocumentoPdf.doc
            };

            var acuerdo = new ServiceReference2.Acuerdo()
            {
                Mensaje = "Prueba Azsign",
                Documentos = new ServiceReference2.AcuerdoTypeDocumento[]
                {
                    d
                },
                Cuenta = "20230317-094007-4c9c60-89584564",
                Aplicativo = "20241022-124027-4fafe1-45992970",
                TipoFirma = ServiceReference2.AcuerdoTypeTipoFirma.E,
                Estado = ServiceReference2.AcuerdoTypeEstado.Item1P,
                RefWebHook = "AZDigital: (5)",
                GruposPartcipantes = new ServiceReference2.AcuerdoTypeGrupo[]
                {
                    new ServiceReference2.AcuerdoTypeGrupo {
                        Nombre = "Prueba",
                        Orden = 0,
                        Rol = ServiceReference2.AcuerdoTypeGrupoRol.E,
                        Participante = ac
                    }
                },
                Grupo = "20230317-094007-4e26a0-98466172",
                Nombre = "Acuerdo 1",

            };


            //var m = new System.Web.Services.Protocols.SoapMessage();

            //client2.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;

            var resp = client2.AcuerdoAsync(acuerdo).Result;

        }

        static void Azsign2()
        {
            var doc1 = File.ReadAllBytes(@"C:\Users\WilfridoR\source\repos\Azsign\WS\Docs\Documento 1.pdf");
            var doc1B64 = Convert.ToBase64String(doc1);

            var documento1 = new ServiceReference2.AcuerdoTypeDocumento()
            {
                Nombre = "Documento 1.pdf",
                Value = doc1B64,
                TipoMime = ServiceReference2.AcuerdoTypeDocumentoTipoMime.applicationpdf
            };

            var doc2 = File.ReadAllBytes(@"C:\Users\WilfridoR\source\repos\Azsign\WS\Docs\Documento 2.pdf");
            var doc2B64 = Convert.ToBase64String(doc2);

            var documento2 = new ServiceReference2.AcuerdoTypeDocumento()
            {
                Nombre = "Documento 2.pdf",
                Value = doc2B64,
                TipoMime = ServiceReference2.AcuerdoTypeDocumentoTipoMime.applicationpdf
            };

            var doc3 = File.ReadAllBytes(@"C:\Users\WilfridoR\source\repos\Azsign\WS\Docs\Documento 3.docx");
            var doc3B64 = Convert.ToBase64String(doc3);

            var documento3 = new ServiceReference2.AcuerdoTypeDocumento()
            {
                Nombre = "Documento 3.docx",
                Value = doc3B64,
                TipoMime = ServiceReference2.AcuerdoTypeDocumentoTipoMime.applicationmsword
            };


            ServiceReference2.AcuerdoTypeGrupoParticipante[] participantes = new ServiceReference2.AcuerdoTypeGrupoParticipante[]{
                new ServiceReference2.AcuerdoTypeGrupoParticipante()
                {
                    Nombre = "Wilfrido",
                    Apellido = "Herrera",
                    Email ="wilheba@hotmail.com",
                },
                new ServiceReference2.AcuerdoTypeGrupoParticipante()
                {
                    Nombre = "Wilfrido",
                    Apellido = "Herrera",
                    Email = "wilfrido.herrerab@gmail.com",
                },
                //new ServiceReference2.AcuerdoTypeGrupoParticipante()
                //{
                //    Nombre = "Robinson",
                //    Apellido = "Sanchez",
                //    Email ="robinson.sanchez@tandemweb.com",
                //}
            };




            var acuerdo = new ServiceReference2.Acuerdo()
            {
                Mensaje = "Prueba Azsign",
                Documentos = new ServiceReference2.AcuerdoTypeDocumento[]
                {
                    documento1,documento2,documento3
                },
                Cuenta = "20230317-094007-4c9c60-89584564",
                Aplicativo = "20241022-124027-4fafe1-45992970",
                TipoFirma = ServiceReference2.AcuerdoTypeTipoFirma.E,
                Estado = ServiceReference2.AcuerdoTypeEstado.Item1P,
                RefWebHook = "AZDigital: (5)",
                GruposPartcipantes = new ServiceReference2.AcuerdoTypeGrupo[]
                {
                    new ServiceReference2.AcuerdoTypeGrupo {
                        Nombre = "Prueba",
                        Orden = 0,
                        Rol = ServiceReference2.AcuerdoTypeGrupoRol.E,
                        Participante = participantes
                    }
                },
                Grupo = "20230317-094007-4e26a0-98466172",
                Nombre = "Acuerdo 1",

            };

            StringWriter stringWriter = new StringWriter();
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(acuerdo.GetType());
            //x.Serialize(Console.Out, acuerdo);
            x.Serialize(stringWriter, acuerdo);
            var camb = stringWriter.ToString().Split("\r\n", 2)[1];
            var st = String.Format(DocumentoPdf.docXML2, camb);
            //var st = stringWriter.ToString().Split("\r\n", 2)[1];

            Console.WriteLine();

            using (var httpClient = new HttpClient())
            {
                var authToken = Encoding.ASCII.GetBytes("20241022-124027-4fafe1-45992970:e20f6181814ba6eac7cb4e599d68dffc");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));

                var requestUrl = "https://azsign.analitica.com.co/WebServices/SOAP/";
                var soapRequest = new StringContent(st, Encoding.UTF8, "text/xml");
                //var respone = httpClient.PostAsXmlAsync(requestUrl, acuerdo).Result;

                var response = httpClient.PostAsync(requestUrl, soapRequest).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;
                //var r = response.Content.ReadAsAsync<AcuerdoResponse>().Result;

                //Console.WriteLine(responseContent);

                //Test(responseContent);
            }
        }

        static void Test()
        {
            AcuerdoResponseSerialize(DocumentoPdf.ResponseAcuerdo);
            //AcuerdoResponseSerialize(r);

        }

        static void AcuerdoResponseSerialize(string response)
        {
            var acuerdoRespXML = RemoveEnvelopeXml(response);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(AcuerdoRsp));
            var str = new StringReader(acuerdoRespXML);
            var resp = (AcuerdoRsp)serializer.Deserialize(str);
        }

        static void SolicitarInfoAcuerdo()
        {
            var acuerdoInfo = new ServiceReference2.SolicitarAcuerdoInfo()
            {
                AcuerdoId = "20241028-103536-df4660-03207304",
                Aplicativo = "20241022-124027-4fafe1-45992970",
                Cuenta = "20230317-094007-4c9c60-89584564",
                IncluirDocs = true
            };

            //var env = new WS.EnvelopeResponseAcuerdoInfo() { 
            //    Body = new WS.Body()
            //    {
            //        AcuerdoInfo = acuerdoInfo
            //    }
            //};


            StringWriter stringWriter = new StringWriter();
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(acuerdoInfo.GetType());
            x.Serialize(stringWriter, acuerdoInfo);
            var xmlSinCabecera = stringWriter.ToString().Split("\r\n", 2)[1];
            var st = String.Format(DocumentoPdf.docXML2, xmlSinCabecera);

            using (var httpClient = new HttpClient())
            {
                var authToken = Encoding.ASCII.GetBytes("20241022-124027-4fafe1-45992970:e20f6181814ba6eac7cb4e599d68dffc");
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));

                var requestUrl = "https://azsign.analitica.com.co/WebServices/SOAP/";
                var soapRequest = new StringContent(st, Encoding.UTF8, "text/xml");

                //System.Xml.Serialization.XmlSerializer y = new System.Xml.Serialization.XmlSerializer(env.GetType());
                //y.Serialize(stringWriter = new StringWriter(), env);
                //var tt = stringWriter.ToString();

                //var respone = (httpClient.PostAsXmlAsync(requestUrl, env).Result).Content.ReadAsStringAsync().Result;

                var response = httpClient.PostAsync(requestUrl, soapRequest).Result;
                var responseContent = response.Content.ReadAsStringAsync().Result;


                //Extrayendo objeto Envelope utilizando ReadAsAsync<T> (recomendado)
                var envelope = EnvelopeSerialize(response);

                //Deserealizar la respuesta al tipo ResponseSolicitudAcuerdoInfo
                envelope = EnvelopeSerialize(responseContent);

                //Deserealizar la respuesta al tipo AcuerdoInfo
                var acuerdo = AcuerdoInfoSerialize(responseContent);

                foreach (var doc in acuerdo.Documentos) {
                    ConvertB64ToPDF(doc.Value, doc.Nombre);
                 }

            }
        }

        static WS.ResponseSolicitudAcuerdoInfo EnvelopeSerialize(HttpResponseMessage httpResponseMessage)
        {
            var formatters = new List<MediaTypeFormatter>() {
                new XmlMediaTypeFormatter(){ UseXmlSerializer = true } };

            //var r = httpResponseMessage.Content.ReadAsStringAsync().Result;

            var response = httpResponseMessage.Content.ReadAsAsync<WS.ResponseSolicitudAcuerdoInfo>(formatters).Result;
            return response;
        }

        static WS.ResponseSolicitudAcuerdoInfo EnvelopeSerialize(string response)
        {
            var responseTemp = response.Replace("\"", "'");
            var des = new System.Xml.Serialization.XmlSerializer(typeof(WS.ResponseSolicitudAcuerdoInfo));
            var xm = (WS.ResponseSolicitudAcuerdoInfo)des.Deserialize(new StringReader(responseTemp));
            return xm;
        }

        static ServiceReference2.AcuerdoInfo AcuerdoInfoSerialize(string response)
        {
            var index = response.IndexOf("</soap:Body>");
            response = response.Remove(index);
            var acuerdoXML = response.Split("Body>")[1].Replace("\"", "'"); ;

            var des = new System.Xml.Serialization.XmlSerializer(typeof(ServiceReference2.AcuerdoInfo));
            var acuerdo = (ServiceReference2.AcuerdoInfo)des.Deserialize(new StringReader(acuerdoXML));
            return acuerdo;
        }

        static string RemoveEnvelopeXml(string envelope)
        {
            var index = envelope.IndexOf("</soap:Body>");
            var content = envelope.Remove(index);
            return content.Split("Body>")[1].Replace("\"", "'"); 
            //return content.Split("Body>")[1];

        }

        static void ConvertB64ToPDF(byte[] value, string fileName)
        {
            File.WriteAllBytes(@$"C:\Users\WilfridoR\source\repos\Azsign\WS\Docs\Download\{fileName}", value);
        }
    }
}
