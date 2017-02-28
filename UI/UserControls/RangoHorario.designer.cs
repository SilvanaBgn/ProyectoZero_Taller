namespace UI.UserControls
{
    partial class RangoHorario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDiferenciaEntreInicioFin = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelFin = new System.Windows.Forms.Label();
            this.labelInicio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxM2 = new System.Windows.Forms.ComboBox();
            this.comboBoxH2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxM1 = new System.Windows.Forms.ComboBox();
            this.comboBoxH1 = new System.Windows.Forms.ComboBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDiferenciaEntreInicioFin
            // 
            this.labelDiferenciaEntreInicioFin.AutoSize = true;
            this.labelDiferenciaEntreInicioFin.Location = new System.Drawing.Point(10, 72);
            this.labelDiferenciaEntreInicioFin.Name = "labelDiferenciaEntreInicioFin";
            this.labelDiferenciaEntreInicioFin.Size = new System.Drawing.Size(0, 13);
            this.labelDiferenciaEntreInicioFin.TabIndex = 2;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelFin);
            this.groupBox.Controls.Add(this.labelInicio);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.comboBoxM2);
            this.groupBox.Controls.Add(this.comboBoxH2);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.comboBoxM1);
            this.groupBox.Controls.Add(this.comboBoxH1);
            this.groupBox.Controls.Add(this.labelDiferenciaEntreInicioFin);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(147, 96);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Rango Horario";
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFin.Location = new System.Drawing.Point(10, 52);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(24, 13);
            this.labelFin.TabIndex = 36;
            this.labelFin.Text = "Fin:";
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInicio.Location = new System.Drawing.Point(10, 27);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(35, 13);
            this.labelInicio.TabIndex = 35;
            this.labelInicio.Text = "Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = ":";
            // 
            // comboBoxM2
            // 
            this.comboBoxM2.FormattingEnabled = true;
            this.comboBoxM2.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.comboBoxM2.Location = new System.Drawing.Point(96, 48);
            this.comboBoxM2.Name = "comboBoxM2";
            this.comboBoxM2.Size = new System.Drawing.Size(37, 21);
            this.comboBoxM2.TabIndex = 33;
            this.comboBoxM2.SelectedIndexChanged += new System.EventHandler(this.comboBoxM2_SelectedIndexChanged);
            // 
            // comboBoxH2
            // 
            this.comboBoxH2.FormattingEnabled = true;
            this.comboBoxH2.Items.AddRange(new object[] {
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
            this.comboBoxH2.Location = new System.Drawing.Point(46, 48);
            this.comboBoxH2.Name = "comboBoxH2";
            this.comboBoxH2.Size = new System.Drawing.Size(36, 21);
            this.comboBoxH2.TabIndex = 32;
            this.comboBoxH2.SelectedIndexChanged += new System.EventHandler(this.comboBoxH2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 31;
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
            this.comboBoxM1.Location = new System.Drawing.Point(96, 23);
            this.comboBoxM1.Name = "comboBoxM1";
            this.comboBoxM1.Size = new System.Drawing.Size(37, 21);
            this.comboBoxM1.TabIndex = 30;
            this.comboBoxM1.SelectedIndexChanged += new System.EventHandler(this.comboBoxM1_SelectedIndexChanged);
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
            this.comboBoxH1.Location = new System.Drawing.Point(46, 23);
            this.comboBoxH1.Name = "comboBoxH1";
            this.comboBoxH1.Size = new System.Drawing.Size(36, 21);
            this.comboBoxH1.TabIndex = 29;
            this.comboBoxH1.SelectedIndexChanged += new System.EventHandler(this.comboBoxH1_SelectedIndexChanged);
            // 
            // RangoHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "RangoHorario";
            this.Size = new System.Drawing.Size(147, 96);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelDiferenciaEntreInicioFin;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.ComboBox comboBoxM2;
        protected System.Windows.Forms.ComboBox comboBoxH2;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.ComboBox comboBoxM1;
        protected System.Windows.Forms.ComboBox comboBoxH1;
    }
}
