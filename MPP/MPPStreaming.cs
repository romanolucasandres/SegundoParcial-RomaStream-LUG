using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using Acceso;

namespace MPP
{
    public class MPPStreaming
    {

        private AccesoXML acceso;
        public MPPStreaming()
        {
            acceso = new AccesoXML();
        }
        public void Alta(BEStreaming s)
        {
            try
            {
                XDocument XML = acceso.CargarXML();
                if (XML != null)
                {
                    if (s != null)
                    {

                        if (s is BELive)
                        {
                            XML.Element("StreamsBD").Element("Streams").Add(new XElement("streaming",
                                                                new XAttribute("codigo", s.Codigo.ToString().Trim()),
                                                            new XElement("categoria", s.Categoria.Trim()),
                                                            new XElement("cliente", s.Cliente.Apellido.Trim()),
                                                            new XElement("duracion", s.Duracion.ToString().Trim()),
                                                            new XElement("stream", s.Stream.ToString().Trim()),
                                                            new XElement("valor", s.Valor.ToString().Trim()),
                                                            new XElement("fecha", s.TipoStream(s).Trim()),
                                                            new XElement("reproduccion", string.Empty)
                                                            ));
                        }
                        else if (s is BEVOD)
                        {
                            XML.Element("StreamsBD").Element("Streams").Add(new XElement("streaming",
                                                               new XAttribute("codigo", s.Codigo.ToString().Trim()),
                                                           new XElement("categoria", s.Categoria.Trim()),
                                                           new XElement("cliente", s.Cliente.Apellido.Trim()),
                                                           new XElement("duracion", s.Duracion.ToString().Trim()),
                                                           new XElement("stream", s.Stream.ToString().Trim()),
                                                           new XElement("valor", s.Valor.ToString().Trim()),
                                                           new XElement("fecha", string.Empty),
                                                           new XElement("reproduccion", s.TipoStream(s).Trim())
                                                           ));
                        }

                        else
                        {
                            XML.Element("Streams").Element("Streams").Add(new XElement("streaming",
                                                                new XAttribute("codigo", s.Codigo.ToString().Trim()),
                                                            new XElement("categoria", s.Categoria.Trim()),
                                                            new XElement("cliente", s.Cliente.Apellido.Trim()),
                                                            new XElement("duracion", s.Duracion.ToString().Trim()),
                                                            new XElement("stream", s.Stream.ToString().Trim()),
                                                            new XElement("valor", s.Valor.ToString().Trim()),
                                                            new XElement("fecha", string.Empty),
                                                            new XElement("reproduccion", string.Empty)
                                                            ));
                        }
                        acceso.GuardarXML(XML);
                    }
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

        public List<BEStreaming> Traer()
        {
            List<BEStreaming> Lista = new List<BEStreaming>();
            try
            {
                XElement XML = acceso.CargarXelementXML();
                var leer = from Streaming in XML.Elements("Streams").Elements("streaming")
                           where Streaming.Element("fecha").Value.Trim() != ""
                           select new BELive
                           {
                               Codigo = Convert.ToInt32(Convert.ToString(Streaming.Attribute("codigo")?.Value).Trim()),
                               Categoria = Convert.ToString(Streaming.Element("categoria")?.Value).Trim(),
                               Duracion = Convert.ToInt32(Streaming.Element("duracion")?.Value.ToString().Trim()),
                               Stream = Convert.ToString(Streaming.Element("stream")?.Value.Trim()),
                               Valor = Convert.ToDecimal(Streaming.Element("valor")?.Value.ToString().Trim()),
                               Fecha = Convert.ToDateTime(Streaming.Element("fecha")?.Value.ToString().Trim()),
                               Cliente = Relacion1a1(Convert.ToInt32(Streaming.Element("cliente")?.Value.Trim()))

                           };
                Lista.AddRange(leer);

                var leerV = from Streaming in XML.Elements("Streams").Elements("streaming")
                            where Streaming.Element("reproduccion").Value.Trim() != ""
                            select new BEVOD
                            {
                                Codigo = Convert.ToInt32(Convert.ToString(Streaming.Attribute("codigo")?.Value).Trim()),
                                Categoria = Convert.ToString(Streaming.Element("categoria")?.Value).Trim(),
                                Duracion = Convert.ToInt32(Streaming.Element("duracion")?.Value.ToString().Trim()),
                                Stream = Convert.ToString(Streaming.Element("stream")?.Value.Trim()),
                                Valor = Convert.ToDecimal(Streaming.Element("valor")?.Value.ToString().Trim()),
                                Reproduccion = Convert.ToString(Streaming.Element("reproduccion")?.Value).Trim(),
                                Cliente = Relacion1a1(Convert.ToInt32(Streaming.Element("cliente")?.Value.Trim()))
                                
                            };
                Lista.AddRange(leerV);

            }
            catch (XmlException xmlex)
            {
                throw xmlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Lista;
        }

        public BECliente Relacion1a1(int cliente)
        {

            BECliente C = null;
            try
            {

                XDocument XML = acceso.CargarXML();
                if (XML != null)
                {
                    var leer = from Cliente in XML.Descendants("cliente")
                               where Cliente.Attribute("codigo").Value == cliente.ToString().Trim()
                               select Cliente;
                    var obj = leer.FirstOrDefault();
                    
                   
                        if (obj != null)
                        {
                            C = new BECliente();
                            C.Codigo = Convert.ToInt32(obj.Attribute("codigo")?.Value.Trim());
                            C.Nombre = obj.Element("nombre")?.Value.Trim();
                            C.Apellido = obj.Element("apellido").Value.Trim();
                            C.DNI = obj.Element("dni").Value?.Trim();
                            C.Email = obj.Element("email").Value?.Trim();
                        }
                   
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
            return C;
        }

     
    }
}
