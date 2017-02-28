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
            this.groupBoxBanner = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.pantallaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campañasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bannersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgwObtenerBanner = new System.ComponentModel.BackgroundWorker();
            this.bgwObtenerCampania = new System.ComponentModel.BackgroundWorker();
            this.timerChequeoCambio = new System.Windows.Forms.Timer(this.components);
            this.bgwLeerBanner = new System.ComponentModel.BackgroundWorker();
            this.buttonSalirPantallaCompleta = new System.Windows.Forms.Button();
            this.groupBoxCampania = new System.Windows.Forms.GroupBox();
            this.labelActualizacion = new System.Windows.Forms.Label();
            this.labelLeido = new System.Windows.Forms.Label();
            this.labelObtenido = new System.Windows.Forms.Label();
            this.labelTick = new System.Windows.Forms.Label();
            this.iStatusStrip = new System.Windows.Forms.StatusStrip();
            this.iToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bannerDeslizante = new UI.UserControls.BannerDeslizante();
            this.campaniaDeslizante = new UI.UserControls.CampaniaDeslizante();
            this.groupBoxBanner.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBoxCampania.SuspendLayout();
            this.iStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBanner
            // 
            this.groupBoxBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(180)))), ((int)(((byte)(92)))));
            this.groupBoxBanner.Controls.Add(this.bannerDeslizante);
            this.groupBoxBanner.Location = new System.Drawing.Point(27, 540);
            this.groupBoxBanner.Name = "groupBoxBanner";
            this.groupBoxBanner.Size = new System.Drawing.Size(781, 91);
            this.groupBoxBanner.TabIndex = 2;
            this.groupBoxBanner.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Gray;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaCompletaToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(840, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // pantallaCompletaToolStripMenuItem
            // 
            this.pantallaCompletaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pantallaCompletaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pantallaCompletaToolStripMenuItem.Image = global::UI.Properties.Resources.Vista;
            this.pantallaCompletaToolStripMenuItem.Name = "pantallaCompletaToolStripMenuItem";
            this.pantallaCompletaToolStripMenuItem.Size = new System.Drawing.Size(197, 29);
            this.pantallaCompletaToolStripMenuItem.Text = "&Pantalla Completa";
            this.pantallaCompletaToolStripMenuItem.Click += new System.EventHandler(this.verPantallaCompletaToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campañasToolStripMenuItem,
            this.bannersToolStripMenuItem,
            this.fuentesToolStripMenuItem});
            this.configuracionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuracionToolStripMenuItem.Image = global::UI.Properties.Resources.Configuracion4;
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(161, 29);
            this.configuracionToolStripMenuItem.Text = "&Configuración";
            // 
            // campañasToolStripMenuItem
            // 
            this.campañasToolStripMenuItem.Image = global::UI.Properties.Resources.AgregarImagen1;
            this.campañasToolStripMenuItem.Name = "campañasToolStripMenuItem";
            this.campañasToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.campañasToolStripMenuItem.Text = "&Campañas";
            this.campañasToolStripMenuItem.Click += new System.EventHandler(this.campañaToolStripMenuItem_Click);
            // 
            // bannersToolStripMenuItem
            // 
            this.bannersToolStripMenuItem.Image = global::UI.Properties.Resources.texto9;
            this.bannersToolStripMenuItem.Name = "bannersToolStripMenuItem";
            this.bannersToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.bannersToolStripMenuItem.Text = "&Banners";
            this.bannersToolStripMenuItem.Click += new System.EventHandler(this.bannerToolStripMenuItem_Click);
            // 
            // fuentesToolStripMenuItem
            // 
            this.fuentesToolStripMenuItem.Image = global::UI.Properties.Resources.Texto6;
            this.fuentesToolStripMenuItem.Name = "fuentesToolStripMenuItem";
            this.fuentesToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.fuentesToolStripMenuItem.Text = "&Fuentes";
            this.fuentesToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Image = global::UI.Properties.Resources.salir3;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // bgwObtenerBanner
            // 
            this.bgwObtenerBanner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwObtenerBanner_DoWork);
            this.bgwObtenerBanner.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwObtener_RunWorkerCompleted);
            // 
            // bgwObtenerCampania
            // 
            this.bgwObtenerCampania.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwObtenerCampania_DoWork);
            this.bgwObtenerCampania.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwObtener_RunWorkerCompleted);
            // 
            // timerChequeoCambio
            // 
            this.timerChequeoCambio.Interval = 1000;
            this.timerChequeoCambio.Tick += new System.EventHandler(this.timerChequeoCambio_Tick);
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
            // groupBoxCampania
            // 
            this.groupBoxCampania.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(180)))), ((int)(((byte)(92)))));
            this.groupBoxCampania.Controls.Add(this.labelActualizacion);
            this.groupBoxCampania.Controls.Add(this.labelLeido);
            this.groupBoxCampania.Controls.Add(this.labelObtenido);
            this.groupBoxCampania.Controls.Add(this.labelTick);
            this.groupBoxCampania.Controls.Add(this.campaniaDeslizante);
            this.groupBoxCampania.Location = new System.Drawing.Point(27, 33);
            this.groupBoxCampania.Name = "groupBoxCampania";
            this.groupBoxCampania.Size = new System.Drawing.Size(781, 503);
            this.groupBoxCampania.TabIndex = 1;
            this.groupBoxCampania.TabStop = false;
            // 
            // labelActualizacion
            // 
            this.labelActualizacion.AutoSize = true;
            this.labelActualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualizacion.Location = new System.Drawing.Point(33, 169);
            this.labelActualizacion.Name = "labelActualizacion";
            this.labelActualizacion.Size = new System.Drawing.Size(0, 20);
            this.labelActualizacion.TabIndex = 8;
            // 
            // labelLeido
            // 
            this.labelLeido.AutoSize = true;
            this.labelLeido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeido.Location = new System.Drawing.Point(33, 207);
            this.labelLeido.Name = "labelLeido";
            this.labelLeido.Size = new System.Drawing.Size(0, 20);
            this.labelLeido.TabIndex = 7;
            // 
            // labelObtenido
            // 
            this.labelObtenido.AutoSize = true;
            this.labelObtenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObtenido.Location = new System.Drawing.Point(33, 128);
            this.labelObtenido.Name = "labelObtenido";
            this.labelObtenido.Size = new System.Drawing.Size(0, 20);
            this.labelObtenido.TabIndex = 5;
            // 
            // labelTick
            // 
            this.labelTick.AutoSize = true;
            this.labelTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTick.Location = new System.Drawing.Point(33, 49);
            this.labelTick.Name = "labelTick";
            this.labelTick.Size = new System.Drawing.Size(0, 20);
            this.labelTick.TabIndex = 4;
            // 
            // iStatusStrip
            // 
            this.iStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iToolStripStatusLabel});
            this.iStatusStrip.Location = new System.Drawing.Point(0, 626);
            this.iStatusStrip.Name = "iStatusStrip";
            this.iStatusStrip.Size = new System.Drawing.Size(840, 22);
            this.iStatusStrip.TabIndex = 4;
            this.iStatusStrip.Text = "statusStrip";
            // 
            // iToolStripStatusLabel
            // 
            this.iToolStripStatusLabel.Name = "iToolStripStatusLabel";
            this.iToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.iToolStripStatusLabel.Visible = false;
            // 
            // bannerDeslizante
            // 
            this.bannerDeslizante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(180)))), ((int)(((byte)(92)))));
            this.bannerDeslizante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bannerDeslizante.Enabled = false;
            this.bannerDeslizante.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerDeslizante.ForeColor = System.Drawing.Color.White;
            this.bannerDeslizante.Location = new System.Drawing.Point(22, 25);
            this.bannerDeslizante.Name = "bannerDeslizante";
            this.bannerDeslizante.Size = new System.Drawing.Size(735, 46);
            this.bannerDeslizante.TabIndex = 0;
            // 
            // campaniaDeslizante
            // 
            this.campaniaDeslizante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("campaniaDeslizante.BackgroundImage")));
            this.campaniaDeslizante.ErrorImage = null;
            this.campaniaDeslizante.Image = global::UI.Properties.Resources.NoImage2;
            this.campaniaDeslizante.InitialImage = null;
            this.campaniaDeslizante.Location = new System.Drawing.Point(22, 28);
            this.campaniaDeslizante.Name = "campaniaDeslizante";
            this.campaniaDeslizante.Size = new System.Drawing.Size(735, 459);
            this.campaniaDeslizante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.campaniaDeslizante.TabIndex = 2;
            this.campaniaDeslizante.TabStop = false;
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 648);
            this.Controls.Add(this.iStatusStrip);
            this.Controls.Add(this.buttonSalirPantallaCompleta);
            this.Controls.Add(this.groupBoxBanner);
            this.Controls.Add(this.groupBoxCampania);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "VPrincipal";
            this.Text = "EASY News";
            this.Activated += new System.EventHandler(this.VPrincipal_Activated);
            this.Load += new System.EventHandler(this.VPrincipal_Load);
            this.groupBoxBanner.ResumeLayout(false);
            this.groupBoxBanner.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBoxCampania.ResumeLayout(false);
            this.groupBoxCampania.PerformLayout();
            this.iStatusStrip.ResumeLayout(false);
            this.iStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
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
        private BannerDeslizante bannerDeslizante;
        private CampaniaDeslizante campaniaDeslizante;
        private System.Windows.Forms.Timer timerChequeoCambio;
        private System.Windows.Forms.Button buttonSalirPantallaCompleta;
        private System.ComponentModel.BackgroundWorker bgwLeerBanner;
        private System.Windows.Forms.Label labelTick;
        private System.Windows.Forms.Label labelLeido;
        private System.Windows.Forms.Label labelObtenido;
        private System.Windows.Forms.Label labelActualizacion;
        private System.Windows.Forms.StatusStrip iStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel iToolStripStatusLabel;
    }
}