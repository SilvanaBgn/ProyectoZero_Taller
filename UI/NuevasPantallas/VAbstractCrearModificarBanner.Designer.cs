using System.Windows.Forms;

namespace UI.NuevasPantallas
{
    partial class VAbstractCrearModificarBanner
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.dataGridViewMostrarFuentes = new System.Windows.Forms.DataGridView();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.rangoHorario = new UI.UserControls.RangoHorario();
            this.rangoFecha = new UI.UserControls.RangoFecha();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarFuentes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(13, 13);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(35, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.BackColor = System.Drawing.Color.White;
            this.textBoxTitulo.Location = new System.Drawing.Point(97, 13);
            this.textBoxTitulo.MaxLength = 20;
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.ShortcutsEnabled = false;
            this.textBoxTitulo.Size = new System.Drawing.Size(362, 20);
            this.textBoxTitulo.TabIndex = 1;
            this.textBoxTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValido_KeyPress);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(13, 43);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 8;
            this.labelDescripcion.Text = "Descripción";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(97, 43);
            this.textBoxDescripcion.MaxLength = 30;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ShortcutsEnabled = false;
            this.textBoxDescripcion.Size = new System.Drawing.Size(362, 20);
            this.textBoxDescripcion.TabIndex = 9;
            this.textBoxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxValido_KeyPress);
            // 
            // dataGridViewMostrarFuentes
            // 
            this.dataGridViewMostrarFuentes.AllowUserToAddRows = false;
            this.dataGridViewMostrarFuentes.AllowUserToDeleteRows = false;
            this.dataGridViewMostrarFuentes.AllowUserToResizeColumns = false;
            this.dataGridViewMostrarFuentes.AllowUserToResizeRows = false;
            this.dataGridViewMostrarFuentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMostrarFuentes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMostrarFuentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(219)))), ((int)(((byte)(188)))));
            this.dataGridViewMostrarFuentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMostrarFuentes.Location = new System.Drawing.Point(6, 65);
            this.dataGridViewMostrarFuentes.MultiSelect = false;
            this.dataGridViewMostrarFuentes.Name = "dataGridViewMostrarFuentes";
            this.dataGridViewMostrarFuentes.ReadOnly = true;
            this.dataGridViewMostrarFuentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMostrarFuentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMostrarFuentes.Size = new System.Drawing.Size(436, 148);
            this.dataGridViewMostrarFuentes.TabIndex = 11;
            this.dataGridViewMostrarFuentes.SelectionChanged += new System.EventHandler(this.dataGridViewMostrarFuentes_SelectionChanged);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(309, 431);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 13;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(390, 431);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonNuevo);
            this.groupBox1.Controls.Add(this.dataGridViewMostrarFuentes);
            this.groupBox1.Location = new System.Drawing.Point(17, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 219);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuente";
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Image = global::UI.Properties.Resources.Agregar8;
            this.buttonNuevo.Location = new System.Drawing.Point(6, 19);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(131, 40);
            this.buttonNuevo.TabIndex = 12;
            this.buttonNuevo.Text = "&Nueva Fuente";
            this.buttonNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // rangoHorario
            // 
            this.rangoHorario.HoraFin = System.TimeSpan.Parse("23:59:59");
            this.rangoHorario.HoraInicio = System.TimeSpan.Parse("00:00:00");
            this.rangoHorario.Location = new System.Drawing.Point(318, 88);
            this.rangoHorario.Name = "rangoHorario";
            this.rangoHorario.Size = new System.Drawing.Size(147, 96);
            this.rangoHorario.TabIndex = 16;
            // 
            // rangoFecha
            // 
            this.rangoFecha.FechaFin = new System.DateTime(2017, 2, 24, 0, 0, 0, 0);
            this.rangoFecha.FechaInicio = new System.DateTime(2017, 2, 24, 0, 0, 0, 0);
            this.rangoFecha.Location = new System.Drawing.Point(16, 89);
            this.rangoFecha.Name = "rangoFecha";
            this.rangoFecha.Size = new System.Drawing.Size(264, 96);
            this.rangoFecha.TabIndex = 15;
            // 
            // VAbstractCrearModificarBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(485, 466);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rangoHorario);
            this.Controls.Add(this.rangoFecha);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.labelTitulo);
            this.Name = "VAbstractCrearModificarBanner";
            this.Text = "VAbstractCrearModificarBanner";
            this.Activated += new System.EventHandler(this.VAbstractCrearModificarBanner_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VAbstractCrearModificarBanner_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrarFuentes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        protected System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelDescripcion;
        protected System.Windows.Forms.TextBox textBoxDescripcion;
        protected System.Windows.Forms.DataGridView dataGridViewMostrarFuentes;
        protected System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        protected UserControls.RangoFecha rangoFecha;
        protected UserControls.RangoHorario rangoHorario;
        private System.Windows.Forms.GroupBox groupBox1;
        protected Button buttonNuevo;
    }
}