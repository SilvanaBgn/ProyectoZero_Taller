namespace UI
{
    partial class VBannerBuscarPorHoraInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VBannerBuscarPorHoraInicio));
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxM1 = new System.Windows.Forms.ComboBox();
            this.comboBoxH1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = ":";
            // 
            // comboBoxM1
            // 
            this.comboBoxM1.FormattingEnabled = true;
            this.comboBoxM1.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.comboBoxM1.Location = new System.Drawing.Point(182, 16);
            this.comboBoxM1.Name = "comboBoxM1";
            this.comboBoxM1.Size = new System.Drawing.Size(37, 21);
            this.comboBoxM1.TabIndex = 22;
            // 
            // comboBoxH1
            // 
            this.comboBoxH1.FormattingEnabled = true;
            this.comboBoxH1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxH1.Location = new System.Drawing.Point(129, 16);
            this.comboBoxH1.Name = "comboBoxH1";
            this.comboBoxH1.Size = new System.Drawing.Size(36, 21);
            this.comboBoxH1.TabIndex = 21;
            // 
            // BuscarPorHoraInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 51);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxM1);
            this.Controls.Add(this.comboBoxH1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label1);
            this.Name = "BuscarPorHoraInicio";
            this.Text = "Buscar Banner por Hora de Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxM1;
        private System.Windows.Forms.ComboBox comboBoxH1;
    }
}