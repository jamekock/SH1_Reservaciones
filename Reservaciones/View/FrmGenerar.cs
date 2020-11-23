using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservaciones.View
{
    public partial class FrmGenerar : Form
    {
        public string nombre;
        public FrmGenerar()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            if (txtConsulta == null)
            {
                lblMessage.Text = "Hola"+ nombre + "!";  
            }
            else
            {
                lblMessage.Text = "No se encuentra registrado";
                new View.FrmVisitante().Show();
            }
        }
    }
}
