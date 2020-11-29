namespace Reservaciones.View
{
    partial class FrmGenerar
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
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.lblNat = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.rtxtMotivo = new System.Windows.Forms.RichTextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtProfesional = new System.Windows.Forms.TextBox();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.DgvProfesional = new System.Windows.Forms.DataGridView();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.DisponibilidadCalendar = new Pabo.Calendar.MonthCalendar();
            this.DgvCita = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConsulta
            // 
            this.txtConsulta.BackColor = System.Drawing.SystemColors.Control;
            this.txtConsulta.Location = new System.Drawing.Point(199, 320);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(131, 20);
            this.txtConsulta.TabIndex = 0;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(336, 317);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(48, 23);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // lblNat
            // 
            this.lblNat.AutoSize = true;
            this.lblNat.Location = new System.Drawing.Point(87, 254);
            this.lblNat.Name = "lblNat";
            this.lblNat.Size = new System.Drawing.Size(0, 13);
            this.lblNat.TabIndex = 2;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(390, 317);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(48, 23);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // rtxtMotivo
            // 
            this.rtxtMotivo.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtMotivo.Location = new System.Drawing.Point(199, 477);
            this.rtxtMotivo.Name = "rtxtMotivo";
            this.rtxtMotivo.Size = new System.Drawing.Size(252, 31);
            this.rtxtMotivo.TabIndex = 7;
            this.rtxtMotivo.Text = "";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(196, 304);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(123, 13);
            this.lblDocumento.TabIndex = 10;
            this.lblDocumento.Text = "Documento de identidad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(196, 461);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(39, 13);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Motivo";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(139, 119);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(156, 33);
            this.lblTittle.TabIndex = 13;
            this.lblTittle.Text = "Generar cita";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(199, 359);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(96, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(482, 485);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(59, 23);
            this.BtnRegistrar.TabIndex = 16;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(196, 343);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(301, 359);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(95, 20);
            this.txtApellido.TabIndex = 20;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(298, 343);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 21;
            this.lblApellido.Text = "Apellido";
            // 
            // txtProfesional
            // 
            this.txtProfesional.Location = new System.Drawing.Point(368, 398);
            this.txtProfesional.Name = "txtProfesional";
            this.txtProfesional.Size = new System.Drawing.Size(28, 20);
            this.txtProfesional.TabIndex = 27;
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(196, 382);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(59, 13);
            this.lblProfesional.TabIndex = 26;
            this.lblProfesional.Text = "Profesional";
            // 
            // DgvProfesional
            // 
            this.DgvProfesional.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvProfesional.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProfesional.Location = new System.Drawing.Point(199, 398);
            this.DgvProfesional.Name = "DgvProfesional";
            this.DgvProfesional.Size = new System.Drawing.Size(163, 60);
            this.DgvProfesional.TabIndex = 25;
            this.DgvProfesional.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProfesional_CellDoubleClick);
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Location = new System.Drawing.Point(685, 98);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(75, 23);
            this.BtnConsulta.TabIndex = 28;
            this.BtnConsulta.Text = "Consulta";
            this.BtnConsulta.UseVisualStyleBackColor = false;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // DisponibilidadCalendar
            // 
            this.DisponibilidadCalendar.ActiveMonth.Month = 11;
            this.DisponibilidadCalendar.ActiveMonth.Year = 2020;
            this.DisponibilidadCalendar.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.DisponibilidadCalendar.Culture = new System.Globalization.CultureInfo("es-DO");
            this.DisponibilidadCalendar.Footer.BackColor1 = System.Drawing.Color.Transparent;
            this.DisponibilidadCalendar.Footer.BackColor2 = System.Drawing.Color.Transparent;
            this.DisponibilidadCalendar.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.DisponibilidadCalendar.Footer.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.DisponibilidadCalendar.Header.BackColor1 = System.Drawing.Color.Transparent;
            this.DisponibilidadCalendar.Header.BackColor2 = System.Drawing.Color.Transparent;
            this.DisponibilidadCalendar.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.DisponibilidadCalendar.Header.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.DisponibilidadCalendar.ImageList = null;
            this.DisponibilidadCalendar.Location = new System.Drawing.Point(482, 307);
            this.DisponibilidadCalendar.MaxDate = new System.DateTime(2030, 11, 28, 23, 25, 50, 555);
            this.DisponibilidadCalendar.MinDate = new System.DateTime(2010, 11, 28, 23, 25, 50, 555);
            this.DisponibilidadCalendar.Month.BackgroundImage = null;
            this.DisponibilidadCalendar.Month.Colors.BackColor1 = System.Drawing.SystemColors.Control;
            this.DisponibilidadCalendar.Month.Colors.BackColor2 = System.Drawing.Color.Transparent;
            this.DisponibilidadCalendar.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DisponibilidadCalendar.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DisponibilidadCalendar.Name = "DisponibilidadCalendar";
            this.DisponibilidadCalendar.Size = new System.Drawing.Size(227, 172);
            this.DisponibilidadCalendar.TabIndex = 29;
            this.DisponibilidadCalendar.TodayColor = System.Drawing.SystemColors.MenuHighlight;
            this.DisponibilidadCalendar.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DisponibilidadCalendar.Weekdays.TextColor = System.Drawing.SystemColors.MenuHighlight;
            this.DisponibilidadCalendar.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DisponibilidadCalendar.Weeknumbers.TextColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // DgvCita
            // 
            this.DgvCita.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvCita.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCita.Location = new System.Drawing.Point(199, 169);
            this.DgvCita.Name = "DgvCita";
            this.DgvCita.Size = new System.Drawing.Size(510, 132);
            this.DgvCita.TabIndex = 30;
            this.DgvCita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCita_CellClick);
            this.DgvCita.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCita_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reservaciones.Properties.Resources.STOCK;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 608);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(547, 485);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(59, 23);
            this.BtnEliminar.TabIndex = 32;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(612, 485);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(63, 23);
            this.BtnActualizar.TabIndex = 33;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FrmGenerar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 601);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.DgvCita);
            this.Controls.Add(this.DisponibilidadCalendar);
            this.Controls.Add(this.BtnConsulta);
            this.Controls.Add(this.txtProfesional);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.DgvProfesional);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.rtxtMotivo);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.lblNat);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FrmGenerar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGenerar";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label lblNat;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.RichTextBox rtxtMotivo;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtProfesional;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.DataGridView DgvProfesional;
        private System.Windows.Forms.Button BtnConsulta;
        private Pabo.Calendar.MonthCalendar DisponibilidadCalendar;
        private System.Windows.Forms.DataGridView DgvCita;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
    }
}