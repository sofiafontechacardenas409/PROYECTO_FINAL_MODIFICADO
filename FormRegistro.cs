
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ConexionBD conexionBD = new ConexionBD();
            SqlConnection conexion = conexionBD.AbrirConexion();

            string nombre = txtNombre.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            string query = "INSERT INTO Usuarios (Nombre, Correo, Contraseña) VALUES (@nombre, @correo, @contraseña)";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro exitoso");

                // Redirigir al login
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }

            conexionBD.CerrarConexion();
        }

        private void btnVolverLogin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }
    }
}
