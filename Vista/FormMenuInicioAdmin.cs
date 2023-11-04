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
            // TODO: esta línea de código carga datos en la tabla 'hotelSQLDataSet.Habitacion' Puede moverla o quitarla según sea necesario.
            this.habitacionTableAdapter.Fill(this.hotelSQLDataSet.Habitacion);
            // TODO: esta línea de código carga datos en la tabla 'historicoRDS.historicoReservas' Puede moverla o quitarla según sea necesario.
            this.historicoReservasTableAdapter.Fill(this.historicoRDS.historicoReservas);
            // TODO: esta línea de código carga datos en la tabla 'incidenciasDS.Incidencias' Puede moverla o quitarla según sea necesario.
            this.incidenciasTableAdapter.Fill(this.incidenciasDS.Incidencias);
            // TODO: esta línea de código carga datos en la tabla 'usuarioDS.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.usuarioDS.Usuario);
        }
    }
}
