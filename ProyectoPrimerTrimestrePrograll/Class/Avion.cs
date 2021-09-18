using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrimerTrimestrePrograll.Class
{
    public class Avion:TipoAvion
    {
        private int IdAvion { get; set; }
        public string Nombre { get; set; }
        public double Capacidad { get; set; }
        public string Modelo { get; set; }
        private int Estado { get; set; } // 1 = Activo 2 = inactivo
    }
}
