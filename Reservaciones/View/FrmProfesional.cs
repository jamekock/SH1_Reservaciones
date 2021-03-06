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
    public partial class FrmProfesional : Form
    {
        private int id;
        DualDAO age = new DualDAO();
        public string dual = "profesional";
        public string txtDocumentoTipo { get; set; }
        public string txtTelefonoTipo { get; set; }
        public List<string> telefonos = new List<string>();
        public List<string> tipos = new List<string>();
        public FrmProfesional()
        {
            InitializeComponent();
            Consultar();
            BtnEliminar.Enabled = false;
            BtnActualizar.Enabled = false;
            cmbTelefonoTipo.Items.Add("Fax");
            cmbTelefonoTipo.Items.Add("Celular");
            cmbDocumentoTipo.Items.Add("Cedula");
            cmbDocumentoTipo.Items.Add("Pasaporte");
            Dgv_Visitante.Columns[0].Visible = false;
        }

        private void Consultar()
        {
            Dgv_Visitante.DataSource = age.Consultar(dual);
        }

        private void cmbText()
        {
            txtTelefonoTipo = cmbTelefonoTipo.GetItemText(cmbTelefonoTipo.SelectedItem);
            txtDocumentoTipo = cmbDocumentoTipo.GetItemText(cmbDocumentoTipo.SelectedItem);
        }
        private void ObtenerId()
        {           
            bool convert = Int32.TryParse(Dgv_Visitante.CurrentRow.Cells[0].Value.ToString(),out id);
            if (convert == false)
            {
                MessageBox.Show("No se encuentra disponible");
            }
        }
        private void ObtenerDatos()
        {
            ObtenerId();
            txtNombre.Text = Dgv_Visitante.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = Dgv_Visitante.CurrentRow.Cells[2].Value.ToString();
            cmbDocumentoTipo.Text = Dgv_Visitante.CurrentRow.Cells[4].Value.ToString();
            txtDocumentoIdentidad.Text = Dgv_Visitante.CurrentRow.Cells[3].Value.ToString();
            age.GetTelefonos(dual, id);
            tipos = age.tipos;
            telefonos = age.telefonos;
            lbTipo.DataSource = null;
            lbTipo.DataSource = tipos;
            lbTelefono.DataSource = null;
            lbTelefono.DataSource = telefonos;
        }
        public void RestablecerControles()
        {
            this.lbTelefono.DataSource = null;
            this.lbTipo.DataSource = null;
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtDocumentoIdentidad.Clear();
            this.cmbTelefono.Items.Clear();
            this.cmbTelefono.Text = "";
            this.cmbDocumentoTipo.Text = "";
            this.BtnEliminar.Enabled = false;
            this.BtnActualizar.Enabled = false;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            cmbText();
            string telefono = cmbTelefono.Text;
            telefonos.Remove(telefono);
            tipos.Remove(txtTelefonoTipo);
            cmbTelefono.Items.Remove(cmbTelefono.Text);
            lbTelefono.DataSource = null;
            lbTelefono.DataSource = telefonos;
            lbTipo.DataSource = null;
            lbTipo.DataSource = tipos;
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            cmbText();
            string telefono = cmbTelefono.Text;
            telefonos.Add(telefono);
            tipos.Add(txtTelefonoTipo);
            cmbTelefono.Items.Add(cmbTelefono.Text);
            lbTelefono.DataSource = null;
            lbTelefono.DataSource = telefonos;
            lbTipo.DataSource = null;
            lbTipo.DataSource = tipos;
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
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            cmbText();
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
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            cmbText();
            ObtenerId();
            DialogResult r =
            MessageBox.Show("Actualizar",
            "Esta seguro que desea  Actualizar este registro? ",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (r == DialogResult.OK)
            {
                bool rs = age.Actualizar(dual, id, txtNombre.Text, txtApellido.Text, txtDocumentoIdentidad.Text, txtDocumentoTipo, telefonos, tipos);
                if (rs)
                {
                    MessageBox.Show("Registro Actualizado Correctamente");
                    Consultar();
                }
                RestablecerControles();
            }
        }

        private void Dgv_Visitante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerId();
            RestablecerControles();
            this.BtnEliminar.Enabled = true;
            this.BtnActualizar.Enabled = false;
            
        }
        private void Dgv_Visitante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerDatos();
            this.BtnEliminar.Enabled = false;
            this.BtnActualizar.Enabled = true;
        }
    }
}
