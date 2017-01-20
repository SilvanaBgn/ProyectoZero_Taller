namespace UI
{
    partial class VBanner
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
            this.textoPlanoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteRssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCódigoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porDescripciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porFechaDeInicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porHoraDeInicioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porCódigoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.porDescripciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewBanners = new System.Windows.Forms.DataGridView();
            this.dataGridViewFuentesRss = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuentesRss)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoPlanoToolStripMenuItem,
            this.fuenteRssToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // textoPlanoToolStripMenuItem
            // 
            this.textoPlanoToolStripMenuItem.Name = "textoPlanoToolStripMenuItem";
            this.textoPlanoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.textoPlanoToolStripMenuItem.Text = "&Banner";
            this.textoPlanoToolStripMenuItem.Click += new System.EventHandler(this.textoPlanoToolStripMenuItem_Click);
            // 
            // fuenteRssToolStripMenuItem
            // 
            this.fuenteRssToolStripMenuItem.Name = "fuenteRssToolStripMenuItem";
            this.fuenteRssToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.fuenteRssToolStripMenuItem.Text = "&Fuente Rss";
            this.fuenteRssToolStripMenuItem.Click += new System.EventHandler(this.fuenteRssToolStripMenuItem_Click);
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
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCódigoToolStripMenuItem,
            this.porToolStripMenuItem1});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "&Buscar";
            // 
            // porCódigoToolStripMenuItem
            // 
            this.porCódigoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCódigoToolStripMenuItem1,
            this.porDescripciónToolStripMenuItem,
            this.porFechaDeInicioToolStripMenuItem,
            this.porHoraDeInicioToolStripMenuItem1});
            this.porCódigoToolStripMenuItem.Name = "porCódigoToolStripMenuItem";
            this.porCódigoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.porCódigoToolStripMenuItem.Text = "&Banner";
            // 
            // porCódigoToolStripMenuItem1
            // 
            this.porCódigoToolStripMenuItem1.Name = "porCódigoToolStripMenuItem1";
            this.porCódigoToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.porCódigoToolStripMenuItem1.Text = "Por &Código";
            this.porCódigoToolStripMenuItem1.Click += new System.EventHandler(this.porCódigoToolStripMenuItem1_Click);
            // 
            // porDescripciónToolStripMenuItem
            // 
            this.porDescripciónToolStripMenuItem.Name = "porDescripciónToolStripMenuItem";
            this.porDescripciónToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.porDescripciónToolStripMenuItem.Text = "Por &Descripción";
            this.porDescripciónToolStripMenuItem.Click += new System.EventHandler(this.porDescripciónToolStripMenuItem_Click);
            // 
            // porFechaDeInicioToolStripMenuItem
            // 
            this.porFechaDeInicioToolStripMenuItem.Name = "porFechaDeInicioToolStripMenuItem";
            this.porFechaDeInicioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.porFechaDeInicioToolStripMenuItem.Text = "Por &Fecha de Inicio";
            this.porFechaDeInicioToolStripMenuItem.Click += new System.EventHandler(this.porFechaDeInicioToolStripMenuItem_Click);
            // 
            // porHoraDeInicioToolStripMenuItem1
            // 
            this.porHoraDeInicioToolStripMenuItem1.Name = "porHoraDeInicioToolStripMenuItem1";
            this.porHoraDeInicioToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.porHoraDeInicioToolStripMenuItem1.Text = "Por &Hora de Inicio";
            this.porHoraDeInicioToolStripMenuItem1.Click += new System.EventHandler(this.porHoraDeInicioToolStripMenuItem1_Click);
            // 
            // porToolStripMenuItem1
            // 
            this.porToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCódigoToolStripMenuItem2,
            this.porDescripciónToolStripMenuItem1});
            this.porToolStripMenuItem1.Name = "porToolStripMenuItem1";
            this.porToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.porToolStripMenuItem1.Text = "&Fuente Rss";
            // 
            // porCódigoToolStripMenuItem2
            // 
            this.porCódigoToolStripMenuItem2.Name = "porCódigoToolStripMenuItem2";
            this.porCódigoToolStripMenuItem2.Size = new System.Drawing.Size(157, 22);
            this.porCódigoToolStripMenuItem2.Text = "Por &Código";
            this.porCódigoToolStripMenuItem2.Click += new System.EventHandler(this.porCódigoToolStripMenuItem2_Click);
            // 
            // porDescripciónToolStripMenuItem1
            // 
            this.porDescripciónToolStripMenuItem1.Name = "porDescripciónToolStripMenuItem1";
            this.porDescripciónToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.porDescripciónToolStripMenuItem1.Text = "Por &Descripción";
            this.porDescripciónToolStripMenuItem1.Click += new System.EventHandler(this.porDescripciónToolStripMenuItem1_Click);
            // 
            // dataGridViewBanners
            // 
            this.dataGridViewBanners.AllowUserToOrderColumns = true;
            this.dataGridViewBanners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBanners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBanners.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBanners.Location = new System.Drawing.Point(0, 522);
            this.dataGridViewBanners.Name = "dataGridViewBanners";
            this.dataGridViewBanners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBanners.Size = new System.Drawing.Size(1222, 147);
            this.dataGridViewBanners.TabIndex = 5;
            this.dataGridViewBanners.Enter += new System.EventHandler(this.dataGridViewBanners_Enter);
            // 
            // dataGridViewFuentesRss
            // 
            this.dataGridViewFuentesRss.AllowUserToOrderColumns = true;
            this.dataGridViewFuentesRss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFuentesRss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFuentesRss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuentesRss.Location = new System.Drawing.Point(886, 27);
            this.dataGridViewFuentesRss.Name = "dataGridViewFuentesRss";
            this.dataGridViewFuentesRss.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFuentesRss.Size = new System.Drawing.Size(336, 543);
            this.dataGridViewFuentesRss.TabIndex = 4;
            this.dataGridViewFuentesRss.Enter += new System.EventHandler(this.dataGridViewFuentesRss_Enter);
            // 
            // VBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1222, 669);
            this.Controls.Add(this.dataGridViewBanners);
            this.Controls.Add(this.dataGridViewFuentesRss);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VBanner";
            this.Text = "Configuración Banner";
            this.Load += new System.EventHandler(this.VBanner_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBanners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuentesRss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoPlanoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteRssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridViewBanners;
        private System.Windows.Forms.ToolStripMenuItem porCódigoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porDescripciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porFechaDeInicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porHoraDeInicioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porCódigoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem porDescripciónToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridViewFuentesRss;
    }
}

