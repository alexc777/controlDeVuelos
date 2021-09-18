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
    public partial class EmpleadosForm : Form
    {
        private Form1 form1;
        List<Empleado> ListEmpleados = new List<Empleado>();

        public EmpleadosForm(Form1 MiFormularioPadre)
        {
            InitializeComponent();
            this.form1 = MiFormularioPadre;

            var miEmpleado = new Empleado
            {
                Nombre = "Osman",
                Apellido = "Cruz",
                Codigo = 01,
                Direccion = "Avenida petapa 25-51 zona 12",
                Estado = 1,
                NIT = 012344
            };

            ListEmpleados.Add(miEmpleado);

            BindingSource bsEm = new BindingSource
            {
                DataSource = ListEmpleados
            };

            GvEmpleados.DataSource = bsEm;
            GvEmpleados.Refresh();
        }


        private void btn_Crear_Click(object sender, EventArgs e)
        {
            using (AgregarEmpleadoForm Empleado = new AgregarEmpleadoForm(this))
            {
                Empleado.ShowDialog();
            }
        }

        public void AgregarEmpleado(Empleado empleado)
        {

            ListEmpleados.Add(empleado);

            BindingSource bsSucu = new BindingSource
            {
                DataSource = ListEmpleados
            };

            GvEmpleados.DataSource = bsSucu;
            GvEmpleados.Refresh();
        }

        public void CargarEmpleado(string nombre, string apellido, int codigo, string direccion, int estado, int nit)
        {
            var miEmpleado = new Empleado
            {
                Nombre = nombre,
                Apellido = apellido,
                Codigo = codigo,
                Direccion = direccion,
                Estado = estado,
                NIT = nit
            };

            ListEmpleados.Add(miEmpleado);

            BindingSource bsSucu = new BindingSource
            {
                DataSource = ListEmpleados
            };

            GvEmpleados.DataSource = bsSucu;
            GvEmpleados.Refresh();
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
                    //Console.WriteLine(Convert.ToString(arr[0]));
                    //Console.WriteLine(Convert.ToString(arr[1]));
                    //Console.WriteLine(int.Parse(arr[2]));
                    //Console.WriteLine(Convert.ToString(arr[3]));
                    //Console.WriteLine(int.Parse(arr[4]));
                    //Console.WriteLine(int.Parse(arr[5]));
                    CargarEmpleado(Convert.ToString(arr[0]), Convert.ToString(arr[1]), int.Parse(arr[2]), Convert.ToString(arr[3]), int.Parse(arr[4]), int.Parse(arr[5]));
                }
            }
        }
    }
}
