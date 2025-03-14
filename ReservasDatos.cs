using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal.Datos
{
    public class ReservasDatos
    {
        private string conexion = "Server=LAPTOP-L3M57PGQ\\SQLEXPRESS; Database=ProyectoFinalDB; Trusted_Connection=True;";

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Reservas", conn);
                da.Fill(tabla);
            }
            return tabla;
        }

        public void Insertar(int usuarioId, int espacioId, DateTime fechaReserva, TimeSpan horaInicio, TimeSpan horaFin)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "INSERT INTO Reservas (UsuarioId, EspacioId, FechaReserva, HoraInicio, HoraFin) VALUES (@UsuarioId, @EspacioId, @FechaReserva, @HoraInicio, @HoraFin)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@EspacioId", espacioId);
                cmd.Parameters.AddWithValue("@FechaReserva", fechaReserva);
                cmd.Parameters.AddWithValue("@HoraInicio", horaInicio);
                cmd.Parameters.AddWithValue("@HoraFin", horaFin);
                cmd.ExecuteNonQuery();
            }
        }

        public void Editar(int idReserva, int usuarioId, int espacioId, DateTime fechaReserva, TimeSpan horaInicio, TimeSpan horaFin)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "UPDATE Reservas SET UsuarioId = @UsuarioId, EspacioId = @EspacioId, FechaReserva = @FechaReserva, HoraInicio = @HoraInicio, HoraFin = @HoraFin WHERE IdReserva = @IdReserva";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdReserva", idReserva);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@EspacioId", espacioId);
                cmd.Parameters.AddWithValue("@FechaReserva", fechaReserva);
                cmd.Parameters.AddWithValue("@HoraInicio", horaInicio);
                cmd.Parameters.AddWithValue("@HoraFin", horaFin);
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idReserva)
        {
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "DELETE FROM Reservas WHERE IdReserva = @IdReserva";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdReserva", idReserva);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
