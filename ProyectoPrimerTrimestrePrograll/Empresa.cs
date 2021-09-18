using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPrimerTrimestrePrograll.Class;

namespace ProyectoPrimerTrimestrePrograll
{
    public partial class Empresa : Form
    {
        private Form1 form1;

        List<Empresas> ListEmpesas = new List<Empresas>();

        public Empresa(Form1 MiFormularioPadre)
        {
            InitializeComponent();
            this.form1 = MiFormularioPadre;
            var Empresa = new Empresas
            {
                Nombre = "Aeropuerto XYZ S.A",
                NIT = 18231241,
                Direccion = "bulevar liberación 3-12 zona 13 guatemala",
                Telefono = 54455126,
            };

            ListEmpesas.Add(Empresa);

            BindingSource bsEmpresa = new BindingSource
            {
                DataSource = ListEmpesas
            };

            GvEmpresa.DataSource = bsEmpresa;
            GvEmpresa.Refresh();
        }

    }
}
