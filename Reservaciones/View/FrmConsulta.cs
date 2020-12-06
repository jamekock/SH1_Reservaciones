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
    public partial class FrmConsulta : Form
    {
        private int id_visitante;
        private int id_estado;
        private int id;
        DAO.GetDAO age = new DAO.GetDAO();
        DAO.GenerarDAO mod = new DAO.GenerarDAO();
        public FrmConsulta()
        {
            InitializeComponent();
            Consulta();
            
            DgvEstado.Columns[0].Visible = false;
            txtIdEstado.Enabled = false;
            BtnActualizar.Enabled = false;
            DgvConsulta.Columns[0].Visible = false;
            DgvConsulta.Columns[1].Visible = false;
            DgvConsulta.Columns[3].Visible = false;
        }

        public void Consulta()
        {
            DgvEstado.DataSource = age.GetEstado();
            DgvConsulta.DataSource = mod.Consultar();
        }

        public void Filter()
        {
            (DgvConsulta.DataSource as DataTable).DefaultView.RowFilter = $"id_visitante = '{age.id_visitante}'";
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            age.GetFiltro(txtConsulta.Text);
            if (age.name != "")
            {
                Filter();
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
            this.age.name = "";
            this.age.lastname = "";
            (DgvConsulta.DataSource as DataTable).DefaultView.RowFilter = $"";
        }

        public void ObtenerId()
        {
            bool convert = Int32.TryParse(DgvConsulta.CurrentRow.Cells[3].Value.ToString(),out id_visitante);
            id = age.id_visitante;
            id = id_visitante;
            if (convert == false)
            {
                MessageBox.Show("No se encuentra disponible");
            }


        }
        private void ObtenerIdEstado()
        {
            bool convert = Int32.TryParse(DgvEstado.CurrentRow.Cells[0].Value.ToString(),out id_estado);
            txtIdEstado.Text = Convert.ToString(id_estado);
            if (convert == false)
            {
                MessageBox.Show("No se encuentra disponible");
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerId();
            ObtenerIdEstado();
            DialogResult r =
            MessageBox.Show("Actualizar",
            "Esta seguro que desea  Actualizar este registro? ",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (r == DialogResult.OK)
            {
                bool rs = mod.SetGenerar(id_estado, id);
                if (rs)
                {
                    MessageBox.Show("Registro Actualizado Correctamente");
                    Consulta();
                }
            }
        }

        private void DgvEstado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerIdEstado();
        }
        private void DgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerId();
            BtnActualizar.Enabled = true;
        }


    }
}
