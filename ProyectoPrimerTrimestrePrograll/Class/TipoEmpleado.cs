using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrimerTrimestrePrograll.Class
{
    public class TipoEmpleado
    {
        private int IdTEmpleado { get; set; }
        public string Nombre { get; set; }
        /*
            Pilotos, Aeromosas, Guardias, Ventas, Atencion al cliente, revisión
        */
        public int Estado { get; set; } // 1 = activo 2 = inactivo

    }
}
