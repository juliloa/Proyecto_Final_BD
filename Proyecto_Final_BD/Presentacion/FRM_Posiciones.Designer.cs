namespace Proyecto_Final_BD.Presentacion
{
    partial class FRM_Posiciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Posiciones));
            this.btn_GuardarPosiciones = new System.Windows.Forms.Button();
            this.dgv_Posiciones = new System.Windows.Forms.DataGridView();
            this.text_Encuentros = new System.Windows.Forms.TextBox();
            this.text_Victorias = new System.Windows.Forms.TextBox();
            this.txt_Derrotas = new System.Windows.Forms.TextBox();
            this.txt_Empates = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SalirPresentacion = new System.Windows.Forms.Button();
            this.txt_id_Posicion = new System.Windows.Forms.TextBox();
            this.Cbo_cargar_Equipos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Posiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GuardarPosiciones
            // 
            this.btn_GuardarPosiciones.BackColor = System.Drawing.Color.DarkGray;
            this.btn_GuardarPosiciones.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_GuardarPosiciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarPosiciones.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarPosiciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_GuardarPosiciones.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarPosiciones.Image")));
            this.btn_GuardarPosiciones.Location = new System.Drawing.Point(60, 508);
            this.btn_GuardarPosiciones.Name = "btn_GuardarPosiciones";
            this.btn_GuardarPosiciones.Size = new System.Drawing.Size(177, 46);
            this.btn_GuardarPosiciones.TabIndex = 123;
            this.btn_GuardarPosiciones.Text = "Guardar";
            this.btn_GuardarPosiciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarPosiciones.UseVisualStyleBackColor = false;
            // 
            // dgv_Posiciones
            // 
            this.dgv_Posiciones.AllowUserToAddRows = false;
            this.dgv_Posiciones.AllowUserToDeleteRows = false;
            this.dgv_Posiciones.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgv_Posiciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Posiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Posiciones.Location = new System.Drawing.Point(386, 65);
            this.dgv_Posiciones.Name = "dgv_Posiciones";
            this.dgv_Posiciones.ReadOnly = true;
            this.dgv_Posiciones.RowHeadersWidth = 62;
            this.dgv_Posiciones.RowTemplate.Height = 28;
            this.dgv_Posiciones.Size = new System.Drawing.Size(826, 385);
            this.dgv_Posiciones.TabIndex = 122;
            // 
            // text_Encuentros
            // 
            this.text_Encuentros.BackColor = System.Drawing.Color.Snow;
            this.text_Encuentros.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Encuentros.ForeColor = System.Drawing.SystemColors.InfoText;
            this.text_Encuentros.Location = new System.Drawing.Point(209, 169);
            this.text_Encuentros.Name = "text_Encuentros";
            this.text_Encuentros.Size = new System.Drawing.Size(61, 30);
            this.text_Encuentros.TabIndex = 121;
            // 
            // text_Victorias
            // 
            this.text_Victorias.BackColor = System.Drawing.Color.Snow;
            this.text_Victorias.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Victorias.ForeColor = System.Drawing.SystemColors.InfoText;
            this.text_Victorias.Location = new System.Drawing.Point(209, 222);
            this.text_Victorias.Name = "text_Victorias";
            this.text_Victorias.Size = new System.Drawing.Size(61, 30);
            this.text_Victorias.TabIndex = 120;
            // 
            // txt_Derrotas
            // 
            this.txt_Derrotas.BackColor = System.Drawing.Color.Snow;
            this.txt_Derrotas.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Derrotas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_Derrotas.Location = new System.Drawing.Point(209, 271);
            this.txt_Derrotas.Name = "txt_Derrotas";
            this.txt_Derrotas.Size = new System.Drawing.Size(61, 30);
            this.txt_Derrotas.TabIndex = 119;
            // 
            // txt_Empates
            // 
            this.txt_Empates.BackColor = System.Drawing.Color.Snow;
            this.txt_Empates.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Empates.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_Empates.Location = new System.Drawing.Point(209, 319);
            this.txt_Empates.Name = "txt_Empates";
            this.txt_Empates.Size = new System.Drawing.Size(61, 30);
            this.txt_Empates.TabIndex = 118;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 26);
            this.label7.TabIndex = 117;
            this.label7.Text = "ENCUENTROS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 116;
            this.label6.Text = "VICTORIAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 115;
            this.label5.Text = "DERROTAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 114;
            this.label4.Text = "EMPATES";
            // 
            // btn_SalirPresentacion
            // 
            this.btn_SalirPresentacion.BackColor = System.Drawing.Color.DarkGray;
            this.btn_SalirPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirPresentacion.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirPresentacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SalirPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalirPresentacion.Image")));
            this.btn_SalirPresentacion.Location = new System.Drawing.Point(277, 508);
            this.btn_SalirPresentacion.Name = "btn_SalirPresentacion";
            this.btn_SalirPresentacion.Size = new System.Drawing.Size(177, 46);
            this.btn_SalirPresentacion.TabIndex = 113;
            this.btn_SalirPresentacion.Text = "Salir";
            this.btn_SalirPresentacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SalirPresentacion.UseVisualStyleBackColor = false;
            // 
            // txt_id_Posicion
            // 
            this.txt_id_Posicion.BackColor = System.Drawing.Color.Snow;
            this.txt_id_Posicion.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_Posicion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_id_Posicion.Location = new System.Drawing.Point(209, 65);
            this.txt_id_Posicion.Name = "txt_id_Posicion";
            this.txt_id_Posicion.Size = new System.Drawing.Size(61, 30);
            this.txt_id_Posicion.TabIndex = 112;
            // 
            // Cbo_cargar_Equipos
            // 
            this.Cbo_cargar_Equipos.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_cargar_Equipos.FormattingEnabled = true;
            this.Cbo_cargar_Equipos.Location = new System.Drawing.Point(209, 121);
            this.Cbo_cargar_Equipos.Name = "Cbo_cargar_Equipos";
            this.Cbo_cargar_Equipos.Size = new System.Drawing.Size(159, 28);
            this.Cbo_cargar_Equipos.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 26);
            this.label2.TabIndex = 110;
            this.label2.Text = "EQUIPO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 26);
            this.label1.TabIndex = 109;
            this.label1.Text = "ID";
            // 
            // FRM_Posiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 793);
            this.Controls.Add(this.btn_GuardarPosiciones);
            this.Controls.Add(this.dgv_Posiciones);
            this.Controls.Add(this.text_Encuentros);
            this.Controls.Add(this.text_Victorias);
            this.Controls.Add(this.txt_Derrotas);
            this.Controls.Add(this.txt_Empates);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_SalirPresentacion);
            this.Controls.Add(this.txt_id_Posicion);
            this.Controls.Add(this.Cbo_cargar_Equipos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_Posiciones";
            this.Text = "FRM_Posiciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Posiciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GuardarPosiciones;
        private System.Windows.Forms.DataGridView dgv_Posiciones;
        private System.Windows.Forms.TextBox text_Encuentros;
        private System.Windows.Forms.TextBox text_Victorias;
        private System.Windows.Forms.TextBox txt_Derrotas;
        private System.Windows.Forms.TextBox txt_Empates;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SalirPresentacion;
        private System.Windows.Forms.TextBox txt_id_Posicion;
        private System.Windows.Forms.ComboBox Cbo_cargar_Equipos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}