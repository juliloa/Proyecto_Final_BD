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
    public partial class FRM_Programacion : Form
    {
        public FRM_Programacion()
        {
            InitializeComponent();
            dgvProgramacion.Font = new Font("SimSun", 9);
            CargarEquipoLocal();
            CargarEquipoVisi();
            CargarTorneo();
        }
        SqlConnection Conexion = new SqlConnection("server=DESKTOP-K54DEQR\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");
        //SqlConnection Conexion = new SqlConnection("server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");

        public void refreshPantalla()
        {
            dgvProgramacion.DataSource = ClsProcedimientos.PresentarRegistroProgramacion();
        }
        private void btn_GuardarTorneo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbo_Equipo_Visitante.Text) ||
                string.IsNullOrWhiteSpace(cbo_Equipo_Local.Text) ||
                string.IsNullOrWhiteSpace(dtm_Fecha_Programacion.Text) ||
                string.IsNullOrWhiteSpace(dtm_Hora_Programacion.Text) ||
                string.IsNullOrWhiteSpace(cbo_CargarTorneo.Text) ||
                string.IsNullOrWhiteSpace(txt_UbicacionPrograma.Text)
                )
            {
                MessageBox.Show("Ingrese todos los datos solicitados");
            }
            else
            {
                ClsProgramacion Programacion = new ClsProgramacion();

                Programacion.Fecha = Convert.ToDateTime(dtm_Fecha_Programacion.Text);
                Programacion.Hora = Convert.ToDateTime(dtm_Hora_Programacion.Text);
                Programacion.Ubicacion = txt_UbicacionPrograma.Text;
                // Programacion.Equipo_Local = Convert.ToString(cbo_Equipo_Local.Text);
                //Programacion.Equipo_Visitante = Convert.ToString(cbo_Equipo_Visitante.Text);

                if (dgvProgramacion.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(dgvProgramacion.CurrentRow.Cells["id_Programacion"].Value);

                    if (id != null) //Si  existe un ID el boton modificará los datos
                    {
                        Programacion.id_Programacion = id;

                        int Resulta = ClsProcedimientos.ModificarProgramacion(Programacion, cbo_CargarTorneo.Text, cbo_Equipo_Local.Text,
                            cbo_Equipo_Visitante.Text);

                        if (Resulta > 0)
                        {
                            MessageBox.Show("Datos modificados con éxito");
                            refreshPantalla();
                        }

                        else
                        {
                            MessageBox.Show("Error al modificar los datos");
                        }
                    }
                }
                else
                {
                    int Resulta = ClsProcedimientos.GuardarProgramacion(Programacion, cbo_CargarTorneo.Text, cbo_Equipo_Local.Text,
                            cbo_Equipo_Visitante.Text);
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

        private void btnLimpiarProgramacion_Click(object sender, EventArgs e)
        {
            txt_IdPrograma.Clear();
            cbo_CargarTorneo.Items.Clear();
            txt_UbicacionPrograma.Clear();
            cbo_Equipo_Visitante.Items.Clear();
            cbo_Equipo_Local.Items.Clear();
        }

        private void FRM_Programacion_Load(object sender, EventArgs e)
        {
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

            txt_IdPrograma.Enabled = false;

            dgvProgramacion.DataSource = ClsProcedimientos.PresentarRegistroProgramacion();
            dgvProgramacion.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnEliminarProgramacion_Click(object sender, EventArgs e)
        {
            if (dgvProgramacion.SelectedRows.Count == 1)
            {
                //Variable para modificar los datos
                int id = Convert.ToInt32(dgvProgramacion.CurrentRow.Cells["id_Programacion"].Value);

                //Fila seleccionada se guarda en variable id pero solo si esta
                int Resultado = ClsProcedimientos.EliminarProgramacion(id);

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

        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    cbo_CargarTorneo.Items.Add(Lector[0].ToString());
                }
                cbo_CargarTorneo.Items.Insert(0, "-Seleccione Torneo-");
                cbo_CargarTorneo.SelectedIndex = 0;
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

                SqlCommand Comando = new SqlCommand("SELECT * FROM REGISTRO_EQUIPOS WHERE Estado = 1 ", Conexion);
                SqlDataReader Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    cbo_Equipo_Visitante.Items.Add(Lector[2].ToString());
                }
                cbo_Equipo_Visitante.Items.Insert(0, "-Seleccione Visitante-");
                cbo_Equipo_Visitante.SelectedIndex = 0;
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

                SqlCommand Comando = new SqlCommand("SELECT *  FROM REGISTRO_EQUIPOS WHERE Estado = 1 ", Conexion);

                SqlDataReader Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    cbo_Equipo_Local.Items.Add(Lector[2].ToString());
                }
                cbo_Equipo_Local.Items.Insert(0, "-Seleccione Local-");
                cbo_Equipo_Local.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Equipo Local: " + ex.Message);
            }
            finally
            {
                if (Conexion != null && Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }
        }

        private void dgvProgramacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_IdPrograma.Text = dgvProgramacion.SelectedCells[0].Value.ToString();
            cbo_CargarTorneo.Text = dgvProgramacion.SelectedCells[1].Value.ToString();
            dtm_Fecha_Programacion.Text = dgvProgramacion.SelectedCells[2].Value.ToString();
            dtm_Hora_Programacion.Text = dgvProgramacion.SelectedCells[3].Value.ToString();
            txt_UbicacionPrograma.Text = dgvProgramacion.SelectedCells[4].Value.ToString();
            cbo_Equipo_Local.Text = dgvProgramacion.SelectedCells[5].Value.ToString();
            cbo_Equipo_Visitante.Text = dgvProgramacion.SelectedCells[6].Value.ToString();
        }
    }
}
