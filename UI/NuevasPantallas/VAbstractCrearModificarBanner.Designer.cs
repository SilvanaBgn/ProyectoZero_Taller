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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelSeleccionFuente = new System.Windows.Forms.Label();
            this.dataGridViewMostrarFuentes = new System.Windows.Forms.DataGridView();
            this.buttonCrearNuevaFuente = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.rangoHorario = new UI.UserControls.RangoHorario();
            this.rangoFecha = new UI.UserControls.RangoFecha();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarFuentes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(15, 10);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(35, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(104, 10);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(364, 20);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(15, 40);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 8;
            this.labelDescripcion.Text = "Descripción";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(104, 37);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(364, 20);
            this.textBoxDescripcion.TabIndex = 9;
            // 
            // labelSeleccionFuente
            // 
            this.labelSeleccionFuente.AutoSize = true;
            this.labelSeleccionFuente.Location = new System.Drawing.Point(9, 235);
            this.labelSeleccionFuente.Name = "labelSeleccionFuente";
            this.labelSeleccionFuente.Size = new System.Drawing.Size(105, 13);
            this.labelSeleccionFuente.TabIndex = 10;
            this.labelSeleccionFuente.Text = "Selección de Fuente";
            // 
            // dataGridViewMostrarFuentes
            // 
            this.dataGridViewMostrarFuentes.AllowUserToAddRows = false;
            this.dataGridViewMostrarFuentes.AllowUserToDeleteRows = false;
            this.dataGridViewMostrarFuentes.AllowUserToOrderColumns = true;
            this.dataGridViewMostrarFuentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrarFuentes.Location = new System.Drawing.Point(18, 254);
            this.dataGridViewMostrarFuentes.Name = "dataGridViewMostrarFuentes";
            this.dataGridViewMostrarFuentes.ReadOnly = true;
            this.dataGridViewMostrarFuentes.Size = new System.Drawing.Size(450, 150);
            this.dataGridViewMostrarFuentes.TabIndex = 11;
            // 
            // buttonCrearNuevaFuente
            // 
            this.buttonCrearNuevaFuente.Location = new System.Drawing.Point(18, 410);
            this.buttonCrearNuevaFuente.Name = "buttonCrearNuevaFuente";
            this.buttonCrearNuevaFuente.Size = new System.Drawing.Size(91, 24);
            this.buttonCrearNuevaFuente.TabIndex = 12;
            this.buttonCrearNuevaFuente.Text = "Nueva Fuente";
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
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // rangoHorario
            // 
            this.rangoHorario.HoraFin = System.TimeSpan.Parse("00:15:00");
            this.rangoHorario.HoraInicio = System.TimeSpan.Parse("00:00:00");
            this.rangoHorario.Location = new System.Drawing.Point(329, 97);
            this.rangoHorario.Name = "rangoHorario";
            this.rangoHorario.Size = new System.Drawing.Size(120, 101);
            this.rangoHorario.TabIndex = 16;
            // 
            // rangoFecha
            // 
            this.rangoFecha.FechaFin = new System.DateTime(2017, 2, 14, 0, 0, 0, 0);
            this.rangoFecha.FechaInicio = new System.DateTime(2017, 2, 14, 0, 0, 0, 0);
            this.rangoFecha.Location = new System.Drawing.Point(18, 99);
            this.rangoFecha.Name = "rangoFecha";
            this.rangoFecha.Size = new System.Drawing.Size(269, 96);
            this.rangoFecha.TabIndex = 15;
            // 
            // VAbstractCrearModificarBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 477);
            this.Controls.Add(this.rangoHorario);
            this.Controls.Add(this.rangoFecha);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonCrearNuevaFuente);
            this.Controls.Add(this.dataGridViewMostrarFuentes);
            this.Controls.Add(this.labelSeleccionFuente);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Name = "VAbstractCrearModificarBanner";
            this.Text = "VAbstractCrearModificarBanner";
            this.Activated += new System.EventHandler(this.VAbstractCrearModificarBanner_Activated);
            this.Load += new System.EventHandler(this.VAbstractCrearModificarBanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarFuentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        protected System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelDescripcion;
        protected System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelSeleccionFuente;
        protected System.Windows.Forms.DataGridView dataGridViewMostrarFuentes;
        protected System.Windows.Forms.Button buttonCrearNuevaFuente;
        protected System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        protected UserControls.RangoFecha rangoFecha;
        protected UserControls.RangoHorario rangoHorario;
    }
}