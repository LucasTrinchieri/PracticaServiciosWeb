using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Cliente
    {
        public int Codigo { get; set; }
        public string NombreApellido { get; set; }
        public int Edad { get; set; }

        public abstract decimal ObtenerTasaInteresSugerida();
    }
}
