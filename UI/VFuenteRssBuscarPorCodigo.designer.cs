﻿namespace UI
{
    partial class VFuenteRssBuscarPorCodigo
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
            this.SuspendLayout();
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // VFuenteRssBuscarPorCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 51);
            this.Name = "VFuenteRssBuscarPorCodigo";
            this.Text = "Buscar Fuente Rss por Código";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}