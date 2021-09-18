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
    public partial class ListadoVuelosForm : Form
    {
        private Form1 form1;

        List<Vuelos> VuelosList = new List<Vuelos>();

        //Pistas
        List<Vuelos> Pista1List = new List<Vuelos>();
        List<Vuelos> Pista2List = new List<Vuelos>();
        List<Vuelos> Pista3List = new List<Vuelos>();
        List<Vuelos> Pista4List = new List<Vuelos>();
        List<Vuelos> Pista5List = new List<Vuelos>();
        List<Vuelos> Pista6List = new List<Vuelos>();

        //Despegues Aterrizajes
        List<Vuelos> DespeguesList = new List<Vuelos>();
        List<Vuelos> AterrizajesList = new List<Vuelos>();

        public ListadoVuelosForm()
        {
            InitializeComponent();
        }

        public ListadoVuelosForm(Form1 MiFormularioPadre)
        {
            InitializeComponent();
            this.form1 = MiFormularioPadre;

            var miVuelo = new Vuelos
            {
                //Vuelo
                FechaVuelo = DateTime.Now.ToString("dd/MM/yyyy"),
                FechaLlegada = DateTime.Now.ToString("dd/MM/yyyy"),
                Estado = 1,
                Destino = "Miami",
                Tipo = 2,
                AlturaVuelo = 0,
                LargoPista = 3190,
                Velicidad = 0,
                Aterrizaje = 0,
                //AeroLinea
                NombreLinea = "American",
                Calificacion = "Buena",
                //Avion
                Nombre = "Avion C02",
                Capacidad = 200,
                Modelo = "ultra 2019",
                NombreTipo = "Jumbo"

            };

            VuelosList.Add(miVuelo);

            BindingSource bsSucu = new BindingSource
            {
                DataSource = VuelosList
            };

            gvListado.DataSource = bsSucu;
            gvListado.Refresh();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            using (CrearVueloForm CrearVuelo = new CrearVueloForm(this))
            {
                CrearVuelo.ShowDialog();
            }
        }

        public void GuardarVuelo(Vuelos vueloObj)
        {
            VuelosList.Add(vueloObj);

            BindingSource bsvuelo = new BindingSource
            {
                DataSource = VuelosList
            };

            gvListado.DataSource = bsvuelo;
            gvListado.Refresh();
        }

        private void btnDespegue_Click(object sender, EventArgs e)
        {
            foreach (var vuelo in VuelosList)
            {
                if (vuelo.FechaVuelo == DateTime.Now.ToString("dd/MM/yyyy"))
                {
                    if (vuelo.Tipo == 2)
                    {
                        if (Pista1List.Count < 1)
                        {

                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista1List.Add(vuelo);
                                BindingSource bsPista1 = new BindingSource
                                {
                                    DataSource = Pista1List
                                };

                                gvPista1.DataSource = bsPista1;
                                gvPista1.Refresh();
                            }
                        }
                        else if (Pista2List.Count < 1)
                        {

                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista2List.Add(vuelo);
                                BindingSource bsPista2 = new BindingSource
                                {
                                    DataSource = Pista2List
                                };

                                gvPista2.DataSource = bsPista2;
                                gvPista2.Refresh();
                            }
                        }
                        else if (Pista3List.Count < 1)
                        {
                            vuelo.Estado = 2;
                            Pista3List.Add(vuelo);
                            BindingSource bsPista3 = new BindingSource
                            {
                                DataSource = Pista3List
                            };

                            gvPista3.DataSource = bsPista3;
                            gvPista3.Refresh();
                        }
                        else if (Pista4List.Count < 1)
                        {
                            if (vuelo.NombreTipo == "Jumbo")
                            {
                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista4List.Add(vuelo);
                                BindingSource bsPista4 = new BindingSource
                                {
                                    DataSource = Pista4List
                                };

                                gvPista4.DataSource = bsPista4;
                                gvPista4.Refresh();
                            }
                        }
                        else if (Pista5List.Count < 1)
                        {

                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista5List.Add(vuelo);
                                BindingSource bsPista5 = new BindingSource
                                {
                                    DataSource = Pista5List
                                };

                                gvPista5.DataSource = bsPista5;
                                gvPista5.Refresh();
                            }
                        }
                        else if (Pista6List.Count < 1)
                        {

                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista6List.Add(vuelo);
                                BindingSource bsPista6 = new BindingSource
                                {
                                    DataSource = Pista6List
                                };

                                gvPista6.DataSource = bsPista6;
                                gvPista6.Refresh();
                            }
                        }
                        else
                        {
                            vuelo.Estado = 1;
                            MessageBox.Show("No se puede despegar, Pistas llenas", "Aviso", MessageBoxButtons.OK);
                        }
                    }
                    else if (vuelo.Tipo == 1)
                    {
                        if (Pista1List.Count < 1)
                        {

                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista1List.Add(vuelo);
                                BindingSource bsPista1 = new BindingSource
                                {
                                    DataSource = Pista1List
                                };

                                gvPista1.DataSource = bsPista1;
                                gvPista1.Refresh();
                            }
                        }
                        else if (Pista2List.Count < 1)
                        {
                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista2List.Add(vuelo);
                                BindingSource bsPista2 = new BindingSource
                                {
                                    DataSource = Pista2List
                                };

                                gvPista2.DataSource = bsPista2;
                                gvPista2.Refresh();
                            }

                        }
                        else if (Pista3List.Count < 1)
                        {
                            vuelo.Estado = 2;
                            Pista3List.Add(vuelo);
                            BindingSource bsPista3 = new BindingSource
                            {
                                DataSource = Pista3List
                            };

                            gvPista3.DataSource = bsPista3;
                            gvPista3.Refresh();
                        }
                        else if (Pista4List.Count < 1)
                        {
                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista4List.Add(vuelo);
                                BindingSource bsPista4 = new BindingSource
                                {
                                    DataSource = Pista4List
                                };

                                gvPista4.DataSource = bsPista4;
                                gvPista4.Refresh();
                            }
                        }
                        else if (Pista5List.Count < 1)
                        {
                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista5List.Add(vuelo);
                                BindingSource bsPista5 = new BindingSource
                                {
                                    DataSource = Pista5List
                                };

                                gvPista5.DataSource = bsPista5;
                                gvPista5.Refresh();
                            }
                        }
                        else if (Pista6List.Count < 1)
                        {
                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista6List.Add(vuelo);
                                BindingSource bsPista6 = new BindingSource
                                {
                                    DataSource = Pista6List
                                };

                                gvPista6.DataSource = bsPista6;
                                gvPista6.Refresh();
                            }
                        }
                        else
                        {
                            vuelo.Estado = 1;
                            MessageBox.Show("No se puede despegar, Pistas llenas", "Aviso", MessageBoxButtons.OK);
                        }
                    }
                    else if (vuelo.Tipo == 3)
                    {
                        if (Pista1List.Count < 1)
                        {
                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista1List.Add(vuelo);
                                BindingSource bsPista1 = new BindingSource
                                {
                                    DataSource = Pista1List
                                };

                                gvPista1.DataSource = bsPista1;
                                gvPista1.Refresh();
                            }

                        }
                        else if (Pista2List.Count < 1)
                        {

                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista2List.Add(vuelo);
                                BindingSource bsPista2 = new BindingSource
                                {
                                    DataSource = Pista2List
                                };

                                gvPista2.DataSource = bsPista2;
                                gvPista2.Refresh();
                            }
                        }
                        else if (Pista3List.Count < 1)
                        {
                            vuelo.Estado = 2;
                            Pista3List.Add(vuelo);
                            BindingSource bsPista3 = new BindingSource
                            {
                                DataSource = Pista3List
                            };

                            gvPista3.DataSource = bsPista3;
                            gvPista3.Refresh();
                        }
                        else if (Pista4List.Count < 1)
                        {

                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista4List.Add(vuelo);
                                BindingSource bsPista4 = new BindingSource
                                {
                                    DataSource = Pista4List
                                };

                                gvPista4.DataSource = bsPista4;
                                gvPista4.Refresh();
                            }
                        }
                        else if (Pista5List.Count < 1)
                        {
                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista5List.Add(vuelo);
                                BindingSource bsPista5 = new BindingSource
                                {
                                    DataSource = Pista5List
                                };

                                gvPista5.DataSource = bsPista5;
                                gvPista5.Refresh();
                            }
                        }
                        else if (Pista6List.Count < 1)
                        {

                            if (vuelo.NombreTipo == "Jumbo")
                            {

                                if (Pista3List.Count < 1)
                                {
                                    vuelo.Estado = 2;
                                    Pista3List.Add(vuelo);
                                    BindingSource bsPista3 = new BindingSource
                                    {
                                        DataSource = Pista3List
                                    };

                                    gvPista3.DataSource = bsPista3;
                                    gvPista3.Refresh();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede despegar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                                }

                            } else
                            {
                                vuelo.Estado = 2;
                                Pista6List.Add(vuelo);
                                BindingSource bsPista6 = new BindingSource
                                {
                                    DataSource = Pista6List
                                };

                                gvPista6.DataSource = bsPista6;
                                gvPista6.Refresh();
                            }
                        }
                        else
                        {
                            vuelo.Estado = 1;
                            MessageBox.Show("No se puede despegar, Pistas llenas", "Aviso", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No es un vuelo Prioritario");
                    }
                }
                else
                {
                    MessageBox.Show("El vuelo no puede despegar, Fecha vuelo no concuerdan","Error", MessageBoxButtons.OK);
                }
            }

            VuelosList.RemoveAll(r => r.Estado == 2);

            BindingSource bsVuelo = new BindingSource
            {
                DataSource = VuelosList
            };

            gvListado.DataSource = bsVuelo;
            gvListado.Refresh();
        }

        private void btnDespegarp1_Click(object sender, EventArgs e)
        {
            var randomNumber = new Random().Next(800, 2000);
            var randomNumberSpedd = new Random().Next(50, 300);
            var despegueSpedd = new Random().Next(50, 800);
            var despCuadrado = Math.Pow(despegueSpedd, 2);
            var despFinal = despCuadrado / 3600;

            foreach (var despegue in Pista1List)
            {
                if (despegue.Estado == 2)
                {
                    despegue.Estado = 3;
                    despegue.AlturaVuelo = randomNumber;
                    despegue.Velicidad = randomNumberSpedd;
                    despegue.TiempoDespegue = despFinal;
                    DespeguesList.Add(despegue);

                    BindingSource bsDesp = new BindingSource
                    {
                        DataSource = DespeguesList
                    };

                    gvDespegues.DataSource = bsDesp;
                    gvDespegues.Refresh();
                } else
                {
                    MessageBox.Show("Estado del vuelo incorrecto", "Aviso", MessageBoxButtons.OK);
                }
                
            }

            Pista1List.RemoveAll(r => r.Estado == 3);
            BindingSource bsPista1 = new BindingSource
            {
                DataSource = Pista1List
            };

            gvPista1.DataSource = bsPista1;
            gvPista1.Refresh();
        }

        private void btnDesabordarp1_Click(object sender, EventArgs e)
        {
            foreach (var vuelo in Pista1List)
            {
                if (vuelo.Estado == 4)
                {

                    AterrizajesList.Add(vuelo);

                    BindingSource bsAtrr = new BindingSource
                    {
                        DataSource = AterrizajesList
                    };

                    gvAterrizaje.DataSource = bsAtrr;
                    gvAterrizaje.Refresh();
                }
                else
                {
                    MessageBox.Show("Estado del vuelo incorrecto", "Aviso", MessageBoxButtons.OK);
                }
            }

            if (Pista1List.Count >= 1)
            {
                Pista1List.RemoveAll(r => r.Estado == 4);

                BindingSource bsDesp = new BindingSource
                {
                    DataSource = Pista1List
                };

                gvPista1.DataSource = bsDesp;
                gvPista1.Refresh();
            }
            else
            {
                MessageBox.Show("No existen vuelos", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnAterrizar_Click(object sender, EventArgs e)
        {
            foreach (var vuelo in DespeguesList)
            {
                if (vuelo.Tipo == 2)
                {
                    if (Pista1List.Count < 1)
                    {

                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            //Aterizaje
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista1List.Add(vuelo);
                            BindingSource bsPista1 = new BindingSource
                            {
                                DataSource = Pista1List
                            };

                            gvPista1.DataSource = bsPista1;
                            gvPista1.Refresh();
                        }

                    }
                    else if (Pista2List.Count < 1)
                    {
                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista2List.Add(vuelo);
                            BindingSource bsPista2 = new BindingSource
                            {
                                DataSource = Pista2List
                            };

                            gvPista2.DataSource = bsPista2;
                            gvPista2.Refresh();
                        }
                    }
                    else if (Pista3List.Count < 1)
                    {
                        var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                        var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                        var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                        var calcRaiz = alturaCuadrado + largoCuadrado;
                        var resultRaiz = Math.Sqrt(calcRaiz);
                        var tAterrizaje = resultRaiz / velocidadDescenso;

                        vuelo.Estado = 4;
                        vuelo.Aterrizaje = tAterrizaje;
                        Pista3List.Add(vuelo);
                        BindingSource bsPista3 = new BindingSource
                        {
                            DataSource = Pista3List
                        };

                        gvPista3.DataSource = bsPista3;
                        gvPista3.Refresh();
                    }
                    else if (Pista4List.Count < 1)
                    {

                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista4List.Add(vuelo);
                            BindingSource bsPista4 = new BindingSource
                            {
                                DataSource = Pista4List
                            };

                            gvPista4.DataSource = bsPista4;
                            gvPista4.Refresh();
                        }
                    }
                    else if (Pista5List.Count < 1)
                    {

                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista5List.Add(vuelo);
                            BindingSource bsPista5 = new BindingSource
                            {
                                DataSource = Pista5List
                            };

                            gvPista5.DataSource = bsPista5;
                            gvPista5.Refresh();
                        }
                    }
                    else if (Pista6List.Count < 1)
                    {

                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista6List.Add(vuelo);
                            BindingSource bsPista6 = new BindingSource
                            {
                                DataSource = Pista6List
                            };

                            gvPista6.DataSource = bsPista6;
                            gvPista6.Refresh();
                        }
                    }
                    else
                    {
                        vuelo.Estado = 3;
                        MessageBox.Show("No se puede Aterrizar, Pistas llenas", "Aviso", MessageBoxButtons.OK);
                    }
                }
                else if (vuelo.Tipo == 1)
                {
                    if (Pista1List.Count < 1)
                    {

                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista1List.Add(vuelo);
                            BindingSource bsPista1 = new BindingSource
                            {
                                DataSource = Pista1List
                            };

                            gvPista1.DataSource = bsPista1;
                            gvPista1.Refresh();
                        }
                    }
                    else if (Pista2List.Count < 1)
                    {

                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista2List.Add(vuelo);
                            BindingSource bsPista2 = new BindingSource
                            {
                                DataSource = Pista2List
                            };

                            gvPista2.DataSource = bsPista2;
                            gvPista2.Refresh();
                        }
                    }
                    else if (Pista3List.Count < 1)
                    {
                        var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                        var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                        var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                        var calcRaiz = alturaCuadrado + largoCuadrado;
                        var resultRaiz = Math.Sqrt(calcRaiz);
                        var tAterrizaje = resultRaiz / velocidadDescenso;

                        vuelo.Estado = 4;
                        vuelo.Aterrizaje = tAterrizaje;
                        Pista3List.Add(vuelo);
                        BindingSource bsPista3 = new BindingSource
                        {
                            DataSource = Pista3List
                        };

                        gvPista3.DataSource = bsPista3;
                        gvPista3.Refresh();
                    }
                    else if (Pista4List.Count < 1)
                    {

                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista4List.Add(vuelo);
                            BindingSource bsPista4 = new BindingSource
                            {
                                DataSource = Pista4List
                            };

                            gvPista4.DataSource = bsPista4;
                            gvPista4.Refresh();
                        }
                    }
                    else if (Pista5List.Count < 1)
                    {

                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista5List.Add(vuelo);
                            BindingSource bsPista5 = new BindingSource
                            {
                                DataSource = Pista5List
                            };

                            gvPista5.DataSource = bsPista5;
                            gvPista5.Refresh();
                        }
                    }
                    else if (Pista6List.Count < 1)
                    {

                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista6List.Add(vuelo);
                            BindingSource bsPista6 = new BindingSource
                            {
                                DataSource = Pista6List
                            };

                            gvPista6.DataSource = bsPista6;
                            gvPista6.Refresh();
                        }
                    }
                    else
                    {
                        vuelo.Estado = 3;
                        MessageBox.Show("No se puede Aterrizar, Pistas llenas", "Aviso", MessageBoxButtons.OK);
                    }
                }
                else if (vuelo.Tipo == 3)
                {
                    if (Pista1List.Count < 1)
                    {
                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista1List.Add(vuelo);
                            BindingSource bsPista1 = new BindingSource
                            {
                                DataSource = Pista1List
                            };

                            gvPista1.DataSource = bsPista1;
                            gvPista1.Refresh();
                        }
                    }
                    else if (Pista2List.Count < 1)
                    {

                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista2List.Add(vuelo);
                            BindingSource bsPista2 = new BindingSource
                            {
                                DataSource = Pista2List
                            };

                            gvPista2.DataSource = bsPista2;
                            gvPista2.Refresh();
                        }

                        
                    }
                    else if (Pista3List.Count < 1)
                    {
                        var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                        var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                        var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                        var calcRaiz = alturaCuadrado + largoCuadrado;
                        var resultRaiz = Math.Sqrt(calcRaiz);
                        var tAterrizaje = resultRaiz / velocidadDescenso;

                        vuelo.Estado = 4;
                        vuelo.Aterrizaje = tAterrizaje;
                        Pista3List.Add(vuelo);
                        BindingSource bsPista3 = new BindingSource
                        {
                            DataSource = Pista3List
                        };

                        gvPista3.DataSource = bsPista3;
                        gvPista3.Refresh();
                    }
                    else if (Pista4List.Count < 1)
                    {

                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista4List.Add(vuelo);
                            BindingSource bsPista4 = new BindingSource
                            {
                                DataSource = Pista4List
                            };

                            gvPista4.DataSource = bsPista4;
                            gvPista4.Refresh();
                        }
                    }
                    else if (Pista5List.Count < 1)
                    {

                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista5List.Add(vuelo);
                            BindingSource bsPista5 = new BindingSource
                            {
                                DataSource = Pista5List
                            };

                            gvPista5.DataSource = bsPista5;
                            gvPista5.Refresh();
                        }
                    }
                    else if (Pista6List.Count < 1)
                    {

                        if (vuelo.NombreTipo == "Jumbo")
                        {

                            if (Pista3List.Count < 1)
                            {
                                //Aterizaje
                                var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                                var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                                var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                                var calcRaiz = alturaCuadrado + largoCuadrado;
                                var resultRaiz = Math.Sqrt(calcRaiz);
                                var tAterrizaje = resultRaiz / velocidadDescenso;

                                vuelo.Estado = 4;
                                vuelo.Aterrizaje = tAterrizaje;
                                Pista3List.Add(vuelo);
                                BindingSource bsPista3 = new BindingSource
                                {
                                    DataSource = Pista3List
                                };

                                gvPista3.DataSource = bsPista3;
                                gvPista3.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("No se puede aterrizar, solo la pista 3 es compatible pero esta ocupada", "Pista no compatible", MessageBoxButtons.OK);
                            }

                        } else
                        {
                            var alturaCuadrado = Math.Pow(vuelo.AlturaVuelo, 2);
                            var largoCuadrado = Math.Pow(vuelo.LargoPista, 2);
                            var velocidadDescenso = (vuelo.Velicidad * 1000) / 3600;

                            var calcRaiz = alturaCuadrado + largoCuadrado;
                            var resultRaiz = Math.Sqrt(calcRaiz);
                            var tAterrizaje = resultRaiz / velocidadDescenso;

                            vuelo.Estado = 4;
                            vuelo.Aterrizaje = tAterrizaje;
                            Pista6List.Add(vuelo);
                            BindingSource bsPista6 = new BindingSource
                            {
                                DataSource = Pista6List
                            };

                            gvPista6.DataSource = bsPista6;
                            gvPista6.Refresh();
                        }
                    }
                    else
                    {
                        vuelo.Estado = 3;
                        MessageBox.Show("No se puede Aterrizar, Pistas llenas", "Aviso", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede Aterrizar, Pistas llenas", "Aviso", MessageBoxButtons.OK);
                }
            }

            DespeguesList.RemoveAll(r => r.Estado == 4);

            BindingSource bsDesp = new BindingSource
            {
                DataSource = DespeguesList
            };

            gvDespegues.DataSource = bsDesp;
            gvDespegues.Refresh();
        }

        private void btnDespegar2_Click(object sender, EventArgs e)
        {
            var randomNumber = new Random().Next(800, 2000);
            var randomNumberSpedd = new Random().Next(50, 300);
            var despegueSpedd = new Random().Next(50, 800);
            var despCuadrado = Math.Pow(despegueSpedd, 2);
            var despFinal = despCuadrado / 3600;
            foreach (var despegue in Pista2List)
            {
                if (despegue.Estado == 2)
                {
                    despegue.Estado = 3;
                    despegue.AlturaVuelo = randomNumber;
                    despegue.Velicidad = randomNumberSpedd;
                    despegue.TiempoDespegue = despFinal;
                    DespeguesList.Add(despegue);

                    BindingSource bsDesp = new BindingSource
                    {
                        DataSource = DespeguesList
                    };

                    gvDespegues.DataSource = bsDesp;
                    gvDespegues.Refresh();
                }
                else
                {
                    MessageBox.Show("Estado del vuelo incorrecto", "Error", MessageBoxButtons.OK);
                }
            }

            Pista2List.RemoveAll(r => r.Estado == 3);
            BindingSource bsPista2 = new BindingSource
            {
                DataSource = Pista2List
            };

            gvPista2.DataSource = bsPista2;
            gvPista2.Refresh();
        }

        private void btnDespegarp3_Click(object sender, EventArgs e)
        {
            var randomNumber = new Random().Next(800, 2000);
            var randomNumberSpedd = new Random().Next(50, 300);
            var despegueSpedd = new Random().Next(50, 800);
            var despCuadrado = Math.Pow(despegueSpedd, 2);
            var despFinal = despCuadrado / 3600;

            foreach (var despegue in Pista3List)
            {
                if (despegue.Estado == 2)
                {
                    despegue.Estado = 3;
                    despegue.AlturaVuelo = randomNumber;
                    despegue.Velicidad = randomNumberSpedd;
                    despegue.TiempoDespegue = despFinal;
                    DespeguesList.Add(despegue);

                    BindingSource bsDesp = new BindingSource
                    {
                        DataSource = DespeguesList
                    };

                    gvDespegues.DataSource = bsDesp;
                    gvDespegues.Refresh();
                }
                else
                {
                    MessageBox.Show("Estado del vuelo incorrecto", "Error", MessageBoxButtons.OK);
                }
            }

            Pista3List.RemoveAll(r => r.Estado == 3);
            BindingSource bsPista3 = new BindingSource
            {
                DataSource = Pista3List
            };

            gvPista3.DataSource = bsPista3;
            gvPista3.Refresh();
        }

        private void btnCancelarp1_Click(object sender, EventArgs e)
        {
            if (Pista1List.Count >= 1)
            {
                Pista1List.RemoveAll(r => r.Estado == 2);

                BindingSource bsDesp = new BindingSource
                {
                    DataSource = Pista1List
                };

                gvPista1.DataSource = bsDesp;
                gvPista1.Refresh();
            }
            else
            {
                MessageBox.Show("No existen vuelos", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnDesabordarp2_Click(object sender, EventArgs e)
        {
            foreach (var vuelo in Pista2List)
            {
                if (vuelo.Estado == 4)
                {

                    AterrizajesList.Add(vuelo);

                    BindingSource bsAtrr = new BindingSource
                    {
                        DataSource = AterrizajesList
                    };

                    gvAterrizaje.DataSource = bsAtrr;
                    gvAterrizaje.Refresh();
                }
                else
                {
                    MessageBox.Show("Estado del vuelo incorrecto", "Error", MessageBoxButtons.OK);
                }
            }

            if (Pista2List.Count >= 1)
            {
                Pista2List.RemoveAll(r => r.Estado == 4);

                BindingSource bsDesp = new BindingSource
                {
                    DataSource = Pista2List
                };

                gvPista2.DataSource = bsDesp;
                gvPista2.Refresh();
            }
            else
            {
                MessageBox.Show("Estado del vuelo incorrecto", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnDesabordarp3_Click(object sender, EventArgs e)
        {
            foreach (var vuelo in Pista3List)
            {
                if (vuelo.Estado == 4)
                {

                    AterrizajesList.Add(vuelo);

                    BindingSource bsAtrr = new BindingSource
                    {
                        DataSource = AterrizajesList
                    };

                    gvAterrizaje.DataSource = bsAtrr;
                    gvAterrizaje.Refresh();
                }
                else
                {
                    MessageBox.Show("Estado del vuelo incorrecto", "Error", MessageBoxButtons.OK);
                }
            }

            if (Pista3List.Count >= 1)
            {
                Pista3List.RemoveAll(r => r.Estado == 4);

                BindingSource bsDesp = new BindingSource
                {
                    DataSource = Pista3List
                };

                gvPista3.DataSource = bsDesp;
                gvPista3.Refresh();
            }
            else
            {
                MessageBox.Show("No existen vuelos", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnCancelarp2_Click(object sender, EventArgs e)
        {
            if (Pista2List.Count >= 1)
            {
                Pista2List.RemoveAll(r => r.Estado == 2);

                BindingSource bsDesp = new BindingSource
                {
                    DataSource = Pista2List
                };

                gvPista2.DataSource = bsDesp;
                gvPista2.Refresh();
            }
            else
            {
                MessageBox.Show("No existen vuelos", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnCancelarp3_Click(object sender, EventArgs e)
        {
            if (Pista3List.Count >= 1)
            {
                Pista3List.RemoveAll(r => r.Estado == 2);

                BindingSource bsDesp = new BindingSource
                {
                    DataSource = Pista3List
                };

                gvPista3.DataSource = bsDesp;
                gvPista3.Refresh();
            }
            else
            {
                MessageBox.Show("No existen vuelos", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnHangar_Click(object sender, EventArgs e)
        {
            if (AterrizajesList.Count >= 1)
            {
                AterrizajesList.RemoveAll(r => r.Estado == 4);

                BindingSource bsAterr = new BindingSource
                {
                    DataSource = AterrizajesList
                };

                gvAterrizaje.DataSource = bsAterr;
                gvAterrizaje.Refresh();
            }
            else
            {
                MessageBox.Show("No existen Aterrizajes", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnDespegarp4_Click(object sender, EventArgs e)
        {
            var randomNumber = new Random().Next(800, 2000);
            var randomNumberSpedd = new Random().Next(50, 300);
            var despegueSpedd = new Random().Next(50, 800);
            var despCuadrado = Math.Pow(despegueSpedd, 2);
            var despFinal = despCuadrado / 3600;

            foreach (var despegue in Pista4List)
            {
                if (despegue.Estado == 2)
                {
                    despegue.Estado = 3;
                    despegue.AlturaVuelo = randomNumber;
                    despegue.Velicidad = randomNumberSpedd;
                    despegue.TiempoDespegue = despFinal;
                    DespeguesList.Add(despegue);

                    BindingSource bsDesp = new BindingSource
                    {
                        DataSource = DespeguesList
                    };

                    gvDespegues.DataSource = bsDesp;
                    gvDespegues.Refresh();
                }
                else
                {
                    MessageBox.Show("Estado del vuelo incorrecto", "Error", MessageBoxButtons.OK);
                }

            }

            Pista4List.RemoveAll(r => r.Estado == 3);
            BindingSource bsPista4 = new BindingSource
            {
                DataSource = Pista4List
            };

            gvPista4.DataSource = bsPista4;
            gvPista4.Refresh();
        }

        private void btnDesabordarp4_Click(object sender, EventArgs e)
        {
            foreach (var vuelo in Pista4List)
            {
                if (vuelo.Estado == 4)
                {

                    AterrizajesList.Add(vuelo);

                    BindingSource bsAtrr = new BindingSource
                    {
                        DataSource = AterrizajesList
                    };

                    gvAterrizaje.DataSource = bsAtrr;
                    gvAterrizaje.Refresh();
                }
                else
                {
                    MessageBox.Show("Estado del vuelo incorrecto", "Error", MessageBoxButtons.OK);
                }
            }

            if (Pista4List.Count >= 1)
            {
                Pista4List.RemoveAll(r => r.Estado == 4);

                BindingSource bsDesp = new BindingSource
                {
                    DataSource = Pista4List
                };

                gvPista4.DataSource = bsDesp;
                gvPista4.Refresh();
            }
            else
            {
                MessageBox.Show("No existen vuelos");
            }
        }

        private void btnCancelarp4_Click(object sender, EventArgs e)
        {
            if (Pista4List.Count >= 1)
            {
                Pista4List.RemoveAll(r => r.Estado == 2);

                BindingSource bsDesp = new BindingSource
                {
                    DataSource = Pista4List
                };

                gvPista4.DataSource = bsDesp;
                gvPista4.Refresh();
            }
            else
            {
                MessageBox.Show("No existen vuelos", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnDespegarp5_Click(object sender, EventArgs e)
        {
            var randomNumber = new Random().Next(800, 2000);
            var randomNumberSpedd = new Random().Next(50, 300);
            var despegueSpedd = new Random().Next(50, 800);
            var despCuadrado = Math.Pow(despegueSpedd, 2);
            var despFinal = despCuadrado / 3600;

            foreach (var despegue in Pista5List)
            {
                if (despegue.Estado == 2)
                {
                    despegue.Estado = 3;
                    despegue.AlturaVuelo = randomNumber;
                    despegue.Velicidad = randomNumberSpedd;
                    despegue.TiempoDespegue = despFinal;
                    DespeguesList.Add(despegue);

                    BindingSource bsDesp = new BindingSource
                    {
                        DataSource = DespeguesList
                    };

                    gvDespegues.DataSource = bsDesp;
                    gvDespegues.Refresh();
                }
                else
                {
                    MessageBox.Show("Estado del vuelo incorrecto", "Error", MessageBoxButtons.OK);
                }

            }

            Pista5List.RemoveAll(r => r.Estado == 3);
            BindingSource bsPista5 = new BindingSource
            {
                DataSource = Pista5List
            };

            gvPista5.DataSource = bsPista5;
            gvPista5.Refresh();
        }

        private void btnDesabordarp5_Click(object sender, EventArgs e)
        {
            foreach (var vuelo in Pista5List)
            {
                if (vuelo.Estado == 4)
                {

                    AterrizajesList.Add(vuelo);

                    BindingSource bsAtrr = new BindingSource
                    {
                        DataSource = AterrizajesList
                    };

                    gvAterrizaje.DataSource = bsAtrr;
                    gvAterrizaje.Refresh();
                }
                else
                {
                    MessageBox.Show("Estado del vuelo incorrecto", "Error", MessageBoxButtons.OK);
                }
            }

            if (Pista5List.Count >= 1)
            {
                Pista5List.RemoveAll(r => r.Estado == 4);

                BindingSource bsDesp = new BindingSource
                {
                    DataSource = Pista5List
                };

                gvPista5.DataSource = bsDesp;
                gvPista5.Refresh();
            }
            else
            {
                MessageBox.Show("No existen vuelos", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnCancelarp5_Click(object sender, EventArgs e)
        {
            if (Pista5List.Count >= 1)
            {
                Pista5List.RemoveAll(r => r.Estado == 2);

                BindingSource bsDesp = new BindingSource
                {
                    DataSource = Pista5List
                };

                gvPista5.DataSource = bsDesp;
                gvPista5.Refresh();
            }
            else
            {
                MessageBox.Show("No existen vuelos", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnDespegarp6_Click(object sender, EventArgs e)
        {
            var randomNumber = new Random().Next(800, 2000);
            var randomNumberSpedd = new Random().Next(50, 300);
            var despegueSpedd = new Random().Next(50, 800);
            var despCuadrado = Math.Pow(despegueSpedd, 2);
            var despFinal = despCuadrado / 3600;

            foreach (var despegue in Pista6List)
            {
                if (despegue.Estado == 2)
                {
                    despegue.Estado = 3;
                    despegue.AlturaVuelo = randomNumber;
                    despegue.Velicidad = randomNumberSpedd;
                    despegue.TiempoDespegue = despFinal;
                    DespeguesList.Add(despegue);

                    BindingSource bsDesp = new BindingSource
                    {
                        DataSource = DespeguesList
                    };

                    gvDespegues.DataSource = bsDesp;
                    gvDespegues.Refresh();
                }
                else
                {
                    MessageBox.Show("Estado del vuelo incorrecto", "Error", MessageBoxButtons.OK);
                }

            }

            Pista6List.RemoveAll(r => r.Estado == 3);
            BindingSource bsPista6 = new BindingSource
            {
                DataSource = Pista6List
            };

            gvPista6.DataSource = bsPista6;
            gvPista6.Refresh();
        }

        private void btnDesabordarp6_Click(object sender, EventArgs e)
        {
            foreach (var vuelo in Pista6List)
            {
                if (vuelo.Estado == 4)
                {

                    AterrizajesList.Add(vuelo);

                    BindingSource bsAtrr = new BindingSource
                    {
                        DataSource = AterrizajesList
                    };

                    gvAterrizaje.DataSource = bsAtrr;
                    gvAterrizaje.Refresh();
                }
                else
                {
                    MessageBox.Show("El estado del vuelo no es correcto", "Error", MessageBoxButtons.OK);
                }
            }

            if (Pista6List.Count >= 1)
            {
                Pista6List.RemoveAll(r => r.Estado == 4);

                BindingSource bsDesp = new BindingSource
                {
                    DataSource = Pista6List
                };

                gvPista6.DataSource = bsDesp;
                gvPista6.Refresh();
            }
            else
            {
                MessageBox.Show("No existen vuelos", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnCancelarp6_Click(object sender, EventArgs e)
        {
            if (Pista6List.Count >= 1)
            {
                Pista6List.RemoveAll(r => r.Estado == 2);

                BindingSource bsDesp = new BindingSource
                {
                    DataSource = Pista6List
                };

                gvPista6.DataSource = bsDesp;
                gvPista6.Refresh();
            }
            else
            {
                MessageBox.Show("No existen vuelos", "Error", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                    GuardarVuelo(Convert.ToString(arr[0]), Convert.ToString(arr[1]), int.Parse(arr[2]), Convert.ToString(arr[3]), int.Parse(arr[4]), int.Parse(arr[5]), Convert.ToString(arr[6]), Convert.ToString(arr[7]), Convert.ToString(arr[8]), Convert.ToDouble(arr[9]), Convert.ToString(arr[10]), Convert.ToString(arr[11]));//
                }
            }
        }

        //Poli
        public void GuardarVuelo(string fechaDespegue, string fechaAterrizaje, int estado, string destino, int tipo, int larPista, string nomLinea, string cali, string nomAvion, double capa, string modelo, string nomTipo)
        {
            var vueloCreate = new Vuelos
            {
                //Vuelo
                FechaVuelo = fechaDespegue,
                FechaLlegada = fechaAterrizaje,
                Estado = estado,
                Destino = destino,
                Tipo = tipo,
                LargoPista = larPista,
                //Aerolinea
                NombreLinea = nomLinea,
                Calificacion = cali,
                //Avion
                Nombre = nomAvion,
                Capacidad = capa,
                Modelo = modelo,
                NombreTipo = nomTipo
            };

            VuelosList.Add(vueloCreate);

            BindingSource bsvuelo = new BindingSource
            {
                DataSource = VuelosList
            };

            gvListado.DataSource = bsvuelo;
            gvListado.Refresh();
        }
    }
}
