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
    public partial class mdiHotelSol : Form
    {
        private int childFormNumber = 0;

        public mdiHotelSol()
        {
            InitializeComponent();
            this.IsMdiContainer = true; 
        }

        //Evita abrir mas de una instacia de un formulario
        private void abrirFomulario(Type tipoForm)
        {
            var formulariosabiertos = this.MdiChildren.FirstOrDefault(f =>  f.GetType() == tipoForm);

            if (formulariosabiertos != null)
            {
                
                formulariosabiertos.Close();
            }
            else
            {
                var formularioHijo = (Form)Activator.CreateInstance(tipoForm);
                formularioHijo.MdiParent = this;
                formularioHijo.Show();
            }
        }



        private void mdiHotelSol_Load(object sender, EventArgs e)
        {
            abrirFomulario(typeof(frmAutenticacion));
        }

        

        private void mnuFacturas_Click(object sender, EventArgs e)
        {
            abrirFomulario(typeof(InterfazFacturas));
        }

        private void mnuIncidencias_Click(object sender, EventArgs e)
        {
           
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
          //  abrirFomulario(typeof(InterfazUsuario));
        }

        private void mnuInicio_Click(object sender, EventArgs e)
        {
            abrirFomulario(typeof(FrmMenuInicio));
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            abrirFomulario(typeof(frmCliente));
        }

        private void mnuReservas_Click(object sender, EventArgs e)
        {
            abrirFomulario(typeof(Form7Reservas));
        }

        private void mnuHabitaciones_Click(object sender, EventArgs e)
        {
            abrirFomulario(typeof(FrmHabitaciones));
        }

        private void mnuServicios_Click(object sender, EventArgs e)
        {
            abrirFomulario(typeof(FormServicios11));
        }
    }
}
