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
            CargarProgramacion();
            CargarTorneos();
        }
        SqlConnection Conexion = new SqlConnection("server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");
        //SqlConnection Conexion = new SqlConnection("server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");

        public void refreshPantalla()
        {
            Dgv_Resultados.DataSource = ClsProcedimientos.PresentarRegistroResultados();
            Dgv_Resultados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void FRM_Resultados_Load(object sender, EventArgs e)
        {
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

            Dgv_Resultados.DataSource = ClsProcedimientos.PresentarRegistroResultados();
            Dgv_Resultados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void CargarProgramacion()
        {
            try
            {
                Conexion.Open();

                SqlCommand Comando = new SqlCommand("SP_Presentar_Datos_ProgramacionActiva", Conexion);
                SqlDataReader Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Cbo_id_Programacion.Items.Add(Lector[0].ToString());
                }
                Cbo_id_Programacion.Items.Insert(0, "-Seleccione Progra-");
                Cbo_id_Programacion.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Programaciones: " + ex.Message);
            }
            finally
            {   
                if (Conexion != null && Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
        }
        private void CargarTorneos()
        {
            try
            {
                Conexion.Open();

                SqlCommand Comando = new SqlCommand("SP_Presentar_Datos_TorneosActivos", Conexion);
                SqlDataReader Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    cbo_Id_Torneo.Items.Add(Lector[1].ToString());
                }
                cbo_Id_Torneo.Items.Insert(0, "-Seleccione Torneo-");
                cbo_Id_Torneo.SelectedIndex = 0;
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

        private void btnLimpiarResultados_Click(object sender, EventArgs e)
        {
            Cbo_id_Programacion.Items.Clear();
            txt_Evento_Destacado.Clear();
        }

        private void btnEliminarResultados_Click(object sender, EventArgs e)
        {
            if (Dgv_Resultados.SelectedRows.Count == 1)
            {
                ClsResultados Resultados = new ClsResultados();
                //Variable para modificar los datos
                int id = Convert.ToInt32(Dgv_Resultados.CurrentRow.Cells["id_Resultado"].Value);

                //Fila seleccionada se guarda en variable id pero solo si esta
                int Resultado = ClsProcedimientos.EliminarResultados(Resultados, id);

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

        private void Dgv_Resultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_Resultado.Text = Dgv_Resultados.SelectedCells[0].Value.ToString();
            Cbo_id_Programacion.Text = Dgv_Resultados.SelectedCells[1].Value.ToString();
            lbl_Equipo_Local.Text = Dgv_Resultados.SelectedCells[2].Value.ToString();
            lbl_Equipo_Visitante.Text = Dgv_Resultados.SelectedCells[3].Value.ToString();
        }

        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_GuardarResultados_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Cbo_id_Programacion.Text) ||
               string.IsNullOrWhiteSpace(lbl_Equipo_Local.Text) ||
               string.IsNullOrWhiteSpace(lbl_Equipo_Visitante.Text) ||
               string.IsNullOrWhiteSpace(nup_Marcador_Local.Text) ||
               string.IsNullOrWhiteSpace(txt_Evento_Destacado.Text) ||
               string.IsNullOrWhiteSpace(txt_Evento_Destacado.Text))
            {
                MessageBox.Show("Ingrese todos los datos solicitados");
            }
            else
            {
                ClsResultados Resultados = new ClsResultados();

                Resultados.Marcador = nup_Marcador_Local.Text + "-" + nud_Marcador_Visitante.Text;
                Resultados.EventoDestacado = txt_Evento_Destacado.Text;

                if (Dgv_Resultados.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(Dgv_Resultados.CurrentRow.Cells["id_Resultado"].Value);

                    if (id != null)
                    {
                        if (nup_Marcador_Local.Value > nud_Marcador_Visitante.Value)
                        {
                            Resultados.id_Resultado = id;

                            int Resulta = ClsProcedimientos.ModificarResultados(Resultados, cbo_Id_Torneo.Text, lbl_Equipo_Local.Text,
                            lbl_Equipo_Visitante.Text, lbl_Equipo_Local.Text, lbl_Equipo_Visitante.Text, "");

                            if (Resulta > 0)
                            {
                                MessageBox.Show("Datos modificados con éxito");

                            }

                            else
                            {
                                MessageBox.Show("Error al modificar los datos");
                            }
                            refreshPantalla();
                        }
                        else if (nup_Marcador_Local.Value == nud_Marcador_Visitante.Value)
                        {
                            Resultados.id_Resultado = id;

                            int Resulta = ClsProcedimientos.ModificarResultados(Resultados, cbo_Id_Torneo.Text, lbl_Equipo_Local.Text,
                           lbl_Equipo_Visitante.Text, "", "", "Si");

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
                        else
                        {
                            Resultados.id_Resultado = id;

                            int Resulta = ClsProcedimientos.ModificarResultados(Resultados, cbo_Id_Torneo.Text, lbl_Equipo_Local.Text,
                            lbl_Equipo_Visitante.Text, lbl_Equipo_Visitante.Text, lbl_Equipo_Local.Text, "");

                            if (Resulta > 0)
                            {
                                MessageBox.Show("Datos modificados con éxito");

                            }

                            else
                            {
                                MessageBox.Show("Error al modificar los datos");
                            }
                            refreshPantalla();
                        }
                    }
                    else
                    {
                        Resultados.id_Resultado = id;

                        int Resulta = ClsProcedimientos.ModificarResultados(Resultados, cbo_Id_Torneo.Text, lbl_Equipo_Local.Text,
                        lbl_Equipo_Visitante.Text, lbl_Equipo_Visitante.Text, lbl_Equipo_Local.Text, "");

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


                        int Resulta = ClsProcedimientos.GuardarResultados(Resultados, cbo_Id_Torneo.Text, lbl_Equipo_Local.Text,
                            lbl_Equipo_Visitante.Text, lbl_Equipo_Local.Text, lbl_Equipo_Visitante.Text, "");
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
                        int Resulta = ClsProcedimientos.GuardarResultados(Resultados, cbo_Id_Torneo.Text, lbl_Equipo_Local.Text,
                           lbl_Equipo_Visitante.Text, "", "", "Si");
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
                        int Resulta = ClsProcedimientos.GuardarResultados(Resultados, cbo_Id_Torneo.Text, lbl_Equipo_Local.Text,
                            lbl_Equipo_Visitante.Text, lbl_Equipo_Visitante.Text, lbl_Equipo_Local.Text, "");
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

        private void CargarEquiposPorTorneo(int idTorneo)
        {
            try
            {
                Conexion.Open();

                SqlCommand Comando = new SqlCommand("SP_Cargar_Partido_SegunProgramacion", Conexion);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@id_Programacion", idTorneo);

                SqlDataReader Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    string nombreEquipoLocal = Lector["Equipo_local"].ToString();
                    string nombreEquipoVisi = Lector["Equipo_Visitante"].ToString();
                    lbl_Equipo_Local.Text = nombreEquipoLocal;
                    lbl_Equipo_Visitante.Text = nombreEquipoVisi;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los equipos: " + ex.Message);
            }
            finally
            {
                if (Conexion != null && Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
        }

        private void Cbo_id_Programacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbo_id_Programacion.SelectedIndex > 0)
            {
                int idTorneo;
                if (int.TryParse(Cbo_id_Programacion.SelectedItem.ToString(), out idTorneo))
                {
                    CargarEquiposPorTorneo(idTorneo);
                }
            }
        }
    }
}
