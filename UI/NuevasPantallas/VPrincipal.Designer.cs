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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VPrincipal));
            this.groupBoxCampania = new System.Windows.Forms.GroupBox();
            this.labelTituloCampania = new System.Windows.Forms.Label();
            this.groupBoxBanner = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bannersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campañasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwLeerBanner = new System.ComponentModel.BackgroundWorker();
            this.bgwLeerCampania = new System.ComponentModel.BackgroundWorker();
            this.timerChequeoCambioBanner = new System.Windows.Forms.Timer(this.components);
            this.bgwInicializacionTimer = new System.ComponentModel.BackgroundWorker();
            this.groupBoxCampania.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCampania
            // 
            this.groupBoxCampania.Controls.Add(this.labelTituloCampania);
            this.groupBoxCampania.Location = new System.Drawing.Point(27, 31);
            this.groupBoxCampania.Name = "groupBoxCampania";
            this.groupBoxCampania.Size = new System.Drawing.Size(587, 503);
            this.groupBoxCampania.TabIndex = 1;
            this.groupBoxCampania.TabStop = false;
            // 
            // labelTituloCampania
            // 
            this.labelTituloCampania.AutoSize = true;
            this.labelTituloCampania.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCampania.Location = new System.Drawing.Point(26, 28);
            this.labelTituloCampania.Name = "labelTituloCampania";
            this.labelTituloCampania.Size = new System.Drawing.Size(226, 25);
            this.labelTituloCampania.TabIndex = 1;
            this.labelTituloCampania.Text = "(Título de la campaña)";
            // 
            // groupBoxBanner
            // 
            this.groupBoxBanner.Location = new System.Drawing.Point(27, 540);
            this.groupBoxBanner.Name = "groupBoxBanner";
            this.groupBoxBanner.Size = new System.Drawing.Size(587, 106);
            this.groupBoxBanner.TabIndex = 2;
            this.groupBoxBanner.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoToolStripMenuItem,
            this.campañasToolStripMenuItem,
            this.pantallaCompletaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bannersToolStripMenuItem,
            this.fuentesToolStripMenuItem});
            this.textoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("textoToolStripMenuItem.Image")));
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.textoToolStripMenuItem.Text = "&Texto";
            // 
            // bannersToolStripMenuItem
            // 
            this.bannersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bannersToolStripMenuItem.Image")));
            this.bannersToolStripMenuItem.Name = "bannersToolStripMenuItem";
            this.bannersToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.bannersToolStripMenuItem.Text = "&Banners";
            // 
            // fuentesToolStripMenuItem
            // 
            this.fuentesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fuentesToolStripMenuItem.Image")));
            this.fuentesToolStripMenuItem.Name = "fuentesToolStripMenuItem";
            this.fuentesToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.fuentesToolStripMenuItem.Text = "&Fuentes";
            // 
            // campañasToolStripMenuItem
            // 
            this.campañasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("campañasToolStripMenuItem.Image")));
            this.campañasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.campañasToolStripMenuItem.Name = "campañasToolStripMenuItem";
            this.campañasToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.campañasToolStripMenuItem.Text = "&Campañas";
            // 
            // pantallaCompletaToolStripMenuItem
            // 
            this.pantallaCompletaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pantallaCompletaToolStripMenuItem.Image")));
            this.pantallaCompletaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pantallaCompletaToolStripMenuItem.Name = "pantallaCompletaToolStripMenuItem";
            this.pantallaCompletaToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.pantallaCompletaToolStripMenuItem.Text = "&Vista";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // bgwLeerBanner
            // 
            this.bgwLeerBanner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLeerBanner_DoWork);
            this.bgwLeerBanner.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLeerBanner_RunWorkerCompleted);
            // 
            // bgwLeerCampania
            // 
            this.bgwLeerCampania.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLeerCampania_DoWork);
            this.bgwLeerCampania.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLeerCampania_RunWorkerCompleted);
            // 
            // timerChequeoCambioBanner
            // 
            this.timerChequeoCambioBanner.Tick += new System.EventHandler(this.timerChequeoCambioBanner_Tick);
            // 
            // bgwInicializacionTimer
            // 
            this.bgwInicializacionTimer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwInicializacionTimer_DoWork);
            this.bgwInicializacionTimer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwInicializacionTimer_RunWorkerCompleted);
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 664);
            this.Controls.Add(this.groupBoxBanner);
            this.Controls.Add(this.groupBoxCampania);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VPrincipal";
            this.Text = "EASY News";
            this.Resize += new System.EventHandler(this.VPrincipal_Resize);
            this.groupBoxCampania.ResumeLayout(false);
            this.groupBoxCampania.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBoxCampania;
        private System.Windows.Forms.GroupBox groupBoxBanner;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bannersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campañasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantallaCompletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label labelTituloCampania;
        private System.ComponentModel.BackgroundWorker bgwLeerBanner;
        private System.ComponentModel.BackgroundWorker bgwLeerCampania;
        private System.Windows.Forms.Timer timerChequeoCambioBanner;
        private System.ComponentModel.BackgroundWorker bgwInicializacionTimer;
    }
}