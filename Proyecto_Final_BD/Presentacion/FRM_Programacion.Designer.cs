namespace Proyecto_Final_BD.Presentacion
{
    partial class FRM_Programacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Programacion));
            this.dtm_Hora_Programacion = new System.Windows.Forms.DateTimePicker();
            this.dtm_Fecha_Programacion = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Equipo_Local = new System.Windows.Forms.Label();
            this.cbo_Equipo_Local = new System.Windows.Forms.ComboBox();
            this.lbl_EquipoVisitante = new System.Windows.Forms.Label();
            this.cbo_Equipo_Visitante = new System.Windows.Forms.ComboBox();
            this.lbk_LlamarTorneo = new System.Windows.Forms.Label();
            this.cbo_CargarTorneo = new System.Windows.Forms.ComboBox();
            this.btnEliminarProgramacion = new System.Windows.Forms.Button();
            this.btnLimpiarProgramacion = new System.Windows.Forms.Button();
            this.txt_UbicacionPrograma = new System.Windows.Forms.TextBox();
            this.btn_GuardarTorneo = new System.Windows.Forms.Button();
            this.txt_IdPrograma = new System.Windows.Forms.TextBox();
            this.btn_SalirPresentacion = new System.Windows.Forms.Button();
            this.dgvProgramacion = new System.Windows.Forms.DataGridView();
            this.lbl_FechaPrograma = new System.Windows.Forms.Label();
            this.lbl_HoraPrograma = new System.Windows.Forms.Label();
            this.lbl_UbicacionPrograma = new System.Windows.Forms.Label();
            this.lbl_IdPrograma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dtm_Hora_Programacion
            // 
            this.dtm_Hora_Programacion.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtm_Hora_Programacion.Location = new System.Drawing.Point(191, 232);
            this.dtm_Hora_Programacion.Name = "dtm_Hora_Programacion";
            this.dtm_Hora_Programacion.Size = new System.Drawing.Size(169, 26);
            this.dtm_Hora_Programacion.TabIndex = 149;
            // 
            // dtm_Fecha_Programacion
            // 
            this.dtm_Fecha_Programacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_Fecha_Programacion.Location = new System.Drawing.Point(193, 182);
            this.dtm_Fecha_Programacion.Name = "dtm_Fecha_Programacion";
            this.dtm_Fecha_Programacion.Size = new System.Drawing.Size(169, 26);
            this.dtm_Fecha_Programacion.TabIndex = 148;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 28);
            this.label1.TabIndex = 147;
            this.label1.Text = "P R O G R A M A C I O N\r\n";
            // 
            // lbl_Equipo_Local
            // 
            this.lbl_Equipo_Local.AutoSize = true;
            this.lbl_Equipo_Local.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Equipo_Local.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Equipo_Local.Location = new System.Drawing.Point(13, 341);
            this.lbl_Equipo_Local.Name = "lbl_Equipo_Local";
            this.lbl_Equipo_Local.Size = new System.Drawing.Size(96, 52);
            this.lbl_Equipo_Local.TabIndex = 146;
            this.lbl_Equipo_Local.Text = "Equipo\r\nLocal";
            // 
            // cbo_Equipo_Local
            // 
            this.cbo_Equipo_Local.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Equipo_Local.FormattingEnabled = true;
            this.cbo_Equipo_Local.Location = new System.Drawing.Point(195, 365);
            this.cbo_Equipo_Local.Name = "cbo_Equipo_Local";
            this.cbo_Equipo_Local.Size = new System.Drawing.Size(175, 32);
            this.cbo_Equipo_Local.TabIndex = 145;
            // 
            // lbl_EquipoVisitante
            // 
            this.lbl_EquipoVisitante.AutoSize = true;
            this.lbl_EquipoVisitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_EquipoVisitante.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EquipoVisitante.Location = new System.Drawing.Point(8, 416);
            this.lbl_EquipoVisitante.Name = "lbl_EquipoVisitante";
            this.lbl_EquipoVisitante.Size = new System.Drawing.Size(138, 52);
            this.lbl_EquipoVisitante.TabIndex = 144;
            this.lbl_EquipoVisitante.Text = "Equipo\r\nVisitante";
            // 
            // cbo_Equipo_Visitante
            // 
            this.cbo_Equipo_Visitante.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Equipo_Visitante.FormattingEnabled = true;
            this.cbo_Equipo_Visitante.Location = new System.Drawing.Point(193, 440);
            this.cbo_Equipo_Visitante.Name = "cbo_Equipo_Visitante";
            this.cbo_Equipo_Visitante.Size = new System.Drawing.Size(177, 32);
            this.cbo_Equipo_Visitante.TabIndex = 143;
            // 
            // lbk_LlamarTorneo
            // 
            this.lbk_LlamarTorneo.AutoSize = true;
            this.lbk_LlamarTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbk_LlamarTorneo.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbk_LlamarTorneo.Location = new System.Drawing.Point(12, 125);
            this.lbk_LlamarTorneo.Name = "lbk_LlamarTorneo";
            this.lbk_LlamarTorneo.Size = new System.Drawing.Size(96, 26);
            this.lbk_LlamarTorneo.TabIndex = 142;
            this.lbk_LlamarTorneo.Text = "Torneo";
            this.lbk_LlamarTorneo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbo_CargarTorneo
            // 
            this.cbo_CargarTorneo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_CargarTorneo.FormattingEnabled = true;
            this.cbo_CargarTorneo.Location = new System.Drawing.Point(191, 125);
            this.cbo_CargarTorneo.Name = "cbo_CargarTorneo";
            this.cbo_CargarTorneo.Size = new System.Drawing.Size(175, 32);
            this.cbo_CargarTorneo.TabIndex = 141;
            this.cbo_CargarTorneo.SelectedIndexChanged += new System.EventHandler(this.cbo_CargarTorneo_SelectedIndexChanged);
            // 
            // btnEliminarProgramacion
            // 
            this.btnEliminarProgramacion.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminarProgramacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProgramacion.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProgramacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarProgramacion.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProgramacion.Image")));
            this.btnEliminarProgramacion.Location = new System.Drawing.Point(430, 567);
            this.btnEliminarProgramacion.Name = "btnEliminarProgramacion";
            this.btnEliminarProgramacion.Size = new System.Drawing.Size(177, 46);
            this.btnEliminarProgramacion.TabIndex = 140;
            this.btnEliminarProgramacion.Text = "Eliminar";
            this.btnEliminarProgramacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarProgramacion.UseVisualStyleBackColor = false;
            this.btnEliminarProgramacion.Click += new System.EventHandler(this.btnEliminarProgramacion_Click);
            // 
            // btnLimpiarProgramacion
            // 
            this.btnLimpiarProgramacion.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarProgramacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProgramacion.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProgramacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiarProgramacion.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarProgramacion.Image")));
            this.btnLimpiarProgramacion.Location = new System.Drawing.Point(219, 567);
            this.btnLimpiarProgramacion.Name = "btnLimpiarProgramacion";
            this.btnLimpiarProgramacion.Size = new System.Drawing.Size(177, 46);
            this.btnLimpiarProgramacion.TabIndex = 139;
            this.btnLimpiarProgramacion.Text = "Limpiar";
            this.btnLimpiarProgramacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarProgramacion.UseVisualStyleBackColor = false;
            this.btnLimpiarProgramacion.Click += new System.EventHandler(this.btnLimpiarProgramacion_Click);
            // 
            // txt_UbicacionPrograma
            // 
            this.txt_UbicacionPrograma.BackColor = System.Drawing.Color.Snow;
            this.txt_UbicacionPrograma.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UbicacionPrograma.Location = new System.Drawing.Point(193, 287);
            this.txt_UbicacionPrograma.Name = "txt_UbicacionPrograma";
            this.txt_UbicacionPrograma.Size = new System.Drawing.Size(169, 35);
            this.txt_UbicacionPrograma.TabIndex = 130;
            this.txt_UbicacionPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_GuardarTorneo
            // 
            this.btn_GuardarTorneo.BackColor = System.Drawing.Color.DarkGray;
            this.btn_GuardarTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarTorneo.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarTorneo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_GuardarTorneo.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarTorneo.Image")));
            this.btn_GuardarTorneo.Location = new System.Drawing.Point(9, 567);
            this.btn_GuardarTorneo.Name = "btn_GuardarTorneo";
            this.btn_GuardarTorneo.Size = new System.Drawing.Size(177, 46);
            this.btn_GuardarTorneo.TabIndex = 138;
            this.btn_GuardarTorneo.Text = "Guardar";
            this.btn_GuardarTorneo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarTorneo.UseVisualStyleBackColor = false;
            this.btn_GuardarTorneo.Click += new System.EventHandler(this.btn_GuardarTorneo_Click);
            // 
            // txt_IdPrograma
            // 
            this.txt_IdPrograma.BackColor = System.Drawing.Color.Snow;
            this.txt_IdPrograma.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdPrograma.Location = new System.Drawing.Point(193, 84);
            this.txt_IdPrograma.Name = "txt_IdPrograma";
            this.txt_IdPrograma.Size = new System.Drawing.Size(72, 35);
            this.txt_IdPrograma.TabIndex = 137;
            this.txt_IdPrograma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_SalirPresentacion
            // 
            this.btn_SalirPresentacion.BackColor = System.Drawing.Color.DarkGray;
            this.btn_SalirPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirPresentacion.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirPresentacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SalirPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalirPresentacion.Image")));
            this.btn_SalirPresentacion.Location = new System.Drawing.Point(643, 567);
            this.btn_SalirPresentacion.Name = "btn_SalirPresentacion";
            this.btn_SalirPresentacion.Size = new System.Drawing.Size(177, 46);
            this.btn_SalirPresentacion.TabIndex = 136;
            this.btn_SalirPresentacion.Text = "Salir";
            this.btn_SalirPresentacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SalirPresentacion.UseVisualStyleBackColor = false;
            this.btn_SalirPresentacion.Click += new System.EventHandler(this.btn_SalirPresentacion_Click);
            // 
            // dgvProgramacion
            // 
            this.dgvProgramacion.AllowUserToAddRows = false;
            this.dgvProgramacion.AllowUserToDeleteRows = false;
            this.dgvProgramacion.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvProgramacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProgramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgramacion.Location = new System.Drawing.Point(408, 84);
            this.dgvProgramacion.Name = "dgvProgramacion";
            this.dgvProgramacion.ReadOnly = true;
            this.dgvProgramacion.RowHeadersWidth = 62;
            this.dgvProgramacion.RowTemplate.Height = 28;
            this.dgvProgramacion.Size = new System.Drawing.Size(1566, 383);
            this.dgvProgramacion.TabIndex = 135;
            this.dgvProgramacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProgramacion_CellClick);
            // 
            // lbl_FechaPrograma
            // 
            this.lbl_FechaPrograma.AutoSize = true;
            this.lbl_FechaPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_FechaPrograma.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaPrograma.Location = new System.Drawing.Point(13, 181);
            this.lbl_FechaPrograma.Name = "lbl_FechaPrograma";
            this.lbl_FechaPrograma.Size = new System.Drawing.Size(82, 26);
            this.lbl_FechaPrograma.TabIndex = 134;
            this.lbl_FechaPrograma.Text = "Fecha";
            this.lbl_FechaPrograma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_HoraPrograma
            // 
            this.lbl_HoraPrograma.AutoSize = true;
            this.lbl_HoraPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_HoraPrograma.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoraPrograma.Location = new System.Drawing.Point(13, 231);
            this.lbl_HoraPrograma.Name = "lbl_HoraPrograma";
            this.lbl_HoraPrograma.Size = new System.Drawing.Size(68, 26);
            this.lbl_HoraPrograma.TabIndex = 133;
            this.lbl_HoraPrograma.Text = "Hora";
            this.lbl_HoraPrograma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_UbicacionPrograma
            // 
            this.lbl_UbicacionPrograma.AutoSize = true;
            this.lbl_UbicacionPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_UbicacionPrograma.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UbicacionPrograma.Location = new System.Drawing.Point(13, 282);
            this.lbl_UbicacionPrograma.Name = "lbl_UbicacionPrograma";
            this.lbl_UbicacionPrograma.Size = new System.Drawing.Size(138, 26);
            this.lbl_UbicacionPrograma.TabIndex = 132;
            this.lbl_UbicacionPrograma.Text = "Ubicación";
            this.lbl_UbicacionPrograma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_IdPrograma
            // 
            this.lbl_IdPrograma.AutoSize = true;
            this.lbl_IdPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_IdPrograma.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdPrograma.Location = new System.Drawing.Point(11, 80);
            this.lbl_IdPrograma.Name = "lbl_IdPrograma";
            this.lbl_IdPrograma.Size = new System.Drawing.Size(166, 26);
            this.lbl_IdPrograma.TabIndex = 131;
            this.lbl_IdPrograma.Text = "ID Programa";
            this.lbl_IdPrograma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRM_Programacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 820);
            this.Controls.Add(this.dtm_Hora_Programacion);
            this.Controls.Add(this.dtm_Fecha_Programacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Equipo_Local);
            this.Controls.Add(this.cbo_Equipo_Local);
            this.Controls.Add(this.lbl_EquipoVisitante);
            this.Controls.Add(this.cbo_Equipo_Visitante);
            this.Controls.Add(this.lbk_LlamarTorneo);
            this.Controls.Add(this.cbo_CargarTorneo);
            this.Controls.Add(this.btnEliminarProgramacion);
            this.Controls.Add(this.btnLimpiarProgramacion);
            this.Controls.Add(this.txt_UbicacionPrograma);
            this.Controls.Add(this.btn_GuardarTorneo);
            this.Controls.Add(this.txt_IdPrograma);
            this.Controls.Add(this.btn_SalirPresentacion);
            this.Controls.Add(this.dgvProgramacion);
            this.Controls.Add(this.lbl_FechaPrograma);
            this.Controls.Add(this.lbl_HoraPrograma);
            this.Controls.Add(this.lbl_UbicacionPrograma);
            this.Controls.Add(this.lbl_IdPrograma);
            this.Name = "FRM_Programacion";
            this.Text = "FRM_Programacion";
            this.Load += new System.EventHandler(this.FRM_Programacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgramacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtm_Hora_Programacion;
        private System.Windows.Forms.DateTimePicker dtm_Fecha_Programacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Equipo_Local;
        private System.Windows.Forms.ComboBox cbo_Equipo_Local;
        private System.Windows.Forms.Label lbl_EquipoVisitante;
        private System.Windows.Forms.ComboBox cbo_Equipo_Visitante;
        private System.Windows.Forms.Label lbk_LlamarTorneo;
        private System.Windows.Forms.ComboBox cbo_CargarTorneo;
        private System.Windows.Forms.Button btnEliminarProgramacion;
        private System.Windows.Forms.Button btnLimpiarProgramacion;
        private System.Windows.Forms.TextBox txt_UbicacionPrograma;
        private System.Windows.Forms.Button btn_GuardarTorneo;
        private System.Windows.Forms.TextBox txt_IdPrograma;
        private System.Windows.Forms.Button btn_SalirPresentacion;
        private System.Windows.Forms.DataGridView dgvProgramacion;
        private System.Windows.Forms.Label lbl_FechaPrograma;
        private System.Windows.Forms.Label lbl_HoraPrograma;
        private System.Windows.Forms.Label lbl_UbicacionPrograma;
        private System.Windows.Forms.Label lbl_IdPrograma;
    }
}