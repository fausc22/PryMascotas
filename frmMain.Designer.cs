﻿namespace PryMascotas
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAlimentar = new System.Windows.Forms.Button();
            this.btnCuidar = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fotoMascota = new System.Windows.Forms.PictureBox();
            this.listMascotas = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Sienna;
            this.btnSalir.Location = new System.Drawing.Point(103, 353);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.BackColor = System.Drawing.Color.Sienna;
            this.btnAlimentar.Location = new System.Drawing.Point(3, 312);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(75, 23);
            this.btnAlimentar.TabIndex = 4;
            this.btnAlimentar.Text = "Alimentar";
            this.btnAlimentar.UseVisualStyleBackColor = false;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // btnCuidar
            // 
            this.btnCuidar.BackColor = System.Drawing.Color.Sienna;
            this.btnCuidar.Location = new System.Drawing.Point(103, 312);
            this.btnCuidar.Name = "btnCuidar";
            this.btnCuidar.Size = new System.Drawing.Size(75, 23);
            this.btnCuidar.TabIndex = 5;
            this.btnCuidar.Text = "Cuidar";
            this.btnCuidar.UseVisualStyleBackColor = false;
            this.btnCuidar.Click += new System.EventHandler(this.btnCuidar_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Sienna;
            this.btnJugar.Location = new System.Drawing.Point(3, 353);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 7;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "VETERINARIA";
            // 
            // fotoMascota
            // 
            this.fotoMascota.Location = new System.Drawing.Point(211, 173);
            this.fotoMascota.Name = "fotoMascota";
            this.fotoMascota.Size = new System.Drawing.Size(193, 121);
            this.fotoMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoMascota.TabIndex = 13;
            this.fotoMascota.TabStop = false;
            // 
            // listMascotas
            // 
            this.listMascotas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.listMascotas.FormattingEnabled = true;
            this.listMascotas.Location = new System.Drawing.Point(12, 173);
            this.listMascotas.Name = "listMascotas";
            this.listMascotas.Size = new System.Drawing.Size(146, 121);
            this.listMascotas.TabIndex = 14;
            this.listMascotas.SelectedIndexChanged += new System.EventHandler(this.listMascotas_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(106, 84);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 16;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Sienna;
            this.btnAgregar.Location = new System.Drawing.Point(245, 77);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 40);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar Mascota";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tipo de Animal";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Perro Golden",
            "Perro Pastor Aleman",
            "Gato Siames",
            "Gato Persa",
            "Loro",
            "Tortuga"});
            this.cmbTipo.Location = new System.Drawing.Point(107, 114);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(99, 21);
            this.cmbTipo.TabIndex = 22;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(276, 148);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(57, 20);
            this.lblTipo.TabIndex = 23;
            this.lblTipo.Text = "label5";
            this.lblTipo.Visible = false;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(276, 297);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(57, 20);
            this.lblEdad.TabIndex = 24;
            this.lblEdad.Text = "label5";
            this.lblEdad.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(431, 392);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.listMascotas);
            this.Controls.Add(this.fotoMascota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnCuidar);
            this.Controls.Add(this.btnAlimentar);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmMain";
            this.Text = "VETERINARIA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotoMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button btnCuidar;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox fotoMascota;
        private System.Windows.Forms.ListBox listMascotas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEdad;
    }
}

