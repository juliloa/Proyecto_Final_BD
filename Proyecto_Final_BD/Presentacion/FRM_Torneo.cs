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
    public partial class FRM_Torneo : Form
    {
        public FRM_Torneo()
        {
            InitializeComponent();
            dgvTorneo.Font = new Font("SimSun", 9);
            CargarCategoria();
        }
        SqlConnection Conexion = new SqlConnection("server=DESKTOP-K54DEQR\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");
        //SqlConnection Conexion = new SqlConnection("server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");
        public void refreshPantalla()
        {
            dgvTorneo.DataSource = ClsProcedimientos.PresentarRegistroTorneo();
        }

        private void btn_GuardarTorneo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboBox_Categoria_Torneo.Text) ||
               string.IsNullOrWhiteSpace(dtp_FechaInicioTorneo.Text) ||
               string.IsNullOrWhiteSpace(dtp_FechaInicioTorneo.Text) ||
               string.IsNullOrWhiteSpace(txt_NombreTorneo.Text) ||
               string.IsNullOrWhiteSpace(txt_UbicacionTorneo.Text)
               )
            {
                MessageBox.Show("Ingrese todos los datos solicitados");
            }
            else
            {
                //Objeto para agregar los datos
                ClsTorneo torneo = new ClsTorneo();

                torneo.Nombre_torneo = txt_NombreTorneo.Text;
                torneo.Categoria = cboBox_Categoria_Torneo.Text;
                torneo.Fecha_Inicio = Convert.ToDateTime(dtp_FechaInicioTorneo.Value);
                torneo.Fecha_Final = Convert.ToDateTime(dtp_FechaFinal_Torneo.Value);
                torneo.Ubicacion_T = txt_UbicacionTorneo.Text;
                torneo.Reglas_Especificas = txt_ReglasEspecificas.Text;

                //Condicional para modificar y guardar el id en los datos selecionados
                if (dgvTorneo.SelectedRows.Count == 1)
                {

                    //Variable para modificar los datos
                    int id = Convert.ToInt32(dgvTorneo.CurrentRow.Cells["id_Torneo"].Value);
                    //Fila seleccionada se guarda en variable id pero solo si esta

                    //La tabla tiene CONSTRAINS(SQL) Y no deja modificar las llaves

                    if (id != null) //Si  existe un ID el boton modificará los datos
                    {
                        torneo.Id_Torneo = id;
                        int Resulta = ClsProcedimientos.ModificarTorneo(torneo);

                        if (Resulta > 0)
                        {
                            MessageBox.Show("Datos modificados con éxito");
                        }
                        else
                        {
                            MessageBox.Show("Error al modificar los datos");
                        }
                        refreshPantalla(); //LLamamos el metodo cuando se modifique
                    }
                }
                else //Si no existe los va a guardar
                {
                    int Resulta = ClsProcedimientos.GuardarTorneo(torneo);

                    if (Resulta > 0)
                    {
                        MessageBox.Show("Datos guardados con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar los datos");
                    }

                }
            }
            refreshPantalla();

        }

        private void CargarCategoria()
        {
            cboBox_Categoria_Torneo.Items.Clear();
            Conexion.Open();

            SqlCommand Comando = new SqlCommand("SELECT * FROM CATEGORIAS", Conexion);

            SqlDataReader Leer = Comando.ExecuteReader();
            while (Leer.Read())
            {
                cboBox_Categoria_Torneo.Items.Clear();

                cboBox_Categoria_Torneo.Items.Add(Leer[0].ToString());
                cboBox_Categoria_Torneo.Items.Add(Leer[1].ToString());
                cboBox_Categoria_Torneo.Items.Add(Leer[2].ToString());
                cboBox_Categoria_Torneo.Items.Add(Leer[3].ToString());
            }


            Conexion.Close();

            cboBox_Categoria_Torneo.Items.Insert(0, "-Seleccione categoría-");
            cboBox_Categoria_Torneo.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvTorneo.SelectedRows.Count == 1)
            {
                ClsTorneo torneo = new ClsTorneo();

                //Variable para modificar los datos
                int id = Convert.ToInt32(dgvTorneo.CurrentRow.Cells["id_Torneo"].Value);

                //Fila seleccionada se guarda en variable id pero solo si esta
                int Resultado = ClsProcedimientos.EliminarTorneo(torneo, id);

                if (Resultado > 0)
                {
                    MessageBox.Show("Datos eliminados con éxito");
                }
                else
                {
                    MessageBox.Show("Error en la eliminación de datos");
                }

            }
            refreshPantalla();
        }

        private void btn_LimpiarTorneo_Click(object sender, EventArgs e)
        {
            cboBox_Categoria_Torneo.Items.Clear();
            txt_Idtorneo.Clear();
            txt_NombreTorneo.Clear();
            txt_UbicacionTorneo.Clear();
            txt_ReglasEspecificas.Clear();
        }

        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FRM_Torneo_Load(object sender, EventArgs e)
        {
            //Llamamos la connexion en el forms de Torneo
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

            dgvTorneo.DataSource = ClsProcedimientos.PresentarRegistroTorneo();

            dgvTorneo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //Ocultamos ID para que no se pueda modificar porque esta automatico
            txt_Idtorneo.Enabled = false;
        }

        private void dgvTorneo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Idtorneo.Text = dgvTorneo.SelectedCells[0].Value.ToString();
            txt_NombreTorneo.Text = dgvTorneo.SelectedCells[1].Value.ToString();
            cboBox_Categoria_Torneo.Text = dgvTorneo.SelectedCells[2].Value.ToString();
            dtp_FechaInicioTorneo.Text = dgvTorneo.SelectedCells[3].Value.ToString();
            dtp_FechaFinal_Torneo.Text = dgvTorneo.SelectedCells[4].Value.ToString();
            txt_UbicacionTorneo.Text = dgvTorneo.SelectedCells[5].Value.ToString();
            txt_ReglasEspecificas.Text = dgvTorneo.SelectedCells[6].Value.ToString();
        }
    }
}
