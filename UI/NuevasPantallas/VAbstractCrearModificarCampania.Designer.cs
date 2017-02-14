﻿namespace UI.NuevasPantallas
{
    partial class VAbstractCrearModificarCampania
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.rangoFecha = new UI.UserControls.RangoFecha();
            this.rangoHorario = new UI.UserControls.RangoHorario();
            this.galeria = new UI.UserControls.Galeria();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(97, 13);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(213, 20);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(97, 43);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(213, 20);
            this.textBoxDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rango horario";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(154, 300);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(235, 300);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // rangoFecha
            // 
            //this.rangoFecha.FechaFin = new System.DateTime(2017, 2, 7, 0, 0, 0, 0);
            //this.rangoFecha.FechaInicio = new System.DateTime(2017, 2, 7, 0, 0, 0, 0);
            this.rangoFecha.Location = new System.Drawing.Point(16, 113);
            this.rangoFecha.Name = "rangoFecha";
            this.rangoFecha.Size = new System.Drawing.Size(235, 96);
            this.rangoFecha.TabIndex = 8;
            // 
            // rangoHorario
            // 
            this.rangoHorario.HoraFin = System.TimeSpan.Parse("00:15:00");
            this.rangoHorario.HoraInicio = System.TimeSpan.Parse("00:00:00");
            this.rangoHorario.Location = new System.Drawing.Point(258, 113);
            this.rangoHorario.Name = "rangoHorario";
            this.rangoHorario.Size = new System.Drawing.Size(120, 101);
            this.rangoHorario.TabIndex = 9;
            // 
            // galeria
            // 
            this.galeria.Location = new System.Drawing.Point(385, 25);
            this.galeria.Name = "galeria";
            this.galeria.Size = new System.Drawing.Size(488, 189);
            this.galeria.TabIndex = 10;
            // 
            // VAbstractCrearModificarCampania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 335);
            this.Controls.Add(this.galeria);
            this.Controls.Add(this.rangoHorario);
            this.Controls.Add(this.rangoFecha);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VAbstractCrearModificarCampania";
            this.Text = "VAbstractCrearModificarCampania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox textBoxTitulo;
        protected System.Windows.Forms.TextBox textBoxDescripcion;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button buttonGuardar;
        protected System.Windows.Forms.Button buttonCancelar;
        protected UserControls.RangoFecha rangoFecha;
        protected UserControls.RangoHorario rangoHorario;
        protected UserControls.Galeria galeria;
    }
}