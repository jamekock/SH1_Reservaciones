﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservaciones
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void GenerarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.FrmGenerar().Show();
        }
        private void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.FrmConsulta().Show();
        }
        private void VisitanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.FrmVisitante().Show(); 
        }
        private void ProfesionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.FrmProfesional().Show();
        }
        private void DisponibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new View.FrmDisponibilidad().Show();
        }
    }
}
