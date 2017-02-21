using System;
using System.Windows.Forms;

namespace UI.NuevasPantallas
{
    partial class VAbstractBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VAbstractBase));
            this.dataGridViewMostrar = new System.Windows.Forms.DataGridView();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rangoHorario = new UI.UserControls.RangoHorario();
            this.rangoFecha = new UI.UserControls.RangoFecha();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.checkBoxTitulo = new System.Windows.Forms.CheckBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.checkBoxDescripcion = new System.Windows.Forms.CheckBox();
            this.checkBoxRangoHoras = new System.Windows.Forms.CheckBox();
            this.checkBoxRangoFechas = new System.Windows.Forms.CheckBox();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMostrar
            // 
            this.dataGridViewMostrar.AllowUserToAddRows = false;
            this.dataGridViewMostrar.AllowUserToDeleteRows = false;
            this.dataGridViewMostrar.AllowUserToResizeColumns = false;
            this.dataGridViewMostrar.AllowUserToResizeRows = false;
            this.dataGridViewMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMostrar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMostrar.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridViewMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMostrar.Location = new System.Drawing.Point(22, 66);
            this.dataGridViewMostrar.MultiSelect = false;
            this.dataGridViewMostrar.Name = "dataGridViewMostrar";
            this.dataGridViewMostrar.ReadOnly = true;
            this.dataGridViewMostrar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMostrar.Size = new System.Drawing.Size(502, 141);
            this.dataGridViewMostrar.TabIndex = 7;
            this.dataGridViewMostrar.SelectionChanged += new System.EventHandler(this.dataGridViewMostrar_SelectionChanged);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(467, 458);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 11;
            this.buttonSalir.Text = "&Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFiltrar);
            this.groupBox1.Controls.Add(this.rangoHorario);
            this.groupBox1.Controls.Add(this.rangoFecha);
            this.groupBox1.Controls.Add(this.textBoxTitulo);
            this.groupBox1.Controls.Add(this.checkBoxTitulo);
            this.groupBox1.Controls.Add(this.textBoxDescripcion);
            this.groupBox1.Controls.Add(this.checkBoxDescripcion);
            this.groupBox1.Controls.Add(this.checkBoxRangoHoras);
            this.groupBox1.Controls.Add(this.checkBoxRangoFechas);
            this.groupBox1.Location = new System.Drawing.Point(16, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 224);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por";
            // 
            // rangoHorario
            // 
            this.rangoHorario.Enabled = false;
            this.rangoHorario.HoraFin = System.TimeSpan.Parse("00:15:00");
            this.rangoHorario.HoraInicio = System.TimeSpan.Parse("00:00:00");
            this.rangoHorario.Location = new System.Drawing.Point(361, 62);
            this.rangoHorario.Name = "rangoHorario";
            this.rangoHorario.Size = new System.Drawing.Size(147, 94);
            this.rangoHorario.TabIndex = 18;
            // 
            // rangoFecha
            // 
            this.rangoFecha.Enabled = false;
            this.rangoFecha.FechaFin = new System.DateTime(2017, 2, 14, 0, 0, 0, 0);
            this.rangoFecha.FechaInicio = new System.DateTime(2017, 2, 14, 0, 0, 0, 0);
            this.rangoFecha.Location = new System.Drawing.Point(40, 63);
            this.rangoFecha.Name = "rangoFecha";
            this.rangoFecha.Size = new System.Drawing.Size(242, 96);
            this.rangoFecha.TabIndex = 17;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.BackColor = System.Drawing.Color.OldLace;
            this.textBoxTitulo.Enabled = false;
            this.textBoxTitulo.Location = new System.Drawing.Point(369, 187);
            this.textBoxTitulo.MaxLength = 20;
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(139, 20);
            this.textBoxTitulo.TabIndex = 16;
            // 
            // checkBoxTitulo
            // 
            this.checkBoxTitulo.AutoSize = true;
            this.checkBoxTitulo.Location = new System.Drawing.Point(341, 169);
            this.checkBoxTitulo.Name = "checkBoxTitulo";
            this.checkBoxTitulo.Size = new System.Drawing.Size(63, 17);
            this.checkBoxTitulo.TabIndex = 15;
            this.checkBoxTitulo.Text = "   Título";
            this.checkBoxTitulo.UseVisualStyleBackColor = true;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.AcceptsTab = true;
            this.textBoxDescripcion.BackColor = System.Drawing.Color.OldLace;
            this.textBoxDescripcion.Enabled = false;
            this.textBoxDescripcion.Location = new System.Drawing.Point(46, 187);
            this.textBoxDescripcion.MaxLength = 30;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ShortcutsEnabled = false;
            this.textBoxDescripcion.Size = new System.Drawing.Size(227, 20);
            this.textBoxDescripcion.TabIndex = 10;
            // 
            // checkBoxDescripcion
            // 
            this.checkBoxDescripcion.AutoSize = true;
            this.checkBoxDescripcion.Location = new System.Drawing.Point(18, 168);
            this.checkBoxDescripcion.Name = "checkBoxDescripcion";
            this.checkBoxDescripcion.Size = new System.Drawing.Size(91, 17);
            this.checkBoxDescripcion.TabIndex = 6;
            this.checkBoxDescripcion.Text = "   Descripción";
            this.checkBoxDescripcion.UseVisualStyleBackColor = true;
            // 
            // checkBoxRangoHoras
            // 
            this.checkBoxRangoHoras.AutoSize = true;
            this.checkBoxRangoHoras.Location = new System.Drawing.Point(340, 63);
            this.checkBoxRangoHoras.Name = "checkBoxRangoHoras";
            this.checkBoxRangoHoras.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRangoHoras.TabIndex = 5;
            this.checkBoxRangoHoras.UseVisualStyleBackColor = true;
            // 
            // checkBoxRangoFechas
            // 
            this.checkBoxRangoFechas.AutoSize = true;
            this.checkBoxRangoFechas.Location = new System.Drawing.Point(18, 63);
            this.checkBoxRangoFechas.Name = "checkBoxRangoFechas";
            this.checkBoxRangoFechas.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRangoFechas.TabIndex = 4;
            this.checkBoxRangoFechas.UseVisualStyleBackColor = true;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrar.Image = global::UI.Properties.Resources.Buscar2;
            this.buttonFiltrar.Location = new System.Drawing.Point(6, 19);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(87, 35);
            this.buttonFiltrar.TabIndex = 19;
            this.buttonFiltrar.Text = "&Filtrar";
            this.buttonFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Image = global::UI.Properties.Resources.Eliminar7;
            this.buttonEliminar.Location = new System.Drawing.Point(204, 12);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(85, 40);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "&Borrar";
            this.buttonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Image = global::UI.Properties.Resources.Editar6;
            this.buttonModificar.Location = new System.Drawing.Point(115, 12);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(83, 40);
            this.buttonModificar.TabIndex = 1;
            this.buttonModificar.Text = "&Editar";
            this.buttonModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Image = global::UI.Properties.Resources.Agregar8;
            this.buttonNuevo.Location = new System.Drawing.Point(21, 12);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(88, 40);
            this.buttonNuevo.TabIndex = 0;
            this.buttonNuevo.Text = "&Nuevo";
            this.buttonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // VAbstractBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(560, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.dataGridViewMostrar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonNuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VAbstractBase";
            this.Text = "BANNERS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button buttonNuevo;
        protected System.Windows.Forms.Button buttonModificar;
        protected System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonSalir;
        protected System.Windows.Forms.DataGridView dataGridViewMostrar;
        private GroupBox groupBox1;
        protected Button buttonFiltrar;
        protected UserControls.RangoHorario rangoHorario;
        protected UserControls.RangoFecha rangoFecha;
        protected TextBox textBoxTitulo;
        protected CheckBox checkBoxTitulo;
        protected TextBox textBoxDescripcion;
        protected CheckBox checkBoxDescripcion;
        protected CheckBox checkBoxRangoHoras;
        protected CheckBox checkBoxRangoFechas;
    }
}