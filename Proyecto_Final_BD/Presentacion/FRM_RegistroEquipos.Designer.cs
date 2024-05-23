namespace Proyecto_Final_BD.Presentacion
{
    partial class FRM_RegistroEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_RegistroEquipos));
            this.label1 = new System.Windows.Forms.Label();
            this.lbk_LlamarTorneo = new System.Windows.Forms.Label();
            this.lbl_LlamarCategoria = new System.Windows.Forms.Label();
            this.txt_Nombre_Equipo = new System.Windows.Forms.TextBox();
            this.lbl_NombreEquipo = new System.Windows.Forms.Label();
            this.cbo_CargarCategoria = new System.Windows.Forms.ComboBox();
            this.cbo_CargarTorneo = new System.Windows.Forms.ComboBox();
            this.txt_Patrocinadores_Equipo = new System.Windows.Forms.TextBox();
            this.lbl_Patrocinadores = new System.Windows.Forms.Label();
            this.btnLimpiarEquipos = new System.Windows.Forms.Button();
            this.btnEliminarEquipos = new System.Windows.Forms.Button();
            this.lbl_EquipoVisitan = new System.Windows.Forms.Label();
            this.btn_GuardarEquipos = new System.Windows.Forms.Button();
            this.txt_IdTorneo = new System.Windows.Forms.TextBox();
            this.txt_IdEquipo = new System.Windows.Forms.TextBox();
            this.txt_CantidadJugadores = new System.Windows.Forms.TextBox();
            this.btn_SalirPresentacion = new System.Windows.Forms.Button();
            this.dgvRegistroEquipos = new System.Windows.Forms.DataGridView();
            this.lbl_TorneoPrograma = new System.Windows.Forms.Label();
            this.lbl_Equipo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 56);
            this.label1.TabIndex = 147;
            this.label1.Text = "R E G I S T R O   E Q U I P O S\r\n\r\n";
            // 
            // lbk_LlamarTorneo
            // 
            this.lbk_LlamarTorneo.AutoSize = true;
            this.lbk_LlamarTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbk_LlamarTorneo.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbk_LlamarTorneo.Location = new System.Drawing.Point(19, 393);
            this.lbk_LlamarTorneo.Name = "lbk_LlamarTorneo";
            this.lbk_LlamarTorneo.Size = new System.Drawing.Size(96, 26);
            this.lbk_LlamarTorneo.TabIndex = 146;
            this.lbk_LlamarTorneo.Text = "Torneo";
            this.lbk_LlamarTorneo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_LlamarCategoria
            // 
            this.lbl_LlamarCategoria.AutoSize = true;
            this.lbl_LlamarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_LlamarCategoria.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LlamarCategoria.Location = new System.Drawing.Point(19, 448);
            this.lbl_LlamarCategoria.Name = "lbl_LlamarCategoria";
            this.lbl_LlamarCategoria.Size = new System.Drawing.Size(138, 26);
            this.lbl_LlamarCategoria.TabIndex = 145;
            this.lbl_LlamarCategoria.Text = "Categoría";
            this.lbl_LlamarCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Nombre_Equipo
            // 
            this.txt_Nombre_Equipo.BackColor = System.Drawing.Color.Snow;
            this.txt_Nombre_Equipo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre_Equipo.Location = new System.Drawing.Point(242, 208);
            this.txt_Nombre_Equipo.Name = "txt_Nombre_Equipo";
            this.txt_Nombre_Equipo.Size = new System.Drawing.Size(191, 35);
            this.txt_Nombre_Equipo.TabIndex = 128;
            this.txt_Nombre_Equipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_NombreEquipo
            // 
            this.lbl_NombreEquipo.AutoSize = true;
            this.lbl_NombreEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_NombreEquipo.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreEquipo.Location = new System.Drawing.Point(19, 204);
            this.lbl_NombreEquipo.Name = "lbl_NombreEquipo";
            this.lbl_NombreEquipo.Size = new System.Drawing.Size(96, 26);
            this.lbl_NombreEquipo.TabIndex = 144;
            this.lbl_NombreEquipo.Text = "Nombre";
            this.lbl_NombreEquipo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbo_CargarCategoria
            // 
            this.cbo_CargarCategoria.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_CargarCategoria.FormattingEnabled = true;
            this.cbo_CargarCategoria.Location = new System.Drawing.Point(241, 447);
            this.cbo_CargarCategoria.Name = "cbo_CargarCategoria";
            this.cbo_CargarCategoria.Size = new System.Drawing.Size(192, 32);
            this.cbo_CargarCategoria.TabIndex = 143;
            // 
            // cbo_CargarTorneo
            // 
            this.cbo_CargarTorneo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_CargarTorneo.FormattingEnabled = true;
            this.cbo_CargarTorneo.Location = new System.Drawing.Point(241, 392);
            this.cbo_CargarTorneo.Name = "cbo_CargarTorneo";
            this.cbo_CargarTorneo.Size = new System.Drawing.Size(192, 32);
            this.cbo_CargarTorneo.TabIndex = 142;
            // 
            // txt_Patrocinadores_Equipo
            // 
            this.txt_Patrocinadores_Equipo.BackColor = System.Drawing.Color.Snow;
            this.txt_Patrocinadores_Equipo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Patrocinadores_Equipo.Location = new System.Drawing.Point(241, 335);
            this.txt_Patrocinadores_Equipo.Name = "txt_Patrocinadores_Equipo";
            this.txt_Patrocinadores_Equipo.Size = new System.Drawing.Size(191, 35);
            this.txt_Patrocinadores_Equipo.TabIndex = 130;
            this.txt_Patrocinadores_Equipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Patrocinadores
            // 
            this.lbl_Patrocinadores.AutoSize = true;
            this.lbl_Patrocinadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Patrocinadores.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patrocinadores.Location = new System.Drawing.Point(19, 337);
            this.lbl_Patrocinadores.Name = "lbl_Patrocinadores";
            this.lbl_Patrocinadores.Size = new System.Drawing.Size(208, 26);
            this.lbl_Patrocinadores.TabIndex = 141;
            this.lbl_Patrocinadores.Text = "Patrocinadores";
            this.lbl_Patrocinadores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLimpiarEquipos
            // 
            this.btnLimpiarEquipos.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarEquipos.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarEquipos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiarEquipos.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarEquipos.Image")));
            this.btnLimpiarEquipos.Location = new System.Drawing.Point(241, 517);
            this.btnLimpiarEquipos.Name = "btnLimpiarEquipos";
            this.btnLimpiarEquipos.Size = new System.Drawing.Size(177, 46);
            this.btnLimpiarEquipos.TabIndex = 140;
            this.btnLimpiarEquipos.Text = "Limpiar";
            this.btnLimpiarEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarEquipos.UseVisualStyleBackColor = false;
            // 
            // btnEliminarEquipos
            // 
            this.btnEliminarEquipos.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminarEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEquipos.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEquipos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarEquipos.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEquipos.Image")));
            this.btnEliminarEquipos.Location = new System.Drawing.Point(458, 517);
            this.btnEliminarEquipos.Name = "btnEliminarEquipos";
            this.btnEliminarEquipos.Size = new System.Drawing.Size(177, 46);
            this.btnEliminarEquipos.TabIndex = 139;
            this.btnEliminarEquipos.Text = "Eliminar";
            this.btnEliminarEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarEquipos.UseVisualStyleBackColor = false;
            // 
            // lbl_EquipoVisitan
            // 
            this.lbl_EquipoVisitan.AutoSize = true;
            this.lbl_EquipoVisitan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_EquipoVisitan.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EquipoVisitan.Location = new System.Drawing.Point(19, 261);
            this.lbl_EquipoVisitan.Name = "lbl_EquipoVisitan";
            this.lbl_EquipoVisitan.Size = new System.Drawing.Size(138, 52);
            this.lbl_EquipoVisitan.TabIndex = 138;
            this.lbl_EquipoVisitan.Text = "Cantidad \r\nJugadores";
            this.lbl_EquipoVisitan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_GuardarEquipos
            // 
            this.btn_GuardarEquipos.BackColor = System.Drawing.Color.DarkGray;
            this.btn_GuardarEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarEquipos.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarEquipos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_GuardarEquipos.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarEquipos.Image")));
            this.btn_GuardarEquipos.Location = new System.Drawing.Point(24, 517);
            this.btn_GuardarEquipos.Name = "btn_GuardarEquipos";
            this.btn_GuardarEquipos.Size = new System.Drawing.Size(177, 46);
            this.btn_GuardarEquipos.TabIndex = 137;
            this.btn_GuardarEquipos.Text = "Guardar";
            this.btn_GuardarEquipos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarEquipos.UseVisualStyleBackColor = false;
            // 
            // txt_IdTorneo
            // 
            this.txt_IdTorneo.BackColor = System.Drawing.Color.Snow;
            this.txt_IdTorneo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdTorneo.Location = new System.Drawing.Point(242, 155);
            this.txt_IdTorneo.Name = "txt_IdTorneo";
            this.txt_IdTorneo.Size = new System.Drawing.Size(75, 35);
            this.txt_IdTorneo.TabIndex = 136;
            this.txt_IdTorneo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_IdEquipo
            // 
            this.txt_IdEquipo.BackColor = System.Drawing.Color.Snow;
            this.txt_IdEquipo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdEquipo.Location = new System.Drawing.Point(241, 99);
            this.txt_IdEquipo.Name = "txt_IdEquipo";
            this.txt_IdEquipo.Size = new System.Drawing.Size(76, 35);
            this.txt_IdEquipo.TabIndex = 135;
            this.txt_IdEquipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_CantidadJugadores
            // 
            this.txt_CantidadJugadores.BackColor = System.Drawing.Color.Snow;
            this.txt_CantidadJugadores.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CantidadJugadores.Location = new System.Drawing.Point(242, 265);
            this.txt_CantidadJugadores.Name = "txt_CantidadJugadores";
            this.txt_CantidadJugadores.Size = new System.Drawing.Size(191, 35);
            this.txt_CantidadJugadores.TabIndex = 129;
            this.txt_CantidadJugadores.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_SalirPresentacion
            // 
            this.btn_SalirPresentacion.BackColor = System.Drawing.Color.DarkGray;
            this.btn_SalirPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirPresentacion.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirPresentacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SalirPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalirPresentacion.Image")));
            this.btn_SalirPresentacion.Location = new System.Drawing.Point(668, 517);
            this.btn_SalirPresentacion.Name = "btn_SalirPresentacion";
            this.btn_SalirPresentacion.Size = new System.Drawing.Size(177, 46);
            this.btn_SalirPresentacion.TabIndex = 134;
            this.btn_SalirPresentacion.Text = "Salir";
            this.btn_SalirPresentacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SalirPresentacion.UseVisualStyleBackColor = false;
            // 
            // dgvRegistroEquipos
            // 
            this.dgvRegistroEquipos.AllowUserToAddRows = false;
            this.dgvRegistroEquipos.AllowUserToDeleteRows = false;
            this.dgvRegistroEquipos.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvRegistroEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistroEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroEquipos.Location = new System.Drawing.Point(470, 89);
            this.dgvRegistroEquipos.Name = "dgvRegistroEquipos";
            this.dgvRegistroEquipos.ReadOnly = true;
            this.dgvRegistroEquipos.RowHeadersWidth = 62;
            this.dgvRegistroEquipos.RowTemplate.Height = 28;
            this.dgvRegistroEquipos.Size = new System.Drawing.Size(1186, 385);
            this.dgvRegistroEquipos.TabIndex = 133;
            // 
            // lbl_TorneoPrograma
            // 
            this.lbl_TorneoPrograma.AutoSize = true;
            this.lbl_TorneoPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_TorneoPrograma.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TorneoPrograma.Location = new System.Drawing.Point(19, 152);
            this.lbl_TorneoPrograma.Name = "lbl_TorneoPrograma";
            this.lbl_TorneoPrograma.Size = new System.Drawing.Size(138, 26);
            this.lbl_TorneoPrograma.TabIndex = 132;
            this.lbl_TorneoPrograma.Text = "ID Torneo";
            this.lbl_TorneoPrograma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Equipo
            // 
            this.lbl_Equipo.AutoSize = true;
            this.lbl_Equipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Equipo.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Equipo.Location = new System.Drawing.Point(19, 95);
            this.lbl_Equipo.Name = "lbl_Equipo";
            this.lbl_Equipo.Size = new System.Drawing.Size(138, 26);
            this.lbl_Equipo.TabIndex = 131;
            this.lbl_Equipo.Text = "ID Equipo";
            this.lbl_Equipo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRM_RegistroEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbk_LlamarTorneo);
            this.Controls.Add(this.lbl_LlamarCategoria);
            this.Controls.Add(this.txt_Nombre_Equipo);
            this.Controls.Add(this.lbl_NombreEquipo);
            this.Controls.Add(this.cbo_CargarCategoria);
            this.Controls.Add(this.cbo_CargarTorneo);
            this.Controls.Add(this.txt_Patrocinadores_Equipo);
            this.Controls.Add(this.lbl_Patrocinadores);
            this.Controls.Add(this.btnLimpiarEquipos);
            this.Controls.Add(this.btnEliminarEquipos);
            this.Controls.Add(this.lbl_EquipoVisitan);
            this.Controls.Add(this.btn_GuardarEquipos);
            this.Controls.Add(this.txt_IdTorneo);
            this.Controls.Add(this.txt_IdEquipo);
            this.Controls.Add(this.txt_CantidadJugadores);
            this.Controls.Add(this.btn_SalirPresentacion);
            this.Controls.Add(this.dgvRegistroEquipos);
            this.Controls.Add(this.lbl_TorneoPrograma);
            this.Controls.Add(this.lbl_Equipo);
            this.Name = "FRM_RegistroEquipos";
            this.Text = "FRM_RegistroEquipos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbk_LlamarTorneo;
        private System.Windows.Forms.Label lbl_LlamarCategoria;
        private System.Windows.Forms.TextBox txt_Nombre_Equipo;
        private System.Windows.Forms.Label lbl_NombreEquipo;
        private System.Windows.Forms.ComboBox cbo_CargarCategoria;
        private System.Windows.Forms.ComboBox cbo_CargarTorneo;
        private System.Windows.Forms.TextBox txt_Patrocinadores_Equipo;
        private System.Windows.Forms.Label lbl_Patrocinadores;
        private System.Windows.Forms.Button btnLimpiarEquipos;
        private System.Windows.Forms.Button btnEliminarEquipos;
        private System.Windows.Forms.Label lbl_EquipoVisitan;
        private System.Windows.Forms.Button btn_GuardarEquipos;
        private System.Windows.Forms.TextBox txt_IdTorneo;
        private System.Windows.Forms.TextBox txt_IdEquipo;
        private System.Windows.Forms.TextBox txt_CantidadJugadores;
        private System.Windows.Forms.Button btn_SalirPresentacion;
        private System.Windows.Forms.DataGridView dgvRegistroEquipos;
        private System.Windows.Forms.Label lbl_TorneoPrograma;
        private System.Windows.Forms.Label lbl_Equipo;
    }
}