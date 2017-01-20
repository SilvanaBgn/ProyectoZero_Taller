namespace UI
{
    partial class PruebaBannerDeslizante
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
            this.bannerDeslizante1 = new UI.BannerDeslizante();
            this.buttonComenzar = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.bannerDeslizante2 = new UI.BannerDeslizante();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bannerDeslizante1
            // 
            this.bannerDeslizante1.CaracteresAMostrar = 45;
            this.bannerDeslizante1.Location = new System.Drawing.Point(23, 77);
            this.bannerDeslizante1.Name = "bannerDeslizante1";
            this.bannerDeslizante1.Size = new System.Drawing.Size(236, 20);
            this.bannerDeslizante1.TabIndex = 0;
            this.bannerDeslizante1.TextoCompleto = null;
            // 
            // buttonComenzar
            // 
            this.buttonComenzar.Location = new System.Drawing.Point(49, 146);
            this.buttonComenzar.Name = "buttonComenzar";
            this.buttonComenzar.Size = new System.Drawing.Size(75, 23);
            this.buttonComenzar.TabIndex = 1;
            this.buttonComenzar.Text = "Comenzar";
            this.buttonComenzar.UseVisualStyleBackColor = true;
            this.buttonComenzar.Click += new System.EventHandler(this.buttonComenzar_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(157, 146);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Parar";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // bannerDeslizante2
            // 
            this.bannerDeslizante2.CaracteresAMostrar = 0;
            this.bannerDeslizante2.Location = new System.Drawing.Point(27, 33);
            this.bannerDeslizante2.Name = "bannerDeslizante2";
            this.bannerDeslizante2.Size = new System.Drawing.Size(100, 20);
            this.bannerDeslizante2.TabIndex = 3;
            this.bannerDeslizante2.TextoCompleto = null;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "1",
            "1",
            "1",
            "1",
            "1",
            "1",
            "1",
            "31",
            "34",
            "1",
            "232",
            "43ç",
            "3423",
            "43",
            "3",
            "3",
            "3",
            "3",
            "4",
            "54",
            "5",
            "5",
            "6",
            "56",
            "56",
            "4",
            "6",
            "6",
            "768",
            "67",
            "5",
            "7",
            "8",
            "9",
            "9",
            "6",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(32, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // PruebaBannerDeslizante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 188);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bannerDeslizante2);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonComenzar);
            this.Controls.Add(this.bannerDeslizante1);
            this.Name = "PruebaBannerDeslizante";
            this.Text = "PruebaBannerDeslizante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BannerDeslizante bannerDeslizante1;
        private System.Windows.Forms.Button buttonComenzar;
        private System.Windows.Forms.Button buttonStop;
        private BannerDeslizante bannerDeslizante2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}