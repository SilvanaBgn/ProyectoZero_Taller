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
            this.comboBoxTipoFuente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoPlano2 = new UI.UserControls.TextoPlano();
            this.SuspendLayout();
            // 
            // comboBoxTipoFuente
            // 
            this.comboBoxTipoFuente.FormattingEnabled = true;
            this.comboBoxTipoFuente.Items.AddRange(new object[] {
            "Texto Plano",
            "RSS"});
            this.comboBoxTipoFuente.Location = new System.Drawing.Point(95, 10);
            this.comboBoxTipoFuente.Name = "comboBoxTipoFuente";
            this.comboBoxTipoFuente.Size = new System.Drawing.Size(194, 21);
            this.comboBoxTipoFuente.TabIndex = 4;
            this.comboBoxTipoFuente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Titulo";
            // 
            // textoPlano2
            // 
            this.textoPlano2.ListaItems = null;
            this.textoPlano2.Location = new System.Drawing.Point(12, 77);
            this.textoPlano2.Name = "textoPlano2";
            this.textoPlano2.Size = new System.Drawing.Size(427, 197);
            this.textoPlano2.TabIndex = 12;
            // 
            // VAbstractCrearModificarFuente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 315);
            this.Controls.Add(this.textoPlano2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTipoFuente);
            this.Name = "VAbstractCrearModificarFuente";
            this.Text = "VAbstractCrearModificarFuente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxTipoFuente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControls.TextoPlano textoPlano1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private UserControls.Galeria galeria1;
        private UserControls.TextoPlano textoPlano2;
    }
}