using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaCorriente : Cuenta, IAdministradorDinero
    {
        public decimal MontoDescubierto { get; set; } //La cuenta puede quedar en negativo pero no mas de este valor
        public Cliente Cliente { get; set; }

        public bool Retirar(decimal monto)
        {
            if ((Monto - monto) >= MontoDescubierto)
            {
                Monto -= monto;

                return true;
            }

            return false;
        }
    }
}
