namespace UI.NuevasPantallas
{
    partial class VAbstractCrearModificarBanner
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewMostrarFuentes = new System.Windows.Forms.DataGridView();
            this.buttonCrearNuevaFuente = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.rangoFecha = new UI.UserControls.RangoFecha();
            this.rangoHorario = new UI.UserControls.RangoHorario();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarFuentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(123, 10);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(345, 20);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descripcion";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(123, 37);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(345, 20);
            this.textBoxDescripcion.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Seleccion de fuente";
            // 
            // dataGridViewMostrarFuentes
            // 
            this.dataGridViewMostrarFuentes.AllowUserToAddRows = false;
            this.dataGridViewMostrarFuentes.AllowUserToDeleteRows = false;
            this.dataGridViewMostrarFuentes.AllowUserToOrderColumns = true;
            this.dataGridViewMostrarFuentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrarFuentes.Location = new System.Drawing.Point(12, 254);
            this.dataGridViewMostrarFuentes.Name = "dataGridViewMostrarFuentes";
            this.dataGridViewMostrarFuentes.ReadOnly = true;
            this.dataGridViewMostrarFuentes.Size = new System.Drawing.Size(456, 150);
            this.dataGridViewMostrarFuentes.TabIndex = 11;
            // 
            // buttonCrearNuevaFuente
            // 
            this.buttonCrearNuevaFuente.Location = new System.Drawing.Point(12, 410);
            this.buttonCrearNuevaFuente.Name = "buttonCrearNuevaFuente";
            this.buttonCrearNuevaFuente.Size = new System.Drawing.Size(77, 36);
            this.buttonCrearNuevaFuente.TabIndex = 12;
            this.buttonCrearNuevaFuente.Text = "Crear nueva fuente";
            this.buttonCrearNuevaFuente.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(303, 442);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 13;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(393, 442);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // rangoFecha
            // 
            this.rangoFecha.FechaFin = new System.DateTime(2017, 2, 7, 0, 0, 0, 0);
            this.rangoFecha.FechaInicio = new System.DateTime(2017, 2, 7, 0, 0, 0, 0);
            this.rangoFecha.Location = new System.Drawing.Point(9, 97);
            this.rangoFecha.Name = "rangoFecha";
            this.rangoFecha.Size = new System.Drawing.Size(235, 96);
            this.rangoFecha.TabIndex = 15;
            // 
            // rangoHorario
            // 
            this.rangoHorario.HoraFin = System.TimeSpan.Parse("00:15:00");
            this.rangoHorario.HoraInicio = System.TimeSpan.Parse("00:00:00");
            this.rangoHorario.Location = new System.Drawing.Point(258, 97);
            this.rangoHorario.Name = "rangoHorario";
            this.rangoHorario.Size = new System.Drawing.Size(120, 101);
            this.rangoHorario.TabIndex = 16;
            // 
            // VAbstractCrearModificarBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 477);
            this.Controls.Add(this.rangoHorario);
            this.Controls.Add(this.rangoFecha);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCrearNuevaFuente);
            this.Controls.Add(this.dataGridViewMostrarFuentes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.label1);
            this.Name = "VAbstractCrearModificarBanner";
            this.Text = "VAbstractCrearModificarBanner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarFuentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox textBoxTitulo;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TextBox textBoxDescripcion;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.DataGridView dataGridViewMostrarFuentes;
        protected System.Windows.Forms.Button buttonCrearNuevaFuente;
        protected System.Windows.Forms.Button buttonGuardar;
        protected System.Windows.Forms.Button buttonCancelar;
        protected UserControls.RangoFecha rangoFecha;
        protected UserControls.RangoHorario rangoHorario;
    }
}