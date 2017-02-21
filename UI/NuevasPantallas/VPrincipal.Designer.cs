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
            this.groupBoxBanner = new System.Windows.Forms.GroupBox();
            this.bannerDeslizante = new UI.UserControls.BannerDeslizante();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bgwObtenerBanner = new System.ComponentModel.BackgroundWorker();
            this.bgwObtenerCampania = new System.ComponentModel.BackgroundWorker();
            this.timerChequeoCambioBanner = new System.Windows.Forms.Timer(this.components);
            this.timerChequeoCambioCampania = new System.Windows.Forms.Timer(this.components);
            this.bgwLeerBanner = new System.ComponentModel.BackgroundWorker();
            this.buttonSalirPantallaCompleta = new System.Windows.Forms.Button();
            this.campaniaDeslizante1 = new UI.UserControls.CampaniaDeslizante();
            this.pantallaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campañasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bannersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCampania.SuspendLayout();
            this.groupBoxBanner.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCampania
            // 
            this.groupBoxCampania.Controls.Add(this.campaniaDeslizante1);
            this.groupBoxCampania.Location = new System.Drawing.Point(27, 30);
            this.groupBoxCampania.Name = "groupBoxCampania";
            this.groupBoxCampania.Size = new System.Drawing.Size(781, 503);
            this.groupBoxCampania.TabIndex = 1;
            this.groupBoxCampania.TabStop = false;
            // 
            // groupBoxBanner
            // 
            this.groupBoxBanner.Controls.Add(this.bannerDeslizante);
            this.groupBoxBanner.Location = new System.Drawing.Point(27, 535);
            this.groupBoxBanner.Name = "groupBoxBanner";
            this.groupBoxBanner.Size = new System.Drawing.Size(781, 91);
            this.groupBoxBanner.TabIndex = 2;
            this.groupBoxBanner.TabStop = false;
            // 
            // bannerDeslizante
            // 
            this.bannerDeslizante.BackColor = System.Drawing.Color.Bisque;
            this.bannerDeslizante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bannerDeslizante.Enabled = false;
            this.bannerDeslizante.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerDeslizante.Location = new System.Drawing.Point(22, 25);
            this.bannerDeslizante.Name = "bannerDeslizante";
            this.bannerDeslizante.Size = new System.Drawing.Size(735, 46);
            this.bannerDeslizante.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSalmon;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaCompletaToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bgwObtenerBanner
            // 
            this.bgwObtenerBanner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwObtenerBanner_DoWork);
            this.bgwObtenerBanner.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwObtenerBanner_ActualizarPantalla_RunWorkerCompleted);
            // 
            // bgwObtenerCampania
            // 
            this.bgwObtenerCampania.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwObtenerCampania_DoWork);
            this.bgwObtenerCampania.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwObtenerCampania_RunWorkerCompleted);
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
            // bgwLeerBanner
            // 
            this.bgwLeerBanner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLeerBanner_DoWork);
            this.bgwLeerBanner.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLeerBanner_RunWorkerCompleted);
            // 
            // buttonSalirPantallaCompleta
            // 
            this.buttonSalirPantallaCompleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSalirPantallaCompleta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSalirPantallaCompleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalirPantallaCompleta.Image = global::UI.Properties.Resources.salir3;
            this.buttonSalirPantallaCompleta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalirPantallaCompleta.Location = new System.Drawing.Point(1280, 5);
            this.buttonSalirPantallaCompleta.Name = "buttonSalirPantallaCompleta";
            this.buttonSalirPantallaCompleta.Size = new System.Drawing.Size(83, 42);
            this.buttonSalirPantallaCompleta.TabIndex = 3;
            this.buttonSalirPantallaCompleta.Text = "Salir";
            this.buttonSalirPantallaCompleta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalirPantallaCompleta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalirPantallaCompleta.UseVisualStyleBackColor = true;
            this.buttonSalirPantallaCompleta.Visible = false;
            this.buttonSalirPantallaCompleta.Click += new System.EventHandler(this.IniciarFormatoPantallaPrincipal);
            this.buttonSalirPantallaCompleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonSalirPantallaCompleta_KeyPress);
            // 
            // campaniaDeslizante1
            // 
            this.campaniaDeslizante1.Image = ((System.Drawing.Image)(resources.GetObject("campaniaDeslizante1.Image")));
            this.campaniaDeslizante1.Location = new System.Drawing.Point(22, 28);
            this.campaniaDeslizante1.Name = "campaniaDeslizante1";
            this.campaniaDeslizante1.Size = new System.Drawing.Size(735, 459);
            this.campaniaDeslizante1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.campaniaDeslizante1.TabIndex = 2;
            this.campaniaDeslizante1.TabStop = false;
            // 
            // pantallaCompletaToolStripMenuItem
            // 
            this.pantallaCompletaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pantallaCompletaToolStripMenuItem.Image = global::UI.Properties.Resources.Vista;
            this.pantallaCompletaToolStripMenuItem.Name = "pantallaCompletaToolStripMenuItem";
            this.pantallaCompletaToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.pantallaCompletaToolStripMenuItem.Text = "&Pantalla Completa";
            this.pantallaCompletaToolStripMenuItem.Click += new System.EventHandler(this.verPantallaCompletaToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campañasToolStripMenuItem,
            this.bannersToolStripMenuItem,
            this.fuentesToolStripMenuItem});
            this.configuracionToolStripMenuItem.Image = global::UI.Properties.Resources.Configuracion4;
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.configuracionToolStripMenuItem.Text = "&Configuración";
            // 
            // campañasToolStripMenuItem
            // 
            this.campañasToolStripMenuItem.Image = global::UI.Properties.Resources.AgregarImagen1;
            this.campañasToolStripMenuItem.Name = "campañasToolStripMenuItem";
            this.campañasToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.campañasToolStripMenuItem.Text = "&Campañas";
            this.campañasToolStripMenuItem.Click += new System.EventHandler(this.campañaToolStripMenuItem_Click);
            // 
            // bannersToolStripMenuItem
            // 
            this.bannersToolStripMenuItem.Image = global::UI.Properties.Resources.texto9;
            this.bannersToolStripMenuItem.Name = "bannersToolStripMenuItem";
            this.bannersToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.bannersToolStripMenuItem.Text = "&Banners";
            this.bannersToolStripMenuItem.Click += new System.EventHandler(this.bannerToolStripMenuItem_Click);
            // 
            // fuentesToolStripMenuItem
            // 
            this.fuentesToolStripMenuItem.Image = global::UI.Properties.Resources.Texto6;
            this.fuentesToolStripMenuItem.Name = "fuentesToolStripMenuItem";
            this.fuentesToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.fuentesToolStripMenuItem.Text = "&Fuentes";
            this.fuentesToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::UI.Properties.Resources.salir3;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(851, 680);
            this.Controls.Add(this.buttonSalirPantallaCompleta);
            this.Controls.Add(this.groupBoxBanner);
            this.Controls.Add(this.groupBoxCampania);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VPrincipal";
            this.Text = "EASY News";
            this.Activated += new System.EventHandler(this.VPrincipal_Activated);
            this.Load += new System.EventHandler(this.VPrincipal_Load);
            this.groupBoxCampania.ResumeLayout(false);
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
        private System.ComponentModel.BackgroundWorker bgwObtenerBanner;
        private System.ComponentModel.BackgroundWorker bgwObtenerCampania;
        private System.Windows.Forms.Timer timerChequeoCambioBanner;
        private BannerDeslizante bannerDeslizante;
        private CampaniaDeslizante campaniaDeslizante1;
        private System.Windows.Forms.Timer timerChequeoCambioCampania;
        private System.Windows.Forms.Button buttonSalirPantallaCompleta;
        private System.ComponentModel.BackgroundWorker bgwLeerBanner;
    }
}