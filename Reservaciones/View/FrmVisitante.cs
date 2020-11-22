﻿using System;
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
        public string MyProperty { get; set; }
        public string MyProperty2 { get; set; }
        public List<string> tipos = new List<string>();
        public List<string> telefonos = new List<string>();

       
        CRUDDAO age = new CRUDDAO();
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


        private void BtnRegistrar_Click_1(object sender, EventArgs e)
        {
            DocumentoTipo();
            bool rs = age.Insertar(dual, txtNombre.Text, txtApellido.Text, txtDocumentoIdentidad.Text, MyProperty, telefonos, tipos);
            if (rs)
            {
                MessageBox.Show("Registro  insertado  correctamente");
            }
            RestablecerControles();
            Consultar();
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
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

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            ObtenerId();
            bool rs = age.Actualizar(dual, id, txtNombre.Text, txtApellido.Text, txtDocumentoIdentidad.Text, MyProperty, txtApellido.Text, txtApellido.Text);
            if (rs)
            {
                MessageBox.Show("Registro  insertado  correctamente");
                Consultar();
            }
            RestablecerControles();
        }

        private void BtnEnter_Click_1(object sender, EventArgs e)
        {
            TelefonoTipo();
            string telefono = cmbTelefono.Text;
            telefonos.Add(telefono);
            tipos.Add(MyProperty2);
            cmbTelefono.Items.Add(cmbTelefono.Text);
            lbTelefono.DataSource = null;
            lbTelefono.DataSource = telefonos;
            lbTipo.DataSource = null;
            lbTipo.DataSource = tipos;
        }

        private void BtnDel_Click_1(object sender, EventArgs e)
        {
            TelefonoTipo();
            string telefono = cmbTelefono.Text;
            telefonos.Remove(telefono);
            tipos.Remove(MyProperty2);
            cmbTelefono.Items.Remove(cmbTelefono.Text);
            lbTelefono.DataSource = null;
            lbTelefono.DataSource = telefonos;
            lbTipo.DataSource = null;
            lbTipo.DataSource = tipos;
        }

        private void DocumentoTipo()
        {
            if (cmbDocumentoTipo.SelectedIndex == 0) { MyProperty = "Cedula"; }
            else { MyProperty = "Tipo"; }
        }

        private void TelefonoTipo()
        {
            if (cmbTelefonoTipo.SelectedIndex == 0) { MyProperty2 = "Celular"; }
            else { MyProperty2 = "Fax"; }

        }

        public void RestablecerControles()
        {
            this.lbTelefono.DataSource = null;
            this.lbTipo.DataSource = null;
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtDocumentoIdentidad.Clear();
            this.cmbTelefono.Items.Clear();
            //this.BtnEliminar.Enabled = false;
            //this.BtnActualizar.Enabled = false;
        }

        private void ObtenerId()
        {
            id = Convert.ToInt32(Dgv_Visitante.Rows[Dgv_Visitante.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
        }

        private void Dgv_Visitante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RestablecerControles();
            ObtenerId();
            this.BtnEliminar.Enabled = true;
        }
        private void Dgv_Visitante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.BtnEliminar.Enabled = false;
            this.BtnActualizar.Enabled = true;
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
