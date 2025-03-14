
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ConexionBD conexionBD = new ConexionBD();
            SqlConnection conexion = conexionBD.AbrirConexion();

            string correo = txtCorreo.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            string query = "SELECT IdUsuario FROM Usuarios WHERE Correo = @correo AND Contraseña = @contraseña";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int idUsuario = reader.GetInt32(0);
                MessageBox.Show("Inicio de sesión exitoso");

                // Abrir el formulario de reservas y pasar el IdUsuario
                FormReservas reservas = new FormReservas(idUsuario);
                reservas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos");
            }

            conexionBD.CerrarConexion();
        }

        private void btnIrARegistro_Click(object sender, EventArgs e)
        {
            FormRegistro registro = new FormRegistro();
            registro.Show();
            this.Hide();
        }
    }
}
