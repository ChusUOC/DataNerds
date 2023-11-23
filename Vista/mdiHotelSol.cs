using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
           // this.DeshabilitarBoton();
           
           
        }

        //Evita abrir mas de una instacia de un formulario
        public void abrirFomulario(Type tipoForm)
        {
            var formulariosabiertos = this.MdiChildren.FirstOrDefault(f =>  f.GetType() == tipoForm);

            if (formulariosabiertos != null)
            {
                formulariosabiertos.BringToFront();
               
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
            cerrarForms();
            abrirFomulario(typeof(frmAutenticacion));
            
        }
       
        public void HabilitarBoton()
        {
            //mnuInicio.Enabled = true;
            mnuClientes.Enabled = true;
            mnuReservas.Enabled = true;
            mnuHabitaciones.Enabled = true;
            mnuServicios.Enabled = true;
            mnuFacturas.Enabled = true;
            mnuImportarXML.Enabled = true;
            mnuExportarXML.Enabled = true;
        }

        public void DeshabilitarBoton()
        {
            //mnuInicio.Enabled = false;
            mnuClientes.Enabled = false;
            mnuReservas.Enabled = false;
            mnuHabitaciones.Enabled = false;
            mnuServicios.Enabled = false;
            mnuFacturas.Enabled = false;
            mnuExportarXML.Enabled = false;
            mnuImportarXML.Enabled = false;
        }

        private void mnuFacturas_Click(object sender, EventArgs e)
        {
            cerrarForms();
            abrirFomulario(typeof(InterfazFacturas));
        }

       

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            cerrarForms();
            abrirFomulario(typeof(frmCliente));
        }

        private void mnuReservas_Click(object sender, EventArgs e)
        {
            cerrarForms();
            abrirFomulario(typeof(Form7Reservas));
        }

        private void mnuHabitaciones_Click(object sender, EventArgs e)
        {
            cerrarForms();
            abrirFomulario(typeof(FrmHabitaciones));
        }

        private void mnuServicios_Click(object sender, EventArgs e)
        {
            
            abrirFomulario(typeof(FormServicios11));
        }

        private void cerrarForms()
        {
            
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuImportarXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
               // List<Clientes> listaClientesImportados = controlador.ImportarXML(rutaArchivo);
               /*
                foreach (var cliente in listaClientesImportados)
                {
                    try
                    {
                      //  controlador.AgregarCliente(cliente);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el cliente: " + ex.Message);
                    }
                }
               */
                MessageBox.Show("Datos importados y agregados con éxito!");
              // dbGrid.DataSource = controlador.ObtenerClientes();
            }
        }

        private void mnuExportarXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;
               // List<Clientes> listaClientes = controlador.ObtenerClientes();
               // controlador.ExportarClientesAXML(listaClientes, rutaArchivo);
                MessageBox.Show("Datos exportados con éxito!");

            }
        }
    }
}
