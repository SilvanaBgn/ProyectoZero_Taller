namespace UI
{
    partial class PruebaGaleria
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
            this.galeria1 = new UI.UserControls.Galeria();
            this.SuspendLayout();
            // 
            // galeria1
            // 
            this.galeria1.Location = new System.Drawing.Point(13, 13);
            this.galeria1.Name = "galeria1";
            this.galeria1.Size = new System.Drawing.Size(560, 223);
            this.galeria1.TabIndex = 0;
            // 
            // PruebaGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 344);
            this.Controls.Add(this.galeria1);
            this.Name = "PruebaGaleria";
            this.Text = "PruebaGaleria";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Galeria galeria1;
    }
}