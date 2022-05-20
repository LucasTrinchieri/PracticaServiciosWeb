using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Cuenta
    {
        public int Id { get; set; }

        protected decimal Monto { get; set; }

        public decimal ObtenerSaldo()
        {
            return Monto;
        }

        public bool Ingresar(decimal monto)
        {
            Monto += monto;

            return true;
        }
    }
}
