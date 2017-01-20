namespace UI
{
    partial class PruebaCampaniaDeslizante
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
            this.buttonComenzar = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.campaniaDeslizante1 = new UI.CampaniaDeslizante();
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonComenzar
            // 
            this.buttonComenzar.Location = new System.Drawing.Point(98, 298);
            this.buttonComenzar.Name = "buttonComenzar";
            this.buttonComenzar.Size = new System.Drawing.Size(75, 23);
            this.buttonComenzar.TabIndex = 1;
            this.buttonComenzar.Text = "Comenzar";
            this.buttonComenzar.UseVisualStyleBackColor = true;
            this.buttonComenzar.Click += new System.EventHandler(this.buttonComenzar_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(206, 298);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Parar";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // campaniaDeslizante1
            // 
            this.campaniaDeslizante1.Campania = null;
            this.campaniaDeslizante1.Location = new System.Drawing.Point(36, 12);
            this.campaniaDeslizante1.Name = "campaniaDeslizante1";
            this.campaniaDeslizante1.Size = new System.Drawing.Size(330, 260);
            this.campaniaDeslizante1.TabIndex = 3;
            this.campaniaDeslizante1.TabStop = false;
            // 
            // PruebaCampaniaDeslizante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 344);
            this.Controls.Add(this.campaniaDeslizante1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonComenzar);
            this.Name = "PruebaCampaniaDeslizante";
            this.Text = "PruebaBannerDeslizante";
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonComenzar;
        private System.Windows.Forms.Button buttonStop;
        private CampaniaDeslizante campaniaDeslizante1;
    }
}