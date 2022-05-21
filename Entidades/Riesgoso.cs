using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteRiesgoso : Cliente
    {
        public decimal? DeudaTotal { get; set; }
        public override decimal ObtenerTasaInteresSugerida()
        {
            if (DeudaTotal > 100000)
                return 60;

            return 30;
        }
    }
}
