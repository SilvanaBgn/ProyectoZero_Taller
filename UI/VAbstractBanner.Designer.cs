namespace UI
{
    partial class VAbstractBanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VAbstractBanner));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxNuevoPasoBanner = new System.Windows.Forms.TextBox();
            this.labelNuevoPasoBanner = new System.Windows.Forms.Label();
            this.buttonAgregarPasoBanner = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.comboBoxH1 = new System.Windows.Forms.ComboBox();
            this.comboBoxM1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxM2 = new System.Windows.Forms.ComboBox();
            this.comboBoxH2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxHora = new System.Windows.Forms.GroupBox();
            this.groupBoxFecha = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.panelTextoPlano = new System.Windows.Forms.Panel();
            this.buttonBorrarPasoBanner = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.listBoxPasosBanners = new System.Windows.Forms.ListBox();
            this.panelFuenteRss = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnaNombreFuente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaUrlFuente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDesplegarFuentes = new System.Windows.Forms.Button();
            this.textBoxFuente = new System.Windows.Forms.TextBox();
            this.buttonAgregarFuenteRss = new System.Windows.Forms.Button();
            this.radioButtonFuenteRss = new System.Windows.Forms.RadioButton();
            this.radioButtonTextoPlano = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewHorariosDisponibles = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxHora.SuspendLayout();
            this.groupBoxFecha.SuspendLayout();
            this.groupBoxDatos.SuspendLayout();
            this.panelTextoPlano.SuspendLayout();
            this.panelFuenteRss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(11, 11);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(38, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título:";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(55, 5);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(318, 20);
            this.textBoxTitulo.TabIndex = 1;
            this.textBoxTitulo.Click += new System.EventHandler(this.textBoxTitulo_Click);
            // 
            // textBoxNuevoPasoBanner
            // 
            this.textBoxNuevoPasoBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNuevoPasoBanner.Location = new System.Drawing.Point(73, 6);
            this.textBoxNuevoPasoBanner.Multiline = true;
            this.textBoxNuevoPasoBanner.Name = "textBoxNuevoPasoBanner";
            this.textBoxNuevoPasoBanner.Size = new System.Drawing.Size(260, 51);
            this.textBoxNuevoPasoBanner.TabIndex = 2;
            // 
            // labelNuevoPasoBanner
            // 
            this.labelNuevoPasoBanner.AutoSize = true;
            this.labelNuevoPasoBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuevoPasoBanner.Location = new System.Drawing.Point(5, 8);
            this.labelNuevoPasoBanner.Name = "labelNuevoPasoBanner";
            this.labelNuevoPasoBanner.Size = new System.Drawing.Size(68, 13);
            this.labelNuevoPasoBanner.TabIndex = 3;
            this.labelNuevoPasoBanner.Text = "Nuevo texto:";
            // 
            // buttonAgregarPasoBanner
            // 
            this.buttonAgregarPasoBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarPasoBanner.Location = new System.Drawing.Point(339, 11);
            this.buttonAgregarPasoBanner.Name = "buttonAgregarPasoBanner";
            this.buttonAgregarPasoBanner.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarPasoBanner.TabIndex = 4;
            this.buttonAgregarPasoBanner.Text = "Agregar";
            this.buttonAgregarPasoBanner.UseVisualStyleBackColor = true;
            this.buttonAgregarPasoBanner.Click += new System.EventHandler(this.buttonAgregarPasoBanner_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(696, 335);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(777, 335);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
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
            this.comboBoxH1.Location = new System.Drawing.Point(54, 19);
            this.comboBoxH1.Name = "comboBoxH1";
            this.comboBoxH1.Size = new System.Drawing.Size(36, 21);
            this.comboBoxH1.TabIndex = 15;
            // 
            // comboBoxM1
            // 
            this.comboBoxM1.FormattingEnabled = true;
            this.comboBoxM1.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.comboBoxM1.Location = new System.Drawing.Point(100, 19);
            this.comboBoxM1.Name = "comboBoxM1";
            this.comboBoxM1.Size = new System.Drawing.Size(37, 21);
            this.comboBoxM1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 24;
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
            this.comboBoxM2.Location = new System.Drawing.Point(100, 46);
            this.comboBoxM2.Name = "comboBoxM2";
            this.comboBoxM2.Size = new System.Drawing.Size(37, 21);
            this.comboBoxM2.TabIndex = 22;
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
            this.comboBoxH2.Location = new System.Drawing.Point(54, 46);
            this.comboBoxH2.Name = "comboBoxH2";
            this.comboBoxH2.Size = new System.Drawing.Size(36, 21);
            this.comboBoxH2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Fin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Inicio:";
            // 
            // groupBoxHora
            // 
            this.groupBoxHora.Controls.Add(this.label7);
            this.groupBoxHora.Controls.Add(this.label8);
            this.groupBoxHora.Controls.Add(this.label4);
            this.groupBoxHora.Controls.Add(this.comboBoxM2);
            this.groupBoxHora.Controls.Add(this.comboBoxH2);
            this.groupBoxHora.Controls.Add(this.label3);
            this.groupBoxHora.Controls.Add(this.comboBoxM1);
            this.groupBoxHora.Controls.Add(this.comboBoxH1);
            this.groupBoxHora.Location = new System.Drawing.Point(251, 42);
            this.groupBoxHora.Name = "groupBoxHora";
            this.groupBoxHora.Size = new System.Drawing.Size(156, 77);
            this.groupBoxHora.TabIndex = 29;
            this.groupBoxHora.TabStop = false;
            this.groupBoxHora.Text = "Hora";
            this.groupBoxHora.Enter += new System.EventHandler(this.groupBoxHora_Enter);
            // 
            // groupBoxFecha
            // 
            this.groupBoxFecha.Controls.Add(this.label2);
            this.groupBoxFecha.Controls.Add(this.label1);
            this.groupBoxFecha.Controls.Add(this.dateTimePickerFin);
            this.groupBoxFecha.Controls.Add(this.dateTimePickerInicio);
            this.groupBoxFecha.Location = new System.Drawing.Point(12, 42);
            this.groupBoxFecha.Name = "groupBoxFecha";
            this.groupBoxFecha.Size = new System.Drawing.Size(233, 77);
            this.groupBoxFecha.TabIndex = 30;
            this.groupBoxFecha.TabStop = false;
            this.groupBoxFecha.Text = "Fecha";
            this.groupBoxFecha.Enter += new System.EventHandler(this.groupBoxFecha_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Inicio:";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.CustomFormat = "dddd d MMMM yyyy";
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFin.Location = new System.Drawing.Point(46, 46);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.Size = new System.Drawing.Size(177, 20);
            this.dateTimePickerFin.TabIndex = 19;
            this.dateTimePickerFin.ValueChanged += new System.EventHandler(this.dateTimePickerFin_ValueChanged);
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.CustomFormat = "dddd d MMMM yyyy";
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(46, 21);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(177, 20);
            this.dateTimePickerInicio.TabIndex = 18;
            this.dateTimePickerInicio.ValueChanged += new System.EventHandler(this.dateTimePickerInicio_ValueChanged);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.panelFuenteRss);
            this.groupBoxDatos.Controls.Add(this.panelTextoPlano);
            this.groupBoxDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatos.Location = new System.Drawing.Point(430, 59);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(438, 270);
            this.groupBoxDatos.TabIndex = 31;
            this.groupBoxDatos.TabStop = false;
            // 
            // panelTextoPlano
            // 
            this.panelTextoPlano.Controls.Add(this.buttonAgregarPasoBanner);
            this.panelTextoPlano.Controls.Add(this.buttonBorrarPasoBanner);
            this.panelTextoPlano.Controls.Add(this.buttonUp);
            this.panelTextoPlano.Controls.Add(this.buttonDown);
            this.panelTextoPlano.Controls.Add(this.listBoxPasosBanners);
            this.panelTextoPlano.Controls.Add(this.textBoxNuevoPasoBanner);
            this.panelTextoPlano.Controls.Add(this.labelNuevoPasoBanner);
            this.panelTextoPlano.Location = new System.Drawing.Point(7, 3);
            this.panelTextoPlano.Name = "panelTextoPlano";
            this.panelTextoPlano.Size = new System.Drawing.Size(416, 267);
            this.panelTextoPlano.TabIndex = 15;
            // 
            // buttonBorrarPasoBanner
            // 
            this.buttonBorrarPasoBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarPasoBanner.Location = new System.Drawing.Point(338, 225);
            this.buttonBorrarPasoBanner.Name = "buttonBorrarPasoBanner";
            this.buttonBorrarPasoBanner.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrarPasoBanner.TabIndex = 8;
            this.buttonBorrarPasoBanner.Text = "Borrar";
            this.buttonBorrarPasoBanner.UseVisualStyleBackColor = true;
            this.buttonBorrarPasoBanner.Click += new System.EventHandler(this.buttonBorrarPasoBanner_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.AutoSize = true;
            this.buttonUp.FlatAppearance.BorderSize = 0;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
            this.buttonUp.Location = new System.Drawing.Point(340, 84);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(70, 70);
            this.buttonUp.TabIndex = 42;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.AutoSize = true;
            this.buttonDown.FlatAppearance.BorderSize = 0;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonDown.Image")));
            this.buttonDown.Location = new System.Drawing.Point(340, 154);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(70, 70);
            this.buttonDown.TabIndex = 43;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // listBoxPasosBanners
            // 
            this.listBoxPasosBanners.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPasosBanners.FormattingEnabled = true;
            this.listBoxPasosBanners.Location = new System.Drawing.Point(8, 78);
            this.listBoxPasosBanners.Name = "listBoxPasosBanners";
            this.listBoxPasosBanners.Size = new System.Drawing.Size(325, 173);
            this.listBoxPasosBanners.TabIndex = 11;
            // 
            // panelFuenteRss
            // 
            this.panelFuenteRss.Controls.Add(this.listView1);
            this.panelFuenteRss.Controls.Add(this.buttonDesplegarFuentes);
            this.panelFuenteRss.Controls.Add(this.textBoxFuente);
            this.panelFuenteRss.Controls.Add(this.buttonAgregarFuenteRss);
            this.panelFuenteRss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFuenteRss.Location = new System.Drawing.Point(1, 1);
            this.panelFuenteRss.Name = "panelFuenteRss";
            this.panelFuenteRss.Size = new System.Drawing.Size(422, 269);
            this.panelFuenteRss.TabIndex = 35;
            this.panelFuenteRss.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelFuenteRss_MouseClick);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaNombreFuente,
            this.columnaUrlFuente});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(9, 55);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(388, 195);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            // 
            // columnaNombreFuente
            // 
            this.columnaNombreFuente.Text = "NombreFuente";
            this.columnaNombreFuente.Width = 201;
            // 
            // columnaUrlFuente
            // 
            this.columnaUrlFuente.Text = "UrlFuente";
            this.columnaUrlFuente.Width = 201;
            // 
            // buttonDesplegarFuentes
            // 
            this.buttonDesplegarFuentes.Image = ((System.Drawing.Image)(resources.GetObject("buttonDesplegarFuentes.Image")));
            this.buttonDesplegarFuentes.Location = new System.Drawing.Point(363, 34);
            this.buttonDesplegarFuentes.Name = "buttonDesplegarFuentes";
            this.buttonDesplegarFuentes.Size = new System.Drawing.Size(25, 22);
            this.buttonDesplegarFuentes.TabIndex = 16;
            this.buttonDesplegarFuentes.UseVisualStyleBackColor = true;
            this.buttonDesplegarFuentes.Click += new System.EventHandler(this.buttonDesplegarFuentes_Click);
            // 
            // textBoxFuente
            // 
            this.textBoxFuente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxFuente.Location = new System.Drawing.Point(20, 34);
            this.textBoxFuente.Name = "textBoxFuente";
            this.textBoxFuente.ReadOnly = true;
            this.textBoxFuente.Size = new System.Drawing.Size(343, 20);
            this.textBoxFuente.TabIndex = 15;
            // 
            // buttonAgregarFuenteRss
            // 
            this.buttonAgregarFuenteRss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarFuenteRss.Location = new System.Drawing.Point(302, 80);
            this.buttonAgregarFuenteRss.Name = "buttonAgregarFuenteRss";
            this.buttonAgregarFuenteRss.Size = new System.Drawing.Size(86, 23);
            this.buttonAgregarFuenteRss.TabIndex = 13;
            this.buttonAgregarFuenteRss.Text = "Nueva Fuente";
            this.buttonAgregarFuenteRss.UseVisualStyleBackColor = true;
            this.buttonAgregarFuenteRss.Click += new System.EventHandler(this.buttonAgregarFuenteRss_Click);
            // 
            // radioButtonFuenteRss
            // 
            this.radioButtonFuenteRss.AutoSize = true;
            this.radioButtonFuenteRss.Location = new System.Drawing.Point(574, 42);
            this.radioButtonFuenteRss.Name = "radioButtonFuenteRss";
            this.radioButtonFuenteRss.Size = new System.Drawing.Size(79, 17);
            this.radioButtonFuenteRss.TabIndex = 32;
            this.radioButtonFuenteRss.Text = "Fuente Rss";
            this.radioButtonFuenteRss.UseVisualStyleBackColor = true;
            this.radioButtonFuenteRss.Click += new System.EventHandler(this.radioButtonFuenteRss_Click);
            // 
            // radioButtonTextoPlano
            // 
            this.radioButtonTextoPlano.AutoSize = true;
            this.radioButtonTextoPlano.Location = new System.Drawing.Point(699, 42);
            this.radioButtonTextoPlano.Name = "radioButtonTextoPlano";
            this.radioButtonTextoPlano.Size = new System.Drawing.Size(92, 17);
            this.radioButtonTextoPlano.TabIndex = 33;
            this.radioButtonTextoPlano.Text = "Textos Planos";
            this.radioButtonTextoPlano.UseVisualStyleBackColor = true;
            this.radioButtonTextoPlano.CheckedChanged += new System.EventHandler(this.radioButtonTextoPlano_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Obtener los datos desde:";
            // 
            // dataGridViewHorariosDisponibles
            // 
            this.dataGridViewHorariosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHorariosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorariosDisponibles.Location = new System.Drawing.Point(14, 165);
            this.dataGridViewHorariosDisponibles.MultiSelect = false;
            this.dataGridViewHorariosDisponibles.Name = "dataGridViewHorariosDisponibles";
            this.dataGridViewHorariosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHorariosDisponibles.Size = new System.Drawing.Size(392, 145);
            this.dataGridViewHorariosDisponibles.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Intervalos disponibles:";
            // 
            // VAbstractBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 364);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewHorariosDisponibles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonTextoPlano);
            this.Controls.Add(this.radioButtonFuenteRss);
            this.Controls.Add(this.groupBoxHora);
            this.Controls.Add(this.groupBoxFecha);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Name = "VAbstractBanner";
            this.Text = "Nuevo Banner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VAbstractBanner_FormClosing);
            this.Load += new System.EventHandler(this.VAbstractBanner_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VAbstractBanner_MouseClick);
            this.groupBoxHora.ResumeLayout(false);
            this.groupBoxHora.PerformLayout();
            this.groupBoxFecha.ResumeLayout(false);
            this.groupBoxFecha.PerformLayout();
            this.groupBoxDatos.ResumeLayout(false);
            this.panelTextoPlano.ResumeLayout(false);
            this.panelTextoPlano.PerformLayout();
            this.panelFuenteRss.ResumeLayout(false);
            this.panelFuenteRss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariosDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label labelTitulo;
        protected System.Windows.Forms.TextBox textBoxNuevoPasoBanner;
        protected System.Windows.Forms.Label labelNuevoPasoBanner;
        protected System.Windows.Forms.Button buttonAgregarPasoBanner;
        protected System.Windows.Forms.Button buttonGuardar;
        protected System.Windows.Forms.Button buttonCancelar;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.GroupBox groupBoxHora;
        protected System.Windows.Forms.GroupBox groupBoxFecha;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.GroupBox groupBoxDatos;
        protected System.Windows.Forms.ListBox listBoxPasosBanners;
        protected System.Windows.Forms.Button buttonBorrarPasoBanner;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Button buttonAgregarFuenteRss;
        protected System.Windows.Forms.TextBox textBoxTitulo;
        protected System.Windows.Forms.ComboBox comboBoxH1;
        protected System.Windows.Forms.ComboBox comboBoxM1;
        protected System.Windows.Forms.ComboBox comboBoxM2;
        protected System.Windows.Forms.ComboBox comboBoxH2;
        protected System.Windows.Forms.DateTimePicker dateTimePickerFin;
        protected System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        protected System.Windows.Forms.RadioButton radioButtonFuenteRss;
        protected System.Windows.Forms.RadioButton radioButtonTextoPlano;
        protected System.Windows.Forms.Panel panelTextoPlano;
        protected System.Windows.Forms.Panel panelFuenteRss;
        protected System.Windows.Forms.Button buttonDesplegarFuentes;
        protected System.Windows.Forms.TextBox textBoxFuente;
        protected System.Windows.Forms.ListView listView1;
        protected System.Windows.Forms.ColumnHeader columnaNombreFuente;
        protected System.Windows.Forms.ColumnHeader columnaUrlFuente;
        protected System.Windows.Forms.Button buttonUp;
        protected System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.DataGridView dataGridViewHorariosDisponibles;
        protected System.Windows.Forms.Label label6;
    }
}