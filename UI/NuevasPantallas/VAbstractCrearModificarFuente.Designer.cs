namespace UI.NuevasPantallas
{
    partial class VAbstractCrearModificarFuente
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
            this.textBoxTituloRss = new System.Windows.Forms.TextBox();
            this.comboBoxTipoFuente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelRss = new System.Windows.Forms.Panel();
            this.panelTextoFijo = new System.Windows.Forms.Panel();
            this.listBoxPasosBanner = new System.Windows.Forms.ListBox();
            this.textBoxAgregarPasoBanner = new System.Windows.Forms.TextBox();
            this.textBoxTituloTextoFijo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFuenteRss = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.panelRss.SuspendLayout();
            this.panelTextoFijo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // textBoxTituloRss
            // 
            this.textBoxTituloRss.Location = new System.Drawing.Point(83, 33);
            this.textBoxTituloRss.Name = "textBoxTituloRss";
            this.textBoxTituloRss.Size = new System.Drawing.Size(194, 20);
            this.textBoxTituloRss.TabIndex = 1;
            // 
            // comboBoxTipoFuente
            // 
            this.comboBoxTipoFuente.FormattingEnabled = true;
            this.comboBoxTipoFuente.Items.AddRange(new object[] {
            "Rss",
            "Texto Fijo"});
            this.comboBoxTipoFuente.Location = new System.Drawing.Point(95, 10);
            this.comboBoxTipoFuente.Name = "comboBoxTipoFuente";
            this.comboBoxTipoFuente.Size = new System.Drawing.Size(194, 21);
            this.comboBoxTipoFuente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de fuente";
            // 
            // panelRss
            // 
            this.panelRss.Controls.Add(this.textBoxFuenteRss);
            this.panelRss.Controls.Add(this.label4);
            this.panelRss.Controls.Add(this.label1);
            this.panelRss.Controls.Add(this.textBoxTituloRss);
            this.panelRss.Location = new System.Drawing.Point(12, 37);
            this.panelRss.Name = "panelRss";
            this.panelRss.Size = new System.Drawing.Size(382, 175);
            this.panelRss.TabIndex = 6;
            this.panelRss.Visible = false;
            // 
            // panelTextoFijo
            // 
            this.panelTextoFijo.Controls.Add(this.listBoxPasosBanner);
            this.panelTextoFijo.Controls.Add(this.textBoxAgregarPasoBanner);
            this.panelTextoFijo.Controls.Add(this.textBoxTituloTextoFijo);
            this.panelTextoFijo.Controls.Add(this.label7);
            this.panelTextoFijo.Controls.Add(this.label5);
            this.panelTextoFijo.Location = new System.Drawing.Point(12, 37);
            this.panelTextoFijo.Name = "panelTextoFijo";
            this.panelTextoFijo.Size = new System.Drawing.Size(382, 175);
            this.panelTextoFijo.TabIndex = 6;
            this.panelTextoFijo.Visible = false;
            // 
            // listBoxPasosBanner
            // 
            this.listBoxPasosBanner.FormattingEnabled = true;
            this.listBoxPasosBanner.Location = new System.Drawing.Point(21, 96);
            this.listBoxPasosBanner.Name = "listBoxPasosBanner";
            this.listBoxPasosBanner.Size = new System.Drawing.Size(345, 69);
            this.listBoxPasosBanner.TabIndex = 6;
            // 
            // textBoxAgregarPasoBanner
            // 
            this.textBoxAgregarPasoBanner.Location = new System.Drawing.Point(21, 69);
            this.textBoxAgregarPasoBanner.Multiline = true;
            this.textBoxAgregarPasoBanner.Name = "textBoxAgregarPasoBanner";
            this.textBoxAgregarPasoBanner.Size = new System.Drawing.Size(345, 20);
            this.textBoxAgregarPasoBanner.TabIndex = 5;
            // 
            // textBoxTituloTextoFijo
            // 
            this.textBoxTituloTextoFijo.Location = new System.Drawing.Point(83, 12);
            this.textBoxTituloTextoFijo.Name = "textBoxTituloTextoFijo";
            this.textBoxTituloTextoFijo.Size = new System.Drawing.Size(194, 20);
            this.textBoxTituloTextoFijo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ingresar lineas separadas por [ENTER] (Suprimir para eliminar)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Titulo";
            // 
            // textBoxFuenteRss
            // 
            this.textBoxFuenteRss.Location = new System.Drawing.Point(79, 99);
            this.textBoxFuenteRss.Name = "textBoxFuenteRss";
            this.textBoxFuenteRss.Size = new System.Drawing.Size(283, 20);
            this.textBoxFuenteRss.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fuente Rss";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(237, 218);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(319, 218);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // VAbstractCrearModificarFuente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 253);
            this.Controls.Add(this.panelTextoFijo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTipoFuente);
            this.Controls.Add(this.panelRss);
            this.Name = "VAbstractCrearModificarFuente";
            this.Text = "VAbstractCrearModificarFuente";
            this.panelRss.ResumeLayout(false);
            this.panelRss.PerformLayout();
            this.panelTextoFijo.ResumeLayout(false);
            this.panelTextoFijo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox textBoxTituloRss;
        protected System.Windows.Forms.ComboBox comboBoxTipoFuente;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Panel panelRss;
        protected System.Windows.Forms.Panel panelTextoFijo;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox textBoxFuenteRss;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button buttonGuardar;
        protected System.Windows.Forms.Button buttonCancelar;
        protected System.Windows.Forms.TextBox textBoxAgregarPasoBanner;
        protected System.Windows.Forms.TextBox textBoxTituloTextoFijo;
        private System.Windows.Forms.ListBox listBoxPasosBanner;
    }
}