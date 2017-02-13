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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // galeria1
            // 
            this.galeria1.Location = new System.Drawing.Point(61, 54);
            this.galeria1.Name = "galeria1";
            this.galeria1.Size = new System.Drawing.Size(488, 189);
            this.galeria1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PruebaGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.galeria1);
            this.Name = "PruebaGaleria";
            this.Text = "PruebaGaleria";
            this.ResumeLayout(false);

        }

        private UserControls.Galeria galeria1;
        private System.Windows.Forms.Button button1;

        #endregion

        // private UserControls.Galeria galeria1;
    }
}