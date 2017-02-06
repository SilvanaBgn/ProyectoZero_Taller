namespace UI.UserControls
{
    partial class LectorFuente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bgwLector = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // bgwLector
            // 
            this.bgwLector.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLector_DoWork);
            this.bgwLector.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLector_RunWorkerCompleted);
            // 
            // LectorFuente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "LectorFuente";
            this.Size = new System.Drawing.Size(12, 10);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwLector;
    }
}
