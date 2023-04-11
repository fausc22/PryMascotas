namespace PryMascotas
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
            ((System.ComponentModel.ISupportInitialize)(this.fotoMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(196, 256);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAlimentar
            // 
            this.btnAlimentar.Location = new System.Drawing.Point(96, 215);
            this.btnAlimentar.Name = "btnAlimentar";
            this.btnAlimentar.Size = new System.Drawing.Size(75, 23);
            this.btnAlimentar.TabIndex = 4;
            this.btnAlimentar.Text = "Alimentar";
            this.btnAlimentar.UseVisualStyleBackColor = true;
            this.btnAlimentar.Click += new System.EventHandler(this.btnAlimentar_Click);
            // 
            // btnCuidar
            // 
            this.btnCuidar.Location = new System.Drawing.Point(196, 215);
            this.btnCuidar.Name = "btnCuidar";
            this.btnCuidar.Size = new System.Drawing.Size(75, 23);
            this.btnCuidar.TabIndex = 5;
            this.btnCuidar.Text = "Cuidar";
            this.btnCuidar.UseVisualStyleBackColor = true;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(96, 256);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 7;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "VETERINARIA";
            // 
            // fotoMascota
            // 
            this.fotoMascota.Location = new System.Drawing.Point(187, 56);
            this.fotoMascota.Name = "fotoMascota";
            this.fotoMascota.Size = new System.Drawing.Size(193, 121);
            this.fotoMascota.TabIndex = 13;
            this.fotoMascota.TabStop = false;
            // 
            // listMascotas
            // 
            this.listMascotas.FormattingEnabled = true;
            this.listMascotas.Location = new System.Drawing.Point(12, 56);
            this.listMascotas.Name = "listMascotas";
            this.listMascotas.Size = new System.Drawing.Size(146, 121);
            this.listMascotas.TabIndex = 14;
            this.listMascotas.SelectedIndexChanged += new System.EventHandler(this.listMascotas_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 305);
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
    }
}

