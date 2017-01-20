using System.Windows.Forms;
using System.Drawing;

namespace UI
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
            this.bwRssReader = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPantallaCompletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.climaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarCiudadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCampania = new System.Windows.Forms.GroupBox();
            this.campaniaDeslizante = new UI.CampaniaDeslizante();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxBanner = new System.Windows.Forms.GroupBox();
            this.bannerDeslizante = new UI.BannerDeslizante();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBoxCampania.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante)).BeginInit();
            this.groupBoxBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPantallaCompletaToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // verPantallaCompletaToolStripMenuItem
            // 
            this.verPantallaCompletaToolStripMenuItem.Name = "verPantallaCompletaToolStripMenuItem";
            this.verPantallaCompletaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.verPantallaCompletaToolStripMenuItem.Text = "&Ver pantalla completa";
            this.verPantallaCompletaToolStripMenuItem.Click += new System.EventHandler(this.verPantallaCompletaToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pantallaToolStripMenuItem,
            this.climaToolStripMenuItem,
            this.campaniaToolStripMenuItem,
            this.bannerToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.configuraciónToolStripMenuItem.Text = "&Configuración";
            // 
            // pantallaToolStripMenuItem
            // 
            this.pantallaToolStripMenuItem.Name = "pantallaToolStripMenuItem";
            this.pantallaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.pantallaToolStripMenuItem.Text = "&Pantalla";
            // 
            // climaToolStripMenuItem
            // 
            this.climaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarCiudadToolStripMenuItem,
            this.actualizarToolStripMenuItem});
            this.climaToolStripMenuItem.Name = "climaToolStripMenuItem";
            this.climaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.climaToolStripMenuItem.Text = "&Clima";
            // 
            // cambiarCiudadToolStripMenuItem
            // 
            this.cambiarCiudadToolStripMenuItem.Name = "cambiarCiudadToolStripMenuItem";
            this.cambiarCiudadToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cambiarCiudadToolStripMenuItem.Text = "&Cambiar Ciudad";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.actualizarToolStripMenuItem.Text = "&Actualizar";
            // 
            // campaniaToolStripMenuItem
            // 
            this.campaniaToolStripMenuItem.Name = "campaniaToolStripMenuItem";
            this.campaniaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.campaniaToolStripMenuItem.Text = "C&ampaña";
            this.campaniaToolStripMenuItem.Click += new System.EventHandler(this.campaniaToolStripMenuItem_Click);
            // 
            // bannerToolStripMenuItem
            // 
            this.bannerToolStripMenuItem.Name = "bannerToolStripMenuItem";
            this.bannerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.bannerToolStripMenuItem.Text = "&Banner";
            this.bannerToolStripMenuItem.Click += new System.EventHandler(this.bannerToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAyudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "A&yuda";
            // 
            // verAyudaToolStripMenuItem
            // 
            this.verAyudaToolStripMenuItem.Name = "verAyudaToolStripMenuItem";
            this.verAyudaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.verAyudaToolStripMenuItem.Text = "&Ver ayuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre ...";
            // 
            // groupBoxCampania
            // 
            this.groupBoxCampania.Controls.Add(this.campaniaDeslizante);
            this.groupBoxCampania.Controls.Add(this.label5);
            this.groupBoxCampania.Location = new System.Drawing.Point(12, 27);
            this.groupBoxCampania.Name = "groupBoxCampania";
            this.groupBoxCampania.Size = new System.Drawing.Size(791, 535);
            this.groupBoxCampania.TabIndex = 62;
            this.groupBoxCampania.TabStop = false;
            // 
            // campaniaDeslizante
            // 
            this.campaniaDeslizante.ImageLocation = "";
            this.campaniaDeslizante.Location = new System.Drawing.Point(32, 70);
            this.campaniaDeslizante.Name = "campaniaDeslizante";
            this.campaniaDeslizante.Size = new System.Drawing.Size(722, 451);
            this.campaniaDeslizante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.campaniaDeslizante.TabIndex = 39;
            this.campaniaDeslizante.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(27, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "  ";
            // 
            // groupBoxBanner
            // 
            this.groupBoxBanner.Controls.Add(this.bannerDeslizante);
            this.groupBoxBanner.Location = new System.Drawing.Point(12, 568);
            this.groupBoxBanner.Name = "groupBoxBanner";
            this.groupBoxBanner.Size = new System.Drawing.Size(791, 86);
            this.groupBoxBanner.TabIndex = 0;
            this.groupBoxBanner.TabStop = false;
            // 
            // bannerDeslizante
            // 
            this.bannerDeslizante.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bannerDeslizante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bannerDeslizante.Enabled = false;
            this.bannerDeslizante.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerDeslizante.Location = new System.Drawing.Point(22, 33);
            this.bannerDeslizante.Name = "bannerDeslizante";
            this.bannerDeslizante.Size = new System.Drawing.Size(746, 28);
            this.bannerDeslizante.TabIndex = 0;
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(836, 669);
            this.Controls.Add(this.groupBoxBanner);
            this.Controls.Add(this.groupBoxCampania);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VPrincipal";
            this.Text = "Pantalla Publicitaria EASYNEWS";
            this.Activated += new System.EventHandler(this.VPrincipal_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VPrincipal_FormClosing);
            this.Resize += new System.EventHandler(this.VPrincipal_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxCampania.ResumeLayout(false);
            this.groupBoxCampania.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campaniaDeslizante)).EndInit();
            this.groupBoxBanner.ResumeLayout(false);
            this.groupBoxBanner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bwRssReader;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem verPantallaCompletaToolStripMenuItem;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem pantallaToolStripMenuItem;
        private ToolStripMenuItem climaToolStripMenuItem;
        private ToolStripMenuItem campaniaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem cambiarCiudadToolStripMenuItem;
        private ToolStripMenuItem actualizarToolStripMenuItem;
        private ToolStripMenuItem bannerToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem verAyudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private GroupBox groupBoxCampania;
        private GroupBox groupBoxBanner;
        private Label label5;
        private Timer timer1;
        private BannerDeslizante bannerDeslizante;
        private CampaniaDeslizante campaniaDeslizante;
    }
}

