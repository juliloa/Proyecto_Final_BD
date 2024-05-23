using Proyecto_Final_BD.Datos;
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
            dgv_Historial.Font = new Font("SimSun", 11);
        }
        SqlConnection Conexion = new SqlConnection("server=DESKTOP-K54DEQR\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");
        //SqlConnection Conexion = new SqlConnection("server=DESKTOP-63RH14Q\\SQLEXPRESS; database=PRUEBAFINAL; integrated security=true");

        public void refreshPantalla()
        {
            dgv_Historial.DataSource = ClsProcedimientos.PresentarHistorial();
        }
        private void FRM_Historial_Load(object sender, EventArgs e)
        {
            ClsConexion Conexion = new ClsConexion();
            Conexion.CrearConexion();

            dgv_Historial.DataSource = ClsProcedimientos.PresentarHistorial();
            dgv_Historial.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            txt_id_Historial.Enabled = false;
        }

        private void btn_Cargar_Historial_Click(object sender, EventArgs e)
        {
            if (dgv_Historial.SelectedRows.Count == 1)
            {

            }
        }

        private void btn_SalirPresentacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
