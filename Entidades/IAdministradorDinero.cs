using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAdministradorDinero
    {
        decimal ObtenerSaldo();

        bool Retirar(decimal monto);

        bool Ingresar(decimal monto);
    }
}
