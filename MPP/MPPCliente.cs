using Acceso;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MPP
{
    public class MPPCliente
    {
        private AccesoXML acceso;
        public MPPCliente()
        {
            acceso = new AccesoXML();
        }

        public void Alta(BECliente c)
        {
            try
            {
                XDocument XML = acceso.CargarXML();


                if (c != null)
                {
                    XML.Element("StreamsBD").Element("Clientes").Add(new XElement("cliente",
                                                        new XAttribute("codigo", c.Codigo.ToString().Trim()),
                                                    new XElement("nombre", c.Nombre.Trim()),
                                                    new XElement("apellido", c.Apellido.Trim()),
                                                    new XElement("dni", c.DNI.Trim()),
                                                    new XElement("email", c.Email.Trim())
                                                    ));                        
                    acceso.GuardarXML(XML);
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

        }
        
        public void Modificar(BECliente c) 
        {
            try
            {
                XDocument XML = acceso.CargarXML();
                if (XML != null)
                {
                    var leer = from Cliente in XML.Descendants("cliente")
                               where Cliente.Attribute("codigo").Value == c.Codigo.ToString().Trim()
                               select Cliente;

                    foreach (var item in leer)
                    {
                        item.Element("nombre").Value = c.Nombre.Trim();
                        item.Element("apellido").Value = c.Apellido.Trim();
                        item.Element("dni").Value = c.DNI.Trim();
                        item.Element("email").Value = c.Email.Trim();
                    }
                    acceso.GuardarXML(XML);
                }
               
            }
            catch (XmlException ex)
            {

                throw ex;
            }
        }

        public void Baja(BECliente c)
        {
            try
            {
                XDocument XML = acceso.CargarXML();
                if (XML != null)
                {
                    var leer = from Cliente in XML.Descendants("cliente")
                               where Cliente.Attribute("codigo").Value == c.Codigo.ToString().Trim()
                               select Cliente;

                    leer.Remove();
                    acceso.GuardarXML(XML);
                }
            }
            catch (XmlException ex)
            {

                throw ex;
            }
        }

        public List<BECliente> Traer()
        {
            try
            {

                XElement XML = acceso.CargarXelementXML();
                var leer = from Cliente in XML.Elements("Clientes").Elements("cliente")
                           select new BECliente
                           {
                               Codigo = Convert.ToInt32(Convert.ToString(Cliente.Attribute("codigo")?.Value).Trim()),
                               Nombre = Convert.ToString(Cliente.Element("nombre")?.Value).Trim(),
                               Apellido = Convert.ToString(Cliente.Element("apellido")?.Value).Trim(),
                               DNI = Convert.ToString(Cliente.Element("dni").Value)?.Trim(),
                               Email = Convert.ToString(Cliente.Element("email").Value)?.Trim(),
                           };

                List<BECliente> Lista= leer.ToList();
                return Lista;
            }
            catch (XmlException ex)
            {
                throw ex;
            }
        }
    }
}
