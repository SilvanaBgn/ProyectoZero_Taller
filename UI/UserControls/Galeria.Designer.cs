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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVistaPrevia = new System.Windows.Forms.Button();
            this.buttonAgregarImagenes = new System.Windows.Forms.Button();
            this.campaniaDeslizante1 = new UI.UserControls.CampaniaDeslizante();
            this.buttonAbajo = new System.Windows.Forms.Button();
            this.buttonArriba = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnBytes = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSegundos
            // 
            this.textBoxSegundos.Location = new System.Drawing.Point(81, 174);
            this.textBoxSegundos.Name = "textBoxSegundos";
            this.textBoxSegundos.Size = new System.Drawing.Size(37, 20);
            this.textBoxSegundos.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(22, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Segundos:";
            // 
            // buttonVistaPrevia
            // 
            this.buttonVistaPrevia.AutoSize = true;
            this.buttonVistaPrevia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVistaPrevia.Location = new System.Drawing.Point(177, 167);
            this.buttonVistaPrevia.Name = "buttonVistaPrevia";
            this.buttonVistaPrevia.Size = new System.Drawing.Size(51, 32);
            this.buttonVistaPrevia.TabIndex = 49;
            this.buttonVistaPrevia.Text = "Prueba";
            this.buttonVistaPrevia.UseVisualStyleBackColor = true;
            this.buttonVistaPrevia.Click += new System.EventHandler(this.buttonVistaPrevia_Click);
            // 
            // buttonAgregarImagenes
            // 
            this.buttonAgregarImagenes.AutoSize = true;
            this.buttonAgregarImagenes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAgregarImagenes.Location = new System.Drawing.Point(117, 167);
            this.buttonAgregarImagenes.Name = "buttonAgregarImagenes";
            this.buttonAgregarImagenes.Size = new System.Drawing.Size(54, 32);
            this.buttonAgregarImagenes.TabIndex = 48;
            this.buttonAgregarImagenes.Text = "Agregar";
            this.buttonAgregarImagenes.UseVisualStyleBackColor = true;
            this.buttonAgregarImagenes.Click += new System.EventHandler(this.buttonAgregarImagenes_Click);
            // 
            // campaniaDeslizante1
            // 
            this.campaniaDeslizante1.Location = new System.Drawing.Point(304, 20);
            this.campaniaDeslizante1.Name = "campaniaDeslizante1";
            this.campaniaDeslizante1.Size = new System.Drawing.Size(215, 179);
            this.campaniaDeslizante1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.campaniaDeslizante1.TabIndex = 50;
            this.campaniaDeslizante1.TabStop = false;
            // 
            // buttonAbajo
            // 
            this.buttonAbajo.AutoSize = true;
            this.buttonAbajo.FlatAppearance.BorderSize = 0;
            this.buttonAbajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbajo.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbajo.Image")));
            this.buttonAbajo.Location = new System.Drawing.Point(228, 91);
            this.buttonAbajo.Name = "buttonAbajo";
            this.buttonAbajo.Size = new System.Drawing.Size(70, 70);
            this.buttonAbajo.TabIndex = 52;
            this.buttonAbajo.UseVisualStyleBackColor = true;
            // 
            // buttonArriba
            // 
            this.buttonArriba.AutoSize = true;
            this.buttonArriba.FlatAppearance.BorderSize = 0;
            this.buttonArriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArriba.Image = ((System.Drawing.Image)(resources.GetObject("buttonArriba.Image")));
            this.buttonArriba.Location = new System.Drawing.Point(228, 20);
            this.buttonArriba.Name = "buttonArriba";
            this.buttonArriba.Size = new System.Drawing.Size(70, 70);
            this.buttonArriba.TabIndex = 51;
            this.buttonArriba.UseVisualStyleBackColor = true;
            this.buttonArriba.Click += new System.EventHandler(this.buttonArriba_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnBytes});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(25, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(203, 141);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // columnBytes
            // 
            this.columnBytes.HeaderText = "Imagen";
            this.columnBytes.Name = "columnBytes";
            this.columnBytes.ReadOnly = true;
            this.columnBytes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Galeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.campaniaDeslizante1);
            this.Controls.Add(this.buttonVistaPrevia);
            this.Controls.Add(this.buttonAgregarImagenes);
            this.Controls.Add(this.textBoxSegundos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonArriba);
            this.Controls.Add(this.buttonAbajo);
            this.Name = "Galeria";
            this.Size = new System.Drawing.Size(585, 223);
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn columnBytes;
    }
}
