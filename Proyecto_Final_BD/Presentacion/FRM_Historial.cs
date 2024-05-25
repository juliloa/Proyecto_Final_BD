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
    public partial class FRM_Historial : Form
    {
        public FRM_Historial()
        {
            InitializeComponent();
            CargarTorneo();
            dgv_Historial.Font = new Font("SimSun", 11);
        }
        //SqlConnection Conexion = new SqlConnection("server=DESKTOP-K54DEQR\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");
        SqlConnection Conexion = new SqlConnection("server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");

        public void refreshPantalla()
        {
           // dgv_Historial.DataSource = ClsProcedimientos.PresentarHistorial();
        }
        private void FRM_Historial_Load(object sender, EventArgs e)
        {
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

           // dgv_Historial.DataSource = ClsProcedimientos.PresentarHistorial();
            dgv_Historial.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            txt_id_Historial.Enabled = false;
        }

        private void btn_Cargar_Historial_Click(object sender, EventArgs e)
        {
            if (cbo_CargarTorneo.SelectedItem != null)
            {
                int idTorneo = Convert.ToInt32(cbo_CargarTorneo.SelectedItem.ToString());
                CargarDatos(idTorneo);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un torneo.");
            }
        }
        private void CargarDatos(int idTorneo)
        {
            string connectionString = "server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_Cargar_Historial_SegunTorneo", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id_Torneo", idTorneo));

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgv_Historial.DataSource = dt;
                            dgv_Historial.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
                }
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
        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbo_CargarTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string connectionString = "server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_Cargar_Historial_SegunTorneo", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@id_Torneo", cbo_CargarTorneo.Text));

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgv_Historial.DataSource = dt;
                            dgv_Historial.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
                }
            }
        }

        private void btnEliminarHistorial_Click(object sender, EventArgs e)
        {
            if (dgv_Historial.SelectedRows.Count == 1)
            {
                ClsHistorial Historial = new ClsHistorial();
                //Variable para modificar los datos
                int id = Convert.ToInt32(dgv_Historial.CurrentRow.Cells["id_Historial"].Value);

                //Fila seleccionada se guarda en variable id pero solo si esta
                int Resultado = ClsProcedimientos.EliminarHistorial(Historial, id);

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
    }
}
