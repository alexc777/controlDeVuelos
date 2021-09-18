using ProyectoPrimerTrimestrePrograll.Class;
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
    public partial class AgregarEmpleadoForm : Form
    {
        private EmpleadosForm formEmple;
        public AgregarEmpleadoForm(EmpleadosForm frmEmple)
        {
            InitializeComponent();
            this.formEmple = frmEmple;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text;
            var apellido = txtApellido.Text;
            var codigo = int.Parse(txtCodigo.Text);
            var direccion = txtDireccion.Text;
            var estado = int.Parse(txtEstado.Text);
            var nit = int.Parse(txtNit.Text);

            var Empleado = new Empleado
            {
                Nombre = nombre,
                Apellido = apellido,
                Codigo = codigo,
                Direccion = direccion,
                Estado = estado,
                NIT = nit
            };

            formEmple.AgregarEmpleado(Empleado);
            this.Close();
        }
    }
}
