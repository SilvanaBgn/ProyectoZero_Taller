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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Galeria));
            this.textBoxSegundos = new System.Windows.Forms.TextBox();
            this.labelSeg = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBytes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonArriba = new System.Windows.Forms.Button();
            this.buttonAbajo = new System.Windows.Forms.Button();
            this.buttonEliminarImagen = new System.Windows.Forms.Button();
            this.buttonVistaPrevia = new System.Windows.Forms.Button();
            this.buttonAgregarImagenes = new System.Windows.Forms.Button();
            this.campaniaDeslizante = new UI.UserControls.CampaniaDeslizante();
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSegundos
            // 
            this.textBoxSegundos.Location = new System.Drawing.Point(48, 160);
            this.textBoxSegundos.Name = "textBoxSegundos";
            this.textBoxSegundos.Size = new System.Drawing.Size(33, 20);
            this.textBoxSegundos.TabIndex = 30;
            // 
            // labelSeg
            // 
            this.labelSeg.AutoSize = true;
            this.labelSeg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSeg.Location = new System.Drawing.Point(14, 163);
            this.labelSeg.Name = "labelSeg";
            this.labelSeg.Size = new System.Drawing.Size(26, 13);
            this.labelSeg.TabIndex = 29;
            this.labelSeg.Text = "Seg";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNumero,
            this.columnNombre,
            this.columnBytes});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 9);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(182, 141);
            this.listView.TabIndex = 53;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnNumero
            // 
            this.columnNumero.Text = "Id";
            this.columnNumero.Width = 23;
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 154;
            // 
            // columnBytes
            // 
            this.columnBytes.Text = "Bytes";
            this.columnBytes.Width = 0;
            // 
            // buttonArriba
            // 
            this.buttonArriba.AutoSize = true;
            this.buttonArriba.BackgroundImage = global::UI.Properties.Resources.Arriba1;
            this.buttonArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonArriba.FlatAppearance.BorderSize = 0;
            this.buttonArriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArriba.Location = new System.Drawing.Point(195, 35);
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
            this.buttonAbajo.Location = new System.Drawing.Point(195, 93);
            this.buttonAbajo.Name = "buttonAbajo";
            this.buttonAbajo.Size = new System.Drawing.Size(53, 54);
            this.buttonAbajo.TabIndex = 52;
            this.buttonAbajo.UseVisualStyleBackColor = true;
            this.buttonAbajo.Click += new System.EventHandler(this.buttonAbajo_Click);
            // 
            // buttonEliminarImagen
            // 
            this.buttonEliminarImagen.BackgroundImage = global::UI.Properties.Resources.Eliminar4;
            this.buttonEliminarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminarImagen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEliminarImagen.Location = new System.Drawing.Point(127, 154);
            this.buttonEliminarImagen.Name = "buttonEliminarImagen";
            this.buttonEliminarImagen.Size = new System.Drawing.Size(28, 31);
            this.buttonEliminarImagen.TabIndex = 62;
            this.buttonEliminarImagen.UseVisualStyleBackColor = true;
            this.buttonEliminarImagen.Click += new System.EventHandler(this.buttonEliminarImagen_Click);
            // 
            // buttonVistaPrevia
            // 
            this.buttonVistaPrevia.AutoSize = true;
            this.buttonVistaPrevia.BackgroundImage = global::UI.Properties.Resources.Play1;
            this.buttonVistaPrevia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVistaPrevia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVistaPrevia.Location = new System.Drawing.Point(164, 154);
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
            this.buttonAgregarImagenes.Location = new System.Drawing.Point(97, 154);
            this.buttonAgregarImagenes.Name = "buttonAgregarImagenes";
            this.buttonAgregarImagenes.Size = new System.Drawing.Size(29, 31);
            this.buttonAgregarImagenes.TabIndex = 48;
            this.buttonAgregarImagenes.UseVisualStyleBackColor = true;
            this.buttonAgregarImagenes.Click += new System.EventHandler(this.buttonAgregarImagenes_Click);
            // 
            // campaniaDeslizante
            // 
            this.campaniaDeslizante.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.campaniaDeslizante.Image = ((System.Drawing.Image)(resources.GetObject("campaniaDeslizante.Image")));
            this.campaniaDeslizante.Location = new System.Drawing.Point(270, 6);
            this.campaniaDeslizante.Name = "campaniaDeslizante";
            this.campaniaDeslizante.Size = new System.Drawing.Size(215, 179);
            this.campaniaDeslizante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.campaniaDeslizante.TabIndex = 50;
            this.campaniaDeslizante.TabStop = false;
            // 
            // Galeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEliminarImagen);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.campaniaDeslizante);
            this.Controls.Add(this.buttonVistaPrevia);
            this.Controls.Add(this.buttonAgregarImagenes);
            this.Controls.Add(this.textBoxSegundos);
            this.Controls.Add(this.labelSeg);
            this.Controls.Add(this.buttonArriba);
            this.Controls.Add(this.buttonAbajo);
            this.Name = "Galeria";
            this.Size = new System.Drawing.Size(488, 189);
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.TextBox textBoxSegundos;
        private System.Windows.Forms.Label labelSeg;
        protected System.Windows.Forms.Button buttonVistaPrevia;
        private System.Windows.Forms.Button buttonAgregarImagenes;
        private UI.UserControls.CampaniaDeslizante campaniaDeslizante;
        protected System.Windows.Forms.Button buttonAbajo;
        protected System.Windows.Forms.Button buttonArriba;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnBytes;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnNumero;
        private System.Windows.Forms.Button buttonEliminarImagen;
    }
}
