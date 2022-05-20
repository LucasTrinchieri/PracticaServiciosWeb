using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CajaAhorro : Cuenta, IAdministradorDinero
    {
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaCierre { get; set; }
        public Cliente Cliente { get; set; }        

        public bool Retirar(decimal monto)
        {
            if (monto <= Monto)
            {
                Monto -= monto;

                return true;
            }

            return false;
        }
    }
}
