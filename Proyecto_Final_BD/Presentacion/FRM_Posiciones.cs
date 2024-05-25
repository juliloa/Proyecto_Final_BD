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
    public partial class FRM_Posiciones : Form
    {
        public FRM_Posiciones()
        {
            InitializeComponent();
            dgv_Posiciones.Font = new Font("SimSun", 9);
            Cargar_Equipo();
        }
        //SqlConnection Conexion = new SqlConnection("server=DESKTOP-K54DEQR\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");
        SqlConnection Conexion = new SqlConnection("server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");

        private void Cargar_Equipo()
        {
            try
            {
                Conexion.Open();

                SqlCommand Comando = new SqlCommand("[SP_Presentar_Datos_EuiposActivos]", Conexion);
                SqlDataReader Lector = Comando.ExecuteReader();

                while (Lector.Read())
                {
                    Cbo_cargar_Equipos.Items.Add(Lector[2].ToString());
                }
                Cbo_cargar_Equipos.Items.Insert(0, "-Seleccione Equipo-");
                Cbo_cargar_Equipos.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar Equipo : " + ex.Message);
            }
            finally
            {
                if (Conexion != null && Conexion.State == ConnectionState.Open)
                {
                    Conexion.Close();
                }
            }

        }
        private void FRM_Posiciones_Load(object sender, EventArgs e)
        {
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

            dgv_Posiciones.DataSource = ClsProcedimientos.PresentarPosiciones();
            dgv_Posiciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            txt_id_Posicion.Enabled = false;
        }

        public void refreshPantalla()
        {
            dgv_Posiciones.DataSource = ClsProcedimientos.PresentarPosiciones();
        }

        private void btn_GuardarPosiciones_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Cbo_cargar_Equipos.Text))
            {
                MessageBox.Show("Ingrese todos los datos solicitados");
            }
            else
            {
                ClsPosiciones posiciones = new ClsPosiciones();

                posiciones.Encuentros = text_Encuentros.Text;
                posiciones.Victorias = text_Victorias.Text;
                posiciones.Derrotas = txt_Derrotas.Text;
                posiciones.Empates = txt_Empates.Text;

                if (dgv_Posiciones.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(dgv_Posiciones.CurrentRow.Cells["id_Posicion"].Value);

                }
                else
                {
                    int Posicion = ClsProcedimientos.GuardarPosiciones(posiciones, txt_id_Posicion.Text, Cbo_cargar_Equipos.Text,
                        text_Encuentros.Text, text_Victorias.Text, txt_Derrotas.Text, txt_Empates.Text);
                    if (Posicion > 0)
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

        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminarPosiciones_Click(object sender, EventArgs e)
        {
            if (dgv_Posiciones.SelectedRows.Count == 1)
            {
                ClsPosiciones Posiciones = new ClsPosiciones();
                //Variable para modificar los datos
                int id = Convert.ToInt32(dgv_Posiciones.CurrentRow.Cells["id_Posicion"].Value);

                //Fila seleccionada se guarda en variable id pero solo si esta
                int Resultado = ClsProcedimientos.EliminarPosiciones(Posiciones, id);

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
