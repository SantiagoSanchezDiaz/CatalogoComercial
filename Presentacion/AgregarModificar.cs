using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private string decision; 
        public AgregarModificar(string text)
        {
            InitializeComponent();
            decision = text;
            bAgregarModificar.Text = decision;
            lbAgregarModificar.Text = decision;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAgregarModificar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            try
            {
                if (decision == "Agregar")
                {
                    art.Nombre = tbNombre.Text;
                    art.Codigo = tbCodigo.Text;
                    art.Precio = decimal.Parse(tbPrecio.Text);
                    negocio.agregar(art);
                    MessageBox.Show("Agregado exitosamente");
                }
                else
                {


                    negocio.modificar(art);
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
                cobCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
