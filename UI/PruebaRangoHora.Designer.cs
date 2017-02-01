using UI.UserControls;

namespace UI
{
    partial class PruebaRangoHora
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
            this.controlHora1 = new RangoHorario.ControlHora();
            this.SuspendLayout();
            // 
            // controlHora1
            // 
            this.controlHora1.Location = new System.Drawing.Point(35, 41);
            this.controlHora1.Name = "controlHora1";
            this.controlHora1.Size = new System.Drawing.Size(120, 101);
            this.controlHora1.TabIndex = 0;
            // 
            // PruebaRangoHora
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.controlHora1);
            this.Name = "PruebaRangoHora";
            this.ResumeLayout(false);

        }

        #endregion

        private RangoHorario.ControlHora controlHora1;
    }
}