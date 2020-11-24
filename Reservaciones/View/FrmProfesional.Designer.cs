namespace Reservaciones.View
{
    partial class FrmProfesional
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
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_Visitante = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.txtDocumentoIdentidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lbTelefono = new System.Windows.Forms.ListBox();
            this.lbTipo = new System.Windows.Forms.ListBox();
            this.cmbDocumentoTipo = new System.Windows.Forms.ComboBox();
            this.cmbTelefonoTipo = new System.Windows.Forms.ComboBox();
            this.cmbTelefono = new System.Windows.Forms.ComboBox();
            this.lblTipoTelefono = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDocumentoTipo = new System.Windows.Forms.Label();
            this.lblDocumentoIdentidad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Visitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 57;
            this.label1.Text = "Profesional";
            // 
            // Dgv_Visitante
            // 
            this.Dgv_Visitante.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgv_Visitante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Visitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Visitante.Location = new System.Drawing.Point(211, 164);
            this.Dgv_Visitante.Name = "Dgv_Visitante";
            this.Dgv_Visitante.Size = new System.Drawing.Size(495, 150);
            this.Dgv_Visitante.TabIndex = 56;
            this.Dgv_Visitante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Visitante_CellClick);
            this.Dgv_Visitante.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Visitante_CellDoubleClick);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(373, 443);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 55;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(292, 443);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 54;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(211, 444);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 53;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(505, 473);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(75, 23);
            this.BtnEnter.TabIndex = 52;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = false;
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDel.Location = new System.Drawing.Point(586, 473);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 51;
            this.BtnDel.Text = "Del";
            this.BtnDel.UseVisualStyleBackColor = false;
            // 
            // txtDocumentoIdentidad
            // 
            this.txtDocumentoIdentidad.BackColor = System.Drawing.SystemColors.Control;
            this.txtDocumentoIdentidad.Location = new System.Drawing.Point(327, 345);
            this.txtDocumentoIdentidad.Name = "txtDocumentoIdentidad";
            this.txtDocumentoIdentidad.Size = new System.Drawing.Size(121, 20);
            this.txtDocumentoIdentidad.TabIndex = 50;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Location = new System.Drawing.Point(211, 345);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 49;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Control;
            this.txtApellido.Location = new System.Drawing.Point(211, 401);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 48;
            // 
            // lbTelefono
            // 
            this.lbTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.lbTelefono.FormattingEnabled = true;
            this.lbTelefono.Location = new System.Drawing.Point(460, 372);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(120, 95);
            this.lbTelefono.TabIndex = 47;
            // 
            // lbTipo
            // 
            this.lbTipo.BackColor = System.Drawing.SystemColors.Control;
            this.lbTipo.FormattingEnabled = true;
            this.lbTipo.Location = new System.Drawing.Point(586, 371);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(120, 95);
            this.lbTipo.TabIndex = 46;
            // 
            // cmbDocumentoTipo
            // 
            this.cmbDocumentoTipo.BackColor = System.Drawing.SystemColors.Control;
            this.cmbDocumentoTipo.FormattingEnabled = true;
            this.cmbDocumentoTipo.Location = new System.Drawing.Point(327, 401);
            this.cmbDocumentoTipo.Name = "cmbDocumentoTipo";
            this.cmbDocumentoTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbDocumentoTipo.TabIndex = 45;
            // 
            // cmbTelefonoTipo
            // 
            this.cmbTelefonoTipo.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTelefonoTipo.FormattingEnabled = true;
            this.cmbTelefonoTipo.Location = new System.Drawing.Point(585, 344);
            this.cmbTelefonoTipo.Name = "cmbTelefonoTipo";
            this.cmbTelefonoTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTelefonoTipo.TabIndex = 44;
            // 
            // cmbTelefono
            // 
            this.cmbTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTelefono.FormattingEnabled = true;
            this.cmbTelefono.Location = new System.Drawing.Point(459, 345);
            this.cmbTelefono.Name = "cmbTelefono";
            this.cmbTelefono.Size = new System.Drawing.Size(121, 21);
            this.cmbTelefono.TabIndex = 43;
            // 
            // lblTipoTelefono
            // 
            this.lblTipoTelefono.AutoSize = true;
            this.lblTipoTelefono.Location = new System.Drawing.Point(583, 329);
            this.lblTipoTelefono.Name = "lblTipoTelefono";
            this.lblTipoTelefono.Size = new System.Drawing.Size(84, 13);
            this.lblTipoTelefono.TabIndex = 42;
            this.lblTipoTelefono.Text = "Tipo de telefono";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(457, 329);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 41;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDocumentoTipo
            // 
            this.lblDocumentoTipo.AutoSize = true;
            this.lblDocumentoTipo.Location = new System.Drawing.Point(324, 385);
            this.lblDocumentoTipo.Name = "lblDocumentoTipo";
            this.lblDocumentoTipo.Size = new System.Drawing.Size(99, 13);
            this.lblDocumentoTipo.TabIndex = 40;
            this.lblDocumentoTipo.Text = "Tipo de documento";
            // 
            // lblDocumentoIdentidad
            // 
            this.lblDocumentoIdentidad.AutoSize = true;
            this.lblDocumentoIdentidad.Location = new System.Drawing.Point(328, 329);
            this.lblDocumentoIdentidad.Name = "lblDocumentoIdentidad";
            this.lblDocumentoIdentidad.Size = new System.Drawing.Size(123, 13);
            this.lblDocumentoIdentidad.TabIndex = 39;
            this.lblDocumentoIdentidad.Text = "Documento de identidad";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(208, 385);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 38;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(208, 329);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reservaciones.Properties.Resources.STOCK;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(908, 640);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // FrmProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_Visitante);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.txtDocumentoIdentidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.cmbDocumentoTipo);
            this.Controls.Add(this.cmbTelefonoTipo);
            this.Controls.Add(this.cmbTelefono);
            this.Controls.Add(this.lblTipoTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDocumentoTipo);
            this.Controls.Add(this.lblDocumentoIdentidad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrmProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProfesional";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Visitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_Visitante;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.TextBox txtDocumentoIdentidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ListBox lbTelefono;
        private System.Windows.Forms.ListBox lbTipo;
        private System.Windows.Forms.ComboBox cmbDocumentoTipo;
        private System.Windows.Forms.ComboBox cmbTelefonoTipo;
        private System.Windows.Forms.ComboBox cmbTelefono;
        private System.Windows.Forms.Label lblTipoTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDocumentoTipo;
        private System.Windows.Forms.Label lblDocumentoIdentidad;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}