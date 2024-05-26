namespace Proyecto_Final_BD.Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Torneo = new FontAwesome.Sharp.IconMenuItem();
            this.Menu_Equipos = new FontAwesome.Sharp.IconMenuItem();
            this.Menu_Juador = new FontAwesome.Sharp.IconMenuItem();
            this.Menu_Programacion = new FontAwesome.Sharp.IconMenuItem();
            this.Menu_Resultados = new FontAwesome.Sharp.IconMenuItem();
            this.Menu_Posiciones = new FontAwesome.Sharp.IconMenuItem();
            this.Menu_Historial = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.sISTEMADEREGISTRODEEVENTOSDEFUTBOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.LightCyan;
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(0, 137);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1606, 710);
            this.panelcontenedor.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Torneo,
            this.Menu_Equipos,
            this.Menu_Juador,
            this.Menu_Programacion,
            this.Menu_Resultados,
            this.Menu_Posiciones,
            this.Menu_Historial});
            this.menuStrip1.Location = new System.Drawing.Point(0, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1606, 87);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Torneo
            // 
            this.Menu_Torneo.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Torneo.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.Menu_Torneo.IconColor = System.Drawing.Color.Black;
            this.Menu_Torneo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Menu_Torneo.IconSize = 50;
            this.Menu_Torneo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_Torneo.Name = "Menu_Torneo";
            this.Menu_Torneo.Size = new System.Drawing.Size(91, 81);
            this.Menu_Torneo.Text = "Torneo";
            this.Menu_Torneo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Menu_Torneo.Click += new System.EventHandler(this.Menu_Torneo_Click);
            // 
            // Menu_Equipos
            // 
            this.Menu_Equipos.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Equipos.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.Menu_Equipos.IconColor = System.Drawing.Color.Black;
            this.Menu_Equipos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Menu_Equipos.IconSize = 50;
            this.Menu_Equipos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_Equipos.Name = "Menu_Equipos";
            this.Menu_Equipos.Size = new System.Drawing.Size(113, 81);
            this.Menu_Equipos.Text = " Equipos";
            this.Menu_Equipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Menu_Equipos.Click += new System.EventHandler(this.Menu_Equipos_Click);
            // 
            // Menu_Juador
            // 
            this.Menu_Juador.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Juador.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.Menu_Juador.IconColor = System.Drawing.Color.Black;
            this.Menu_Juador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Menu_Juador.IconSize = 50;
            this.Menu_Juador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_Juador.Name = "Menu_Juador";
            this.Menu_Juador.Size = new System.Drawing.Size(102, 81);
            this.Menu_Juador.Text = "Jugador";
            this.Menu_Juador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Menu_Juador.Click += new System.EventHandler(this.Menu_Juador_Click);
            // 
            // Menu_Programacion
            // 
            this.Menu_Programacion.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Programacion.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.Menu_Programacion.IconColor = System.Drawing.Color.Black;
            this.Menu_Programacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Menu_Programacion.IconSize = 50;
            this.Menu_Programacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_Programacion.Name = "Menu_Programacion";
            this.Menu_Programacion.Size = new System.Drawing.Size(157, 81);
            this.Menu_Programacion.Text = "Programación";
            this.Menu_Programacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Menu_Programacion.Click += new System.EventHandler(this.Menu_Programacion_Click);
            // 
            // Menu_Resultados
            // 
            this.Menu_Resultados.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Resultados.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.Menu_Resultados.IconColor = System.Drawing.Color.Black;
            this.Menu_Resultados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Menu_Resultados.IconSize = 50;
            this.Menu_Resultados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_Resultados.Name = "Menu_Resultados";
            this.Menu_Resultados.Size = new System.Drawing.Size(135, 81);
            this.Menu_Resultados.Text = "Resultados";
            this.Menu_Resultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Menu_Resultados.Click += new System.EventHandler(this.Menu_Resultados_Click);
            // 
            // Menu_Posiciones
            // 
            this.Menu_Posiciones.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Posiciones.IconChar = FontAwesome.Sharp.IconChar.TableList;
            this.Menu_Posiciones.IconColor = System.Drawing.Color.Black;
            this.Menu_Posiciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Menu_Posiciones.IconSize = 50;
            this.Menu_Posiciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_Posiciones.Name = "Menu_Posiciones";
            this.Menu_Posiciones.Size = new System.Drawing.Size(135, 81);
            this.Menu_Posiciones.Text = "Posiciones";
            this.Menu_Posiciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Menu_Posiciones.Click += new System.EventHandler(this.Menu_Posiciones_Click);
            // 
            // Menu_Historial
            // 
            this.Menu_Historial.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Historial.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.Menu_Historial.IconColor = System.Drawing.Color.Black;
            this.Menu_Historial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Menu_Historial.IconSize = 50;
            this.Menu_Historial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menu_Historial.Name = "Menu_Historial";
            this.Menu_Historial.Size = new System.Drawing.Size(124, 81);
            this.Menu_Historial.Text = "Historial";
            this.Menu_Historial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Menu_Historial.Click += new System.EventHandler(this.Menu_Historial_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LightCyan;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sISTEMADEREGISTRODEEVENTOSDEFUTBOLToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1606, 50);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // sISTEMADEREGISTRODEEVENTOSDEFUTBOLToolStripMenuItem
            // 
            this.sISTEMADEREGISTRODEEVENTOSDEFUTBOLToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sISTEMADEREGISTRODEEVENTOSDEFUTBOLToolStripMenuItem.Name = "sISTEMADEREGISTRODEEVENTOSDEFUTBOLToolStripMenuItem";
            this.sISTEMADEREGISTRODEEVENTOSDEFUTBOLToolStripMenuItem.Size = new System.Drawing.Size(873, 44);
            this.sISTEMADEREGISTRODEEVENTOSDEFUTBOLToolStripMenuItem.Text = "SISTEMA DE REGISTRO DE EVENTOS DE FÚTBOL";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 847);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem sISTEMADEREGISTRODEEVENTOSDEFUTBOLToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem Menu_Torneo;
        private FontAwesome.Sharp.IconMenuItem Menu_Equipos;
        private FontAwesome.Sharp.IconMenuItem Menu_Juador;
        private FontAwesome.Sharp.IconMenuItem Menu_Programacion;
        private FontAwesome.Sharp.IconMenuItem Menu_Resultados;
        private FontAwesome.Sharp.IconMenuItem Menu_Posiciones;
        private FontAwesome.Sharp.IconMenuItem Menu_Historial;
    }
}