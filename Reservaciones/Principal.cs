using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservaciones
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void VisitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            View.FrmVisitante ventana1 = new View.FrmVisitante();
            ventana1.Show();
        }
    }
}
