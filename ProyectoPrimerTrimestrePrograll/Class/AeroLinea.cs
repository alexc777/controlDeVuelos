using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrimerTrimestrePrograll.Class
{
    public class AeroLinea:Avion
    {
        private int IdAero { get; set; }
        public string NombreLinea { get; set; }
        private int Estado { get; set; } // 1 = activo 2 = inactivo
        public string Calificacion { get; set; }
        //List<Avion> Aviones = new List<Avion>();
    }
}
