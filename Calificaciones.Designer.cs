namespace PROYECTO_FINAL
{
    partial class Calificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calificaciones));
            this.label1 = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.trackbarCalificacion = new System.Windows.Forms.Label();
            this.trackBarDarCalificacion = new System.Windows.Forms.TrackBar();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDarCalificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALIFICACIONES";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(36, 127);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(260, 26);
            this.lblComentario.TabIndex = 1;
            this.lblComentario.Text = "INGRESAR COMENTARIO";
            // 
            // trackbarCalificacion
            // 
            this.trackbarCalificacion.AutoSize = true;
            this.trackbarCalificacion.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackbarCalificacion.Location = new System.Drawing.Point(36, 243);
            this.trackbarCalificacion.Name = "trackbarCalificacion";
            this.trackbarCalificacion.Size = new System.Drawing.Size(222, 26);
            this.trackbarCalificacion.TabIndex = 2;
            this.trackbarCalificacion.Text = "DAR CALIFICACIÓN ";
            // 
            // trackBarDarCalificacion
            // 
            this.trackBarDarCalificacion.Location = new System.Drawing.Point(27, 272);
            this.trackBarDarCalificacion.Name = "trackBarDarCalificacion";
            this.trackBarDarCalificacion.Size = new System.Drawing.Size(160, 56);
            this.trackBarDarCalificacion.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(41, 334);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(146, 49);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(39, 169);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(100, 22);
            this.txtComentario.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(396, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 293);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.trackBarDarCalificacion);
            this.Controls.Add(this.trackbarCalificacion);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calificaciones";
            this.Text = "Calificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDarCalificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Label trackbarCalificacion;
        private System.Windows.Forms.TrackBar trackBarDarCalificacion;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}