using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace Acceso
{
    public class AccesoXML
    {
        //genero una constante con el nombre del archivo XML
        private const string NombreXML = "StreamBD.xml";
        //creo una variable para la ruta de acceso
        private string rutaAcceso = Path.Combine(Directory.GetCurrentDirectory(),NombreXML);

        public XDocument CargarXML()
        {
            XDocument xDocument = null;
            try
            {
                if (File.Exists(rutaAcceso))
                    xDocument = XDocument.Load(rutaAcceso);
                else
                {
                    xDocument = XDocument.Load(rutaAcceso);
                }
            }
            catch (XmlException xex)
            {
                throw xex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return xDocument;

        }

        public XElement CargarXelementXML()
        {
            XElement xElement = null;
            try
            {
                if (File.Exists(rutaAcceso))
                    xElement = XElement.Load(rutaAcceso);

            }
            catch (XmlException xex)
            {
                throw xex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return xElement;

        }

        public void GuardarXML(XDocument XML)
        {
            try
            {
                if (XML != null)
                    XML.Save(rutaAcceso);
            }
            catch (XmlException xex)
            {
                throw xex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
