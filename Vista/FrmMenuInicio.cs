using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto_2.Vista
{
    public partial class FrmMenuInicio : Form
    {
        public FrmMenuInicio()
        {
            InitializeComponent();
        }

        private void FrmMenuInicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelSQLDataSet1.Reservas' Puede moverla o quitarla según sea necesario.
            this.reservasTableAdapter.Fill(this.hotelSQLDataSet1.Reservas);

            

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaInicio = e.Start;
            DateTime fechaFin = e.End;

            // Consulta las reservas de habitaciones para la semana seleccionada
            List<Reserva> reservas = ObtenerReservasDeLaBaseDeDatos(fechaInicio, fechaFin);

            // Limpia el DataGridView
            dataGridView1.Rows.Clear();

            // Rellena el DataGridView con las reservas
            foreach (Reserva reserva in reservas)
            {
                // Agrega una fila al DataGridView con la información de la reserva
                dataGridView1.Rows.Add(reserva.Habitacion, reserva.FechaLlegada, reserva.FechaSalida, reserva.Estado);
            }
        }

        private void dbGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCambioTurno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnVerFacturas_Click(object sender, EventArgs e)
        {

        }

        private void btnVerDisponibilidad_Click(object sender, EventArgs e)
        {

        }
    }
}
