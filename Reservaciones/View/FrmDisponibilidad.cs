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
        int id1;
        int id2;
        int id_dias;
        int id_profesional;
        DAO.DisponibilidadDAO age = new DAO.DisponibilidadDAO();
        DAO.GetDAO mod = new DAO.GetDAO();
        public FrmDisponibilidad()
        {
            InitializeComponent();
            Consultar();
            ConsultarD();
            ConsultarP();
            mod.GetDias();
            mod.GetProfesional();
            txtDias.Enabled = false;
            txtIdDias.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnActualizar.Enabled = false;
            txtProfesional.Enabled = false;
            txtIdProfesional.Enabled = false;
            DgvDisponibilidad.Columns[0].Visible = false;
            DgvDisponibilidad.Columns[2].Visible = false;
        }

        public void Consultar()
        {
            DgvDisponibilidad.DataSource= age.Consultar();
        }
        public void ConsultarP()
        {
            DgvProfesional.DataSource= mod.GetProfesional();
        }
        public void ConsultarD()
        {
            DgvDias.DataSource= mod.GetDias();
        }

        public void ObtenerIDDay()
        {
            bool convert = Int32.TryParse(DgvDias.CurrentRow.Cells[0].Value.ToString(),out id_dias);
            if (convert == false)
            {
                MessageBox.Show("No se encuentra disponible");
            }
        }
        public void ObtenerIDPro()
        {
            bool convert= Int32.TryParse(DgvProfesional.CurrentRow.Cells[0].Value.ToString(),out id_profesional);
            if (convert == false)
            {
                MessageBox.Show("No se encuentra disponible");
            }
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
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

            bool rs = age.Insertar(id_profesional,id_dias);
            Consultar();
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

        private void DgvDias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerIDDay();
            txtDias.Text = Convert.ToString(id_dias);
        }
        private void DgvDisponibilidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool convert2 = Int32.TryParse(DgvDisponibilidad.CurrentRow.Cells[2].Value.ToString(),out id_dias);
            bool convert1 = Int32.TryParse(DgvDisponibilidad.CurrentRow.Cells[0].Value.ToString(),out id_profesional);
            txtIdDias.Text = Convert.ToString(id_dias);
            txtIdProfesional.Text = Convert.ToString(id_profesional);
            if (convert2 == false)
            {
                MessageBox.Show("No se encuentra disponible");
            }
            this.BtnEliminar.Enabled = true;
            this.BtnActualizar.Enabled = false;
        }
        private void DgvProfesional_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerIDPro();
            txtProfesional.Text = Convert.ToString(id_profesional);
        }
        private void DgvDisponibilidad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool convert1 = Int32.TryParse(DgvDisponibilidad.CurrentRow.Cells[0].Value.ToString(),out id1);
            bool convert2 = Int32.TryParse(DgvDisponibilidad.CurrentRow.Cells[2].Value.ToString(),out id2);
            txtIdDias.Text = Convert.ToString(id2);
            txtIdProfesional.Text = Convert.ToString(id1);
            if (convert2 == false)
            {
                MessageBox.Show("No se encuentra disponible");
            }
            this.BtnEliminar.Enabled = false;
            this.BtnActualizar.Enabled = true;
        }
    }
}
