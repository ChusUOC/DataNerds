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
    public partial class FormMenuInicioAdmin : Form
    {
        public FormMenuInicioAdmin()
        {
            InitializeComponent();
        }

        private void FormMenuInicioAdmin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hotelSQLDataSet3.historicoReservas' Puede moverla o quitarla según sea necesario.
            this.historicoReservasTableAdapter.Fill(this.hotelSQLDataSet3.historicoReservas);
            // TODO: esta línea de código carga datos en la tabla 'hotelSQLDataSet2.EstadoHabitacion' Puede moverla o quitarla según sea necesario.
            this.estadoHabitacionTableAdapter.Fill(this.hotelSQLDataSet2.EstadoHabitacion);
            // TODO: esta línea de código carga datos en la tabla 'hotelSQLDataSet1.Incidencias' Puede moverla o quitarla según sea necesario.
            this.incidenciasTableAdapter.Fill(this.hotelSQLDataSet1.Incidencias);
            // TODO: esta línea de código carga datos en la tabla 'hotelSQLDataSet.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.hotelSQLDataSet.Usuario);

        }
    }
}
