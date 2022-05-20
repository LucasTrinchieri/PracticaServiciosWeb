using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteVip : Cliente
    {
        public override decimal ObtenerTasaInteresSugerida()
        {
            if (Edad > 18 && Edad < 75)
            {
                return 15;
            }

            return 20;
        }
    }
}
