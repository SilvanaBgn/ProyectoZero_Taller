namespace UI.NuevasPantallas
{
    partial class VAbstractBase
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
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.checkBoxRangoFechas = new System.Windows.Forms.CheckBox();
            this.checkBoxRangoHoras = new System.Windows.Forms.CheckBox();
            this.checkBoxDescripcion = new System.Windows.Forms.CheckBox();
            this.dataGridViewMostrar = new System.Windows.Forms.DataGridView();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.checkBoxTitulo = new System.Windows.Forms.CheckBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.rangoHorario = new UI.UserControls.RangoHorario();
            this.rangoFecha = new UI.UserControls.RangoFecha();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(13, 13);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 0;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(103, 13);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(192, 13);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.AutoSize = true;
            this.labelFiltrar.Location = new System.Drawing.Point(10, 69);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(53, 13);
            this.labelFiltrar.TabIndex = 3;
            this.labelFiltrar.Text = "Filtrar por:";
            // 
            // checkBoxRangoFechas
            // 
            this.checkBoxRangoFechas.AutoSize = true;
            this.checkBoxRangoFechas.Location = new System.Drawing.Point(12, 92);
            this.checkBoxRangoFechas.Name = "checkBoxRangoFechas";
            this.checkBoxRangoFechas.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRangoFechas.TabIndex = 4;
            this.checkBoxRangoFechas.UseVisualStyleBackColor = true;
            this.checkBoxRangoFechas.CheckedChanged += new System.EventHandler(this.checkBoxRangoFechas_CheckedChanged);
            // 
            // checkBoxRangoHoras
            // 
            this.checkBoxRangoHoras.AutoSize = true;
            this.checkBoxRangoHoras.Location = new System.Drawing.Point(13, 203);
            this.checkBoxRangoHoras.Name = "checkBoxRangoHoras";
            this.checkBoxRangoHoras.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRangoHoras.TabIndex = 5;
            this.checkBoxRangoHoras.UseVisualStyleBackColor = true;
            this.checkBoxRangoHoras.CheckedChanged += new System.EventHandler(this.checkBoxRangoHoras_CheckedChanged);
            // 
            // checkBoxDescripcion
            // 
            this.checkBoxDescripcion.AutoSize = true;
            this.checkBoxDescripcion.Location = new System.Drawing.Point(14, 320);
            this.checkBoxDescripcion.Name = "checkBoxDescripcion";
            this.checkBoxDescripcion.Size = new System.Drawing.Size(82, 17);
            this.checkBoxDescripcion.TabIndex = 6;
            this.checkBoxDescripcion.Text = "Descripción";
            this.checkBoxDescripcion.UseVisualStyleBackColor = true;
            this.checkBoxDescripcion.CheckedChanged += new System.EventHandler(this.checkBoxDescripcion_CheckedChanged);
            // 
            // dataGridViewMostrar
            // 
            this.dataGridViewMostrar.AllowUserToAddRows = false;
            this.dataGridViewMostrar.AllowUserToDeleteRows = false;
            this.dataGridViewMostrar.AllowUserToOrderColumns = true;
            this.dataGridViewMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrar.Location = new System.Drawing.Point(282, 69);
            this.dataGridViewMostrar.Name = "dataGridViewMostrar";
            this.dataGridViewMostrar.ReadOnly = true;
            this.dataGridViewMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMostrar.Size = new System.Drawing.Size(363, 344);
            this.dataGridViewMostrar.TabIndex = 7;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.AcceptsTab = true;
            this.textBoxDescripcion.Enabled = false;
            this.textBoxDescripcion.Location = new System.Drawing.Point(34, 339);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(198, 20);
            this.textBoxDescripcion.TabIndex = 10;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(570, 441);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 11;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(34, 441);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 14;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // checkBoxTitulo
            // 
            this.checkBoxTitulo.AutoSize = true;
            this.checkBoxTitulo.Location = new System.Drawing.Point(14, 375);
            this.checkBoxTitulo.Name = "checkBoxTitulo";
            this.checkBoxTitulo.Size = new System.Drawing.Size(54, 17);
            this.checkBoxTitulo.TabIndex = 15;
            this.checkBoxTitulo.Text = "Título";
            this.checkBoxTitulo.UseVisualStyleBackColor = true;
            this.checkBoxTitulo.CheckedChanged += new System.EventHandler(this.checkBoxTitulo_CheckedChanged);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Enabled = false;
            this.textBoxTitulo.Location = new System.Drawing.Point(34, 393);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(198, 20);
            this.textBoxTitulo.TabIndex = 16;
            // 
            // rangoHorario
            // 
            this.rangoHorario.Enabled = false;
            this.rangoHorario.HoraFin = System.TimeSpan.Parse("00:15:00");
            this.rangoHorario.HoraInicio = System.TimeSpan.Parse("00:00:00");
            this.rangoHorario.Location = new System.Drawing.Point(34, 203);
            this.rangoHorario.Name = "rangoHorario";
            this.rangoHorario.Size = new System.Drawing.Size(120, 101);
            this.rangoHorario.TabIndex = 18;
            // 
            // rangoFecha
            // 
            this.rangoFecha.Enabled = false;
            this.rangoFecha.FechaFin = new System.DateTime(2017, 2, 14, 0, 0, 0, 0);
            this.rangoFecha.FechaInicio = new System.DateTime(2017, 2, 14, 0, 0, 0, 0);
            this.rangoFecha.Location = new System.Drawing.Point(34, 92);
            this.rangoFecha.Name = "rangoFecha";
            this.rangoFecha.Size = new System.Drawing.Size(242, 96);
            this.rangoFecha.TabIndex = 17;
            // 
            // VAbstractBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 476);
            this.Controls.Add(this.rangoHorario);
            this.Controls.Add(this.rangoFecha);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.checkBoxTitulo);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.dataGridViewMostrar);
            this.Controls.Add(this.checkBoxDescripcion);
            this.Controls.Add(this.checkBoxRangoHoras);
            this.Controls.Add(this.checkBoxRangoFechas);
            this.Controls.Add(this.labelFiltrar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonNuevo);
            this.Name = "VAbstractBase";
            this.Text = "VAbstractBase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button buttonNuevo;
        protected System.Windows.Forms.Button buttonModificar;
        protected System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonSalir;
        protected System.Windows.Forms.Button buttonFiltrar;
        protected System.Windows.Forms.Label labelFiltrar;
        protected System.Windows.Forms.CheckBox checkBoxRangoFechas;
        protected System.Windows.Forms.CheckBox checkBoxRangoHoras;
        protected System.Windows.Forms.CheckBox checkBoxDescripcion;
        protected System.Windows.Forms.DataGridView dataGridViewMostrar;
        protected System.Windows.Forms.TextBox textBoxDescripcion;
        protected System.Windows.Forms.CheckBox checkBoxTitulo;
        protected System.Windows.Forms.TextBox textBoxTitulo;
        protected UserControls.RangoFecha rangoFecha;
        protected UserControls.RangoHorario rangoHorario;
    }
}