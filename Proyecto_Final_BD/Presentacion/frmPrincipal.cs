using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_BD.Presentacion
{
    public partial class frmPrincipal : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(IconMenuItem Menu, Form Formulario)
        {
            Menu.BackColor = Color.White;
            MenuActivo = Menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = Formulario;
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            Formulario.BackColor = Color.LightCyan;

            panelcontenedor.Controls.Add(Formulario);
            Formulario.Show();

        }


        private void Menu_Torneo_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FRM_Torneo());

        }

        private void Menu_Equipos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FRM_RegistroEquipos());
        }

        private void Menu_Juador_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FRM_RegistroJugador());
        }

        private void Menu_Programacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FRM_Programacion());
        }

        private void Menu_Resultados_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FRM_Resultados());
        }

        private void Menu_Posiciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FRM_Posiciones());
        }

        private void Menu_Historial_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FRM_Historial());
        }
    }
}
