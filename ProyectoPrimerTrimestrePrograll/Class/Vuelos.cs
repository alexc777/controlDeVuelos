using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrimerTrimestrePrograll.Class
{
    public class Vuelos: TipoVuelo
    {
        private int IdVuelo { get; set; }
        public string FechaVuelo { get; set; }
        public string FechaLlegada { get; set; }
        public int Estado { get; set; }
        /*
            1 = cargando 2 = despegando 3 = proceso 4 = aterizando
        */
        public string Destino { get; set; }
        
        
        public double AlturaVuelo { get; set; }
        public int LargoPista { get; set; }
        public double Velicidad { get; set; }
        public double Aterrizaje { get; set; }
        public double TiempoDespegue { get; set; }

    }
}
