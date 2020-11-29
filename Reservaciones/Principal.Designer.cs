namespace Reservaciones
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.profesionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCita = new System.Windows.Forms.ToolStripMenuItem();
            this.generarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSystem,
            this.tsmAdministrar,
            this.tsmCita,
            this.tsmReportes,
            this.tsmHelp,
            this.tsmExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(892, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmSystem
            // 
            this.tsmSystem.Name = "tsmSystem";
            this.tsmSystem.Size = new System.Drawing.Size(57, 20);
            this.tsmSystem.Text = "System";
            // 
            // tsmAdministrar
            // 
            this.tsmAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesionalToolStripMenuItem,
            this.visitanteToolStripMenuItem,
            this.disponibilidadToolStripMenuItem});
            this.tsmAdministrar.Name = "tsmAdministrar";
            this.tsmAdministrar.Size = new System.Drawing.Size(81, 20);
            this.tsmAdministrar.Text = "Administrar";
            // 
            // profesionalToolStripMenuItem
            // 
            this.profesionalToolStripMenuItem.Name = "profesionalToolStripMenuItem";
            this.profesionalToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.profesionalToolStripMenuItem.Text = "Profesional";
            this.profesionalToolStripMenuItem.Click += new System.EventHandler(this.ProfesionalToolStripMenuItem_Click);
            // 
            // visitanteToolStripMenuItem
            // 
            this.visitanteToolStripMenuItem.Name = "visitanteToolStripMenuItem";
            this.visitanteToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.visitanteToolStripMenuItem.Text = "Visitante";
            this.visitanteToolStripMenuItem.Click += new System.EventHandler(this.VisitanteToolStripMenuItem_Click);
            // 
            // disponibilidadToolStripMenuItem
            // 
            this.disponibilidadToolStripMenuItem.Name = "disponibilidadToolStripMenuItem";
            this.disponibilidadToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.disponibilidadToolStripMenuItem.Text = "Disponibilidad";
            this.disponibilidadToolStripMenuItem.Click += new System.EventHandler(this.DisponibilidadToolStripMenuItem_Click);
            // 
            // tsmCita
            // 
            this.tsmCita.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.tsmCita.Name = "tsmCita";
            this.tsmCita.Size = new System.Drawing.Size(40, 20);
            this.tsmCita.Text = "Cita";
            this.tsmCita.Click += new System.EventHandler(this.TsmCita_Click);
            // 
            // generarToolStripMenuItem
            // 
            this.generarToolStripMenuItem.Name = "generarToolStripMenuItem";
            this.generarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generarToolStripMenuItem.Text = "Generar";
            this.generarToolStripMenuItem.Click += new System.EventHandler(this.GenerarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.ConsultarToolStripMenuItem_Click);
            // 
            // tsmReportes
            // 
            this.tsmReportes.Name = "tsmReportes";
            this.tsmReportes.Size = new System.Drawing.Size(65, 20);
            this.tsmReportes.Text = "Reportes";
            // 
            // tsmHelp
            // 
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.ShortcutKeyDisplayString = "Help";
            this.tsmHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmHelp.Text = "Help";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(38, 20);
            this.tsmExit.Text = "Exit";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reservaciones.Properties.Resources.STOCKP;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(908, 640);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Principal
            // 
            this.ClientSize = new System.Drawing.Size(892, 601);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmAdministrar;
        private System.Windows.Forms.ToolStripMenuItem profesionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCita;
        private System.Windows.Forms.ToolStripMenuItem tsmReportes;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
    }
}

