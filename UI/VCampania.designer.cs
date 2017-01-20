namespace UI
{
    partial class VCampania
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaDeInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaDeFinalizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porCódigoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porDescripciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaDeInicioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewCampania = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCampania)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ordenarToolStripMenuItem,
            this.buscarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem1,
            this.borrarToolStripMenuItem1});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem1.Text = "&Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // borrarToolStripMenuItem1
            // 
            this.borrarToolStripMenuItem1.Name = "borrarToolStripMenuItem1";
            this.borrarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.borrarToolStripMenuItem1.Text = "&Borrar";
            this.borrarToolStripMenuItem1.Click += new System.EventHandler(this.borrarToolStripMenuItem1_Click);
            // 
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCódigoToolStripMenuItem,
            this.porFechaDeInicioToolStripMenuItem,
            this.porFechaDeFinalizaciónToolStripMenuItem});
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ordenarToolStripMenuItem.Text = "&Ordenar";
            // 
            // porCódigoToolStripMenuItem
            // 
            this.porCódigoToolStripMenuItem.Name = "porCódigoToolStripMenuItem";
            this.porCódigoToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.porCódigoToolStripMenuItem.Text = "Por &Código";
            // 
            // porFechaDeInicioToolStripMenuItem
            // 
            this.porFechaDeInicioToolStripMenuItem.Name = "porFechaDeInicioToolStripMenuItem";
            this.porFechaDeInicioToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.porFechaDeInicioToolStripMenuItem.Text = "Por &Fecha de inicio";
            // 
            // porFechaDeFinalizaciónToolStripMenuItem
            // 
            this.porFechaDeFinalizaciónToolStripMenuItem.Name = "porFechaDeFinalizaciónToolStripMenuItem";
            this.porFechaDeFinalizaciónToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.porFechaDeFinalizaciónToolStripMenuItem.Text = "Por F&echa de finalización";
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCódigoToolStripMenuItem1,
            this.porDescripciónToolStripMenuItem,
            this.porFechaDeInicioToolStripMenuItem1});
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem1.Text = "&Buscar";
            // 
            // porCódigoToolStripMenuItem1
            // 
            this.porCódigoToolStripMenuItem1.Name = "porCódigoToolStripMenuItem1";
            this.porCódigoToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.porCódigoToolStripMenuItem1.Text = "Por &Código";
            // 
            // porDescripciónToolStripMenuItem
            // 
            this.porDescripciónToolStripMenuItem.Name = "porDescripciónToolStripMenuItem";
            this.porDescripciónToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.porDescripciónToolStripMenuItem.Text = "Por &Descripción";
            // 
            // porFechaDeInicioToolStripMenuItem1
            // 
            this.porFechaDeInicioToolStripMenuItem1.Name = "porFechaDeInicioToolStripMenuItem1";
            this.porFechaDeInicioToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.porFechaDeInicioToolStripMenuItem1.Text = "Por &Fecha de inicio";
            // 
            // dataGridViewCampania
            // 
            this.dataGridViewCampania.AllowUserToOrderColumns = true;
            this.dataGridViewCampania.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCampania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCampania.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCampania.Location = new System.Drawing.Point(0, 522);
            this.dataGridViewCampania.Name = "dataGridViewCampania";
            this.dataGridViewCampania.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCampania.Size = new System.Drawing.Size(1222, 147);
            this.dataGridViewCampania.TabIndex = 1;
            // 
            // VCampania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1222, 669);
            this.Controls.Add(this.dataGridViewCampania);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VCampania";
            this.Text = "Configuración Campaña";
            this.Load += new System.EventHandler(this.VCampania_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCampania)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewCampania;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFechaDeInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFechaDeFinalizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porCódigoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porDescripciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFechaDeInicioToolStripMenuItem1;
    }
}