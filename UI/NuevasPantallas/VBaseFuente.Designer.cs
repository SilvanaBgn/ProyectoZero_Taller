using System.Windows.Forms;

namespace UI.NuevasPantallas
{
    partial class VBaseFuente
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
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.Banners = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuenteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxDescripcion = new System.Windows.Forms.CheckBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.checkBoxTipo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewMostrar = new System.Windows.Forms.DataGridView();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBorrarFiltros = new System.Windows.Forms.Button();
            this.ColumnFuenteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnorigenItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBanners = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.Enabled = false;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Rss",
            "Texto Fijo"});
            this.comboBoxTipo.Location = new System.Drawing.Point(150, 418);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(145, 21);
            this.comboBoxTipo.TabIndex = 7;
            // 
            // Banners
            // 
            this.Banners.Name = "Banners";
            // 
            // Tipo
            // 
            this.Tipo.Name = "Tipo";
            // 
            // FuenteId
            // 
            this.FuenteId.Name = "FuenteId";
            // 
            // checkBoxDescripcion
            // 
            this.checkBoxDescripcion.AutoSize = true;
            this.checkBoxDescripcion.Location = new System.Drawing.Point(368, 398);
            this.checkBoxDescripcion.Name = "checkBoxDescripcion";
            this.checkBoxDescripcion.Size = new System.Drawing.Size(91, 17);
            this.checkBoxDescripcion.TabIndex = 8;
            this.checkBoxDescripcion.Text = "   Descripción";
            this.checkBoxDescripcion.UseVisualStyleBackColor = true;
            this.checkBoxDescripcion.CheckedChanged += new System.EventHandler(this.checkBoxDescripcion_CheckedChanged);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.BackColor = System.Drawing.Color.White;
            this.textBoxDescripcion.Enabled = false;
            this.textBoxDescripcion.Location = new System.Drawing.Point(396, 417);
            this.textBoxDescripcion.MaxLength = 30;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ShortcutsEnabled = false;
            this.textBoxDescripcion.Size = new System.Drawing.Size(152, 20);
            this.textBoxDescripcion.TabIndex = 9;
            this.textBoxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValido_KeyPress);
            // 
            // checkBoxTipo
            // 
            this.checkBoxTipo.AutoSize = true;
            this.checkBoxTipo.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTipo.Location = new System.Drawing.Point(122, 398);
            this.checkBoxTipo.Name = "checkBoxTipo";
            this.checkBoxTipo.Size = new System.Drawing.Size(56, 17);
            this.checkBoxTipo.TabIndex = 10;
            this.checkBoxTipo.Text = "   Tipo";
            this.checkBoxTipo.UseVisualStyleBackColor = false;
            this.checkBoxTipo.CheckedChanged += new System.EventHandler(this.checkBoxTipo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBorrarFiltros);
            this.groupBox1.Controls.Add(this.buttonFiltrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 132);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrar.Image = global::UI.Properties.Resources.Buscar2;
            this.buttonFiltrar.Location = new System.Drawing.Point(8, 23);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(87, 35);
            this.buttonFiltrar.TabIndex = 30;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // dataGridViewMostrar
            // 
            this.dataGridViewMostrar.AllowUserToAddRows = false;
            this.dataGridViewMostrar.AllowUserToDeleteRows = false;
            this.dataGridViewMostrar.AllowUserToResizeColumns = false;
            this.dataGridViewMostrar.AllowUserToResizeRows = false;
            this.dataGridViewMostrar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMostrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(188)))));
            this.dataGridViewMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFuenteId,
            this.ColumnTipo,
            this.ColumnDescripcion,
            this.ColumnorigenItems,
            this.ColumnBanners,
            this.ColumnItems});
            this.dataGridViewMostrar.Location = new System.Drawing.Point(21, 71);
            this.dataGridViewMostrar.MultiSelect = false;
            this.dataGridViewMostrar.Name = "dataGridViewMostrar";
            this.dataGridViewMostrar.ReadOnly = true;
            this.dataGridViewMostrar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMostrar.Size = new System.Drawing.Size(556, 245);
            this.dataGridViewMostrar.TabIndex = 24;
            // 
            // ColumnFuenteId
            // 
            this.ColumnFuenteId.DataPropertyName = "FuenteId";
            this.ColumnFuenteId.HeaderText = "Cod";
            this.ColumnFuenteId.Name = "ColumnFuenteId";
            this.ColumnFuenteId.ReadOnly = true;
            this.ColumnFuenteId.Width = 30;
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.DataPropertyName = "Tipo";
            this.ColumnTipo.HeaderText = "Tipo";
            this.ColumnTipo.Name = "ColumnTipo";
            this.ColumnTipo.ReadOnly = true;
            this.ColumnTipo.Width = 80;
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.DataPropertyName = "Descripcion";
            this.ColumnDescripcion.HeaderText = "Descripción";
            this.ColumnDescripcion.Name = "ColumnDescripcion";
            this.ColumnDescripcion.ReadOnly = true;
            this.ColumnDescripcion.Width = 160;
            // 
            // ColumnorigenItems
            // 
            this.ColumnorigenItems.DataPropertyName = "origenItems";
            this.ColumnorigenItems.HeaderText = "Fuente (origen de datos)";
            this.ColumnorigenItems.Name = "ColumnorigenItems";
            this.ColumnorigenItems.ReadOnly = true;
            this.ColumnorigenItems.Width = 240;
            // 
            // ColumnBanners
            // 
            this.ColumnBanners.DataPropertyName = "Banners";
            this.ColumnBanners.HeaderText = "ColumnBanners";
            this.ColumnBanners.Name = "ColumnBanners";
            this.ColumnBanners.ReadOnly = true;
            this.ColumnBanners.Visible = false;
            this.ColumnBanners.Width = 106;
            // 
            // ColumnItems
            // 
            this.ColumnItems.DataPropertyName = "Items";
            this.ColumnItems.HeaderText = "Items";
            this.ColumnItems.Name = "ColumnItems";
            this.ColumnItems.ReadOnly = true;
            this.ColumnItems.Visible = false;
            this.ColumnItems.Width = 57;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Image = global::UI.Properties.Resources.Eliminar7;
            this.buttonBorrar.Location = new System.Drawing.Point(207, 22);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(88, 40);
            this.buttonBorrar.TabIndex = 23;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.Image = global::UI.Properties.Resources.Editar6;
            this.buttonEditar.Location = new System.Drawing.Point(114, 22);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(88, 40);
            this.buttonEditar.TabIndex = 22;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Image = global::UI.Properties.Resources.Agregar8;
            this.buttonNuevo.Location = new System.Drawing.Point(21, 22);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(88, 40);
            this.buttonNuevo.TabIndex = 21;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(159)))), ((int)(((byte)(70)))));
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(620, 7);
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(159)))), ((int)(((byte)(70)))));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(3, 525);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(210)))), ((int)(((byte)(59)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(620, 4);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBorrarFiltros
            // 
            this.buttonBorrarFiltros.Enabled = false;
            this.buttonBorrarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrarFiltros.Image = global::UI.Properties.Resources.Eliminar7;
            this.buttonBorrarFiltros.Location = new System.Drawing.Point(101, 23);
            this.buttonBorrarFiltros.Name = "buttonBorrarFiltros";
            this.buttonBorrarFiltros.Size = new System.Drawing.Size(115, 35);
            this.buttonBorrarFiltros.TabIndex = 36;
            this.buttonBorrarFiltros.Text = "Borrar filtros";
            this.buttonBorrarFiltros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBorrarFiltros.UseVisualStyleBackColor = true;
            this.buttonBorrarFiltros.Click += new System.EventHandler(this.buttonBorrarFiltros_Click);
            this.buttonBorrarFiltros.Enabled = false;
            // 
            // VBaseFuente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(228)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(597, 520);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.checkBoxTipo);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.checkBoxDescripcion);
            this.Controls.Add(this.dataGridViewMostrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "VBaseFuente";
            this.Text = "Configuración FUENTES";
            this.Activated += new System.EventHandler(this.VBaseFuente_Activated);
            this.Load += new System.EventHandler(this.VBaseFuente_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Banners;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuenteId;
        private System.Windows.Forms.CheckBox checkBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.CheckBox checkBoxTipo;
        private GroupBox groupBox1;
        protected Button buttonFiltrar;
        private Button button2;
        protected DataGridView dataGridViewMostrar;
        protected Button buttonBorrar;
        protected Button buttonEditar;
        protected Button buttonNuevo;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ColumnFuenteId;
        private DataGridViewTextBoxColumn ColumnTipo;
        private DataGridViewTextBoxColumn ColumnDescripcion;
        private DataGridViewTextBoxColumn ColumnorigenItems;
        private DataGridViewTextBoxColumn ColumnBanners;
        private DataGridViewTextBoxColumn ColumnItems;
        protected Button buttonBorrarFiltros;
    }
}