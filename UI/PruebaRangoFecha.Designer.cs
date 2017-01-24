namespace UI
{
    partial class PruebaRangoFecha
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
            this.rangoFecha1 = new UI.RangoFecha();
            this.SuspendLayout();
            // 
            // rangoFecha1
            // 
            this.rangoFecha1.Location = new System.Drawing.Point(5, 26);
            this.rangoFecha1.Name = "rangoFecha1";
            this.rangoFecha1.Size = new System.Drawing.Size(267, 111);
            this.rangoFecha1.TabIndex = 0;
            // 
            // PruebaRangoFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.rangoFecha1);
            this.Name = "PruebaRangoFecha";
            this.Text = "PruebaRangoFecha";
            this.ResumeLayout(false);

        }

        #endregion

        private RangoFecha rangoFecha1;
    }
}