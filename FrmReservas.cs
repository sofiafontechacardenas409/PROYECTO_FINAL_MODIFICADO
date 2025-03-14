using ProyectoFinal.Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinal.Presentacion
{
    public partial class FrmReservas : Form
    {
        ReservasLogica logica = new ReservasLogica();

        public FrmReservas()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvReservas.DataSource = logica.MostrarReservas();
            // Aquí podrías cargar los ComboBox de Usuarios y Espacios desde la base de datos también
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int usuarioId = Convert.ToInt32(cmbUsuarios.SelectedValue);
            int espacioId = Convert.ToInt32(cmbEspacios.SelectedValue);
            DateTime fecha = dtpFechaReserva.Value.Date;
            TimeSpan horaInicio = TimeSpan.Parse(txtHoraInicio.Text);
            TimeSpan horaFin = TimeSpan.Parse(txtHoraFin.Text);

            logica.AgregarReserva(usuarioId, espacioId, fecha, horaInicio, horaFin);
            MessageBox.Show("Reserva agregada correctamente.");
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                int idReserva = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["IdReserva"].Value);
                int usuarioId = Convert.ToInt32(cmbUsuarios.SelectedValue);
                int espacioId = Convert.ToInt32(cmbEspacios.SelectedValue);
                DateTime fecha = dtpFechaReserva.Value.Date;
                TimeSpan horaInicio = TimeSpan.Parse(txtHoraInicio.Text);
                TimeSpan horaFin = TimeSpan.Parse(txtHoraFin.Text);

                logica.EditarReserva(idReserva, usuarioId, espacioId, fecha, horaInicio, horaFin);
                MessageBox.Show("Reserva editada correctamente.");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Selecciona una reserva para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                int idReserva = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["IdReserva"].Value);
                logica.EliminarReserva(idReserva);
                MessageBox.Show("Reserva eliminada correctamente.");
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Selecciona una reserva para eliminar.");
            }
        }
    }
}
