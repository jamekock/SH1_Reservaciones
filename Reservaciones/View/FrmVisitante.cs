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
    public partial class FrmVisitante : Form
    {
        private int id;
        public string dual = "visitante";
        public List<string> tipos = new List<string>();
        public List<string> telefonos = new List<string>();
        public string txtTelefonoTipo { get; set; }
        public string txtDocumentoTipo { get; set; }
        DualDAO age = new DualDAO();
        private static DataTable table;
        public FrmVisitante()
        {
            InitializeComponent();
            cmbDocumentoTipo.Items.Add("Cedula");
            cmbDocumentoTipo.Items.Add("Pasaporte");
            cmbTelefonoTipo.Items.Add("Celular");
            cmbTelefonoTipo.Items.Add("Fax");
            Consultar();
            Dgv_Visitante.Columns["Id"].Visible = false;
            
        }
        

        private void Consultar()
        {
            Dgv_Visitante.DataSource = table = age.Consultar(dual);
        }


        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            CmbText();
            if (txtNombre.Text != "" && txtApellido.Text != "" && txtDocumentoIdentidad.Text != "" && txtDocumentoTipo != "" && telefonos != null && tipos != null)
            {
                bool rs = age.Insertar(dual, txtNombre.Text, txtApellido.Text, txtDocumentoIdentidad.Text, txtDocumentoTipo, telefonos, tipos);
                if (rs)
                {
                    MessageBox.Show("Registro  insertado  correctamente");
                }
                RestablecerControles();
                Consultar();
            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos");
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ObtenerId();
            DialogResult r =
            MessageBox.Show("Eliminar",
            "Esta seguro que desea  Eliminar este registro? ",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (r == DialogResult.OK)
            {
                bool rs = age.Eliminar(dual, id);
                if (rs)
                {
                    MessageBox.Show("Registro Eliminado Correctamente");
                    Consultar();
                }
                RestablecerControles();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CmbText();
            ObtenerId();
            bool rs = age.Actualizar(dual, id, txtNombre.Text, txtApellido.Text, txtDocumentoIdentidad.Text, txtDocumentoTipo,telefonos,tipos);
            if (rs)
            {
                MessageBox.Show("Registro  insertado  correctamente");
                Consultar();
            }
            RestablecerControles();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            CmbText();
            string telefono = cmbTelefono.Text;
            telefonos.Add(telefono);
            tipos.Add(txtTelefonoTipo);
            cmbTelefono.Items.Add(cmbTelefono.Text);
            lbTelefono.DataSource = null;
            lbTelefono.DataSource = telefonos;
            lbTipo.DataSource = null;
            lbTipo.DataSource = tipos;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            CmbText();
            string telefono = cmbTelefono.Text;
            telefonos.Remove(telefono);
            tipos.Remove(txtTelefonoTipo);
            cmbTelefono.Items.Remove(cmbTelefono.Text);
            lbTelefono.DataSource = null;
            lbTelefono.DataSource = telefonos;
            lbTipo.DataSource = null;
            lbTipo.DataSource = tipos;
        }

        public void RestablecerControles()
        {
            this.lbTelefono.DataSource = null;
            this.lbTipo.DataSource = null;
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtDocumentoIdentidad.Clear();
            this.cmbTelefono.Items.Clear();
            this.telefonos.Clear();
            this.tipos.Clear();
            this.BtnEliminar.Enabled = false;
            this.BtnActualizar.Enabled = false;
        }

        private void ObtenerId()
        {
            
            id = Convert.ToInt32(Dgv_Visitante.CurrentRow.Cells[0].Value.ToString());
        }
        private void ObtenerDatos()
        {
            ObtenerId();
            txtNombre.Text = Dgv_Visitante.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = Dgv_Visitante.CurrentRow.Cells[2].Value.ToString();
            txtDocumentoIdentidad.Text = Dgv_Visitante.CurrentRow.Cells[3].Value.ToString();
            cmbDocumentoTipo.Text = Dgv_Visitante.CurrentRow.Cells[4].Value.ToString();
        }

        private void Dgv_Visitante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RestablecerControles();
            ObtenerId();
            this.BtnEliminar.Enabled = true;
        }
        private void Dgv_Visitante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerDatos();
            this.BtnEliminar.Enabled = false;
            this.BtnActualizar.Enabled = true;
        }
        private void CmbText()
        {
            txtDocumentoTipo = cmbDocumentoTipo.GetItemText(cmbDocumentoTipo.SelectedItem);
            txtTelefonoTipo = cmbTelefonoTipo.GetItemText(cmbTelefonoTipo.SelectedItem);
        }

        private void LbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmVisitante_Load(object sender, EventArgs e)
        {

        }

        private void CmbDocumentoTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
