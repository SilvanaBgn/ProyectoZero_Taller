using System.Windows.Forms;

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
            this.textBoxDescripcionRss = new System.Windows.Forms.TextBox();
            this.comboBoxTipoFuente = new System.Windows.Forms.ComboBox();
            this.labelTipoFuente = new System.Windows.Forms.Label();
            this.panelRss = new System.Windows.Forms.Panel();
            this.textBoxFuenteRss = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxPasosBanner = new System.Windows.Forms.ListBox();
            this.textBoxAgregarPasoBanner = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionTextoFijo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.bgwActualizarRssAlGuardar = new System.ComponentModel.BackgroundWorker();
            this.panelTextoFijo = new System.Windows.Forms.Panel();
            this.textoFijo = new UI.UserControls.TextoFijo();
            this.panelRss.SuspendLayout();
            this.panelTextoFijo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // textBoxDescripcionRss
            // 
            this.textBoxDescripcionRss.Location = new System.Drawing.Point(83, 33);
            this.textBoxDescripcionRss.MaxLength = 30;
            this.textBoxDescripcionRss.Name = "textBoxDescripcionRss";
            this.textBoxDescripcionRss.ShortcutsEnabled = false;
            this.textBoxDescripcionRss.Size = new System.Drawing.Size(194, 20);
            this.textBoxDescripcionRss.TabIndex = 1;
            this.textBoxDescripcionRss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValido_KeyPress);
            // 
            // comboBoxTipoFuente
            // 
            this.comboBoxTipoFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoFuente.FormattingEnabled = true;
            this.comboBoxTipoFuente.Items.AddRange(new object[] {
            "Rss",
            "Texto Fijo"});
            this.comboBoxTipoFuente.Location = new System.Drawing.Point(98, 10);
            this.comboBoxTipoFuente.Name = "comboBoxTipoFuente";
            this.comboBoxTipoFuente.Size = new System.Drawing.Size(194, 21);
            this.comboBoxTipoFuente.TabIndex = 4;
            this.comboBoxTipoFuente.SelectedValueChanged += new System.EventHandler(this.MostrarPanel);
            // 
            // labelTipoFuente
            // 
            this.labelTipoFuente.AutoSize = true;
            this.labelTipoFuente.Location = new System.Drawing.Point(13, 13);
            this.labelTipoFuente.Name = "labelTipoFuente";
            this.labelTipoFuente.Size = new System.Drawing.Size(79, 13);
            this.labelTipoFuente.TabIndex = 5;
            this.labelTipoFuente.Text = "Tipo de Fuente";
            // 
            // panelRss
            // 
            this.panelRss.Controls.Add(this.textBoxFuenteRss);
            this.panelRss.Controls.Add(this.label4);
            this.panelRss.Controls.Add(this.label1);
            this.panelRss.Controls.Add(this.textBoxDescripcionRss);
            this.panelRss.Location = new System.Drawing.Point(12, 37);
            this.panelRss.Name = "panelRss";
            this.panelRss.Size = new System.Drawing.Size(382, 175);
            this.panelRss.TabIndex = 6;
            this.panelRss.Visible = false;
            // 
            // textBoxFuenteRss
            // 
            this.textBoxFuenteRss.Location = new System.Drawing.Point(79, 99);
            this.textBoxFuenteRss.MaxLength = 50;
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
            this.textBoxAgregarPasoBanner.MaxLength = 50;
            this.textBoxAgregarPasoBanner.Multiline = true;
            this.textBoxAgregarPasoBanner.Name = "textBoxAgregarPasoBanner";
            this.textBoxAgregarPasoBanner.Size = new System.Drawing.Size(345, 20);
            this.textBoxAgregarPasoBanner.TabIndex = 5;
            // 
            // textBoxDescripcionTextoFijo
            // 
            this.textBoxDescripcionTextoFijo.Location = new System.Drawing.Point(83, 12);
            this.textBoxDescripcionTextoFijo.MaxLength = 30;
            this.textBoxDescripcionTextoFijo.Name = "textBoxDescripcionTextoFijo";
            this.textBoxDescripcionTextoFijo.ShortcutsEnabled = false;
            this.textBoxDescripcionTextoFijo.Size = new System.Drawing.Size(194, 20);
            this.textBoxDescripcionTextoFijo.TabIndex = 3;
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
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descripcion";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(283, 283);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 7;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(365, 283);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 8;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // panelTextoFijo
            // 
            this.panelTextoFijo.Controls.Add(this.textoFijo);
            this.panelTextoFijo.Location = new System.Drawing.Point(11, 37);
            this.panelTextoFijo.Name = "panelTextoFijo";
            this.panelTextoFijo.Size = new System.Drawing.Size(438, 240);
            this.panelTextoFijo.TabIndex = 9;
            // 
            // textoFijo
            // 
            this.textoFijo.Descripcion = "";
            this.textoFijo.Location = new System.Drawing.Point(3, 7);
            this.textoFijo.Name = "textoFijo";
            this.textoFijo.Size = new System.Drawing.Size(420, 238);
            this.textoFijo.TabIndex = 0;
            // 
            // VAbstractCrearModificarFuente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(461, 309);
            this.Controls.Add(this.panelTextoFijo);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelTipoFuente);
            this.Controls.Add(this.comboBoxTipoFuente);
            this.Controls.Add(this.panelRss);
            this.Name = "VAbstractCrearModificarFuente";
            this.Text = "VAbstractCrearModificarFuente";
            this.panelRss.ResumeLayout(false);
            this.panelRss.PerformLayout();
            this.panelTextoFijo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox textBoxDescripcionRss;
        protected System.Windows.Forms.ComboBox comboBoxTipoFuente;
        private System.Windows.Forms.Label labelTipoFuente;
        protected System.Windows.Forms.Panel panelRss;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox textBoxFuenteRss;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        protected System.Windows.Forms.TextBox textBoxAgregarPasoBanner;
        protected System.Windows.Forms.TextBox textBoxDescripcionTextoFijo;
        protected System.Windows.Forms.ListBox listBoxPasosBanner;
        protected System.ComponentModel.BackgroundWorker bgwActualizarRssAlGuardar;
        protected System.Windows.Forms.Panel panelTextoFijo;
        protected UserControls.TextoFijo textoFijo;
    }
}