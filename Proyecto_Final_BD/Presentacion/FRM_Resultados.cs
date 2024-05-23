using Proyecto_Final_BD.Datos;
using Proyecto_Final_BD.Entides;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_BD.Presentacion
{
    public partial class FRM_Resultados : Form
    {
        public FRM_Resultados()
        {
            InitializeComponent();
            Dgv_Resultados.Font = new Font("SimSun", 9);
            CargarEquipoLocal();
            CargarEquipoVisi();
            CargarTorneo();
        }
        SqlConnection Conexion = new SqlConnection("server=DESKTOP-K54DEQR\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");
        //SqlConnection Conexion = new SqlConnection("server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");

        public void refreshPantalla()
        {
            Dgv_Resultados.DataSource = ClsProcedimientos.PresentarRegistroResultados();
            Dgv_Resultados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btn_GuardarResultados_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Cbo_id_Torneo.Text) ||
               string.IsNullOrWhiteSpace(Cbo_Cargar_EquipoLocal.Text) ||
               string.IsNullOrWhiteSpace(Cbo_Cargar_EquipoVisitante.Text) ||
               string.IsNullOrWhiteSpace(nup_Marcador_Local.Text) ||
               string.IsNullOrWhiteSpace(txt_Evento_Destacado.Text) ||
               string.IsNullOrWhiteSpace(txt_Evento_Destacado.Text))
            {
                MessageBox.Show("Ingrese todos los datos solicitados");
            }
            else
            {
                ClsResultados Resultados = new ClsResultados();

                Resultados.Marcador = nup_Marcador_Local.Text + " - " + nud_Marcador_Visitante.Text;
                Resultados.EventoDestacado = txt_Evento_Destacado.Text;

                if (Dgv_Resultados.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(Dgv_Resultados.CurrentRow.Cells["id_Resultado"].Value);
                    if (id != null)
                    {
                        if (nup_Marcador_Local.Value > nud_Marcador_Visitante.Value)
                        {
                            Resultados.id_Resultado = id;

                            int Resulta = ClsProcedimientos.ModificarResultados(Resultados, Cbo_id_Torneo.Text, Cbo_Cargar_EquipoLocal.Text,
                            Cbo_Cargar_EquipoVisitante.Text, Cbo_Cargar_EquipoLocal.Text, Cbo_Cargar_EquipoVisitante.Text, "");

                            if (Resulta > 0)
                            {
                                MessageBox.Show("Datos modificados con éxito");
                                refreshPantalla();
                                MessageBox.Show("");
                            }

                            else
                            {
                                MessageBox.Show("Error al modificar los datos");
                            }
                        }
                        else if (nup_Marcador_Local.Value == nud_Marcador_Visitante.Value)
                        {
                            Resultados.id_Resultado = id;

                            int Resulta = ClsProcedimientos.ModificarResultados(Resultados, Cbo_id_Torneo.Text, Cbo_Cargar_EquipoLocal.Text,
                           Cbo_Cargar_EquipoVisitante.Text, "", "", "Sí");

                            if (Resulta > 0)
                            {
                                MessageBox.Show("Datos modificados con éxito");
                                refreshPantalla();
                                MessageBox.Show("");
                            }

                            else
                            {
                                MessageBox.Show("Error al modificar los datos");
                            }
                        }
                    }
                    else
                    {
                        Resultados.id_Resultado = id;

                        int Resulta = ClsProcedimientos.ModificarResultados(Resultados, Cbo_id_Torneo.Text, Cbo_Cargar_EquipoLocal.Text,
                        Cbo_Cargar_EquipoVisitante.Text, Cbo_Cargar_EquipoVisitante.Text, Cbo_Cargar_EquipoLocal.Text, "");

                        if (Resulta > 0)
                        {
                            MessageBox.Show("Datos modificados con éxito");
                            refreshPantalla();
                            MessageBox.Show("");
                        }

                        else
                        {
                            MessageBox.Show("Error al modificar los datos");
                        }
                    }
                }
                else
                {
                    if (nup_Marcador_Local.Value > nud_Marcador_Visitante.Value)
                    {


                        int Resulta = ClsProcedimientos.GuardarResultados(Resultados, Cbo_id_Torneo.Text, Cbo_Cargar_EquipoLocal.Text,
                            Cbo_Cargar_EquipoVisitante.Text, Cbo_Cargar_EquipoLocal.Text, Cbo_Cargar_EquipoVisitante.Text, "");
                        if (Resulta > 0)
                        {
                            MessageBox.Show("Datos guardados con éxito");
                            refreshPantalla();
                        }

                        else
                        {
                            MessageBox.Show("Error al guardar los datos");
                        }

                    }
                    else if (nup_Marcador_Local.Value == nud_Marcador_Visitante.Value)
                    {
                        int Resulta = ClsProcedimientos.GuardarResultados(Resultados, Cbo_id_Torneo.Text, Cbo_Cargar_EquipoLocal.Text,
                           Cbo_Cargar_EquipoVisitante.Text, "", "", "Sí");
                        if (Resulta > 0)
                        {
                            MessageBox.Show("Datos guardados con éxito");
                            refreshPantalla();
                        }

                        else
                        {
                            MessageBox.Show("Error al guardar los datos");
                        }
                    }
                    else
                    {
                        int Resulta = ClsProcedimientos.GuardarResultados(Resultados, Cbo_id_Torneo.Text, Cbo_Cargar_EquipoLocal.Text,
                            Cbo_Cargar_EquipoVisitante.Text, Cbo_Cargar_EquipoVisitante.Text, Cbo_Cargar_EquipoLocal.Text, "");
                        if (Resulta > 0)
                        {
                            MessageBox.Show("Datos guardados con éxito");
                            refreshPantalla();
                        }

                        else
                        {
                            MessageBox.Show("Error al guardar los datos");
                        }
                    }
                }
            }
        }

        private void FRM_Resultados_Load(object sender, EventArgs e)
        {
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

            Dgv_Resultados.DataSource = ClsProcedimientos.PresentarRegistroResultados();
            Dgv_Resultados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnLimpiarResultados_Click(object sender, EventArgs e)
        {
            Cbo_id_Torneo.Items.Clear();
            Cbo_Cargar_EquipoLocal.Items.Clear();
            Cbo_Cargar_EquipoVisitante.Items.Clear();
            txt_Evento_Destacado.Clear();
        }

        private void btnEliminarResultados_Click(object sender, EventArgs e)
        {
            if (Dgv_Resultados.SelectedRows.Count == 1)
            {
                //Variable para modificar los datos
                int id = Convert.ToInt32(Dgv_Resultados.CurrentRow.Cells["id_Resultado"].Value);

                //Fila seleccionada se guarda en variable id pero solo si esta
                int Resultado = ClsProcedimientos.EliminarResultados(id);

                if (Resultado > 0)
                {
                    MessageBox.Show("Datos eliminados con éxito");
                }
                else
                {
                    MessageBox.Show("Error en la eliminación de datos");
                }
                refreshPantalla();
            }
        }
        private void CargarTorneo()
        {
            try
            {
                Conexion.Open();

                SqlCommand Comando = new SqlCommand("SELECT * FROM TORNEOS WHERE Estado = 1", Conexion);
                SqlDataReader Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Cbo_id_Torneo.Items.Add(Lector[0].ToString());
                }
                Cbo_id_Torneo.Items.Insert(0, "-Seleccione Torneo-");
                Cbo_id_Torneo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Torneos: " + ex.Message);
            }
            finally
            {
                if (Conexion != null && Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
        }
        private void CargarEquipoVisi()
        {
            try
            {
                Conexion.Open();

                SqlCommand Comando = new SqlCommand("SELECT * FROM REGISTRO_EQUIPOS WHERE Estado = 1", Conexion);
                SqlDataReader Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Cbo_Cargar_EquipoVisitante.Items.Add(Lector[2].ToString());
                }
                Cbo_Cargar_EquipoVisitante.Items.Insert(0, "-Seleccione Visitante-");
                Cbo_Cargar_EquipoVisitante.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Equipo Visitante: " + ex.Message);
            }
            finally
            {
                if (Conexion != null && Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
        }

        private void CargarEquipoLocal()
        {
            try
            {
                Conexion.Open();

                SqlCommand Comando = new SqlCommand("SELECT * FROM REGISTRO_EQUIPOS WHERE Estado = 1", Conexion);
                SqlDataReader Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Cbo_Cargar_EquipoLocal.Items.Add(Lector[2].ToString());
                }
                Cbo_Cargar_EquipoLocal.Items.Insert(0, "-Seleccione Local-");
                Cbo_Cargar_EquipoLocal.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Equipo Visitante: " + ex.Message);
            }
            finally
            {
                if (Conexion != null && Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
        }

        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
