﻿namespace UI.NuevasPantallas
{
    partial class VAbstractBase
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
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxRangoFechas = new System.Windows.Forms.CheckBox();
            this.checkBoxRangoHoras = new System.Windows.Forms.CheckBox();
            this.checkBoxDescripcion = new System.Windows.Forms.CheckBox();
            this.dataGridViewMostrar = new System.Windows.Forms.DataGridView();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.checkBoxTitulo = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(13, 13);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 0;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(118, 13);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(231, 13);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por:";
            // 
            // checkBoxRangoFechas
            // 
            this.checkBoxRangoFechas.AutoSize = true;
            this.checkBoxRangoFechas.Location = new System.Drawing.Point(12, 92);
            this.checkBoxRangoFechas.Name = "checkBoxRangoFechas";
            this.checkBoxRangoFechas.Size = new System.Drawing.Size(108, 17);
            this.checkBoxRangoFechas.TabIndex = 4;
            this.checkBoxRangoFechas.Text = "Rango de fechas";
            this.checkBoxRangoFechas.UseVisualStyleBackColor = true;
            // 
            // checkBoxRangoHoras
            // 
            this.checkBoxRangoHoras.AutoSize = true;
            this.checkBoxRangoHoras.Location = new System.Drawing.Point(13, 217);
            this.checkBoxRangoHoras.Name = "checkBoxRangoHoras";
            this.checkBoxRangoHoras.Size = new System.Drawing.Size(102, 17);
            this.checkBoxRangoHoras.TabIndex = 5;
            this.checkBoxRangoHoras.Text = "Rango de horas";
            this.checkBoxRangoHoras.UseVisualStyleBackColor = true;
            // 
            // checkBoxDescripcion
            // 
            this.checkBoxDescripcion.AutoSize = true;
            this.checkBoxDescripcion.Location = new System.Drawing.Point(14, 351);
            this.checkBoxDescripcion.Name = "checkBoxDescripcion";
            this.checkBoxDescripcion.Size = new System.Drawing.Size(82, 17);
            this.checkBoxDescripcion.TabIndex = 6;
            this.checkBoxDescripcion.Text = "Descripcion";
            this.checkBoxDescripcion.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMostrar
            // 
            this.dataGridViewMostrar.AllowUserToAddRows = false;
            this.dataGridViewMostrar.AllowUserToDeleteRows = false;
            this.dataGridViewMostrar.AllowUserToOrderColumns = true;
            this.dataGridViewMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrar.Location = new System.Drawing.Point(281, 69);
            this.dataGridViewMostrar.Name = "dataGridViewMostrar";
            this.dataGridViewMostrar.ReadOnly = true;
            this.dataGridViewMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMostrar.Size = new System.Drawing.Size(363, 234);
            this.dataGridViewMostrar.TabIndex = 7;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.AcceptsTab = true;
            this.textBoxDescripcion.Enabled = false;
            this.textBoxDescripcion.Location = new System.Drawing.Point(14, 374);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescripcion.TabIndex = 10;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(569, 418);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 11;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(12, 471);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 14;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // checkBoxTitulo
            // 
            this.checkBoxTitulo.AutoSize = true;
            this.checkBoxTitulo.Location = new System.Drawing.Point(14, 399);
            this.checkBoxTitulo.Name = "checkBoxTitulo";
            this.checkBoxTitulo.Size = new System.Drawing.Size(52, 17);
            this.checkBoxTitulo.TabIndex = 15;
            this.checkBoxTitulo.Text = "Titulo";
            this.checkBoxTitulo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 422);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // VAbstractBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 506);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxTitulo);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.dataGridViewMostrar);
            this.Controls.Add(this.checkBoxDescripcion);
            this.Controls.Add(this.checkBoxRangoHoras);
            this.Controls.Add(this.checkBoxRangoFechas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonNuevo);
            this.Name = "VAbstractBase";
            this.Text = "VAbstractBase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button buttonNuevo;
        protected System.Windows.Forms.Button buttonModificar;
        protected System.Windows.Forms.Button buttonEliminar;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.CheckBox checkBoxRangoFechas;
        protected System.Windows.Forms.CheckBox checkBoxRangoHoras;
        protected System.Windows.Forms.CheckBox checkBoxDescripcion;
        protected System.Windows.Forms.DataGridView dataGridViewMostrar;
        protected System.Windows.Forms.TextBox textBoxDescripcion;
        protected System.Windows.Forms.Button buttonSalir;
        protected System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.CheckBox checkBoxTitulo;
        private System.Windows.Forms.TextBox textBox1;
    }
}