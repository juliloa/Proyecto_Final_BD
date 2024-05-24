namespace Proyecto_Final_BD.Presentacion
{
    partial class FRM_Resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Resultados));
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Id_Torneo = new System.Windows.Forms.ComboBox();
            this.lbl_Equipo_Visitante = new System.Windows.Forms.Label();
            this.lbl_Equipo_Local = new System.Windows.Forms.Label();
            this.nud_Marcador_Visitante = new System.Windows.Forms.NumericUpDown();
            this.nup_Marcador_Local = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Torneo = new System.Windows.Forms.Label();
            this.Evento_Destacado = new System.Windows.Forms.Label();
            this.Marcador = new System.Windows.Forms.Label();
            this.EquipoVisitante = new System.Windows.Forms.Label();
            this.EquipoLocal = new System.Windows.Forms.Label();
            this.IdResultado = new System.Windows.Forms.Label();
            this.Cbo_id_Programacion = new System.Windows.Forms.ComboBox();
            this.btnLimpiarResultados = new System.Windows.Forms.Button();
            this.btnEliminarResultados = new System.Windows.Forms.Button();
            this.btn_GuardarResultados = new System.Windows.Forms.Button();
            this.btn_SalirPresentacion = new System.Windows.Forms.Button();
            this.txt_Evento_Destacado = new System.Windows.Forms.TextBox();
            this.Dgv_Resultados = new System.Windows.Forms.DataGridView();
            this.txt_id_Resultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Marcador_Visitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Marcador_Local)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 26);
            this.label2.TabIndex = 155;
            this.label2.Text = "ID Torneo";
            // 
            // cbo_Id_Torneo
            // 
            this.cbo_Id_Torneo.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Id_Torneo.FormattingEnabled = true;
            this.cbo_Id_Torneo.Location = new System.Drawing.Point(289, 151);
            this.cbo_Id_Torneo.Name = "cbo_Id_Torneo";
            this.cbo_Id_Torneo.Size = new System.Drawing.Size(196, 32);
            this.cbo_Id_Torneo.TabIndex = 156;
            this.cbo_Id_Torneo.SelectedIndexChanged += new System.EventHandler(this.cbo_Id_Torneo_SelectedIndexChanged);
            // 
            // lbl_Equipo_Visitante
            // 
            this.lbl_Equipo_Visitante.AutoSize = true;
            this.lbl_Equipo_Visitante.Location = new System.Drawing.Point(344, 373);
            this.lbl_Equipo_Visitante.Name = "lbl_Equipo_Visitante";
            this.lbl_Equipo_Visitante.Size = new System.Drawing.Size(35, 20);
            this.lbl_Equipo_Visitante.TabIndex = 154;
            this.lbl_Equipo_Visitante.Text = "E.V";
            // 
            // lbl_Equipo_Local
            // 
            this.lbl_Equipo_Local.AutoSize = true;
            this.lbl_Equipo_Local.Location = new System.Drawing.Point(54, 373);
            this.lbl_Equipo_Local.Name = "lbl_Equipo_Local";
            this.lbl_Equipo_Local.Size = new System.Drawing.Size(33, 20);
            this.lbl_Equipo_Local.TabIndex = 153;
            this.lbl_Equipo_Local.Text = "E.L";
            // 
            // nud_Marcador_Visitante
            // 
            this.nud_Marcador_Visitante.Location = new System.Drawing.Point(304, 429);
            this.nud_Marcador_Visitante.Name = "nud_Marcador_Visitante";
            this.nud_Marcador_Visitante.Size = new System.Drawing.Size(120, 26);
            this.nud_Marcador_Visitante.TabIndex = 152;
            // 
            // nup_Marcador_Local
            // 
            this.nup_Marcador_Local.Location = new System.Drawing.Point(58, 429);
            this.nup_Marcador_Local.Name = "nup_Marcador_Local";
            this.nup_Marcador_Local.Size = new System.Drawing.Size(120, 26);
            this.nup_Marcador_Local.TabIndex = 151;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 28);
            this.label1.TabIndex = 150;
            this.label1.Text = "R E G I S T R O   R E S U L T A D O S\r\n";
            // 
            // Id_Torneo
            // 
            this.Id_Torneo.AutoSize = true;
            this.Id_Torneo.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Torneo.Location = new System.Drawing.Point(25, 236);
            this.Id_Torneo.Name = "Id_Torneo";
            this.Id_Torneo.Size = new System.Drawing.Size(222, 26);
            this.Id_Torneo.TabIndex = 148;
            this.Id_Torneo.Text = "ID Programacion";
            // 
            // Evento_Destacado
            // 
            this.Evento_Destacado.AutoSize = true;
            this.Evento_Destacado.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Evento_Destacado.Location = new System.Drawing.Point(17, 584);
            this.Evento_Destacado.Name = "Evento_Destacado";
            this.Evento_Destacado.Size = new System.Drawing.Size(236, 26);
            this.Evento_Destacado.TabIndex = 143;
            this.Evento_Destacado.Text = "Evento Destacado";
            // 
            // Marcador
            // 
            this.Marcador.AutoSize = true;
            this.Marcador.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marcador.Location = new System.Drawing.Point(178, 472);
            this.Marcador.Name = "Marcador";
            this.Marcador.Size = new System.Drawing.Size(124, 26);
            this.Marcador.TabIndex = 142;
            this.Marcador.Text = "Marcador";
            // 
            // EquipoVisitante
            // 
            this.EquipoVisitante.AutoSize = true;
            this.EquipoVisitante.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipoVisitante.Location = new System.Drawing.Point(250, 318);
            this.EquipoVisitante.Name = "EquipoVisitante";
            this.EquipoVisitante.Size = new System.Drawing.Size(236, 26);
            this.EquipoVisitante.TabIndex = 141;
            this.EquipoVisitante.Text = "Equipo Visitante";
            // 
            // EquipoLocal
            // 
            this.EquipoLocal.AutoSize = true;
            this.EquipoLocal.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipoLocal.Location = new System.Drawing.Point(17, 318);
            this.EquipoLocal.Name = "EquipoLocal";
            this.EquipoLocal.Size = new System.Drawing.Size(180, 26);
            this.EquipoLocal.TabIndex = 140;
            this.EquipoLocal.Text = "Equipo Local";
            // 
            // IdResultado
            // 
            this.IdResultado.AutoSize = true;
            this.IdResultado.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdResultado.Location = new System.Drawing.Point(25, 79);
            this.IdResultado.Name = "IdResultado";
            this.IdResultado.Size = new System.Drawing.Size(180, 26);
            this.IdResultado.TabIndex = 137;
            this.IdResultado.Text = "ID Resultado";
            // 
            // Cbo_id_Programacion
            // 
            this.Cbo_id_Programacion.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_id_Programacion.FormattingEnabled = true;
            this.Cbo_id_Programacion.Location = new System.Drawing.Point(289, 234);
            this.Cbo_id_Programacion.Name = "Cbo_id_Programacion";
            this.Cbo_id_Programacion.Size = new System.Drawing.Size(196, 32);
            this.Cbo_id_Programacion.TabIndex = 149;
            
            // 
            // btnLimpiarResultados
            // 
            this.btnLimpiarResultados.BackColor = System.Drawing.Color.DarkGray;
            this.btnLimpiarResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarResultados.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarResultados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiarResultados.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarResultados.Image")));
            this.btnLimpiarResultados.Location = new System.Drawing.Point(289, 652);
            this.btnLimpiarResultados.Name = "btnLimpiarResultados";
            this.btnLimpiarResultados.Size = new System.Drawing.Size(177, 46);
            this.btnLimpiarResultados.TabIndex = 147;
            this.btnLimpiarResultados.Text = "Limpiar";
            this.btnLimpiarResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiarResultados.UseVisualStyleBackColor = false;
            this.btnLimpiarResultados.Click += new System.EventHandler(this.btnLimpiarResultados_Click);
            // 
            // btnEliminarResultados
            // 
            this.btnEliminarResultados.BackColor = System.Drawing.Color.DarkGray;
            this.btnEliminarResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarResultados.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarResultados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarResultados.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarResultados.Image")));
            this.btnEliminarResultados.Location = new System.Drawing.Point(529, 652);
            this.btnEliminarResultados.Name = "btnEliminarResultados";
            this.btnEliminarResultados.Size = new System.Drawing.Size(177, 46);
            this.btnEliminarResultados.TabIndex = 146;
            this.btnEliminarResultados.Text = "Eliminar";
            this.btnEliminarResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarResultados.UseVisualStyleBackColor = false;
            this.btnEliminarResultados.Click += new System.EventHandler(this.btnEliminarResultados_Click);
            // 
            // btn_GuardarResultados
            // 
            this.btn_GuardarResultados.BackColor = System.Drawing.Color.DarkGray;
            this.btn_GuardarResultados.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_GuardarResultados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarResultados.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarResultados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_GuardarResultados.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarResultados.Image")));
            this.btn_GuardarResultados.Location = new System.Drawing.Point(38, 652);
            this.btn_GuardarResultados.Name = "btn_GuardarResultados";
            this.btn_GuardarResultados.Size = new System.Drawing.Size(177, 46);
            this.btn_GuardarResultados.TabIndex = 145;
            this.btn_GuardarResultados.Text = "Guardar";
            this.btn_GuardarResultados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarResultados.UseVisualStyleBackColor = false;
            this.btn_GuardarResultados.Click += new System.EventHandler(this.btn_GuardarResultados_Click);
            // 
            // btn_SalirPresentacion
            // 
            this.btn_SalirPresentacion.BackColor = System.Drawing.Color.DarkGray;
            this.btn_SalirPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirPresentacion.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirPresentacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SalirPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalirPresentacion.Image")));
            this.btn_SalirPresentacion.Location = new System.Drawing.Point(755, 652);
            this.btn_SalirPresentacion.Name = "btn_SalirPresentacion";
            this.btn_SalirPresentacion.Size = new System.Drawing.Size(177, 46);
            this.btn_SalirPresentacion.TabIndex = 144;
            this.btn_SalirPresentacion.Text = "Salir";
            this.btn_SalirPresentacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SalirPresentacion.UseVisualStyleBackColor = false;
            this.btn_SalirPresentacion.Click += new System.EventHandler(this.btn_SalirPresentacion_Click);
            // 
            // txt_Evento_Destacado
            // 
            this.txt_Evento_Destacado.BackColor = System.Drawing.Color.Snow;
            this.txt_Evento_Destacado.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Evento_Destacado.Location = new System.Drawing.Point(289, 582);
            this.txt_Evento_Destacado.Name = "txt_Evento_Destacado";
            this.txt_Evento_Destacado.Size = new System.Drawing.Size(196, 35);
            this.txt_Evento_Destacado.TabIndex = 136;
            // 
            // Dgv_Resultados
            // 
            this.Dgv_Resultados.BackgroundColor = System.Drawing.Color.LightCyan;
            this.Dgv_Resultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_Resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Resultados.Location = new System.Drawing.Point(507, 69);
            this.Dgv_Resultados.Name = "Dgv_Resultados";
            this.Dgv_Resultados.ReadOnly = true;
            this.Dgv_Resultados.RowHeadersWidth = 62;
            this.Dgv_Resultados.Size = new System.Drawing.Size(1369, 504);
            this.Dgv_Resultados.TabIndex = 139;
            this.Dgv_Resultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Resultados_CellClick);
            // 
            // txt_id_Resultado
            // 
            this.txt_id_Resultado.BackColor = System.Drawing.Color.Snow;
            this.txt_id_Resultado.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_Resultado.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_id_Resultado.Location = new System.Drawing.Point(289, 79);
            this.txt_id_Resultado.Name = "txt_id_Resultado";
            this.txt_id_Resultado.Size = new System.Drawing.Size(61, 35);
            this.txt_id_Resultado.TabIndex = 138;
            // 
            // FRM_Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 733);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_Id_Torneo);
            this.Controls.Add(this.lbl_Equipo_Visitante);
            this.Controls.Add(this.lbl_Equipo_Local);
            this.Controls.Add(this.nud_Marcador_Visitante);
            this.Controls.Add(this.nup_Marcador_Local);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Id_Torneo);
            this.Controls.Add(this.Evento_Destacado);
            this.Controls.Add(this.Marcador);
            this.Controls.Add(this.EquipoVisitante);
            this.Controls.Add(this.EquipoLocal);
            this.Controls.Add(this.IdResultado);
            this.Controls.Add(this.Cbo_id_Programacion);
            this.Controls.Add(this.btnLimpiarResultados);
            this.Controls.Add(this.btnEliminarResultados);
            this.Controls.Add(this.btn_GuardarResultados);
            this.Controls.Add(this.btn_SalirPresentacion);
            this.Controls.Add(this.txt_Evento_Destacado);
            this.Controls.Add(this.Dgv_Resultados);
            this.Controls.Add(this.txt_id_Resultado);
            this.Name = "FRM_Resultados";
            this.Text = "FRM_Resultados";
            this.Load += new System.EventHandler(this.FRM_Resultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Marcador_Visitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Marcador_Local)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Id_Torneo;
        private System.Windows.Forms.Label lbl_Equipo_Visitante;
        private System.Windows.Forms.Label lbl_Equipo_Local;
        private System.Windows.Forms.NumericUpDown nud_Marcador_Visitante;
        private System.Windows.Forms.NumericUpDown nup_Marcador_Local;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Id_Torneo;
        private System.Windows.Forms.Label Evento_Destacado;
        private System.Windows.Forms.Label Marcador;
        private System.Windows.Forms.Label EquipoVisitante;
        private System.Windows.Forms.Label EquipoLocal;
        private System.Windows.Forms.Label IdResultado;
        private System.Windows.Forms.ComboBox Cbo_id_Programacion;
        private System.Windows.Forms.Button btnLimpiarResultados;
        private System.Windows.Forms.Button btnEliminarResultados;
        private System.Windows.Forms.Button btn_GuardarResultados;
        private System.Windows.Forms.Button btn_SalirPresentacion;
        private System.Windows.Forms.TextBox txt_Evento_Destacado;
        private System.Windows.Forms.DataGridView Dgv_Resultados;
        private System.Windows.Forms.TextBox txt_id_Resultado;
    }
}