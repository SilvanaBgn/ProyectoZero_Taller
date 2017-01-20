namespace UI
{
    partial class VBannerModificar
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
            this.groupBoxHora.SuspendLayout();
            this.groupBoxFecha.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            this.panelTextoPlano.SuspendLayout();
            this.panelFuenteRss.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUp
            // 
            this.buttonUp.FlatAppearance.BorderSize = 0;
            // 
            // buttonDown
            // 
            this.buttonDown.FlatAppearance.BorderSize = 0;
            // 
            // VBannerModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 350);
            this.Name = "VBannerModificar";
            this.Text = "Modificar Banner";
            this.Load += new System.EventHandler(this.VBannerModificar_Load);
            this.groupBoxHora.ResumeLayout(false);
            this.groupBoxHora.PerformLayout();
            this.groupBoxFecha.ResumeLayout(false);
            this.groupBoxFecha.PerformLayout();
            this.groupBoxDatos.ResumeLayout(false);
            this.panelTextoPlano.ResumeLayout(false);
            this.panelTextoPlano.PerformLayout();
            this.panelFuenteRss.ResumeLayout(false);
            this.panelFuenteRss.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}