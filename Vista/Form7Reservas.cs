using Producto_2.Controlador;
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
        private readonly ClienteReservas7 reservas = new ClienteReservas7();
        
        public Form7Reservas()
        {
            InitializeComponent();
        }

        private void Form7Reservas_Load(object sender, EventArgs e)
        {
            
            checkoutHDG.DataSource = reservas.obtenerHistoricoReservas();
            chinDG.DataSource = reservas.obtenerHistoricoReservas();
            pendDG.DataSource = reservas.obtenerHistoricoReservas();

            //checkout
            
            

            checkoutHDG.Columns[0].Visible = false;
            checkoutHDG.Columns[3].Visible = false;
            checkoutHDG.Columns[5].Visible = false;
            

            checkoutHDG.Columns[1].HeaderText = "Num Habit";
            checkoutHDG.Columns[2].HeaderText = "Nombre Cliente";
            checkoutHDG.Columns[6].HeaderText = "Incidencias";

            checkoutHDG.Columns[1].Width = 92;
            checkoutHDG.Columns[2].Width = 150;

            DataGridViewColumn incidenciasColumn = checkoutHDG.Columns[6];
            DataGridViewColumn chinincidenciasColumn = chinDG.Columns[6];

            if (incidenciasColumn is DataGridViewComboBoxColumn)
            {
                // La columna 6 ya es una columna de ComboBox
            }
            else
            {
                // Cambiar la columna existente a una columna de ComboBox
                DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();

                // Configurar las opciones del ComboBox
                comboBoxColumn.HeaderText = "Incidencias";
                comboBoxColumn.Name = "Incidencias";
                comboBoxColumn.Items.AddRange("Opción 1", "Opción 2", "Opción 3");

                // Reemplazar la columna existente por la nueva columna de ComboBox
                int columnIndex = incidenciasColumn.Index;
                checkoutHDG.Columns.Remove(incidenciasColumn);
                checkoutHDG.Columns.Insert(columnIndex, comboBoxColumn);
            }

            //checkin


            chinDG.Columns[0].Visible = false;
            chinDG.Columns[4].Visible = false;
            chinDG.Columns[5].Visible = false;


            chinDG.Columns[1].HeaderText = "Num Habit";
            chinDG.Columns[2].HeaderText = "Nombre Cliente";
            chinDG.Columns[6].HeaderText = "Incidencias";

            chinDG.Columns[1].Width = 92;
            chinDG.Columns[2].Width = 150;

            

            if (incidenciasColumn is DataGridViewComboBoxColumn)
            {
                // La columna 6 ya es una columna de ComboBox
            }
            else
            {
                // Cambiar la columna existente a una columna de ComboBox
                DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();

                // Configurar las opciones del ComboBox
                comboBoxColumn.HeaderText = "Incidencias";
                comboBoxColumn.Name = "Incidencias";
                comboBoxColumn.Items.AddRange("Opción 1", "Opción 2", "Opción 3");

                // Reemplazar la columna existente por la nueva columna de ComboBox
                int columnIndex = incidenciasColumn.Index;
                chinDG.Columns.Remove(chinincidenciasColumn);
                chinDG.Columns.Insert(columnIndex, comboBoxColumn);
            }

            //PENDIENTE column

            pendDG.Columns[0].Visible = false;
            pendDG.Columns[6].Visible = false;

            pendDG.Columns[1].HeaderText = "Nº";

            pendDG.Columns[1].Width = 40;

            DataGridViewCheckBoxColumn checkBox = new DataGridViewCheckBoxColumn();
            DataGridViewColumn estadoColum = pendDG.Columns[5];

            if (estadoColum is DataGridViewCheckBoxColumn)
            {
                //la columna ya es checkbox
            }
            else {
                checkBox.HeaderText = "Estado";
                checkBox.Name = "Indencias";

                int columnIndex = estadoColum.Index;
                pendDG.Columns.Remove(estadoColum);
                pendDG.Columns.Insert(columnIndex, checkBox);
            }
        }
    }
}
