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
    public partial class FrmHabitaciones : Form
    {
        public FrmHabitaciones()
        {
            InitializeComponent();
        }

        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelSQLDataSet.Habitacion' Puede moverla o quitarla según sea necesario.
            this.habitacionTableAdapter.Fill(this.hotelSQLDataSet.Habitacion);

        }

        private void txtBuscarHabitacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }

        private void dbGridHabitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addHabitacion_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificarHabitacion_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarHabitacion_Click(object sender, EventArgs e)
        {

        }
    }
}
