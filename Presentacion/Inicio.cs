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
using System.Configuration;
using System.Xml;
using System.IO;

namespace Presentacion
{
    public partial class Inicio : Form
    {
        // private string direccion = null;

        DateTime horario = DateTime.Now;
        public Inicio()
        {
            InitializeComponent();
            lbHorario.Text = horario.ToString("dd MMMM, yyyy H:mm");
        }

        private void bOpciones_Click(object sender, EventArgs e)
        {
            Opciones opciones = new Opciones();
            opciones.ShowDialog();
            cargarUltimoArt();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            cargarUltimoArt();
        }

        private void cargarUltimoArt()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                Articulo art = negocio.ultimoRegistro();
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
                lvUltimoArticulo.Items.Clear();
                lvUltimoArticulo.Items.Add("");
                lvUltimoArticulo.Items.Add(line1);
                lvUltimoArticulo.Items.Add("");
                lvUltimoArticulo.Items.Add(line2);
                lvUltimoArticulo.Items.Add("");
                lvUltimoArticulo.Items.Add(line3);
                lvUltimoArticulo.Items.Add("");
                lvUltimoArticulo.Items.Add(line4);
                lvUltimoArticulo.Items.Add("");
                lvUltimoArticulo.Items.Add(line5);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string url)
        {
            try
            {
                pbInicio.Load(url);
            }
            catch (Exception)
            {
                pbInicio.Load("https://plantillasdememes.com/img/plantillas/imagen-no-disponible01601774755.jpg");
            }
        }

        private void salirDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opciones opciones = new Opciones();
            opciones.ShowDialog();
            cargarUltimoArt();
        }

        private void agregarUnArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool agregar = true; 
            Opciones opciones = new Opciones(agregar);
            opciones.ShowDialog();
            cargarUltimoArt();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contacte con mantenimiento.");
        }

        // Intento de direccionar a la misma carpeta del proyecto

        /*
            direccion = conseguirDireccion();
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement item in xmlDoc.DocumentElement)
            {
                if (item.Name.Equals("appSettings"))
                {
                    foreach (XmlNode nodo in item.ChildNodes)
                    {
                        if (nodo.Attributes[0].Value == "carpeta-imagenes")
                            nodo.Attributes[1].Value = direccion + "\ ";
                    }
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");
            

        private string conseguirDireccion()
        {
            string path = Path.GetFullPath("CatalogoComercial-main");
            int ancho = path.Length - 45;
            path = path.Remove(ancho, 45) + "Imagenes";
            return path;
        }
        */
    }
}
