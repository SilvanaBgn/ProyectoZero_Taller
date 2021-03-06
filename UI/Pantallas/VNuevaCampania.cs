﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Excepciones.ExcepcionesPantalla;
using Excepciones;

namespace UI.Pantallas
{
    public partial class VNuevaCampania : VAbstractCrearModificarCampania
    {
        //CONSTRUCTOR
        public VNuevaCampania(ref ControladorDominio pControladorDominio) : base(ref pControladorDominio)
        {
            InitializeComponent();
        }

        #region EVENTOS Botones
        /// <summary>
        /// Evento que se invoca cuando se hace click en el botón guardar, agregando una nueva campania
        /// </summary>
        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            this.buttonGuardar.Enabled = false;
            this.iCampania = new Campania();
            this.iCampania.Titulo = this.textBoxTitulo.Text;
            this.iCampania.Descripcion = this.textBoxDescripcion.Text;
            this.iCampania.FechaInicio = this.rangoFecha.FechaInicio;
            this.iCampania.FechaFin = this.rangoFecha.FechaFin;
            this.iCampania.Imagenes = this.galeria.ListaImagenes;
            this.iCampania.DuracionImagen = this.galeria.Segundos;

            if (!this.rangoHorario.HorarioValido())
            {
                MessageBox.Show("La hora de fin debe ser posterior a la hora de inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.buttonGuardar.Enabled = true;
            }
            else
            {
                this.iCampania.HoraInicio = this.rangoHorario.HoraInicio;
                this.iCampania.HoraFin = this.rangoHorario.HoraFin;
                try
                {
                    //Agregamos la campaña y guardamos:
                    this.iControladorDominio.AgregarCampania(this.iCampania);
                    this.iControladorDominio.GuardarCambios();
                    this.Close();
                }
                catch (ExcepcionCamposSinCompletar ex)
                {
                    MessageBox.Show(ex.Message, "Faltan campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.buttonGuardar.Enabled = true;
                }
                catch (ExcepcionAlAgregar ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.buttonGuardar.Enabled = true;
                }
                catch (ExcepcionAlGuardarCambios ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.buttonGuardar.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error. Contacte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.buttonGuardar.Enabled = true;
                }
            }
        }
        #endregion
    }
}
