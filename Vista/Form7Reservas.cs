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
    public partial class Form7Reservas : Form
    {
        public Form7Reservas()
        {
            InitializeComponent();
        }

        private void Form7Reservas_Load(object sender, EventArgs e)
        {
        }

        private void Form7Reservas_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'confirmacionDS.historicoReservas' Puede moverla o quitarla según sea necesario.
            this.historicoReservasTableAdapter2.Fill(this.confirmacionDS.historicoReservas);
            // TODO: esta línea de código carga datos en la tabla 'checkInDS.historicoReservas' Puede moverla o quitarla según sea necesario.
            this.historicoReservasTableAdapter1.Fill(this.checkInDS.historicoReservas);
            // TODO: esta línea de código carga datos en la tabla 'checkoutDS.historicoReservas' Puede moverla o quitarla según sea necesario.
            this.historicoReservasTableAdapter.Fill(this.checkoutDS.historicoReservas);

        }
    }
}
