using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLLive : BLLStreaming
    {
        public override decimal Calcular(int duracion, string categoria)
        {
            decimal costoPorMediaHora = 0;
            switch (categoria)
            {
                case "SD":
                    costoPorMediaHora = 100;
                    break;
                case "HD":
                    costoPorMediaHora = 300;
                    break;
                case "FHD":
                    costoPorMediaHora = 400;
                    break;
                default:
                    throw new Exception("Categoria invalida");
                    break;
            }
            int cantidadMediaHora = (int)Math.Ceiling((double)duracion / 30);
            decimal costoTotal = costoPorMediaHora * cantidadMediaHora;
            return costoTotal - (costoTotal * 0.2m);
        }
    }
}
