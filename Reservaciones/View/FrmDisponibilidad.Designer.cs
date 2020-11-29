namespace Reservaciones.View
{
    partial class FrmDisponibilidad
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
            this.DgvDisponibilidad = new System.Windows.Forms.DataGridView();
            this.lblTittle = new System.Windows.Forms.Label();
            this.DgvProfesional = new System.Windows.Forms.DataGridView();
            this.DgvDias = new System.Windows.Forms.DataGridView();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtProfesional = new System.Windows.Forms.TextBox();
            this.txtIdDias = new System.Windows.Forms.TextBox();
            this.txtIdProfesional = new System.Windows.Forms.TextBox();
            this.lblIdProfesional = new System.Windows.Forms.Label();
            this.lblIdDias = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDisponibilidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDisponibilidad
            // 
            this.DgvDisponibilidad.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvDisponibilidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvDisponibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDisponibilidad.Location = new System.Drawing.Point(187, 152);
            this.DgvDisponibilidad.Name = "DgvDisponibilidad";
            this.DgvDisponibilidad.Size = new System.Drawing.Size(310, 88);
            this.DgvDisponibilidad.TabIndex = 8;
            this.DgvDisponibilidad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDisponibilidad_CellClick);
            this.DgvDisponibilidad.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDisponibilidad_CellDoubleClick);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(556, 101);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(190, 33);
            this.lblTittle.TabIndex = 12;
            this.lblTittle.Text = "Disponibilidad";
            // 
            // DgvProfesional
            // 
            this.DgvProfesional.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvProfesional.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProfesional.Location = new System.Drawing.Point(187, 397);
            this.DgvProfesional.Name = "DgvProfesional";
            this.DgvProfesional.Size = new System.Drawing.Size(310, 98);
            this.DgvProfesional.TabIndex = 14;
            this.DgvProfesional.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProfesional_CellDoubleClick);
            // 
            // DgvDias
            // 
            this.DgvDias.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvDias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDias.Location = new System.Drawing.Point(187, 273);
            this.DgvDias.Name = "DgvDias";
            this.DgvDias.Size = new System.Drawing.Size(310, 91);
            this.DgvDias.TabIndex = 17;
            this.DgvDias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDias_CellDoubleClick);
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Location = new System.Drawing.Point(184, 381);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(59, 13);
            this.lblProfesional.TabIndex = 18;
            this.lblProfesional.Text = "Profesional";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(184, 257);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(28, 13);
            this.lblDays.TabIndex = 19;
            this.lblDays.Text = "Dias";
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(643, 152);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtnRegistrar.TabIndex = 20;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(643, 181);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 21;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(643, 210);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizar.TabIndex = 22;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(503, 273);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(25, 20);
            this.txtDias.TabIndex = 23;
            // 
            // txtProfesional
            // 
            this.txtProfesional.Location = new System.Drawing.Point(503, 397);
            this.txtProfesional.Name = "txtProfesional";
            this.txtProfesional.Size = new System.Drawing.Size(25, 20);
            this.txtProfesional.TabIndex = 24;
            // 
            // txtIdDias
            // 
            this.txtIdDias.Location = new System.Drawing.Point(503, 220);
            this.txtIdDias.Name = "txtIdDias";
            this.txtIdDias.Size = new System.Drawing.Size(25, 20);
            this.txtIdDias.TabIndex = 25;
            // 
            // txtIdProfesional
            // 
            this.txtIdProfesional.Location = new System.Drawing.Point(503, 172);
            this.txtIdProfesional.Name = "txtIdProfesional";
            this.txtIdProfesional.Size = new System.Drawing.Size(25, 20);
            this.txtIdProfesional.TabIndex = 26;
            // 
            // lblIdProfesional
            // 
            this.lblIdProfesional.AutoSize = true;
            this.lblIdProfesional.Location = new System.Drawing.Point(503, 157);
            this.lblIdProfesional.Name = "lblIdProfesional";
            this.lblIdProfesional.Size = new System.Drawing.Size(71, 13);
            this.lblIdProfesional.TabIndex = 27;
            this.lblIdProfesional.Text = "Id Profesional";
            // 
            // lblIdDias
            // 
            this.lblIdDias.AutoSize = true;
            this.lblIdDias.Location = new System.Drawing.Point(503, 204);
            this.lblIdDias.Name = "lblIdDias";
            this.lblIdDias.Size = new System.Drawing.Size(40, 13);
            this.lblIdDias.TabIndex = 28;
            this.lblIdDias.Text = "Id Dias";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Reservaciones.Properties.Resources.STOCK;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(897, 605);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // FrmDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 601);
            this.Controls.Add(this.lblIdDias);
            this.Controls.Add(this.lblIdProfesional);
            this.Controls.Add(this.txtIdProfesional);
            this.Controls.Add(this.txtIdDias);
            this.Controls.Add(this.txtProfesional);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.DgvDias);
            this.Controls.Add(this.DgvProfesional);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.DgvDisponibilidad);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FrmDisponibilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDisponibilidad";
            this.Load += new System.EventHandler(this.FrmDisponibilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDisponibilidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvDisponibilidad;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.DataGridView DgvProfesional;
        private System.Windows.Forms.DataGridView DgvDias;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtProfesional;
        private System.Windows.Forms.TextBox txtIdDias;
        private System.Windows.Forms.TextBox txtIdProfesional;
        private System.Windows.Forms.Label lblIdProfesional;
        private System.Windows.Forms.Label lblIdDias;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}