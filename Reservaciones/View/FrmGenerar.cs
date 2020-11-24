using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reservaciones.View
{
    public partial class FrmGenerar : Form
    {
        DAO.GenerarDAO age = new DAO.GenerarDAO();
        private DataTable table;
        public FrmGenerar()
        {
            InitializeComponent();
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            Consultar();
        }
    
        
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            age.Filtrar(txtConsulta.Text);
            if (age.name != "")
            {
                txtNombre.Text = age.name;
                txtApellido.Text = age.lastname;
            }
            else
            {
                MessageBox.Show("No se encuentra registrado");
                new View.FrmVisitante().Show();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtConsulta.Clear();
            this.txtNombre.Clear();
            this.txtApellido.Clear();
        }

        private void Consultar()
        {
            DgvCita.DataSource = table = age.Consultar();
        }
    }
}
