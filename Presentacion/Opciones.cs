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
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            AgregarModificar form = new AgregarModificar();
            form.ShowDialog();
        }

        private void bVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
