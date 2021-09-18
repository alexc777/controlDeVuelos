using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrimerTrimestrePrograll.Class
{
    public class Empleado
    {
        private int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Codigo { get; set; }
        public string Direccion { get; set; }
        public int Estado { get; set; } // 1 = activo 2 = inactivo
        public int NIT { get; set; }

    }
}
