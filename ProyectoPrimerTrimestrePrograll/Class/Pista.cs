using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrimerTrimestrePrograll.Class
{
    public class Pista
    {
        private int IdPista { get; set; }
        public string Nombre { get; set; }
        private int Estado { get; set; }// 1 = disponible 2 = ocupada 3 = mantenimiento
        public double Largo { get; set; }
        public double Ancho { get; set; }
    }
}
