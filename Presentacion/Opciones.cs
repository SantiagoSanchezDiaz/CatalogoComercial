using System;
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

        private void bVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Opciones_Load(object sender, EventArgs e)
        {
            ArticuloNegocio aux = new ArticuloNegocio();
            try
            {
                listaArticulo = aux.listar();
                dgvArticulos.DataSource = listaArticulo;
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

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
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
            AgregarModificar form = new AgregarModificar("Agregar");
            form.ShowDialog();
        }
        private void bModificar_Click(object sender, EventArgs e)
        {
            AgregarModificar form = new AgregarModificar("Modificar");
            form.ShowDialog();
        }
    }
}
