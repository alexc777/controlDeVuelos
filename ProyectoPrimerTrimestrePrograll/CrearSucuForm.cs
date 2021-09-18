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
    public partial class CrearSucuForm : Form
    {
        private SucursalForm formSucu;

        public CrearSucuForm(SucursalForm FrmSucu)
        {
            InitializeComponent();
            this.formSucu = FrmSucu;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text;
            var nit = int.Parse(txtNit.Text);
            var direccion = txtDireccion.Text;
            var tel = int.Parse(txtTelefono.Text);
            var idSucu = int.Parse(txtIdSucu.Text);

            var sucu = new Sucursal
            {
                Nombre = nombre,
                NIT = nit,
                Direccion = direccion,
                Telefono = tel,
                IdSucu = idSucu
            };

            formSucu.AgregarSucursal(sucu);
            this.Close();
        }
    }
}
