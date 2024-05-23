namespace Proyecto_Final_BD.Presentacion
{
    partial class FRM_Torneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Torneo));
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_FechaFinal_Torneo = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaInicioTorneo = new System.Windows.Forms.DateTimePicker();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.cboBox_Categoria_Torneo = new System.Windows.Forms.ComboBox();
            this.lbl_FechaFinal_Torneo = new System.Windows.Forms.Label();
            this.txt_Idtorneo = new System.Windows.Forms.TextBox();
            this.lbl_Idtorneo = new System.Windows.Forms.Label();
            this.txt_ReglasEspecificas = new System.Windows.Forms.TextBox();
            this.lbl_Reglas = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_LimpiarTorneo = new System.Windows.Forms.Button();
            this.btn_GuardarTorneo = new System.Windows.Forms.Button();
            this.txt_NombreTorneo = new System.Windows.Forms.TextBox();
            this.txt_UbicacionTorneo = new System.Windows.Forms.TextBox();
            this.btn_SalirPresentacion = new System.Windows.Forms.Button();
            this.dgvTorneo = new System.Windows.Forms.DataGridView();
            this.lbl_NombreTorneo = new System.Windows.Forms.Label();
            this.lbl_FechaInicio = new System.Windows.Forms.Label();
            this.lbl_UbicacionTorneo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTorneo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 28);
            this.label1.TabIndex = 63;
            this.label1.Text = "R E G I S T R O   T O R N E O S";
            // 
            // dtp_FechaFinal_Torneo
            // 
            this.dtp_FechaFinal_Torneo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaFinal_Torneo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaFinal_Torneo.Location = new System.Drawing.Point(215, 289);
            this.dtp_FechaFinal_Torneo.Name = "dtp_FechaFinal_Torneo";
            this.dtp_FechaFinal_Torneo.Size = new System.Drawing.Size(197, 35);
            this.dtp_FechaFinal_Torneo.TabIndex = 62;
            // 
            // dtp_FechaInicioTorneo
            // 
            this.dtp_FechaInicioTorneo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaInicioTorneo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaInicioTorneo.Location = new System.Drawing.Point(215, 197);
            this.dtp_FechaInicioTorneo.Name = "dtp_FechaInicioTorneo";
            this.dtp_FechaInicioTorneo.Size = new System.Drawing.Size(197, 35);
            this.dtp_FechaInicioTorneo.TabIndex = 61;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Categoria.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria.Location = new System.Drawing.Point(27, 496);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(138, 26);
            this.lbl_Categoria.TabIndex = 60;
            this.lbl_Categoria.Text = "Categoría";
            this.lbl_Categoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboBox_Categoria_Torneo
            // 
            this.cboBox_Categoria_Torneo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBox_Categoria_Torneo.FormattingEnabled = true;
            this.cboBox_Categoria_Torneo.Location = new System.Drawing.Point(215, 499);
            this.cboBox_Categoria_Torneo.Name = "cboBox_Categoria_Torneo";
            this.cboBox_Categoria_Torneo.Size = new System.Drawing.Size(197, 32);
            this.cboBox_Categoria_Torneo.TabIndex = 59;
            // 
            // lbl_FechaFinal_Torneo
            // 
            this.lbl_FechaFinal_Torneo.AutoSize = true;
            this.lbl_FechaFinal_Torneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_FechaFinal_Torneo.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaFinal_Torneo.Location = new System.Drawing.Point(29, 289);
            this.lbl_FechaFinal_Torneo.Name = "lbl_FechaFinal_Torneo";
            this.lbl_FechaFinal_Torneo.Size = new System.Drawing.Size(166, 26);
            this.lbl_FechaFinal_Torneo.TabIndex = 58;
            this.lbl_FechaFinal_Torneo.Text = "Fecha Final";
            this.lbl_FechaFinal_Torneo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Idtorneo
            // 
            this.txt_Idtorneo.BackColor = System.Drawing.Color.Snow;
            this.txt_Idtorneo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Idtorneo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Idtorneo.Location = new System.Drawing.Point(215, 78);
            this.txt_Idtorneo.Name = "txt_Idtorneo";
            this.txt_Idtorneo.Size = new System.Drawing.Size(42, 35);
            this.txt_Idtorneo.TabIndex = 57;
            this.txt_Idtorneo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Idtorneo
            // 
            this.lbl_Idtorneo.AutoSize = true;
            this.lbl_Idtorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Idtorneo.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idtorneo.Location = new System.Drawing.Point(29, 88);
            this.lbl_Idtorneo.Name = "lbl_Idtorneo";
            this.lbl_Idtorneo.Size = new System.Drawing.Size(40, 26);
            this.lbl_Idtorneo.TabIndex = 56;
            this.lbl_Idtorneo.Text = "ID";
            this.lbl_Idtorneo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_ReglasEspecificas
            // 
            this.txt_ReglasEspecificas.BackColor = System.Drawing.Color.Snow;
            this.txt_ReglasEspecificas.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReglasEspecificas.Location = new System.Drawing.Point(215, 434);
            this.txt_ReglasEspecificas.Name = "txt_ReglasEspecificas";
            this.txt_ReglasEspecificas.Size = new System.Drawing.Size(197, 35);
            this.txt_ReglasEspecificas.TabIndex = 46;
            this.txt_ReglasEspecificas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Reglas
            // 
            this.lbl_Reglas.AutoSize = true;
            this.lbl_Reglas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Reglas.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reglas.Location = new System.Drawing.Point(29, 430);
            this.lbl_Reglas.Name = "lbl_Reglas";
            this.lbl_Reglas.Size = new System.Drawing.Size(96, 26);
            this.lbl_Reglas.TabIndex = 55;
            this.lbl_Reglas.Text = "Reglas";
            this.lbl_Reglas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(270, 573);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 46);
            this.button3.TabIndex = 54;
            this.button3.Text = "Eliminar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_LimpiarTorneo
            // 
            this.btn_LimpiarTorneo.BackColor = System.Drawing.Color.DarkGray;
            this.btn_LimpiarTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LimpiarTorneo.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LimpiarTorneo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_LimpiarTorneo.Image = ((System.Drawing.Image)(resources.GetObject("btn_LimpiarTorneo.Image")));
            this.btn_LimpiarTorneo.Location = new System.Drawing.Point(496, 573);
            this.btn_LimpiarTorneo.Name = "btn_LimpiarTorneo";
            this.btn_LimpiarTorneo.Size = new System.Drawing.Size(177, 46);
            this.btn_LimpiarTorneo.TabIndex = 53;
            this.btn_LimpiarTorneo.Text = "Limpiar";
            this.btn_LimpiarTorneo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_LimpiarTorneo.UseVisualStyleBackColor = false;
            this.btn_LimpiarTorneo.Click += new System.EventHandler(this.btn_LimpiarTorneo_Click);
            // 
            // btn_GuardarTorneo
            // 
            this.btn_GuardarTorneo.BackColor = System.Drawing.Color.DarkGray;
            this.btn_GuardarTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarTorneo.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarTorneo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_GuardarTorneo.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarTorneo.Image")));
            this.btn_GuardarTorneo.Location = new System.Drawing.Point(27, 573);
            this.btn_GuardarTorneo.Name = "btn_GuardarTorneo";
            this.btn_GuardarTorneo.Size = new System.Drawing.Size(177, 46);
            this.btn_GuardarTorneo.TabIndex = 52;
            this.btn_GuardarTorneo.Text = "Guardar";
            this.btn_GuardarTorneo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarTorneo.UseVisualStyleBackColor = false;
            this.btn_GuardarTorneo.Click += new System.EventHandler(this.btn_GuardarTorneo_Click);
            // 
            // txt_NombreTorneo
            // 
            this.txt_NombreTorneo.BackColor = System.Drawing.Color.Snow;
            this.txt_NombreTorneo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreTorneo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_NombreTorneo.Location = new System.Drawing.Point(215, 132);
            this.txt_NombreTorneo.Name = "txt_NombreTorneo";
            this.txt_NombreTorneo.Size = new System.Drawing.Size(197, 35);
            this.txt_NombreTorneo.TabIndex = 44;
            this.txt_NombreTorneo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_UbicacionTorneo
            // 
            this.txt_UbicacionTorneo.BackColor = System.Drawing.Color.Snow;
            this.txt_UbicacionTorneo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UbicacionTorneo.Location = new System.Drawing.Point(215, 366);
            this.txt_UbicacionTorneo.Name = "txt_UbicacionTorneo";
            this.txt_UbicacionTorneo.Size = new System.Drawing.Size(197, 35);
            this.txt_UbicacionTorneo.TabIndex = 45;
            this.txt_UbicacionTorneo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_SalirPresentacion
            // 
            this.btn_SalirPresentacion.BackColor = System.Drawing.Color.DarkGray;
            this.btn_SalirPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirPresentacion.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirPresentacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SalirPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalirPresentacion.Image")));
            this.btn_SalirPresentacion.Location = new System.Drawing.Point(713, 573);
            this.btn_SalirPresentacion.Name = "btn_SalirPresentacion";
            this.btn_SalirPresentacion.Size = new System.Drawing.Size(177, 46);
            this.btn_SalirPresentacion.TabIndex = 51;
            this.btn_SalirPresentacion.Text = "Salir";
            this.btn_SalirPresentacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SalirPresentacion.UseVisualStyleBackColor = false;
            this.btn_SalirPresentacion.Click += new System.EventHandler(this.btn_SalirPresentacion_Click);
            // 
            // dgvTorneo
            // 
            this.dgvTorneo.AllowUserToAddRows = false;
            this.dgvTorneo.AllowUserToDeleteRows = false;
            this.dgvTorneo.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvTorneo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTorneo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTorneo.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvTorneo.Location = new System.Drawing.Point(436, 93);
            this.dgvTorneo.Name = "dgvTorneo";
            this.dgvTorneo.ReadOnly = true;
            this.dgvTorneo.RowHeadersWidth = 62;
            this.dgvTorneo.RowTemplate.Height = 28;
            this.dgvTorneo.Size = new System.Drawing.Size(1510, 439);
            this.dgvTorneo.TabIndex = 50;
            this.dgvTorneo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTorneo_CellClick);
            // 
            // lbl_NombreTorneo
            // 
            this.lbl_NombreTorneo.AutoSize = true;
            this.lbl_NombreTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_NombreTorneo.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreTorneo.Location = new System.Drawing.Point(29, 129);
            this.lbl_NombreTorneo.Name = "lbl_NombreTorneo";
            this.lbl_NombreTorneo.Size = new System.Drawing.Size(96, 26);
            this.lbl_NombreTorneo.TabIndex = 49;
            this.lbl_NombreTorneo.Text = "Nombre";
            this.lbl_NombreTorneo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_FechaInicio
            // 
            this.lbl_FechaInicio.AutoSize = true;
            this.lbl_FechaInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_FechaInicio.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaInicio.Location = new System.Drawing.Point(29, 197);
            this.lbl_FechaInicio.Name = "lbl_FechaInicio";
            this.lbl_FechaInicio.Size = new System.Drawing.Size(180, 26);
            this.lbl_FechaInicio.TabIndex = 48;
            this.lbl_FechaInicio.Text = "Fecha Inicio";
            this.lbl_FechaInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_UbicacionTorneo
            // 
            this.lbl_UbicacionTorneo.AutoSize = true;
            this.lbl_UbicacionTorneo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_UbicacionTorneo.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UbicacionTorneo.Location = new System.Drawing.Point(27, 362);
            this.lbl_UbicacionTorneo.Name = "lbl_UbicacionTorneo";
            this.lbl_UbicacionTorneo.Size = new System.Drawing.Size(138, 26);
            this.lbl_UbicacionTorneo.TabIndex = 47;
            this.lbl_UbicacionTorneo.Text = "Ubicación";
            this.lbl_UbicacionTorneo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRM_Torneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_FechaFinal_Torneo);
            this.Controls.Add(this.dtp_FechaInicioTorneo);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.cboBox_Categoria_Torneo);
            this.Controls.Add(this.lbl_FechaFinal_Torneo);
            this.Controls.Add(this.txt_Idtorneo);
            this.Controls.Add(this.lbl_Idtorneo);
            this.Controls.Add(this.txt_ReglasEspecificas);
            this.Controls.Add(this.lbl_Reglas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_LimpiarTorneo);
            this.Controls.Add(this.btn_GuardarTorneo);
            this.Controls.Add(this.txt_NombreTorneo);
            this.Controls.Add(this.txt_UbicacionTorneo);
            this.Controls.Add(this.btn_SalirPresentacion);
            this.Controls.Add(this.dgvTorneo);
            this.Controls.Add(this.lbl_NombreTorneo);
            this.Controls.Add(this.lbl_FechaInicio);
            this.Controls.Add(this.lbl_UbicacionTorneo);
            this.Name = "FRM_Torneo";
            this.Text = "FRM_Torneo";
            this.Load += new System.EventHandler(this.FRM_Torneo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTorneo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_FechaFinal_Torneo;
        private System.Windows.Forms.DateTimePicker dtp_FechaInicioTorneo;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.ComboBox cboBox_Categoria_Torneo;
        private System.Windows.Forms.Label lbl_FechaFinal_Torneo;
        private System.Windows.Forms.TextBox txt_Idtorneo;
        private System.Windows.Forms.Label lbl_Idtorneo;
        private System.Windows.Forms.TextBox txt_ReglasEspecificas;
        private System.Windows.Forms.Label lbl_Reglas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_LimpiarTorneo;
        private System.Windows.Forms.Button btn_GuardarTorneo;
        private System.Windows.Forms.TextBox txt_NombreTorneo;
        private System.Windows.Forms.TextBox txt_UbicacionTorneo;
        private System.Windows.Forms.Button btn_SalirPresentacion;
        private System.Windows.Forms.DataGridView dgvTorneo;
        private System.Windows.Forms.Label lbl_NombreTorneo;
        private System.Windows.Forms.Label lbl_FechaInicio;
        private System.Windows.Forms.Label lbl_UbicacionTorneo;
    }
}