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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VAbstractCrearModificarBanner));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelSeleccionFuente = new System.Windows.Forms.Label();
            this.dataGridViewMostrarFuentes = new System.Windows.Forms.DataGridView();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.rangoHorario = new UI.UserControls.RangoHorario();
            this.rangoFecha = new UI.UserControls.RangoFecha();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.checkBoxTipo = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxDescripcion = new System.Windows.Forms.CheckBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bannerDeslizante = new UI.UserControls.BannerDeslizante();
            this.buttonVistaPrevia = new System.Windows.Forms.Button();
            this.buttonNuevaFuente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarFuentes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(13, 13);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(35, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(97, 13);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(407, 20);
            this.textBoxTitulo.TabIndex = 1;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(13, 43);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 8;
            this.labelDescripcion.Text = "Descripción";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(97, 43);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(407, 20);
            this.textBoxDescripcion.TabIndex = 9;
            // 
            // labelSeleccionFuente
            // 
            this.labelSeleccionFuente.AutoSize = true;
            this.labelSeleccionFuente.Location = new System.Drawing.Point(256, 25);
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
            this.dataGridViewMostrarFuentes.Location = new System.Drawing.Point(267, 44);
            this.dataGridViewMostrarFuentes.Name = "dataGridViewMostrarFuentes";
            this.dataGridViewMostrarFuentes.ReadOnly = true;
            this.dataGridViewMostrarFuentes.Size = new System.Drawing.Size(205, 111);
            this.dataGridViewMostrarFuentes.TabIndex = 11;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(348, 431);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 13;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(429, 431);
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
            this.rangoHorario.Location = new System.Drawing.Point(333, 89);
            this.rangoHorario.Name = "rangoHorario";
            this.rangoHorario.Size = new System.Drawing.Size(120, 96);
            this.rangoHorario.TabIndex = 16;
            // 
            // rangoFecha
            // 
            this.rangoFecha.FechaFin = new System.DateTime(2017, 2, 15, 0, 0, 0, 0);
            this.rangoFecha.FechaInicio = new System.DateTime(2017, 2, 15, 0, 0, 0, 0);
            this.rangoFecha.Location = new System.Drawing.Point(16, 89);
            this.rangoFecha.Name = "rangoFecha";
            this.rangoFecha.Size = new System.Drawing.Size(264, 96);
            this.rangoFecha.TabIndex = 15;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(13, 169);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 22;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // checkBoxTipo
            // 
            this.checkBoxTipo.AutoSize = true;
            this.checkBoxTipo.Location = new System.Drawing.Point(13, 47);
            this.checkBoxTipo.Name = "checkBoxTipo";
            this.checkBoxTipo.Size = new System.Drawing.Size(47, 17);
            this.checkBoxTipo.TabIndex = 21;
            this.checkBoxTipo.Text = "Tipo";
            this.checkBoxTipo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 20;
            // 
            // checkBoxDescripcion
            // 
            this.checkBoxDescripcion.AutoSize = true;
            this.checkBoxDescripcion.Location = new System.Drawing.Point(13, 111);
            this.checkBoxDescripcion.Name = "checkBoxDescripcion";
            this.checkBoxDescripcion.Size = new System.Drawing.Size(82, 17);
            this.checkBoxDescripcion.TabIndex = 19;
            this.checkBoxDescripcion.Text = "Descripcion";
            this.checkBoxDescripcion.UseVisualStyleBackColor = true;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Rss",
            "Texto Fijo"});
            this.comboBoxTipo.Location = new System.Drawing.Point(13, 67);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(170, 21);
            this.comboBoxTipo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filtrar por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bannerDeslizante);
            this.groupBox1.Controls.Add(this.buttonVistaPrevia);
            this.groupBox1.Controls.Add(this.buttonNuevaFuente);
            this.groupBox1.Controls.Add(this.buttonFiltrar);
            this.groupBox1.Controls.Add(this.checkBoxTipo);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.checkBoxDescripcion);
            this.groupBox1.Controls.Add(this.comboBoxTipo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridViewMostrarFuentes);
            this.groupBox1.Controls.Add(this.labelSeleccionFuente);
            this.groupBox1.Location = new System.Drawing.Point(17, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 208);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuente";
            // 
            // bannerDeslizante
            // 
            this.bannerDeslizante.Enabled = false;
            this.bannerDeslizante.Location = new System.Drawing.Point(337, 167);
            this.bannerDeslizante.Name = "bannerDeslizante";
            this.bannerDeslizante.Size = new System.Drawing.Size(135, 20);
            this.bannerDeslizante.TabIndex = 79;
            // 
            // buttonVistaPrevia
            // 
            this.buttonVistaPrevia.AutoSize = true;
            this.buttonVistaPrevia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVistaPrevia.BackgroundImage")));
            this.buttonVistaPrevia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVistaPrevia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVistaPrevia.Location = new System.Drawing.Point(301, 161);
            this.buttonVistaPrevia.Name = "buttonVistaPrevia";
            this.buttonVistaPrevia.Size = new System.Drawing.Size(30, 31);
            this.buttonVistaPrevia.TabIndex = 78;
            this.buttonVistaPrevia.UseVisualStyleBackColor = true;
            // 
            // buttonNuevaFuente
            // 
            this.buttonNuevaFuente.AutoSize = true;
            this.buttonNuevaFuente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNuevaFuente.BackgroundImage")));
            this.buttonNuevaFuente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNuevaFuente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNuevaFuente.Location = new System.Drawing.Point(267, 161);
            this.buttonNuevaFuente.Name = "buttonNuevaFuente";
            this.buttonNuevaFuente.Size = new System.Drawing.Size(29, 31);
            this.buttonNuevaFuente.TabIndex = 77;
            this.buttonNuevaFuente.UseVisualStyleBackColor = true;
            // 
            // VAbstractCrearModificarBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rangoHorario);
            this.Controls.Add(this.rangoFecha);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Name = "VAbstractCrearModificarBanner";
            this.Text = "VAbstractCrearModificarBanner";
            this.Activated += new System.EventHandler(this.VAbstractCrearModificarBanner_Activated);
            this.Load += new System.EventHandler(this.VAbstractCrearModificarBanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarFuentes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        protected System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        protected UserControls.RangoFecha rangoFecha;
        protected UserControls.RangoHorario rangoHorario;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.CheckBox checkBoxTipo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxDescripcion;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private UserControls.BannerDeslizante bannerDeslizante;
        private System.Windows.Forms.Button buttonVistaPrevia;
        private System.Windows.Forms.Button buttonNuevaFuente;
    }
}