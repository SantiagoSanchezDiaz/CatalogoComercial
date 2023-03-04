using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Detalle : Form
    {
        private Articulo art = null;
        public Detalle(Articulo seleccionado)
        {
            InitializeComponent();
            if(seleccionado == null) 
                art = new Articulo();
            art = seleccionado;
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarImagen(string Url)
        {
            try
            {
                pbDetalle.Load(Url);
            }
            catch (Exception)
            {
                pbDetalle.Load("https://plantillasdememes.com/img/plantillas/imagen-no-disponible01601774755.jpg");
            }
        }

        private void Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                string line1 = "El nombre del Artículo es " + art.Nombre;
                string line2 = "El código del Artículo es " + art.Codigo;
                string line3;
                if (string.IsNullOrEmpty(art.Descripcion))
                    line3 = "No posee descripción";
                else
                    line3 = "Su descripción es: " + art.Descripcion;
                string line4 = "La marca es " + art.Marca.Detalle + " y su categoría es " + art.Categoria.Detalle;
                string line5 = "Su precio actual es " + art.Precio;
                cargarImagen(art.ImagenUrl);
                lvDetalle.Items.Clear();
                lvDetalle.Items.Add("");
                lvDetalle.Items.Add(line1);
                lvDetalle.Items.Add("");
                lvDetalle.Items.Add(line2);
                lvDetalle.Items.Add("");
                lvDetalle.Items.Add(line3);
                lvDetalle.Items.Add("");
                lvDetalle.Items.Add(line4);
                lvDetalle.Items.Add("");
                lvDetalle.Items.Add(line5);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
