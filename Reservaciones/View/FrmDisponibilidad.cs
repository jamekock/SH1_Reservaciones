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
    public partial class FrmDisponibilidad : Form
    {
        int id_dias;
        int id_profesional;
        int id1;
        int id2;
        DAO.DisponibilidadDAO age = new DAO.DisponibilidadDAO();
        DAO.GetDAO mod = new DAO.GetDAO();
        public FrmDisponibilidad()
        {
            InitializeComponent();
            mod.GetProfesional();
            mod.GetDias();
            txtDias.Enabled = false;
            txtProfesional.Enabled = false;
            txtIdDias.Enabled = false;
            txtIdProfesional.Enabled = false;
            Consultar2();
            Consultar1();
            Consultar();
            DgvDisponibilidad.Columns[0].Visible = false;
            DgvDisponibilidad.Columns[2].Visible = false;
        }
        public void Consultar()
        {
            DgvDisponibilidad.DataSource= age.Consultar();
        }

        public void Consultar1()
        {
            DgvProfesional.DataSource= mod.GetProfesional();
        }

        public void Consultar2()
        {
            DgvDias.DataSource= mod.GetDias();
        }

        public void ObtenerIDDay()
        {
            id_dias = Convert.ToInt32(DgvDias.CurrentRow.Cells[0].Value.ToString());
        }
        public void ObtenerIDPro()
        {
            id_profesional = Convert.ToInt32(DgvProfesional.CurrentRow.Cells[0].Value.ToString());
        }

        private void DgvProfesional_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerIDPro();
            txtProfesional.Text = Convert.ToString(id_profesional);
        }
        private void DgvDias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerIDDay();
            txtDias.Text = Convert.ToString(id_dias);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

            bool rs = age.Insertar(id_profesional,id_dias);
            Consultar();
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r =
            MessageBox.Show("Eliminar",
            "Esta seguro que desea  Eliminar este registro? ",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (r == DialogResult.OK)
            {
                bool rs = age.Eliminar(id_profesional,id_dias);
                if (rs)
                {
                    MessageBox.Show("Registro Eliminado Correctamente");
                    Consultar();
                }
            }
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            DialogResult r =
            MessageBox.Show("Actualizar",
            "Esta seguro que desea  Actualizar este registro? ",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (r == DialogResult.OK)
            {
                bool rs = age.Actualizar(id_profesional, id_dias,id1,id2);
                if (rs)
                {
                    MessageBox.Show("Registro Actualizado Correctamente");
                    Consultar();
                }
            }
        }

        private void DgvDisponibilidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_dias = (Convert.ToInt32(DgvDisponibilidad.CurrentRow.Cells[2].Value.ToString()));
            txtIdDias.Text = Convert.ToString(id_dias);
            id_profesional = Convert.ToInt32(DgvDisponibilidad.CurrentRow.Cells[0].Value.ToString());
            txtIdProfesional.Text = Convert.ToString(id_profesional);
            this.BtnRegistrar.Enabled = true;
            this.BtnEliminar.Enabled = true;
            this.BtnActualizar.Enabled = false;
        }

        private void DgvDisponibilidad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id2 = Convert.ToInt32(DgvDisponibilidad.CurrentRow.Cells[2].Value.ToString());
            txtIdDias.Text = Convert.ToString(id2);
            id1 = Convert.ToInt32(DgvDisponibilidad.CurrentRow.Cells[0].Value.ToString());
            txtIdProfesional.Text = Convert.ToString(id1);
            this.BtnRegistrar.Enabled = true;
            this.BtnActualizar.Enabled = true;
            this.BtnEliminar.Enabled = false;
        }

        private void FrmDisponibilidad_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
