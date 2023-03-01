﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Opciones : Form
    {
        private List<Articulo> listaArticulo = null;
        public Opciones()
        {
            InitializeComponent();
        }

        public Opciones(string otro)
        {
            InitializeComponent();
            AgregarModificar form = new AgregarModificar();
            form.ShowDialog();
            actualizar();
        }

        private void bVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void actualizar()
        {
            ArticuloNegocio aux = new ArticuloNegocio();
            try
            {
                listaArticulo = aux.listar();
                dgvArticulos.DataSource = listaArticulo;
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["Descripcion"].Visible = false;
                dgvArticulos.Columns["Marca"].Visible = false;
                dgvArticulos.Columns["Categoria"].Visible = false;
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            actualizar();
            cobCampo.Items.Add("Nombre");
            cobCampo.Items.Add("Código");
            cobCampo.Items.Add("Precio");
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if(dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    cargarImagen(seleccionado.ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        
        private void cargarImagen(string Url)
        {
            try
            {
                pbImagenOpciones.Load(Url);
            }
            catch (Exception)
            {
                pbImagenOpciones.Load("https://plantillasdememes.com/img/plantillas/imagen-no-disponible01601774755.jpg");
            }
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            AgregarModificar form = new AgregarModificar();
            form.ShowDialog();
            actualizar();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if(dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                AgregarModificar form = new AgregarModificar(seleccionado);
                form.ShowDialog();
                actualizar();
            }
            else
                lbAclaraciones.Text = "Seleccione una fila de la tabla";
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("¿De verdad quieres eliminarlo?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(resultado == DialogResult.Yes)
                {
                    if (dgvArticulos.CurrentRow != null)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.Id);
                        actualizar();
                    }
                    else
                        lbAclaraciones.Text = "Seleccione una fila de la tabla";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if(dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                Detalle form = new Detalle(seleccionado);
                form.ShowDialog();
            }
            else
            {
                lbAclaraciones.Text = "Seleccione una fila de la tabla";
            }
        }

        private void cobCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cobCampo.SelectedItem.ToString();
            switch(opcion)
            {
                case "Nombre":
                    cobCriterio.Items.Clear();
                    cobCriterio.Items.Add("Comienza con");
                    cobCriterio.Items.Add("Termina con");
                    cobCriterio.Items.Add("Contiene");
                    break;
                case "Código":
                    cobCriterio.Items.Clear();
                    cobCriterio.Items.Add("Comienza con");
                    cobCriterio.Items.Add("Termina con");
                    cobCriterio.Items.Add("Contiene");
                    break;
                case "Precio":
                    cobCriterio.Items.Clear();
                    cobCriterio.Items.Add("Mayor a");
                    cobCriterio.Items.Add("Menor a");
                    cobCriterio.Items.Add("Igual a");
                    break;
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string campo = cobCampo.SelectedItem.ToString();
                string criterio = cobCriterio.SelectedItem.ToString();
                string filtro = tbFiltro.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
