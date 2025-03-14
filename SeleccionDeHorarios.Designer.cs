namespace PROYECTO_FINAL
{
    partial class SeleccionDeHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionDeHorarios));
            this.lblSeleccionHorarios = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cboHorariosDisponibles = new System.Windows.Forms.ComboBox();
            this.dtgDisponibilidadFechas = new System.Windows.Forms.DataGridView();
            this.lblHorariosDisponibles = new System.Windows.Forms.Label();
            this.lblDisponibilidadMesas = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisponibilidadFechas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionHorarios
            // 
            this.lblSeleccionHorarios.AutoSize = true;
            this.lblSeleccionHorarios.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionHorarios.Location = new System.Drawing.Point(145, 55);
            this.lblSeleccionHorarios.Name = "lblSeleccionHorarios";
            this.lblSeleccionHorarios.Size = new System.Drawing.Size(486, 39);
            this.lblSeleccionHorarios.TabIndex = 0;
            this.lblSeleccionHorarios.Text = "SELECCIÓN DE HORARIOS";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 202);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // cboHorariosDisponibles
            // 
            this.cboHorariosDisponibles.FormattingEnabled = true;
            this.cboHorariosDisponibles.Location = new System.Drawing.Point(366, 229);
            this.cboHorariosDisponibles.Name = "cboHorariosDisponibles";
            this.cboHorariosDisponibles.Size = new System.Drawing.Size(121, 24);
            this.cboHorariosDisponibles.TabIndex = 2;
            // 
            // dtgDisponibilidadFechas
            // 
            this.dtgDisponibilidadFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDisponibilidadFechas.Location = new System.Drawing.Point(548, 229);
            this.dtgDisponibilidadFechas.Name = "dtgDisponibilidadFechas";
            this.dtgDisponibilidadFechas.RowHeadersWidth = 51;
            this.dtgDisponibilidadFechas.RowTemplate.Height = 24;
            this.dtgDisponibilidadFechas.Size = new System.Drawing.Size(240, 150);
            this.dtgDisponibilidadFechas.TabIndex = 3;
            // 
            // lblHorariosDisponibles
            // 
            this.lblHorariosDisponibles.AutoSize = true;
            this.lblHorariosDisponibles.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorariosDisponibles.Location = new System.Drawing.Point(306, 161);
            this.lblHorariosDisponibles.Name = "lblHorariosDisponibles";
            this.lblHorariosDisponibles.Size = new System.Drawing.Size(219, 23);
            this.lblHorariosDisponibles.TabIndex = 4;
            this.lblHorariosDisponibles.Text = "HORARIOS DISPONIBLES";
            // 
            // lblDisponibilidadMesas
            // 
            this.lblDisponibilidadMesas.AutoSize = true;
            this.lblDisponibilidadMesas.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibilidadMesas.Location = new System.Drawing.Point(570, 161);
            this.lblDisponibilidadMesas.Name = "lblDisponibilidadMesas";
            this.lblDisponibilidadMesas.Size = new System.Drawing.Size(218, 23);
            this.lblDisponibilidadMesas.TabIndex = 5;
            this.lblDisponibilidadMesas.Text = "DISPONIBILIDAD MESAS";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(126, 161);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 23);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "FECHA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(622, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 61);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SeleccionDeHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDisponibilidadMesas);
            this.Controls.Add(this.lblHorariosDisponibles);
            this.Controls.Add(this.dtgDisponibilidadFechas);
            this.Controls.Add(this.cboHorariosDisponibles);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblSeleccionHorarios);
            this.Name = "SeleccionDeHorarios";
            this.Text = "SeleccionDeHorarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDisponibilidadFechas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionHorarios;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cboHorariosDisponibles;
        private System.Windows.Forms.DataGridView dtgDisponibilidadFechas;
        private System.Windows.Forms.Label lblHorariosDisponibles;
        private System.Windows.Forms.Label lblDisponibilidadMesas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}