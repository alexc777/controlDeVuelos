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
    public partial class CrearVueloForm : Form
    {
        private ListadoVuelosForm frmVuelos;

        public CrearVueloForm(ListadoVuelosForm frmPadre)
        {
            InitializeComponent();
            this.frmVuelos = frmPadre;
        }

        private void CrearVueloForm_Load(object sender, EventArgs e)
        {
            List<object> Tipovuelo = new List<object>();
            Tipovuelo.Add("Normal");
            Tipovuelo.Add("Prioritario");
            Tipovuelo.Add("Aterrizaje forzoso");
            selectTvuelo.DataSource = Tipovuelo;

            List<object> Aerolinea = new List<object>();
            Aerolinea.Add("American Airlines");
            Aerolinea.Add("Avianca");
            Aerolinea.Add("Volaris");
            selectAero.DataSource = Aerolinea;

            List<object> Calificacion = new List<object>();
            Calificacion.Add("Excelente");
            Calificacion.Add("Buena");
            Calificacion.Add("Mala");
            selectCali.DataSource = Calificacion;

            List<object> TipoAvion = new List<object>();
            TipoAvion.Add("Comercial");
            TipoAvion.Add("Carga");
            TipoAvion.Add("Militar");
            TipoAvion.Add("Avionetas VIP");
            TipoAvion.Add("Pasajeros");//200
            TipoAvion.Add("Jumbo");//2000
            selectTAvion.DataSource = TipoAvion;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var tipoVuelo = selectTvuelo.Text;
            int miTipo = 0;

            if (tipoVuelo == "Normal")
            {
                miTipo = 1;
            }
            else if (tipoVuelo == "Prioritario")
            {
                miTipo = 2;
            }
            else if (tipoVuelo == "Aterrizaje forzoso")
            {
                miTipo = 3;
            }
            else
            {
                Console.WriteLine("no se asigno");
            }


            var vueloCreate = new Vuelos
            {
                //Vuelo
                FechaVuelo = txtFecha.Value.Date.ToString("dd/MM/yyyy"),
                FechaLlegada = txtFechaLlegada.Value.Date.ToString("dd/MM/yyyy"),
                Estado = int.Parse(txtEstado.Text),
                Destino = txtDestino.Text,
                Tipo = miTipo,
                LargoPista = int.Parse(txtLargoPista.Text),
                //Aerolinea
                NombreLinea = selectAero.Text,
                Calificacion = selectCali.Text,
                //Avion
                Nombre = txtNombreA.Text,
                Capacidad = Convert.ToDouble(txtCapacidad.Text),
                Modelo = txtModeloA.Text,
                NombreTipo = selectTAvion.Text
            };

            frmVuelos.GuardarVuelo(vueloCreate);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
