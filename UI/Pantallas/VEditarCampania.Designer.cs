﻿namespace UI.Pantallas
{
    partial class VEditarCampania
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VEditarCampania));
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // rangoFecha
            // 
            this.rangoFecha.FechaFin = new System.DateTime(2017, 2, 28, 0, 0, 0, 0);
            this.rangoFecha.FechaInicio = new System.DateTime(2017, 2, 28, 0, 0, 0, 0);
            // 
            // VEditarCampania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 466);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VEditarCampania";
            this.Text = "Editar Campaña";
            this.Load += new System.EventHandler(this.VEditarCampania_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}