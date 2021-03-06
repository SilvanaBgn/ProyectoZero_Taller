﻿namespace UI.UserControls
{
    partial class TextoFijo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextoFijo));
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonEliminarItem = new System.Windows.Forms.Button();
            this.buttonVistaPrevia = new System.Windows.Forms.Button();
            this.buttonAgregarItem = new System.Windows.Forms.Button();
            this.buttonArriba = new System.Windows.Forms.Button();
            this.buttonAbajo = new System.Windows.Forms.Button();
            this.bannerDeslizante = new UI.UserControls.BannerDeslizante();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(12, 73);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(345, 124);
            this.comboBoxItems.TabIndex = 70;
            this.comboBoxItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxItems_KeyPress);
            this.comboBoxItems.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.comboBoxItems_PreviewKeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(349, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Ingresar líneas separadas por [ENTER], eliminar líneas con [SUPRIMIR]";
            // 
            // buttonEliminarItem
            // 
            this.buttonEliminarItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminarItem.BackgroundImage")));
            this.buttonEliminarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminarItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonEliminarItem.Location = new System.Drawing.Point(42, 192);
            this.buttonEliminarItem.Name = "buttonEliminarItem";
            this.buttonEliminarItem.Size = new System.Drawing.Size(28, 31);
            this.buttonEliminarItem.TabIndex = 75;
            this.buttonEliminarItem.UseVisualStyleBackColor = true;
            this.buttonEliminarItem.Click += new System.EventHandler(this.buttonEliminarItem_Click);
            // 
            // buttonVistaPrevia
            // 
            this.buttonVistaPrevia.AutoSize = true;
            this.buttonVistaPrevia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVistaPrevia.BackgroundImage")));
            this.buttonVistaPrevia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVistaPrevia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVistaPrevia.Location = new System.Drawing.Point(79, 192);
            this.buttonVistaPrevia.Name = "buttonVistaPrevia";
            this.buttonVistaPrevia.Size = new System.Drawing.Size(30, 31);
            this.buttonVistaPrevia.TabIndex = 74;
            this.buttonVistaPrevia.UseVisualStyleBackColor = true;
            this.buttonVistaPrevia.Click += new System.EventHandler(this.buttonVistaPrevia_Click);
            // 
            // buttonAgregarItem
            // 
            this.buttonAgregarItem.AutoSize = true;
            this.buttonAgregarItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAgregarItem.BackgroundImage")));
            this.buttonAgregarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAgregarItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAgregarItem.Location = new System.Drawing.Point(12, 192);
            this.buttonAgregarItem.Name = "buttonAgregarItem";
            this.buttonAgregarItem.Size = new System.Drawing.Size(29, 31);
            this.buttonAgregarItem.TabIndex = 73;
            this.buttonAgregarItem.UseVisualStyleBackColor = true;
            this.buttonAgregarItem.Click += new System.EventHandler(this.buttonAgregarItem_Click);
            // 
            // buttonArriba
            // 
            this.buttonArriba.AutoSize = true;
            this.buttonArriba.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonArriba.BackgroundImage")));
            this.buttonArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonArriba.FlatAppearance.BorderSize = 0;
            this.buttonArriba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonArriba.Location = new System.Drawing.Point(363, 75);
            this.buttonArriba.Name = "buttonArriba";
            this.buttonArriba.Size = new System.Drawing.Size(53, 54);
            this.buttonArriba.TabIndex = 71;
            this.buttonArriba.UseVisualStyleBackColor = true;
            this.buttonArriba.Click += new System.EventHandler(this.buttonArriba_Click);
            // 
            // buttonAbajo
            // 
            this.buttonAbajo.AutoSize = true;
            this.buttonAbajo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAbajo.BackgroundImage")));
            this.buttonAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAbajo.FlatAppearance.BorderSize = 0;
            this.buttonAbajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbajo.Location = new System.Drawing.Point(363, 135);
            this.buttonAbajo.Name = "buttonAbajo";
            this.buttonAbajo.Size = new System.Drawing.Size(53, 54);
            this.buttonAbajo.TabIndex = 72;
            this.buttonAbajo.UseVisualStyleBackColor = true;
            this.buttonAbajo.Click += new System.EventHandler(this.buttonAbajo_Click);
            // 
            // bannerDeslizante
            // 
            this.bannerDeslizante.Enabled = false;
            this.bannerDeslizante.Location = new System.Drawing.Point(115, 198);
            this.bannerDeslizante.Name = "bannerDeslizante";
            this.bannerDeslizante.Size = new System.Drawing.Size(242, 20);
            this.bannerDeslizante.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Descripción";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(12, 21);
            this.textBoxDescripcion.MaxLength = 100;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ShortcutsEnabled = false;
            this.textBoxDescripcion.Size = new System.Drawing.Size(345, 20);
            this.textBoxDescripcion.TabIndex = 78;
            this.textBoxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValido_KeyPress);
            // 
            // TextoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bannerDeslizante);
            this.Controls.Add(this.buttonEliminarItem);
            this.Controls.Add(this.buttonVistaPrevia);
            this.Controls.Add(this.buttonAgregarItem);
            this.Controls.Add(this.buttonArriba);
            this.Controls.Add(this.buttonAbajo);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.label6);
            this.Name = "TextoFijo";
            this.Size = new System.Drawing.Size(427, 229);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BannerDeslizante bannerDeslizante;
        private System.Windows.Forms.Button buttonEliminarItem;
        private System.Windows.Forms.Button buttonVistaPrevia;
        private System.Windows.Forms.Button buttonAgregarItem;
        private System.Windows.Forms.Button buttonArriba;
        private System.Windows.Forms.Button buttonAbajo;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescripcion;
    }
}
