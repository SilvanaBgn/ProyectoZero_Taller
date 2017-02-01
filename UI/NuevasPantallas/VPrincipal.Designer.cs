namespace UI.NuevasPantallas
{
    partial class VPrincipal
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
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuaraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.verPantallaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuaraciónToolStripMenuItem,
            this.verPantallaCompletaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.menúToolStripMenuItem.Text = "&Archivo";
            // 
            // configuaraciónToolStripMenuItem
            // 
            this.configuaraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bannerToolStripMenuItem,
            this.campañaToolStripMenuItem,
            this.fuenteToolStripMenuItem});
            this.configuaraciónToolStripMenuItem.Name = "configuaraciónToolStripMenuItem";
            this.configuaraciónToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.configuaraciónToolStripMenuItem.Text = "&Configuaración";
            // 
            // bannerToolStripMenuItem
            // 
            this.bannerToolStripMenuItem.Name = "bannerToolStripMenuItem";
            this.bannerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bannerToolStripMenuItem.Text = "&Banner";
            this.bannerToolStripMenuItem.Click += new System.EventHandler(this.bannerToolStripMenuItem_Click);
            // 
            // campañaToolStripMenuItem
            // 
            this.campañaToolStripMenuItem.Name = "campañaToolStripMenuItem";
            this.campañaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.campañaToolStripMenuItem.Text = "&Campaña";
            this.campañaToolStripMenuItem.Click += new System.EventHandler(this.campañaToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fuenteToolStripMenuItem.Text = "&Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 378);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 412);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1025, 114);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // verPantallaCompletaToolStripMenuItem
            // 
            this.verPantallaCompletaToolStripMenuItem.Name = "verPantallaCompletaToolStripMenuItem";
            this.verPantallaCompletaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.verPantallaCompletaToolStripMenuItem.Text = "&Ver pantalla completa";
            this.verPantallaCompletaToolStripMenuItem.Click += new System.EventHandler(this.verPantallaCompletaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VPrincipal";
            this.Text = "VPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuaraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bannerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem verPantallaCompletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}