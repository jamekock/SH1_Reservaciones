using System;
using System.Drawing;
using System.Windows.Forms;
using Pabo.Calendar;

namespace Reservaciones.View
{
    public partial class FrmGenerar : Form
    {
        DAO.GetDAO age = new DAO.GetDAO();
        DAO.GenerarDAO mod = new DAO.GenerarDAO();

        private int id;
        int id_profesional;
        int id_dias;
        int estado = 1;
        public string Fecha { get; set; }
        private DateItem[] dateItems;
        public FrmGenerar()
        {
            InitializeComponent();
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtProfesional.Enabled = false;
            DgvProfesional.DataSource = age.GetProfesional();
            DgvProfesional.Columns["Id"].Visible = false;
            Consultar();
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            age.GetFiltro(txtConsulta.Text);
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
            this.age.name = "";
            this.age.lastname = "";
        }

        private void Consultar()
        {
            DgvCita.DataSource = mod.Consultar();
        }
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            // id_profesional,id_visitante,id_dias,fecha,motivo,id_estado

            Fecha = DisponibilidadCalendar.SelectedDates[0].ToShortDateString();
            id_dias = Convert.ToInt32(DisponibilidadCalendar.SelectedDates[0].DayOfWeek);
            bool rs = mod.Insertar(id_profesional,age.id_visitante,id_dias,Fecha,rtxtMotivo.Text,estado);
            if (rs)
            {
                MessageBox.Show("Registro  insertado  correctamente");
                RestablecerControles();
            }
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
                bool rs = mod.Eliminar(id);
                if (rs)
                {
                    MessageBox.Show("Registro Eliminado Correctamente");
                    Consultar();
                }
                RestablecerControles();
            }
        }

        private void RestablecerControles()
        {
            this.rtxtMotivo.Clear();
        }

        private void DgvProfesional_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id_profesional = Convert.ToInt32(DgvProfesional.CurrentRow.Cells[0].Value.ToString());
            txtProfesional.Text = Convert.ToString(id_profesional);
            Execute();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            View.FrmConsulta ventana = new FrmConsulta();
            ventana.Show();
        }
        public void Execute()
        {
            dateItems = new DateItem[366];
            age.GetDisponibilidadProfesional(id_profesional);
            DiasNoLaborables();
            foreach (var itemDay in age.num)
            {
                DiasLaborables(itemDay);
            }
            DisponibilidadCalendar.AddDateInfo(dateItems);
            DisponibilidadCalendar.Refresh();
        }
        private void DiasNoLaborables()
        {
            DateTime dt = new DateTime(2020, 01, 01);

            for (int i = 0; i <= 365; i++)
            {
                var di = new DateItem();
                di.Date = dt.AddDays(i);
                di.Enabled = false;
                dateItems[i] = di;
            }
        }
        private void DiasLaborables(int dia)
        {
            DateTime dt = new DateTime(2020, 01, 01);

            for (int i = 0; i <= 365; i++)
            {
                var d = dt.AddDays(i);
                if (dateItems[i].Date == d)
                {
                    if (d.DayOfWeek == (DayOfWeek)dia)
                    {
                        var di = new DateItem();
                        di.Date = d;
                        di.BackColor1 = Color.Green;
                        dateItems[i] = di;
                    }
                }
            }
        }
        private void ObtenerId()
        {
            id = Convert.ToInt32(DgvCita.CurrentRow.Cells[0].Value.ToString());
        }
        private void DgvCita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerId();
            this.BtnEliminar.Enabled = true;
            this.BtnActualizar.Enabled = false;
        }

        private void DgvCita_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObtenerId();
            this.BtnEliminar.Enabled = false;
            this.BtnActualizar.Enabled = true;
        }
        /*id_profesional,id_visitante,id_dias,fecha,motivo,id_estado*/
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ObtenerId();
            DialogResult r =
            MessageBox.Show("Actualizar",
            "Esta seguro que desea  Actualizar este registro? ",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (r == DialogResult.OK)
            {
                Fecha = DisponibilidadCalendar.SelectedDates[0].ToShortDateString();
                id_dias = Convert.ToInt32(DisponibilidadCalendar.SelectedDates[0].DayOfWeek);
                bool rs = mod.Actualizar(id,id_dias,Fecha,rtxtMotivo.Text);
                if (rs)
                {
                    MessageBox.Show("Registro Actualizado Correctamente");
                    Consultar();
                }
            }
        }
    }  
}
