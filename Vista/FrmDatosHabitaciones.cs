using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto_2.Vista
{
    public partial class FrmDatosHabitaciones : Form
    {
        public FrmDatosHabitaciones()
        {
            InitializeComponent();
        }

        private void FrmDatosHabitaciones_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelTipoHabitacion.Font = new Font(labelTipoHabitacion.Font, FontStyle.Underline);
            labelTipoHabitacion.ForeColor = Color.Blue;
            labelTipoHabitacion.Cursor = Cursors.Hand;
        }

        private void labelTipoHabitacion_Click(object sender, EventArgs e)
        {
            using (ComboBox comboBoxTipoHab = new ComboBox())
            {
                comboBoxTipoHab.Items.Add("Individual");
                comboBoxTipoHab.Items.Add("Doble");
                comboBoxTipoHab.Items.Add("Triple");
                comboBoxTipoHab.Items.Add("Cuádruple");
                comboBoxTipoHab.Items.Add("Suite");

                if (comboBoxTipoHab.ShowDialog() == DialogResult.OK)
                {
                    labelTipoHabitacion.Text = comboBoxTipoHab.SelectedItem.ToString();
                }
            }
        }

        private void textBoxNumHabitacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoHab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMinNocheTBaja_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMinNocheTMedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMinNocheTAlta_TextChanged(object sender, EventArgs e)
        {

        }

        private void numUpDownPvPxNocheTBaja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numUpDownPvPxNocheTMedia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numUpDownPvPxNocheTAlta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardarHabitacion_Click(object sender, EventArgs e)
        {
            Habitacion habitacion = new Habitacion
            {
                NumeroHabitacion = int.Parse(textBoxNumHabitacion.Text),
                TipoHabitacion = comboBoxTipoHab.SelectedItem.ToString(),
                MaxPersonas = (int)numericUpDownMaxPersonas.Value,
                MinNochesPorTemporada = (int)numericUpDownMinNochesPorTemporada.Value,
                PrecioNoche = decimal.Parse(txtPrecioNoche.Text),
                PrecioPorTemporada = decimal.Parse(txtPrecioPorTemporada.Text),
                CamaExtra = checkCamaExtra.Checked,
                ClienteVIP = checkClienteVip.Checked,
                FueraDeServicio = checkFueraDeServicio.Checked
            };

            dbContext.Set<Habitacion>().Add(habitacion);
            dbContext.SaveChanges();

            MessageBox.Show("Habitación guardada en la base de datos.");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkCamaExtra_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkClienteVip_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkFueraDeServicio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelTipoHabitacion_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDownMaxPersonas_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
