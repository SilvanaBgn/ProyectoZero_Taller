namespace UI.UserControls
{
    partial class RangoFecha
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCantDias = new System.Windows.Forms.Label();
            this.labelFin = new System.Windows.Forms.Label();
            this.labelInicio = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCantDias);
            this.groupBox2.Controls.Add(this.labelFin);
            this.groupBox2.Controls.Add(this.labelInicio);
            this.groupBox2.Controls.Add(this.dateTimePickerFin);
            this.groupBox2.Controls.Add(this.dateTimePickerInicio);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 93);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rango Fecha";
            // 
            // labelCantDias
            // 
            this.labelCantDias.AutoSize = true;
            this.labelCantDias.Location = new System.Drawing.Point(10, 72);
            this.labelCantDias.Name = "labelCantDias";
            this.labelCantDias.Size = new System.Drawing.Size(0, 13);
            this.labelCantDias.TabIndex = 22;
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelFin.Location = new System.Drawing.Point(10, 53);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(24, 13);
            this.labelFin.TabIndex = 21;
            this.labelFin.Text = "Fin:";
            // 
            // labelInicio
            // 
            this.labelInicio.AutoSize = true;
            this.labelInicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInicio.Location = new System.Drawing.Point(10, 27);
            this.labelInicio.Name = "labelInicio";
            this.labelInicio.Size = new System.Drawing.Size(35, 13);
            this.labelInicio.TabIndex = 20;
            this.labelInicio.Text = "Inicio:";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.CustomFormat = "dddd d MMMM yyyy";
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFin.Location = new System.Drawing.Point(46, 49);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(177, 20);
            this.dateTimePickerFin.TabIndex = 19;
            this.dateTimePickerFin.ValueChanged += new System.EventHandler(this.dateTimePickerFin_ValueChanged);
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.CustomFormat = "dddd d MMMM yyyy";
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(46, 23);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(177, 20);
            this.dateTimePickerInicio.TabIndex = 18;
            this.dateTimePickerInicio.ValueChanged += new System.EventHandler(this.dateTimePickerInicio_ValueChanged);
            // 
            // RangoFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "RangoFecha";
            this.Size = new System.Drawing.Size(257, 96);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.Label labelInicio;
        protected System.Windows.Forms.DateTimePicker dateTimePickerFin;
        protected System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label labelCantDias;
    }
}
