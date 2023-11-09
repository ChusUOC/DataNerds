using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using Producto_2.Controlador;

namespace Producto_2.Vista
{
    public partial class FormMenuInicioAdmin : Form
    {
        private readonly ControladorMenuAdmin2 adminMenu = new ControladorMenuAdmin2();
        public FormMenuInicioAdmin()
        {
            InitializeComponent();
        }
       

        private void FormMenuInicioAdmin_Load(object sender, EventArgs e)
        {


            estadoDG.DataSource = adminMenu.obtenerHabitacion();
            histResDG.DataSource = adminMenu.obtenerHistoricoReservas();
            incDG.DataSource = adminMenu.obtenerIncidencia();
            usuariosDG.DataSource = adminMenu.obtenerUsuario();


            //usuarios

            usuariosDG.Columns[0].DisplayIndex = 1;
            usuariosDG.Columns[1].DisplayIndex = 0;

            
            usuariosDG.Columns[1].Width = 40;

            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
            comboBox.HeaderText = "Rol";
            comboBox.Name = "RolCombo";
            comboBox.Items.AddRange("Admin", "Recep");
            comboBox.Width = 57;
            int colIndec = 3;
            usuariosDG.Columns.Insert(colIndec, comboBox);
            usuariosDG.Columns[3].ReadOnly = true;


            //historico reservas

            histResDG.Columns[0].Visible = false;
            histResDG.Columns[6].Visible = false;

            histResDG.Columns[1].HeaderText = "Nº";
            histResDG.Columns[2].HeaderText = "Nombre";
            histResDG.Columns[3].HeaderText = "Entrada";
            histResDG.Columns[4].HeaderText = "Salida";
            histResDG.Columns[5].HeaderText = "Estado";

            histResDG.Columns[1].Width = 40;
            histResDG.Columns[3].Width = 50;
            histResDG.Columns[4].Width = 50;
            histResDG.Columns[5].Width = 60;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "FCT";
            buttonColumn.Name = "generaFacturaBtn";
            int columnIndex = 6;
            buttonColumn.Width = 41;
            histResDG.Columns.Insert(columnIndex, buttonColumn);

            // incidencias
            incDG.Columns[0].HeaderText = "ID";
            incDG.Columns[1].HeaderText = "Tipo";
            incDG.Columns[2].HeaderText = "Detalles";
            incDG.Columns[3].HeaderText = "RES";

            incDG.Columns[0].Width = 30;
            incDG.Columns[1].Width = 80;
            incDG.Columns[2].Width = 148;

            DataGridViewCheckBoxColumn checkBox = new DataGridViewCheckBoxColumn();
            DataGridViewColumn reservasCol = incDG.Columns[3];

            

            if (reservasCol is DataGridViewCheckBoxColumn)
            {
                // ya es un checkbox
            }
            else {
                checkBox.HeaderText = "RES";
                checkBox.Name = "resolverBtn";
                checkBox.Width = 40;

                int reservasIndex = reservasCol.Index;
                incDG.Columns.Remove(reservasCol);
                incDG.Columns.Insert(reservasIndex, checkBox);

            }

            //estado habitacion

            estadoDG.Columns[1].Visible = false;
            estadoDG.Columns[2].Visible = false;
            estadoDG.Columns[3].Visible = false;
            estadoDG.Columns[6].Visible = false;
            estadoDG.Columns[7].Visible = false;

            estadoDG.Columns[0].HeaderText =  "Nº Habit";
            
            estadoDG.Columns[0].Width = 92;

            DataGridViewColumn estadoColumn = estadoDG.Columns[4];
            DataGridViewColumn outColumn = estadoDG.Columns[5];

            if (estadoColumn is DataGridViewComboBoxColumn) {

                //ya es un combobox
            }
            else {
                DataGridViewComboBoxColumn comboEstado = new DataGridViewComboBoxColumn();

                // Configurar las opciones del ComboBox
                comboEstado.HeaderText = "Estado";
                comboEstado.Name = "estadoCombo";
                comboEstado.Width = 150;
                comboEstado.Items.AddRange("limpio", "por arreglar", "mantenimiento");

                // Reemplazar la columna existente por la nueva columna de ComboBox
                int colIndex = estadoColumn.Index;
                estadoDG.Columns.Remove(estadoColumn);
                estadoDG.Columns.Insert(colIndex, comboEstado);
            }

            if (outColumn is DataGridViewCheckBoxColumn) { 
                DataGridViewCheckBoxColumn checkOtC = new DataGridViewCheckBoxColumn();
                checkOtC.HeaderText = "Fuera de servicio";
                checkOtC.Name = "outCheckB";

                int coluInx = outColumn.Index;
                estadoDG.Columns.Remove(outColumn);
                estadoDG.Columns.Insert(coluInx, checkOtC);

            }







        }
    }
}
