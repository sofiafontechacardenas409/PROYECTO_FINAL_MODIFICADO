using ProyectoFinal.Datos;
using System;
using System.Data;

namespace ProyectoFinal.Logica
{
    public class ReservasLogica
    {
        private ReservasDatos datos = new ReservasDatos();

        public DataTable MostrarReservas()
        {
            return datos.Mostrar();
        }

        public void AgregarReserva(int usuarioId, int espacioId, DateTime fechaReserva, TimeSpan horaInicio, TimeSpan horaFin)
        {
            datos.Insertar(usuarioId, espacioId, fechaReserva, horaInicio, horaFin);
        }

        public void EditarReserva(int idReserva, int usuarioId, int espacioId, DateTime fechaReserva, TimeSpan horaInicio, TimeSpan horaFin)
        {
            datos.Editar(idReserva, usuarioId, espacioId, fechaReserva, horaInicio, horaFin);
        }

        public void EliminarReserva(int idReserva)
        {
            datos.Eliminar(idReserva);
        }
    }
}
