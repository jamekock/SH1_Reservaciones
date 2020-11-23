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
        public string nombre =" John ";
        public string apellido = " Javier ";
        public FrmGenerar()
        {
            InitializeComponent();
            cmbDocumentoTipo.Items.Add("Cedula");
            cmbDocumentoTipo.Items.Add("Pasaporte");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            if (txtConsulta.Text != "")
            {
                lblMessage.Text = "Nombre:"+ nombre + apellido ;  
            }
            else
            {
                lblMessage.Text = "No se encuentra registrado";
                new View.FrmVisitante().Show();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtConsulta.Clear();
            this.lblMessage.Text = "";
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
