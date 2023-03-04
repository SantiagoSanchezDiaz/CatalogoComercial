using System;
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
            bool cerrar = true;
            try
            {
                cerrar = verificarCasillas();
                if (cerrar)
                {
                    MessageBox.Show("Complete los datos requeridos *");
                }
                else
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if(cerrar == false)
                    this.Close();
            }
        }

        private bool verificarCasillas()
        {
            bool verificado = false;
            try
            {
                if (string.IsNullOrEmpty(tbNombre.Text))
                {
                    verificado = true;
                    lbNombre2.Text = "*";
                }
                else
                    lbNombre2.Text = "";
                if (string.IsNullOrEmpty(tbCodigo.Text))
                {
                    verificado = true;
                    lbCodigo2.Text = "*";
                }
                else
                    lbCodigo2.Text = "";
                if (string.IsNullOrEmpty(tbPrecio.Text))
                {
                    verificado = true;
                    lbPrecio2.Text = "*";
                }
                else
                    lbPrecio2.Text = "";
                if (cobMarca.SelectedIndex < 0)
                {
                    verificado = true;
                    lbMarca2.Text = "*";
                }
                else
                    lbMarca2.Text = "";
                if (cobCategoria.SelectedIndex < 0)
                {
                    verificado = true;
                    lbCategoria2.Text = "*";
                }
                else
                    lbCategoria2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return verificado;
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
                cobMarca.SelectedIndex = -1;
                cobCategoria.SelectedIndex = -1;

                if (articulo != null)
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

        private void tbUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbUrlImagen.Text);
        }

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

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8 && e.KeyChar !=46)
                e.Handled = true;
        }

        private void bImagen_Click(object sender, EventArgs e)
        {
            /// Cargar aca la imagen desde la compu
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
    }
}
