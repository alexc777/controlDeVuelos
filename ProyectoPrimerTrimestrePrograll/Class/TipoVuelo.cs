using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrimerTrimestrePrograll.Class
{
    public class TipoVuelo :AeroLinea
    {
        private int IdTipo { get; set; }
        public int Tipo { get; set; }
        /* 
            1 = Normal 2 = Prioritario 3 = aterrizaje forzoso
        */
    }
}
