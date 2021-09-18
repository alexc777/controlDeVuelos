using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrimerTrimestrePrograll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Empresa  Empresa = new Empresa(this))
            {
                Empresa.ShowDialog();
            }
        }

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SucursalForm Sucursal = new SucursalForm(this))
            {
                Sucursal.ShowDialog();
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (EmpleadosForm Empleado = new EmpleadosForm(this))
            {
                Empleado.ShowDialog();
            }
        }

        private void listadoDeVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ListadoVuelosForm vuelos = new ListadoVuelosForm(this))
            {
                vuelos.ShowDialog();
            }
        }
    }
}
