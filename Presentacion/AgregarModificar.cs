﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class AgregarModificar : Form
    {
        private Articulo articulo = null;
        public AgregarModificar()
        {
            InitializeComponent();
            bAgregarModificar.Text = "Agregar";
            lbAgregarModificar.Text = "Agregar";
        }
        public AgregarModificar(Articulo seleccionado)
        {
            InitializeComponent();
            bAgregarModificar.Text = "Modificar";
            lbAgregarModificar.Text = "Modificar";
            articulo = seleccionado;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAgregarModificar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                    
                articulo.Nombre = tbNombre.Text;
                articulo.Codigo = tbCodigo.Text;
                articulo.Precio = decimal.Parse(tbPrecio.Text);
                articulo.Marca = (Marca)cobMarca.SelectedItem;
                articulo.Categoria = (Categoria)cobCategoria.SelectedItem;
                articulo.ImagenUrl = tbUrlImagen.Text;
                articulo.Descripcion = tbDescripcion.Text;

                if (articulo.Id == 0)
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                else
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Close();
            }
        }

        private void AgregarModificar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cobMarca.DataSource = marcaNegocio.listar();
                cobMarca.ValueMember = "Id";
                cobMarca.DisplayMember = "Detalle";
                cobCategoria.DataSource = categoriaNegocio.listar();
                cobCategoria.ValueMember = "Id";
                cobCategoria.DisplayMember = "Detalle";

                if(articulo != null)
                {
                    tbNombre.Text = articulo.Nombre;
                    tbCodigo.Text = articulo.Codigo;
                    tbPrecio.Text = articulo.Precio.ToString();
                    cobMarca.SelectedValue = articulo.Marca.Id;
                    cobCategoria.SelectedValue = articulo.Categoria.Id;
                    tbUrlImagen.Text = articulo.ImagenUrl;
                    cargarImagen(tbUrlImagen.Text);
                    tbDescripcion.Text = articulo.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if(tbNombre.Text == "")
                tbNombre.BackColor = Color.LightSalmon;
            else
                tbNombre.BackColor = Color.White;
        }

        private void tbUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbUrlImagen.Text);
        }

        /*  
        Esta linea va en el designer --->  this.bImagen.Click += new System.EventHandler(this.bImagen_Click);
        private void bImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                tbUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                File.Copy();
            }
        }
        */
        private void cargarImagen(string Url)
        {
            try
            {
                pbCargaDatos.Load(Url);
            }
            catch (Exception)
            {
                pbCargaDatos.Load("https://plantillasdememes.com/img/plantillas/imagen-no-disponible01601774755.jpg");
            }
        }

        private void lbAgregarModificar_Click(object sender, EventArgs e)
        {

        }

        private void lbNombre_Click(object sender, EventArgs e)
        {

        }

        private void lbCodigo_Click(object sender, EventArgs e)
        {

        }

        private void lbPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
