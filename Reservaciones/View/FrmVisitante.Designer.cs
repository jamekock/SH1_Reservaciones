namespace Reservaciones.View
{
    partial class FrmVisitante
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
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.Dgv_Visitante = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Visitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDocumentoIdentidad
            // 
            this.txtDocumentoIdentidad.BackColor = System.Drawing.SystemColors.Control;
            this.txtDocumentoIdentidad.Location = new System.Drawing.Point(319, 340);
            this.txtDocumentoIdentidad.Name = "txtDocumentoIdentidad";
            this.txtDocumentoIdentidad.Size = new System.Drawing.Size(121, 20);
            this.txtDocumentoIdentidad.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.Location = new System.Drawing.Point(203, 340);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Control;
            this.txtApellido.Location = new System.Drawing.Point(203, 396);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lbTelefono
            // 
            this.lbTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.lbTelefono.FormattingEnabled = true;
            this.lbTelefono.Location = new System.Drawing.Point(452, 367);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(120, 95);
            this.lbTelefono.TabIndex = 24;
            // 
            // lbTipo
            // 
            this.lbTipo.BackColor = System.Drawing.SystemColors.Control;
            this.lbTipo.FormattingEnabled = true;
            this.lbTipo.Location = new System.Drawing.Point(578, 366);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(120, 95);
            this.lbTipo.TabIndex = 23;
         //   this.lbTipo.SelectedIndexChanged += new System.EventHandler(this.LbTipo_SelectedIndexChanged);
            // 
            // cmbDocumentoTipo
            // 
            this.cmbDocumentoTipo.BackColor = System.Drawing.SystemColors.Control;
            this.cmbDocumentoTipo.FormattingEnabled = true;
            this.cmbDocumentoTipo.Location = new System.Drawing.Point(319, 396);
            this.cmbDocumentoTipo.Name = "cmbDocumentoTipo";
            this.cmbDocumentoTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbDocumentoTipo.TabIndex = 4;
           // this.cmbDocumentoTipo.SelectedIndexChanged += new System.EventHandler(this.CmbDocumentoTipo_SelectedIndexChanged);
            // 
            // cmbTelefonoTipo
            // 
            this.cmbTelefonoTipo.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTelefonoTipo.FormattingEnabled = true;
            this.cmbTelefonoTipo.Location = new System.Drawing.Point(577, 339);
            this.cmbTelefonoTipo.Name = "cmbTelefonoTipo";
            this.cmbTelefonoTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTelefonoTipo.TabIndex = 6;
            // 
            // cmbTelefono
            // 
            this.cmbTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTelefono.FormattingEnabled = true;
            this.cmbTelefono.Location = new System.Drawing.Point(451, 340);
            this.cmbTelefono.Name = "cmbTelefono";
            this.cmbTelefono.Size = new System.Drawing.Size(121, 21);
            this.cmbTelefono.TabIndex = 5;
            // 
            // lblTipoTelefono
            // 
            this.lblTipoTelefono.AutoSize = true;
            this.lblTipoTelefono.Location = new System.Drawing.Point(575, 324);
            this.lblTipoTelefono.Name = "lblTipoTelefono";
            this.lblTipoTelefono.Size = new System.Drawing.Size(84, 13);
            this.lblTipoTelefono.TabIndex = 19;
            this.lblTipoTelefono.Text = "Tipo de telefono";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(449, 324);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 18;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblDocumentoTipo
            // 
            this.lblDocumentoTipo.AutoSize = true;
            this.lblDocumentoTipo.Location = new System.Drawing.Point(316, 380);
            this.lblDocumentoTipo.Name = "lblDocumentoTipo";
            this.lblDocumentoTipo.Size = new System.Drawing.Size(99, 13);
            this.lblDocumentoTipo.TabIndex = 17;
            this.lblDocumentoTipo.Text = "Tipo de documento";
            // 
            // lblDocumentoIdentidad
            // 
            this.lblDocumentoIdentidad.AutoSize = true;
            this.lblDocumentoIdentidad.Location = new System.Drawing.Point(320, 324);
            this.lblDocumentoIdentidad.Name = "lblDocumentoIdentidad";
            this.lblDocumentoIdentidad.Size = new System.Drawing.Size(123, 13);
            this.lblDocumentoIdentidad.TabIndex = 16;
            this.lblDocumentoIdentidad.Text = "Documento de identidad";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(200, 380);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(200, 324);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // BtnDel
            // 
            this.BtnDel.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDel.Location = new System.Drawing.Point(578, 468);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(75, 23);
            this.BtnDel.TabIndex = 8;
            this.BtnDel.Text = "Del";
            this.BtnDel.UseVisualStyleBackColor = false;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnEnter
            // 
            this.BtnEnter.Location = new System.Drawing.Point(497, 468);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(75, 23);
            this.BtnEnter.TabIndex = 7;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(203, 439);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 9;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(284, 438);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 10;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(365, 438);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 11;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Dgv_Visitante
            // 
            this.Dgv_Visitante.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgv_Visitante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dgv_Visitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Visitante.Location = new System.Drawing.Point(203, 161);
            this.Dgv_Visitante.Name = "Dgv_Visitante";
            this.Dgv_Visitante.Size = new System.Drawing.Size(495, 150);
            this.Dgv_Visitante.TabIndex = 33;
            this.Dgv_Visitante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Visitante_CellClick);
            this.Dgv_Visitante.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Visitante_CellDoubleClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Reservaciones.Properties.Resources.STOCK;
            this.pictureBox2.Location = new System.Drawing.Point(0, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(908, 640);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 36;
            this.label1.Text = "Visitante";
            // 
            // FrmVisitante
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
            this.MaximizeBox = false;
            this.Name = "FrmVisitante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVisitante";
           // this.Load += new System.EventHandler(this.FrmVisitante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Visitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView Dgv_Visitante;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}