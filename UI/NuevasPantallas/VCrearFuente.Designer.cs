namespace UI.NuevasPantallas
{
    partial class VCrearFuente
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
            this.panelRss.SuspendLayout();
            this.panelTextoFijo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTextoFijo
            // 
            this.panelTextoFijo.Location = new System.Drawing.Point(26, 29);
            // 
            // bgwActualizarRssAlGuardar
            // 
            this.bgwActualizarRssAlGuardar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwActualizarRssAlGuardar_DoWork);
            this.bgwActualizarRssAlGuardar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwActualizarRssAlGuardar_RunWorkerCompleted);
            // 
            // VCrearFuente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 316);
            this.Name = "VCrearFuente";
            this.Text = "VCrearFuente";
            this.panelRss.ResumeLayout(false);
            this.panelRss.PerformLayout();
            this.panelTextoFijo.ResumeLayout(false);
            this.panelTextoFijo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}