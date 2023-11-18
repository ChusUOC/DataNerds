using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Producto_2.Modelo;
using Producto_2.Controlador;


namespace Producto_2.Vista
{
    public partial class InterfazFacturas : Form
    {
        private readonly FacturaControlador controlador = new FacturaControlador();
        private readonly ReservaControlador controladorR = new ReservaControlador();

        public InterfazFacturas()
        {
            InitializeComponent();
        }

        /*Métodos de botones de navegación*/

        private void limpiarForm()
        {
            FacturaTXT.Text = "";
            ReservaTXT.Text = "";
            FFacturaTXT.Text = "";
            DNITXT.Text = "";
            NPersonasTXT.Text = "";
            DateIniTXT.Text = "";
            DateFinTXT.Text = "";
            NDiasTXT.Text = "";
            PrecioHabitacionTXT.Text = "";
            PrecioPensionTXT.Text = "";
            PrecioServiciosTXT.Text = "";
            BaseImponibleTXT.Text = "";
            ivatxt.Text = "";
            ImporteTotalTXT.Text = "";
            HabitacionCBox.Text = "";
            TipoPensionCB.Text = "";
            ServiciosLBox.Text = "";
            TemporadaCBox.Text = "";
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
            //inicioBtn.Enabled = true;
            //ClientesBtn.Enabled = true;
            //reservasVtb.Enabled = true;
            //habitacionesBtn.Enabled = true;
            //SrvidioBtn.Enabled = true;
            //facturasBtn.Enabled = true;
            //incidenciasbtn.Enabled = true;
            //Usuariosbtn.Enabled = true;
            //ajustesbtn.Enabled = true;
        }

        private void SrvidioBtn_Click(object sender, EventArgs e)
        {

        }

        private void ClientesBtn_Click(object sender, EventArgs e)
        {

        }

        private void reservasVtb_Click(object sender, EventArgs e)
        {

        }

        private void habitacionesBtn_Click(object sender, EventArgs e)
        {

        }

        private void inicioBtn_Click(object sender, EventArgs e)
        {

        }

        private void facturasBtn_Click(object sender, EventArgs e)
        {

        }

        private void incidenciasbtn_Click(object sender, EventArgs e)
        {

        }

        private void Usuariosbtn_Click(object sender, EventArgs e)
        {

        }

        private void ajustesbtn_Click(object sender, EventArgs e)
        {

        }

        private void cerrarForm()
        {
            this.Close();
        }

        /* Métodos de cajas de texto o botones de acción*/
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReservaTXT_TextChanged(object sender, EventArgs e)
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

        private void FFacturaTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DNITXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(DateIniTXT.Text, out DateTime fechaEntrada) && 
                DateTime.TryParse(DateFinTXT.Text, out DateTime fechaSalida))
            {
                TimeSpan diferencia = fechaSalida - fechaEntrada;
                int diasDiferencia = (int)diferencia.TotalDays;

                NDiasTXT.Text = diasDiferencia.ToString();
            }
            else
            {
                NDiasTXT.Text = "Error: fechas inválidas";
            }
        }

        private void PrecioHabitacionTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioPensionTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioServiciosTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ivatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImporteTotalTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmarFacturaBT_Click(object sender, EventArgs e)
        {

        }

        private void MostrarFacturaBT_Click(object sender, EventArgs e)
        {

            string Nfactura = FacturaTXT.Text;
            

            if (int.TryParse(Nfactura, out int numeroFactura))
            {
                
                List<Factura> facturaEncontrada = controlador.BuscarFactura(numeroFactura);
                

                if (facturaEncontrada.Count > 0)
                {
                    
                    Factura factura = facturaEncontrada[0];

                    int NReserva = factura.reservaID;

                    List<Reservas> reservaEncontrada = controladorR.BuscarReserva(NReserva);

                    if (reservaEncontrada.Count > 0)
                    {
                        Reservas reserva = reservaEncontrada[0];
                        /* Introducir los campos faltantes*/
                        FacturaTXT.Text = numeroFactura.ToString();
                        DNITXT.Text = factura.idCliente.ToString();
                        FFacturaTXT.Text = factura.fechaFactura.ToString();
                        DateIniTXT.Text = reserva.fechaEntrada.ToString();
                        DateFinTXT.Text = reserva.fechaSalida.ToString();
                        HabitacionCBox.Text = reserva.numeroHabitacion.ToString();
                        TemporadaCBox.Text = reserva.temporadaID.ToString();
                        DateIniTXT.TextChanged += textBox1_TextChanged;
                        DateFinTXT.TextChanged += textBox1_TextChanged;
                        /*PrecioHabitacionTXT.Text = precioDia */ 

                    }

                }
            }
            else
            {
                MessageBox.Show("El número de factura ingresado no es válido. Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnularFacturaBT_Click(object sender, EventArgs e)
        {
            string Nfactura = FacturaTXT.Text;

            if (int.TryParse(Nfactura, out int numeroFactura))
            {
                List<Factura> facturaEncontrada = controlador.BuscarFactura(numeroFactura);

                if (facturaEncontrada.Count > 0)
                {
                    try
                    {
                        controlador.EliminarFactura(numeroFactura);
                        MessageBox.Show("Factura eliminada con Exito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                    }
                }
            }

        }

        private void CancelarBt_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
