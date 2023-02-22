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
    public partial class Inicio : Form
    {
        DateTime horario = DateTime.Now;
        public Inicio()
        {
            InitializeComponent();
            lbHorario.Text = horario.ToString("dd MMMM, yyyy H:mm");
        }

        private void bOpciones_Click(object sender, EventArgs e)
        {
            Opciones form = new Opciones();
            form.ShowDialog();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
