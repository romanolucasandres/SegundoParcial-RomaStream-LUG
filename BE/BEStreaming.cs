using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class BEStreaming
    {
        private int codigo;
        private string categoria;
        private int duracion;
        private decimal valor;
        private string stream;
        private BECliente cliente;

        public int Codigo { get=>codigo; set=>codigo=value; }
        public string Categoria { get=>categoria; set=>categoria=value; }
        public string Stream { get=>stream; set=>stream =value; }
        public int Duracion { get=>duracion; set=>duracion=value; }
        public BECliente Cliente { get=>cliente; set=>cliente=value; }
        public decimal Valor { get=>valor; set=>valor=value; }

        public BEStreaming()
        {
            
            Cliente = new BECliente();
        }
        public abstract string TipoStream(BEStreaming s);
    }
    public enum Categoria
    {
        SD,HD,FHD
    }
    public enum Reproduccion
    {
        Serie,Pelicula
    }
    public enum Stream
    {
        Live,VOD
    }
}
