using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BELive: BEStreaming
    {
        private DateTime fecha;
        public DateTime Fecha { get=>fecha; set=>fecha=value; }

        public BELive() 
        {
           
        }

        public override string TipoStream(BEStreaming s)
        {
            if(s is BELive)
            {
                return this.Fecha.ToString();
            }
            else
            {
                return "";
            }
        }
    }
    
}
