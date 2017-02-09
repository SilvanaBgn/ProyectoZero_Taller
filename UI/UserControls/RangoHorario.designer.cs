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
            this.labelInicio = new System.Windows.Forms.Label();
            this.labelFin = new System.Windows.Forms.Label();
            this.labelDiferenciaEntreInicioFin = new System.Windows.Forms.Label();
            this.dateTimePickerHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraFin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.Location = new System.Drawing.Point(10, 27);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(35, 13);
            this.labelInicio.TabIndex = 0;
            this.labelInicio.Text = "Inicio:";
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Location = new System.Drawing.Point(10, 53);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(24, 13);
            this.labelFin.TabIndex = 1;
            this.labelFin.Text = "Fin:";
            // 
            // labelDiferenciaEntreInicioFin
            // 
            this.labelDiferenciaEntreInicioFin.AutoSize = true;
            this.labelDiferenciaEntreInicioFin.Location = new System.Drawing.Point(10, 72);
            this.labelDiferenciaEntreInicioFin.Name = "labelDiferenciaEntreInicioFin";
            this.labelDiferenciaEntreInicioFin.Size = new System.Drawing.Size(0, 13);
            this.labelDiferenciaEntreInicioFin.TabIndex = 2;
            // 
            // dateTimePickerHoraInicio
            // 
            this.dateTimePickerHoraInicio.CustomFormat = "HH:mm";
            this.dateTimePickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHoraInicio.Location = new System.Drawing.Point(46, 23);
            this.dateTimePickerHoraInicio.Name = "dateTimePickerHoraInicio";
            this.dateTimePickerHoraInicio.ShowUpDown = true;
            this.dateTimePickerHoraInicio.Size = new System.Drawing.Size(56, 20);
            this.dateTimePickerHoraInicio.TabIndex = 3;
            this.dateTimePickerHoraInicio.Value = new System.DateTime(2017, 1, 30, 0, 0, 0, 0);
            this.dateTimePickerHoraInicio.ValueChanged += new System.EventHandler(this.dateTimePickerHoraInicio_ValueChanged);
            // 
            // dateTimePickerHoraFin
            // 
            this.dateTimePickerHoraFin.CustomFormat = "HH:mm";
            this.dateTimePickerHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHoraFin.Location = new System.Drawing.Point(46, 49);
            this.dateTimePickerHoraFin.Name = "dateTimePickerHoraFin";
            this.dateTimePickerHoraFin.ShowUpDown = true;
            this.dateTimePickerHoraFin.Size = new System.Drawing.Size(56, 20);
            this.dateTimePickerHoraFin.TabIndex = 4;
            this.dateTimePickerHoraFin.Value = new System.DateTime(2017, 1, 30, 0, 0, 0, 0);
            this.dateTimePickerHoraFin.ValueChanged += new System.EventHandler(this.dateTimePickerHoraFin_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerHoraFin);
            this.groupBox1.Controls.Add(this.dateTimePickerHoraInicio);
            this.groupBox1.Controls.Add(this.labelDiferenciaEntreInicioFin);
            this.groupBox1.Controls.Add(this.labelFin);
            this.groupBox1.Controls.Add(this.labelInicio);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango Horario";
            // 
            // RangoHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "RangoHorario";
            this.Size = new System.Drawing.Size(139, 96);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInicio;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.Label labelDiferenciaEntreInicioFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraFin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
