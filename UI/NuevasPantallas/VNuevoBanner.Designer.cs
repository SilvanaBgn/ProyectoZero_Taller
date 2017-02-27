namespace UI.NuevasPantallas
{
    partial class VNuevoBanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VNuevoBanner));
            this.buttonNuevaFuente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNuevaFuente);
            this.groupBox1.Controls.SetChildIndex(this.buttonNuevaFuente, 0);
            // 
            // buttonNuevaFuente
            // 
            this.buttonNuevaFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevaFuente.Image = global::UI.Properties.Resources.Agregar3;
            this.buttonNuevaFuente.Location = new System.Drawing.Point(6, 19);
            this.buttonNuevaFuente.Name = "buttonNuevaFuente";
            this.buttonNuevaFuente.Size = new System.Drawing.Size(135, 39);
            this.buttonNuevaFuente.TabIndex = 24;
            this.buttonNuevaFuente.Text = "Nueva Fuente";
            this.buttonNuevaFuente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNuevaFuente.UseVisualStyleBackColor = true;
            this.buttonNuevaFuente.Click += new System.EventHandler(this.buttonNuevaFuente_Click);
            // 
            // VCrearBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 466);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VCrearBanner";
            this.Text = "Nuevo Banner";
            this.Shown += new System.EventHandler(this.VCrearBanner_Shown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevaFuente;
    }
}