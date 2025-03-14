namespace PROYECTO_FINAL
{
    partial class BuscarRestaurantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarRestaurantes));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.cboTipoCocina = new System.Windows.Forms.ComboBox();
            this.cboCapacidad = new System.Windows.Forms.ComboBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.dtgBuscarRestaurantes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarRestaurantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSCAR RESTAURANTES";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(236, 122);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(100, 22);
            this.txtUbicacion.TabIndex = 2;
            // 
            // cboTipoCocina
            // 
            this.cboTipoCocina.FormattingEnabled = true;
            this.cboTipoCocina.Location = new System.Drawing.Point(417, 120);
            this.cboTipoCocina.Name = "cboTipoCocina";
            this.cboTipoCocina.Size = new System.Drawing.Size(121, 24);
            this.cboTipoCocina.TabIndex = 3;
            // 
            // cboCapacidad
            // 
            this.cboCapacidad.FormattingEnabled = true;
            this.cboCapacidad.Location = new System.Drawing.Point(636, 120);
            this.cboCapacidad.Name = "cboCapacidad";
            this.cboCapacidad.Size = new System.Drawing.Size(121, 24);
            this.cboCapacidad.TabIndex = 4;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Location = new System.Drawing.Point(321, 149);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(174, 77);
            this.btnBusqueda.TabIndex = 5;
            this.btnBusqueda.Text = "EJECUTAR BUSQUEDA";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // dtgBuscarRestaurantes
            // 
            this.dtgBuscarRestaurantes.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgBuscarRestaurantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuscarRestaurantes.Location = new System.Drawing.Point(206, 232);
            this.dtgBuscarRestaurantes.Name = "dtgBuscarRestaurantes";
            this.dtgBuscarRestaurantes.RowHeadersWidth = 51;
            this.dtgBuscarRestaurantes.RowTemplate.Height = 24;
            this.dtgBuscarRestaurantes.Size = new System.Drawing.Size(396, 206);
            this.dtgBuscarRestaurantes.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "UBICACIÓN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "TIPO DE COCINA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(641, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "CAPACIDAD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(636, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 51);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BuscarRestaurantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgBuscarRestaurantes);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.cboCapacidad);
            this.Controls.Add(this.cboTipoCocina);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarRestaurantes";
            this.Text = "BuscarRestaurantes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuscarRestaurantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.ComboBox cboTipoCocina;
        private System.Windows.Forms.ComboBox cboCapacidad;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.DataGridView dtgBuscarRestaurantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}