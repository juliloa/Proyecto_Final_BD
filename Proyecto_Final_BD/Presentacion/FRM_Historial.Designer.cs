﻿namespace Proyecto_Final_BD.Presentacion
{
    partial class FRM_Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Historial));
            this.dgv_Historial = new System.Windows.Forms.DataGridView();
            this.btn_Cargar_Historial = new System.Windows.Forms.Button();
            this.btn_SalirPresentacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_Historial = new System.Windows.Forms.TextBox();
            this.IdHistorial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Historial
            // 
            this.dgv_Historial.AllowUserToAddRows = false;
            this.dgv_Historial.AllowUserToDeleteRows = false;
            this.dgv_Historial.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgv_Historial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Historial.Location = new System.Drawing.Point(334, 83);
            this.dgv_Historial.Name = "dgv_Historial";
            this.dgv_Historial.ReadOnly = true;
            this.dgv_Historial.RowHeadersWidth = 62;
            this.dgv_Historial.RowTemplate.Height = 28;
            this.dgv_Historial.Size = new System.Drawing.Size(907, 495);
            this.dgv_Historial.TabIndex = 136;
            // 
            // btn_Cargar_Historial
            // 
            this.btn_Cargar_Historial.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Cargar_Historial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cargar_Historial.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cargar_Historial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cargar_Historial.Location = new System.Drawing.Point(334, 603);
            this.btn_Cargar_Historial.Name = "btn_Cargar_Historial";
            this.btn_Cargar_Historial.Size = new System.Drawing.Size(177, 46);
            this.btn_Cargar_Historial.TabIndex = 135;
            this.btn_Cargar_Historial.Text = "Cargar";
            this.btn_Cargar_Historial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cargar_Historial.UseVisualStyleBackColor = false;
            this.btn_Cargar_Historial.Click += new System.EventHandler(this.btn_Cargar_Historial_Click);
            // 
            // btn_SalirPresentacion
            // 
            this.btn_SalirPresentacion.BackColor = System.Drawing.Color.DarkGray;
            this.btn_SalirPresentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalirPresentacion.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalirPresentacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SalirPresentacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_SalirPresentacion.Image")));
            this.btn_SalirPresentacion.Location = new System.Drawing.Point(40, 603);
            this.btn_SalirPresentacion.Name = "btn_SalirPresentacion";
            this.btn_SalirPresentacion.Size = new System.Drawing.Size(177, 46);
            this.btn_SalirPresentacion.TabIndex = 134;
            this.btn_SalirPresentacion.Text = "Salir";
            this.btn_SalirPresentacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SalirPresentacion.UseVisualStyleBackColor = false;
            this.btn_SalirPresentacion.Click += new System.EventHandler(this.btn_SalirPresentacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 56);
            this.label1.TabIndex = 133;
            this.label1.Text = "H I S T O R I A L\r\n\r\n";
            // 
            // txt_id_Historial
            // 
            this.txt_id_Historial.BackColor = System.Drawing.Color.Snow;
            this.txt_id_Historial.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_Historial.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_id_Historial.Location = new System.Drawing.Point(235, 74);
            this.txt_id_Historial.Name = "txt_id_Historial";
            this.txt_id_Historial.Size = new System.Drawing.Size(61, 35);
            this.txt_id_Historial.TabIndex = 132;
            // 
            // IdHistorial
            // 
            this.IdHistorial.AutoSize = true;
            this.IdHistorial.Font = new System.Drawing.Font("SimSun", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdHistorial.Location = new System.Drawing.Point(35, 83);
            this.IdHistorial.Name = "IdHistorial";
            this.IdHistorial.Size = new System.Drawing.Size(180, 26);
            this.IdHistorial.TabIndex = 131;
            this.IdHistorial.Text = "ID Historial";
            // 
            // FRM_Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1662, 759);
            this.Controls.Add(this.dgv_Historial);
            this.Controls.Add(this.btn_Cargar_Historial);
            this.Controls.Add(this.btn_SalirPresentacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id_Historial);
            this.Controls.Add(this.IdHistorial);
            this.Name = "FRM_Historial";
            this.Text = "FRM_Historial";
            this.Load += new System.EventHandler(this.FRM_Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Historial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Historial;
        private System.Windows.Forms.Button btn_Cargar_Historial;
        private System.Windows.Forms.Button btn_SalirPresentacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id_Historial;
        private System.Windows.Forms.Label IdHistorial;
    }
}