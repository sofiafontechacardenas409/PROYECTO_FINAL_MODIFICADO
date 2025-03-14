namespace PROYECTO_FINAL
{
    partial class RealizarReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarReserva));
            this.dtgListaDeRestaurantes = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lblBuscarRestaurantes = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblTipoCocina = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDeRestaurantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgListaDeRestaurantes
            // 
            this.dtgListaDeRestaurantes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgListaDeRestaurantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaDeRestaurantes.Location = new System.Drawing.Point(12, 178);
            this.dtgListaDeRestaurantes.Name = "dtgListaDeRestaurantes";
            this.dtgListaDeRestaurantes.RowHeadersWidth = 51;
            this.dtgListaDeRestaurantes.RowTemplate.Height = 24;
            this.dtgListaDeRestaurantes.Size = new System.Drawing.Size(554, 238);
            this.dtgListaDeRestaurantes.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Centro",
            "Norte",
            "Sur",
            "Este",
            "Oeste"});
            this.comboBox1.Location = new System.Drawing.Point(39, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 31);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1-2 Personas",
            "3-4 Personas",
            "5-6 Personas",
            "7+"});
            this.comboBox2.Location = new System.Drawing.Point(448, 119);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 31);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Italiana",
            "Mexicana",
            "Japonesa",
            "Vegetariana",
            "Griega"});
            this.comboBox3.Location = new System.Drawing.Point(240, 119);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 31);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo ",
            "Cena"});
            this.comboBox4.Location = new System.Drawing.Point(657, 119);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 31);
            this.comboBox4.TabIndex = 4;
            // 
            // lblBuscarRestaurantes
            // 
            this.lblBuscarRestaurantes.AutoSize = true;
            this.lblBuscarRestaurantes.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarRestaurantes.Location = new System.Drawing.Point(233, 42);
            this.lblBuscarRestaurantes.Name = "lblBuscarRestaurantes";
            this.lblBuscarRestaurantes.Size = new System.Drawing.Size(384, 38);
            this.lblBuscarRestaurantes.TabIndex = 5;
            this.lblBuscarRestaurantes.Text = "REALIZAR RESERVA";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(44, 93);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(116, 23);
            this.lblUbicacion.TabIndex = 6;
            this.lblUbicacion.Text = "UBICACIÓN";
            // 
            // lblTipoCocina
            // 
            this.lblTipoCocina.AutoSize = true;
            this.lblTipoCocina.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCocina.Location = new System.Drawing.Point(236, 93);
            this.lblTipoCocina.Name = "lblTipoCocina";
            this.lblTipoCocina.Size = new System.Drawing.Size(164, 23);
            this.lblTipoCocina.TabIndex = 7;
            this.lblTipoCocina.Text = "TIPO DE COCINA";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidad.Location = new System.Drawing.Point(456, 93);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(124, 23);
            this.lblCapacidad.TabIndex = 8;
            this.lblCapacidad.Text = "CAPACIDAD";
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibilidad.Location = new System.Drawing.Point(642, 93);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(159, 23);
            this.lblDisponibilidad.TabIndex = 9;
            this.lblDisponibilidad.Text = "DISPONIBILIDAD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(572, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // RealizarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblTipoCocina);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblBuscarRestaurantes);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtgListaDeRestaurantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RealizarReserva";
            this.Text = "RealizarReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaDeRestaurantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgListaDeRestaurantes;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblBuscarRestaurantes;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblTipoCocina;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}