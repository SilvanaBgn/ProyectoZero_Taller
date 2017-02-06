namespace RangoHorario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDiferenciaEntreInicioFin = new System.Windows.Forms.Label();
            this.dateTimePickerHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHoraFin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fin:";
            // 
            // labelDiferenciaEntreInicioFin
            // 
            this.labelDiferenciaEntreInicioFin.AutoSize = true;
            this.labelDiferenciaEntreInicioFin.Location = new System.Drawing.Point(13, 108);
            this.labelDiferenciaEntreInicioFin.Name = "labelDiferenciaEntreInicioFin";
            this.labelDiferenciaEntreInicioFin.Size = new System.Drawing.Size(0, 13);
            this.labelDiferenciaEntreInicioFin.TabIndex = 2;
            // 
            // dateTimePickerHoraInicio
            // 
            this.dateTimePickerHoraInicio.CustomFormat = "HH:mm";
            this.dateTimePickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHoraInicio.Location = new System.Drawing.Point(49, 39);
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
            this.dateTimePickerHoraFin.Location = new System.Drawing.Point(49, 74);
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango Horario";
            // 
            // ControlHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ControlHora";
            this.Size = new System.Drawing.Size(120, 101);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDiferenciaEntreInicioFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerHoraFin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
