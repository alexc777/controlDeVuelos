using ProyectoPrimerTrimestrePrograll.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrimerTrimestrePrograll
{
    public partial class SucursalForm : Form
    {

        private Form1 form1;

        List<Sucursal> ListSucursales = new List<Sucursal>();

        public SucursalForm(Form1 MiFormularioPadre)
        {
            InitializeComponent();
            this.form1 = MiFormularioPadre;

            var Sucuarsal = new Sucursal
            {
                IdSucu = 1,
                Nombre = "Sucursal Reforma",
                NIT = 785465,
                Direccion = "Avenida Reforma 25-51 zona 10",
                Telefono = 52658456
            };

            ListSucursales.Add(Sucuarsal);

            BindingSource bsSucu = new BindingSource
            {
                DataSource = ListSucursales
            };

            GvSucursal.DataSource = bsSucu;
            GvSucursal.Refresh();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            using (CrearSucuForm Sucursal = new CrearSucuForm(this))
            {
                Sucursal.ShowDialog();
            }
        }

        public void AgregarSucursal(Sucursal sucursal)
        {

            ListSucursales.Add(sucursal);

            BindingSource bsSucu = new BindingSource
            {
                DataSource = ListSucursales
            };

            GvSucursal.DataSource = bsSucu;
            GvSucursal.Refresh();
        }

        public void CargarSucu(int id, string nombre, int nit, string direccion, int telefono)
        {
            var sucu = new Sucursal
            {
                IdSucu = id,
                Nombre = nombre,
                NIT = nit,
                Direccion = direccion,
                Telefono = telefono
            };

            ListSucursales.Add(sucu);

            BindingSource bsSucu = new BindingSource
            {
                DataSource = ListSucursales
            };

            GvSucursal.DataSource = bsSucu;
            GvSucursal.Refresh();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog cuadroDialogoAbrirArchivo = new OpenFileDialog();
            cuadroDialogoAbrirArchivo.InitialDirectory = "c:\\";
            cuadroDialogoAbrirArchivo.Filter = "Archivo de Texto (*.txt)|*.txt|Imagenes JPG (*.jpg)|*.jpg|Todos los Archivos (*.*)|*.*";
            cuadroDialogoAbrirArchivo.FilterIndex = 1;
            cuadroDialogoAbrirArchivo.RestoreDirectory = true;

            if (cuadroDialogoAbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                string ubicacionArchivo = cuadroDialogoAbrirArchivo.FileName;
                string linea;
                StreamReader archivo = new StreamReader(ubicacionArchivo);

                while ((linea = archivo.ReadLine()) != null)
                {
                    var arr = linea.ToString().Split(',');
                    CargarSucu(int.Parse(arr[0]), Convert.ToString(arr[1]), int.Parse(arr[2]), Convert.ToString(arr[3]), int.Parse(arr[4]));
                }
            }
        }
    }
}
