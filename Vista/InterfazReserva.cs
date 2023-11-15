using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Producto_2.Controlador;
using Producto_2.Modelo;

namespace Producto_2.Vista
{
    public partial class InterfazReserva : Form
    {
        byte especial;
        private readonly ReservaControlador controlador = new ReservaControlador();

        public InterfazReserva()
        {
            InitializeComponent();
        }

        /*Métodos de botones de navegación*/

        private void limpiarForm()
        {
            ReservaTXT.Text = "";
            NIFClienteTXT.Text = "";
            NPersonasTXT.Text = "";
            DateIniTXT.Text = "";
            DateFinTXT.Text = "";
            HabitacionCBox.Text = "";
            TipoPensionCB.Text = "";
            ServiciosLBox.Text = "";
            TemporadaCBox.Text = "";
            CHKFirm.Checked = false;
        }

        private void InterfazServicio_Load(object sender, EventArgs e)
        {

        }

        public void ocultarGrupos()
        {
            grpReserva.Visible = false;

        }

        public void activarBtnMenu()
        {
          //  inicioBtn.Enabled = true;
           // ClientesBtn.Enabled = true;
            //reservasVtb.Enabled = true;
          //  habitacionesBtn.Enabled = true;
          //  SrvidioBtn.Enabled = true;
          //  facturasBtn.Enabled = true;
          //  incidenciasbtn.Enabled = true;
          //  Usuariosbtn.Enabled = true;
          //  ajustesbtn.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FacturarBT_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
          //  Form2 form2 = new Form2();
           // form2.Show();
            cerrarForm();
        }

        private void reservasVtb_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            limpiarForm();
            grpReserva.Visible = true;
          //  reservasVtb.Enabled = false;

        }

        private void habitacionesBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();

            cerrarForm();
        }

        private void SrvidioBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void facturasBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void incidenciasbtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void Usuariosbtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            InterfazUsuario interfazUsuario = new InterfazUsuario();
            interfazUsuario.Show();
            cerrarForm();
        }

        private void ajustesbtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void inicioBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }
        private void cerrarForm()
        {
            this.Close();
        }

        /* Métodos de cajas de texto o botones de acción*/

        private void ReservaTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClienteTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void NPersonasTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateIniTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateFinTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void HabitacionCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TipoPensionCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ServiciosLBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TemporadaCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrecioTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioServiciosTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioPensionTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioHabitacionTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiasLB_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(DateIniTXT.Text, out DateTime fechaEntrada) &&
       DateTime.TryParse(DateFinTXT.Text, out DateTime fechaSalida))
            {
                TimeSpan diferencia = fechaSalida - fechaEntrada;
                int diasDiferencia = (int)diferencia.TotalDays;

                DiasTXT.Text = diasDiferencia.ToString();
            }
            else
            {
                DiasTXT.Text = "Error: fechas inválidas";
            }
        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void ContratarBT_Click(object sender, EventArgs e)
        {
            byte especial = CHKFirm.Checked ? (byte)1 : (byte)0;

            DateTime fechaEntrada;
            DateTime fechaSalida;

            if (DateTime.TryParse(DateIniTXT.Text, out fechaEntrada) && DateTime.TryParse(DateFinTXT.Text, out fechaSalida))
            {
                Reservas reserva = new Reservas
                {
                    NIF = NIFClienteTXT.Text,
                    fechaEntrada = fechaEntrada, 
                    fechaSalida = fechaSalida,
                    numeroHabitacion = (int)HabitacionCBox.DataSource,
                    temporadaID = TemporadaCBox.SelectedIndex, 
                    firmado = especial
                    
                };

                try
                {
                    controlador.AgregarReserva(reserva);
                    MessageBox.Show("Datos añadidos con éxito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Las fechas de entrada o salida no son válidas. Por favor, asegúrate de ingresar fechas en el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarReservaBT_Click(object sender, EventArgs e)
        {
            byte especial = CHKFirm.Checked ? (byte)1 : (byte)0;
            string Nreserva = ReservaTXT.Text;

            if (int.TryParse(Nreserva, out int ID))
            {
                List<Reservas> reservaEncontrada = controlador.BuscarReserva(ID);

                if (reservaEncontrada.Count > 0)
                {
                    Reservas reserva = reservaEncontrada[0];

                    ReservaTXT.Text = ID.ToString();
                    NIFClienteTXT.Text = reserva.NIF.ToString();
                    DateIniTXT.Text = reserva.fechaEntrada.ToString();
                    DateFinTXT.Text = reserva.fechaSalida.ToString();
                    HabitacionCBox.Text = reserva.numeroHabitacion.ToString();
                    TemporadaCBox.Text = reserva.temporadaID.ToString(); 
                    especial = (byte)reserva.firmado;
                    DateIniTXT.TextChanged += DiasLB_TextChanged;
                    DateFinTXT.TextChanged += DiasLB_TextChanged;

                }
            }
            else
            {
                MessageBox.Show("El número de reserva ingresado no es válido. Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnularReservaBT_Click(object sender, EventArgs e)
        {

        }

        private void CancelarBt_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
