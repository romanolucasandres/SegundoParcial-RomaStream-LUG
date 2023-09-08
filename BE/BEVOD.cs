using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEVOD : BEStreaming
    {
        private string reproduccion;
        public string Reproduccion { get=> reproduccion; set=>reproduccion=value; }

        public BEVOD()
        {
           
        }

        public override string TipoStream(BEStreaming s)
        {
            if (s is BEVOD)
            {
                return this.Reproduccion;
            }
            else
            {
                return "";
            }
            
        }
    }
}
