using System;
using System.Drawing;
using System.Windows.Forms;
using Pabo.Calendar;

namespace Reservaciones.View
{
    public partial class FrmGenerar : Form
    {
        int id_dias;
        int estado = 1;
        private int id;
        int id_profesional;
        private DateItem[] dateItems;
        public string Fecha { get; set; }
        DAO.GetDAO age = new DAO.GetDAO();
        DAO.GenerarDAO mod = new DAO.GenerarDAO();
        public FrmGenerar()
        {
            InitializeComponent();
            Consultar();
            ConsultarP();
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            BtnEliminar.Enabled = false;
            BtnActualizar.Enabled = false;
            txtProfesional.Enabled = false;
            DgvCita.Columns[0].Visible = false;
            DgvCita.Columns[1].Visible = false;
            DgvCita.Columns[3].Visible = false;
            DgvProfesional.Columns[0].Visible = false;
        }

        private void Consultar()
        {
            DgvCita.DataSource = mod.Consultar();
        }
        private void ConsultarP()
        {
            DgvProfesional.DataSource = age.GetProfesional();

        }

        private void Execute()
        {
            ResetDateInfo();
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
        public void ResetDateInfo()
        {
            DisponibilidadCalendar.ResetDateInfo();
            DisponibilidadCalendar.ClearSelection();
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
            bool convert = Int32.TryParse(DgvCita.CurrentRow.Cells[0].Value.ToString(),out id);
            if (convert == false)
            {
                MessageBox.Show("No se encuentra disponible");
            }
        }
        private void RestablecerControles()
        {
            this.age.name = "";
            this.age.lastname = "";
            this.txtNombre.Clear();
            this.rtxtMotivo.Clear();
            this.txtApellido.Clear();
            this.txtConsulta.Clear();

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
            this.age.name = "";
            this.age.lastname = "";
            this.txtNombre.Clear();
            this.txtConsulta.Clear();
            this.txtApellido.Clear();
        }
        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            View.FrmConsulta ventana = new FrmConsulta();
            ventana.Show();
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
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Fecha = DisponibilidadCalendar.SelectedDates[0].ToShortDateString();
            id_dias = Convert.ToInt32(DisponibilidadCalendar.SelectedDates[0].DayOfWeek);
            bool rs = mod.Insertar(id_profesional,age.id_visitante,id_dias,Fecha,rtxtMotivo.Text,estado);
            if (rs)
            {
                MessageBox.Show("Registro  insertado  correctamente");
                RestablecerControles();
                ResetDateInfo();
            }
            Consultar();
        }
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
                bool rs = mod.Actualizar(id, id_dias, Fecha, rtxtMotivo.Text);
                if (rs)
                {
                    MessageBox.Show("Registro Actualizado Correctamente");
                    Consultar();
                }
                RestablecerControles();
            }
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
        private void DgvProfesional_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool convert = Int32.TryParse(DgvProfesional.CurrentRow.Cells[0].Value.ToString(),out id_profesional);
            if (convert == false)
            {
                MessageBox.Show("No se encuentra disponible");
            }
            txtProfesional.Text = Convert.ToString(id_profesional);
            Execute();

        } 
    }  
}
