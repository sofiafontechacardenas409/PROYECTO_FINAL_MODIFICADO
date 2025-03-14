using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnIrARegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtCorreo
            this.txtCorreo.Location = new System.Drawing.Point(50, 30);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 20);
            this.txtCorreo.TabIndex = 0;
            this.txtCorreo.PlaceholderText = "Correo";

            // txtContraseña
            this.txtContraseña.Location = new System.Drawing.Point(50, 70);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(200, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.PlaceholderText = "Contraseña";

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(50, 110);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnIrARegistro
            this.btnIrARegistro.Location = new System.Drawing.Point(160, 110);
            this.btnIrARegistro.Name = "btnIrARegistro";
            this.btnIrARegistro.Size = new System.Drawing.Size(90, 30);
            this.btnIrARegistro.TabIndex = 3;
            this.btnIrARegistro.Text = "Registrarse";
            this.btnIrARegistro.UseVisualStyleBackColor = true;
            this.btnIrARegistro.Click += new System.EventHandler(this.btnIrARegistro_Click);

            // FormLogin
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnIrARegistro);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnIrARegistro;
    }
}

