using Microsoft.VisualBasic.FileIO;
using Producto_2.Controlador;
using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace Producto_2.Vista
{
    public partial class frmCliente : Form
    {
        
        private readonly ClienteControlador controlador = new ClienteControlador();
        public frmCliente()
        {
            InitializeComponent();

        }



        public void ocultarGrupos()
        {
            grpClientes.Visible = false;
            
            grpClientesDatos.Visible = false;

        }

        public void activarBtnMenu()
        {
           
        }

        private void limpiarForm()
        {
            textBoxNIF.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxApellido.Text = string.Empty;
            textBoxTelefono.Text = string.Empty;
            textBoxMail.Text = string.Empty;
            chkVIP.Checked = false;
            cmbPais.Text = string.Empty;
            cmbPrefijos.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            txtCP.Text = string.Empty;
            txtNomDom.Text = string.Empty;
            txtCuentaDom.Text = string.Empty;
            txtDetalles.Text = string.Empty;
            dtpFechaAltaDom.Value = DateTime.Now;
            dtpFechaNaci.Value = DateTime.Now;


        }


        private void frmCliente_Load(object sender, EventArgs e)
        {
            ocultarGrupos();
            try
            {
                grpClientes.Visible = true;
                dbGrid.DataSource = controlador.ObtenerClientes();
                dbGrid.Columns[6].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }

        }
        /*
        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            this.Text = "Hotel SOL";
            ocultarGrupos();
            //activarBtnMenu();
            grpClientes.Visible = true;
          //  ClientesBtn.Enabled = false;
            this.Text += " - Clientes";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajustesbtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();

            //ajustesbtn.Enabled = false;
        }
        */
        private void DbGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpClientesDatos.Visible = true;
            grpClientes.Visible = false;
            CargarComboBoxPrefijos();
            CargarComboBoxPaises();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dbGrid.Rows[e.RowIndex];

                textBoxNIF.Text = row.Cells["NIF"].Value?.ToString();
                textBoxNombre.Text = row.Cells["nombre"].Value?.ToString();
                textBoxApellido.Text = row.Cells["apellidos"].Value?.ToString();
                textBoxMail.Text = row.Cells["email"].Value?.ToString();
                textBoxTelefono.Text = row.Cells["telefono"].Value?.ToString();

                try
                {

                    byte vipValue = Convert.ToByte(row.Cells["VIP"].Value);
                    chkVIP.Checked = vipValue == 1;
                }
                catch
                {
                    chkVIP.Checked = false;
                }

            }
        }

        private void txtBuscarCli_Enter(object sender, EventArgs e)
        {
            txtBuscarCli.Text = "";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;
                List<Clientes> listaClientes = controlador.ObtenerClientes();
                controlador.ExportarClientesAXML(listaClientes, rutaArchivo);
                MessageBox.Show("Datos exportados con éxito!");

            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                List<Clientes> listaClientesImportados = controlador.ImportarXML(rutaArchivo);

                foreach (var cliente in listaClientesImportados)
                {
                    try
                    {
                        controlador.AgregarCliente(cliente);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el cliente: " + ex.Message);
                    }
                }
                MessageBox.Show("Datos importados y agregados con éxito!");
                dbGrid.DataSource = controlador.ObtenerClientes();
            }

        }

        private void addCliente_Click(object sender, EventArgs e)
        {
            byte especial = chkVIP.Checked ? (byte)1 : (byte)0;

            var cliente = new Clientes
            {

                NIF = textBoxNIF.Text,
                nombre = textBoxNombre.Text,
                apellidos = textBoxApellido.Text,
                telefono = textBoxTelefono.Text,
                email = textBoxMail.Text,
                VIP = especial
            };

            try
            {
                controlador.AgregarCliente(cliente);
                MessageBox.Show("Datos añadidos con exito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarForm();
                dbGrid.DataSource = controlador.ObtenerClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delClienteBtn_Click(object sender, EventArgs e)
        {
            if (dbGrid.CurrentRow != null)
            {
                try
                {
                    string nifSeleccionado = dbGrid.CurrentRow.Cells["NIF"].Value.ToString();
                    controlador.EliminarCliente(nifSeleccionado);
                    MessageBox.Show("Datos eliminados con Exito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbGrid.DataSource = controlador.ObtenerClientes();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }

            }
        }

        private void modClienteBtn_Click(object sender, EventArgs e)
        {
            if (dbGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dbGrid.SelectedRows[0];
                String Nif = selectedRow.Cells["NIF"].Value.ToString();

                byte vipValue = chkVIP.Checked ? (byte)1 : (byte)0;

                try
                {
                    controlador.ActualizarCliente(
                        Nif,
                        textBoxNombre.Text,
                        textBoxApellido.Text,
                        textBoxMail.Text,
                        textBoxTelefono.Text,
                        vipValue
                        );
                    MessageBox.Show("Datos Actualizados con exito.", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbGrid.DataSource = controlador.ObtenerClientes();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente para actualizar.", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /*
        private void Usuariosbtn_Click(object sender, EventArgs e)
        {
            this.Text = "Hotel SOL";
            ocultarGrupos();
            activarBtnMenu();
            this.Text += " - Usuarios";
            // grpUsuariosInicio.Visible = true;
          //  Usuariosbtn.Enabled = false;
        }
        */
        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            dbGrid.DataSource = controlador.BuscarClientesPorNombre(txtBuscarCli.Text);
            txtBuscarCli.Text = "Cliente a buscar...";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grpClientes.Visible = true;
            grpClientesDatos.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
        /*
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        */
        private void CargarComboBoxPrefijos()
        {

            string filePath = "C:\\Users\\jf3pa\\OneDrive\\Desktop\\Pruebas C#\\DataNerds\\prefijos.csv";

            List<string> datosCombo = new List<string>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields.Length >= 2)
                    {
                        string columna1 = fields[4];
                        string columna2 = fields[5];

                        string elementoCombo = columna1 + " - " + columna2;
                        datosCombo.Add(elementoCombo);
                    }
                }
            }


            cmbPrefijos.Items.AddRange(datosCombo.ToArray());
        }

        private void CargarComboBoxPaises()
        {

            string filePath = "C:\\Users\\jf3pa\\OneDrive\\Desktop\\Pruebas C#\\DataNerds\\Paises.csv";

            List<string> datosCombo = new List<string>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields.Length >= 2)
                    {
                        string columna1 = fields[1];


                        string elementoCombo = columna1;
                        datosCombo.Add(elementoCombo);
                    }
                }
            }


            cmbPais.Items.AddRange(datosCombo.ToArray());

        }



    }   

}




