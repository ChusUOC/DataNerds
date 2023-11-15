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
    public partial class InterfazFacturas : Form
    {
        public InterfazFacturas()
        {
            InitializeComponent();
        }

        /*Métodos de botones de navegación*/

        private void limpiarForm()
        {
            ReservaTXT.Text = "";
            DNITXT.Text = "";
            NPersonasTXT.Text = "";
            DateIniTXT.Text = "";
            DateFinTXT.Text = "";
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

        }

        private void AnularFacturaBT_Click(object sender, EventArgs e)
        {

        }

        private void CancelarBt_Click(object sender, EventArgs e)
        {

        }
    }
}
