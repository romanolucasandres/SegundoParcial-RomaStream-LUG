using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECliente
    {
        private int codigo;
        private string nombre;
        private string apellido;
        private string dni;
        private string email;
        public int Codigo { get => codigo; set=>codigo=value; }
        public string Nombre { get => nombre; set=>nombre=value;}
        public string Apellido { get=>apellido; set=> apellido=value; }
        public string DNI { get => dni; set=>dni=value; }
        public string Email { get=>email; set=>email=value; }

        public BECliente() { }

        public override string ToString()
        {
            return $"{Codigo} ";
        }


    }
}
