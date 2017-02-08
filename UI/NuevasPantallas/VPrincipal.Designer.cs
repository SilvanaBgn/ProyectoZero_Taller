using UI.UserControls;
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
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campañasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bannersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwLeerBanner = new System.ComponentModel.BackgroundWorker();
            this.bgwLeerCampania = new System.ComponentModel.BackgroundWorker();
            this.timerChequeoCambioBanner = new System.Windows.Forms.Timer(this.components);
            this.timerChequeoCambioCampania = new System.Windows.Forms.Timer(this.components);
            this.bannerDeslizante = new UI.UserControls.BannerDeslizante();
            this.campaniaDeslizante1 = new UI.UserControls.CampaniaDeslizante();
            this.groupBoxCampania.SuspendLayout();
            this.groupBoxBanner.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCampania
            // 
            this.groupBoxCampania.Controls.Add(this.campaniaDeslizante1);
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
            this.labelTituloCampania.Location = new System.Drawing.Point(13, 28);
            this.labelTituloCampania.Name = "labelTituloCampania";
            this.labelTituloCampania.Size = new System.Drawing.Size(226, 25);
            this.labelTituloCampania.TabIndex = 1;
            this.labelTituloCampania.Text = "(Título de la campaña)";
            // 
            // groupBoxBanner
            // 
            this.groupBoxBanner.Controls.Add(this.bannerDeslizante);
            this.groupBoxBanner.Location = new System.Drawing.Point(27, 555);
            this.groupBoxBanner.Name = "groupBoxBanner";
            this.groupBoxBanner.Size = new System.Drawing.Size(587, 91);
            this.groupBoxBanner.TabIndex = 2;
            this.groupBoxBanner.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.pantallaCompletaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campañasToolStripMenuItem,
            this.bannersToolStripMenuItem,
            this.fuentesToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.configuracionToolStripMenuItem.Text = "&Configuración";
            // 
            // campañasToolStripMenuItem
            // 
            this.campañasToolStripMenuItem.Name = "campañasToolStripMenuItem";
            this.campañasToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.campañasToolStripMenuItem.Text = "&Campañas";
            this.campañasToolStripMenuItem.Click += new System.EventHandler(this.campañaToolStripMenuItem_Click);
            // 
            // bannersToolStripMenuItem
            // 
            this.bannersToolStripMenuItem.Name = "bannersToolStripMenuItem";
            this.bannersToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.bannersToolStripMenuItem.Text = "&Banners";
            this.bannersToolStripMenuItem.Click += new System.EventHandler(this.bannerToolStripMenuItem_Click);
            // 
            // fuentesToolStripMenuItem
            // 
            this.fuentesToolStripMenuItem.Name = "fuentesToolStripMenuItem";
            this.fuentesToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.fuentesToolStripMenuItem.Text = "&Fuentes";
            this.fuentesToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // pantallaCompletaToolStripMenuItem
            // 
            this.pantallaCompletaToolStripMenuItem.Name = "pantallaCompletaToolStripMenuItem";
            this.pantallaCompletaToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.pantallaCompletaToolStripMenuItem.Text = "&Vista";
            this.pantallaCompletaToolStripMenuItem.Click += new System.EventHandler(this.verPantallaCompletaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            this.timerChequeoCambioBanner.Interval = 1000;
            this.timerChequeoCambioBanner.Tick += new System.EventHandler(this.timerChequeoCambioBanner_Tick);
            // 
            // timerChequeoCambioCampania
            // 
            this.timerChequeoCambioCampania.Interval = 1000;
            this.timerChequeoCambioCampania.Tick += new System.EventHandler(this.timerChequeoCambioCampania_Tick);
            // 
            // bannerDeslizante
            // 
            this.bannerDeslizante.Enabled = false;
            this.bannerDeslizante.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerDeslizante.Location = new System.Drawing.Point(17, 23);
            this.bannerDeslizante.Name = "bannerDeslizante";
            this.bannerDeslizante.Size = new System.Drawing.Size(550, 53);
            this.bannerDeslizante.TabIndex = 0;
            // 
            // campaniaDeslizante1
            // 
            this.campaniaDeslizante1.Image = ((System.Drawing.Image)(resources.GetObject("campaniaDeslizante1.Image")));
            this.campaniaDeslizante1.Location = new System.Drawing.Point(17, 68);
            this.campaniaDeslizante1.Name = "campaniaDeslizante1";
            this.campaniaDeslizante1.Size = new System.Drawing.Size(550, 418);
            this.campaniaDeslizante1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.campaniaDeslizante1.TabIndex = 2;
            this.campaniaDeslizante1.TabStop = false;
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
            this.Activated += new System.EventHandler(this.VPrincipal_Activated);
            this.Load += new System.EventHandler(this.VPrincipal_Load);
            this.Resize += new System.EventHandler(this.VPrincipal_Resize);
            this.groupBoxCampania.ResumeLayout(false);
            this.groupBoxCampania.PerformLayout();
            this.groupBoxBanner.ResumeLayout(false);
            this.groupBoxBanner.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBoxCampania;
        private System.Windows.Forms.GroupBox groupBoxBanner;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bannersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campañasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantallaCompletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label labelTituloCampania;
        private System.ComponentModel.BackgroundWorker bgwLeerBanner;
        private System.ComponentModel.BackgroundWorker bgwLeerCampania;
        private System.Windows.Forms.Timer timerChequeoCambioBanner;
        private BannerDeslizante bannerDeslizante;
        private CampaniaDeslizante campaniaDeslizante1;
        private System.Windows.Forms.Timer timerChequeoCambioCampania;
    }
}