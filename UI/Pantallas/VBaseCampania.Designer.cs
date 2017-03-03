namespace UI.Pantallas
{
    partial class VBaseCampania: VAbstractBase
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
            this.SuspendLayout();
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // rangoFecha
            // 
            this.rangoFecha.FechaFin = new System.DateTime(2017, 3, 2, 0, 0, 0, 0);
            this.rangoFecha.FechaInicio = new System.DateTime(2017, 3, 2, 0, 0, 0, 0);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // buttonBorrarFiltros
            // 
            this.buttonBorrarFiltros.Click += new System.EventHandler(this.buttonBorrarFiltros_Click);
            // 
            // VBaseCampania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(619, 520);
            this.MaximizeBox = false;
            this.Name = "VBaseCampania";
            this.Text = "Configuración CAMPAÑAS";
            this.Activated += new System.EventHandler(this.VBaseCampania_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}