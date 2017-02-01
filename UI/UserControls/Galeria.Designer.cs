namespace UI.UserControls
{
    partial class Galeria
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
            this.textBoxSegundos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonEliminarImagen = new System.Windows.Forms.Button();
            this.campaniaDeslizante1 = new UI.UserControls.CampaniaDeslizante();
            this.buttonVistaPrevia = new System.Windows.Forms.Button();
            this.buttonAgregarImagenes = new System.Windows.Forms.Button();
            this.buttonArriba = new System.Windows.Forms.Button();
            this.buttonAbajo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSegundos
            // 
            this.textBoxSegundos.Location = new System.Drawing.Point(51, 160);
            this.textBoxSegundos.Name = "textBoxSegundos";
            this.textBoxSegundos.Size = new System.Drawing.Size(33, 20);
            this.textBoxSegundos.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Seg :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumero,
            this.columnNombre,
            this.columnUrl});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(7, 6);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(203, 141);
            this.listView1.TabIndex = 53;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnNumero
            // 
            this.columnNumero.Text = "Num";
            this.columnNumero.Width = 40;
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 159;
            // 
            // columnUrl
            // 
            this.columnUrl.Text = "Url";
            this.columnUrl.Width = 0;
            // 
            // buttonEliminarImagen
            // 
            this.buttonEliminarImagen.BackgroundImage = global::UI.Properties.Resources.Eliminar4;
            this.buttonEliminarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminarImagen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEliminarImagen.Location = new System.Drawing.Point(141, 153);
            this.buttonEliminarImagen.Name = "buttonEliminarImagen";
            this.buttonEliminarImagen.Size = new System.Drawing.Size(28, 31);
            this.buttonEliminarImagen.TabIndex = 62;
            this.buttonEliminarImagen.UseVisualStyleBackColor = true;
            this.buttonEliminarImagen.Click += new System.EventHandler(this.buttonEliminarImagen_Click);
            // 
            // campaniaDeslizante1
            // 
            this.campaniaDeslizante1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.campaniaDeslizante1.ErrorImage = global::UI.Properties.Resources.Sin_imagen;
            this.campaniaDeslizante1.Location = new System.Drawing.Point(270, 6);
            this.campaniaDeslizante1.Name = "campaniaDeslizante1";
            this.campaniaDeslizante1.Size = new System.Drawing.Size(215, 179);
            this.campaniaDeslizante1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.campaniaDeslizante1.TabIndex = 50;
            this.campaniaDeslizante1.TabStop = false;
            // 
            // buttonVistaPrevia
            // 
            this.buttonVistaPrevia.AutoSize = true;
            this.buttonVistaPrevia.BackgroundImage = global::UI.Properties.Resources.Play1;
            this.buttonVistaPrevia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVistaPrevia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVistaPrevia.Location = new System.Drawing.Point(178, 153);
            this.buttonVistaPrevia.Name = "buttonVistaPrevia";
            this.buttonVistaPrevia.Size = new System.Drawing.Size(30, 31);
            this.buttonVistaPrevia.TabIndex = 49;
            this.buttonVistaPrevia.UseVisualStyleBackColor = true;
            this.buttonVistaPrevia.Click += new System.EventHandler(this.buttonVistaPrevia_Click);
            // 
            // buttonAgregarImagenes
            // 
            this.buttonAgregarImagenes.AutoSize = true;
            this.buttonAgregarImagenes.BackgroundImage = global::UI.Properties.Resources.AgregarImagen1;
            this.buttonAgregarImagenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAgregarImagenes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAgregarImagenes.Location = new System.Drawing.Point(111, 153);
            this.buttonAgregarImagenes.Name = "buttonAgregarImagenes";
            this.buttonAgregarImagenes.Size = new System.Drawing.Size(29, 31);
            this.buttonAgregarImagenes.TabIndex = 48;
            this.buttonAgregarImagenes.UseVisualStyleBackColor = true;
            this.buttonAgregarImagenes.Click += new System.EventHandler(this.buttonAgregarImagenes_Click);
            // 
            // buttonArriba
            // 
            this.buttonArriba.AutoSize = true;
            this.buttonArriba.BackgroundImage = global::UI.Properties.Resources.Arriba1;
            this.buttonArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonArriba.FlatAppearance.BorderSize = 0;
            this.buttonArriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArriba.Location = new System.Drawing.Point(212, 33);
            this.buttonArriba.Name = "buttonArriba";
            this.buttonArriba.Size = new System.Drawing.Size(53, 54);
            this.buttonArriba.TabIndex = 51;
            this.buttonArriba.UseVisualStyleBackColor = true;
            this.buttonArriba.Click += new System.EventHandler(this.buttonArriba_Click);
            // 
            // buttonAbajo
            // 
            this.buttonAbajo.AutoSize = true;
            this.buttonAbajo.BackgroundImage = global::UI.Properties.Resources.Abajo1;
            this.buttonAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAbajo.FlatAppearance.BorderSize = 0;
            this.buttonAbajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbajo.Location = new System.Drawing.Point(212, 91);
            this.buttonAbajo.Name = "buttonAbajo";
            this.buttonAbajo.Size = new System.Drawing.Size(53, 54);
            this.buttonAbajo.TabIndex = 52;
            this.buttonAbajo.UseVisualStyleBackColor = true;
            this.buttonAbajo.Click += new System.EventHandler(this.buttonAbajo_Click);
            // 
            // Galeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEliminarImagen);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.campaniaDeslizante1);
            this.Controls.Add(this.buttonVistaPrevia);
            this.Controls.Add(this.buttonAgregarImagenes);
            this.Controls.Add(this.textBoxSegundos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonArriba);
            this.Controls.Add(this.buttonAbajo);
            this.Name = "Galeria";
            this.Size = new System.Drawing.Size(488, 189);
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.TextBox textBoxSegundos;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button buttonVistaPrevia;
        private System.Windows.Forms.Button buttonAgregarImagenes;
        private CampaniaDeslizante campaniaDeslizante1;
        protected System.Windows.Forms.Button buttonAbajo;
        protected System.Windows.Forms.Button buttonArriba;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnUrl;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnNumero;
        private System.Windows.Forms.Button buttonEliminarImagen;
    }
}
