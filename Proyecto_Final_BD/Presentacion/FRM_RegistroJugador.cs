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
    public partial class FRM_RegistroJugador : Form
    {
        public FRM_RegistroJugador()
        {
            InitializeComponent();
            dgvRegistroJugador.Font = new Font("SimSun", 9);
            CargarEquipo();
            CargarGenero();
        }
        SqlConnection Conexion = new SqlConnection("server=DESKTOP-K54DEQR\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");
        //SqlConnection Conexion = new SqlConnection("server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");
        private void FRM_RegistroJugador_Load(object sender, EventArgs e)
        {
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

            dgvRegistroJugador.DataSource = ClsProcedimientos.PresentarRegistroJugador();
            dgvRegistroJugador.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            txt_Equipo.Enabled = false;
            txt_Id_Jugador.Enabled = false;
        }

        public void refreshPantalla()
        {
            dgvRegistroJugador.DataSource = ClsProcedimientos.PresentarRegistroJugador();
            dgvRegistroJugador.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btn_GuardarTorneo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CorreoJugador.Text) ||
                string.IsNullOrWhiteSpace(txt_DocumentoJugador.Text) ||
                string.IsNullOrWhiteSpace(txt_EdadJugador.Text) ||
                string.IsNullOrWhiteSpace(cbo_Cargar_Equipos.Text) ||
                string.IsNullOrWhiteSpace(txt_NombreJugador.Text) ||
                string.IsNullOrWhiteSpace(txt_TeleJugador.Text)
                )
            {
                MessageBox.Show("Ingrese todos los datos solicitados ");
            }
            else
            {

                ClsRegistroJugador Jugador = new ClsRegistroJugador();

                Jugador.Nombre = txt_NombreJugador.Text;
                Jugador.Apellido = txt_ApellidoJugador.Text;
                Jugador.Documento = txt_DocumentoJugador.Text;
                Jugador.Edad = Convert.ToInt32(txt_EdadJugador.Text);
                Jugador.Genero = cbo_Cargar_Equipos.Text;
                Jugador.Telefono = txt_TeleJugador.Text;
                Jugador.Correo = txt_CorreoJugador.Text;



                if (dgvRegistroJugador.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(dgvRegistroJugador.CurrentRow.Cells["id_Jugador"].Value);

                    if (id != null)
                    {
                        Jugador.id_Jugador = id;

                        int Resultado = ClsProcedimientos.ModificarRegistroJugador(Jugador, cbo_Cargar_Equipos.Text);

                        if (Resultado > 0)
                        {
                            MessageBox.Show("Datos modificados con éxito");
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar los datos");
                        }
                    }
                }
                else
                {
                    int Resultado = ClsProcedimientos.GuardarJugador(Jugador, cbo_Cargar_Equipos.Text);


                    if (Resultado > 0)
                    {
                        MessageBox.Show("Datos guardados con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar los datos");
                    }
                }
                refreshPantalla();
            }
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            txt_ApellidoJugador.Clear();
            txt_CorreoJugador.Clear();
            txt_DocumentoJugador.Clear();
            txt_EdadJugador.Clear();
            txt_Equipo.Clear();
            txt_Id_Jugador.Clear();
            txt_NombreJugador.Clear();
            txt_TeleJugador.Clear();
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            if (dgvRegistroJugador.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvRegistroJugador.CurrentRow.Cells["id_Jugador"].Value);

                int Resultado = ClsProcedimientos.EliminarRegistroJugador(id);

                if (Resultado == 0)
                {
                    if (Resultado > 0)
                    {
                        MessageBox.Show("Datos eliminados con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error en la eliminación de datos");
                    }
                }

            }
        }

        private void CargarEquipo()
        {
            try
            {
                Conexion.Open();

                SqlCommand Comando = new SqlCommand("SELECT * FROM REGISTRO_EQUIPOS WHERE Estado = 1", Conexion);
                SqlDataReader Lector = Comando.ExecuteReader();

                List<ClsRegistroEquipo> listaTorneos = new List<ClsRegistroEquipo>();
                while (Lector.Read())
                {
                    cbo_Cargar_Equipos.Items.Add(Lector[0].ToString());
                }
                cbo_Cargar_Equipos.Items.Insert(0, "-Seleccione Equipo-");
                cbo_Cargar_Equipos.SelectedIndex = 0;
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
        private void CargarGenero()
        {
            cbo_Genero_Jugador.Items.Clear();
            Conexion.Open();

            SqlCommand Comando = new SqlCommand("SELECT * FROM GENEROS", Conexion);

            SqlDataReader Leer = Comando.ExecuteReader();
            while (Leer.Read())
            {
                cbo_Genero_Jugador.Items.Clear();

                cbo_Genero_Jugador.Items.Add(Leer[0].ToString());
                cbo_Genero_Jugador.Items.Add(Leer[1].ToString());
                cbo_Genero_Jugador.Items.Add(Leer[2].ToString());
                cbo_Genero_Jugador.Items.Add(Leer[3].ToString());
            }


            Conexion.Close();

            cbo_Genero_Jugador.Items.Insert(0, "-Seleccione Género-");
            cbo_Genero_Jugador.SelectedIndex = 0;
        }

        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvRegistroJugador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id_Jugador.Text = dgvRegistroJugador.SelectedCells[0].Value.ToString();
            cbo_Cargar_Equipos.Text = dgvRegistroJugador.SelectedCells[1].Value.ToString();
            txt_NombreJugador.Text = dgvRegistroJugador.SelectedCells[2].Value.ToString();
            txt_ApellidoJugador.Text = dgvRegistroJugador.SelectedCells[3].Value.ToString();
            txt_DocumentoJugador.Text = dgvRegistroJugador.SelectedCells[4].Value.ToString();
            txt_EdadJugador.Text = dgvRegistroJugador.SelectedCells[5].Value.ToString();
            txt_TeleJugador.Text = dgvRegistroJugador.SelectedCells[7].Value.ToString();
            txt_CorreoJugador.Text = dgvRegistroJugador.SelectedCells[8].Value.ToString();
        }
    }
}



