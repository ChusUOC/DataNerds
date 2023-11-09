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
    public partial class FormServicios11 : Form
    {
        private readonly ServiciosControlador11 servicios = new ServiciosControlador11();
        public FormServicios11()
        {
            InitializeComponent();
        }

        private void FormServicios11_Load(object sender, EventArgs e)
        {

            serviciosDG.DataSource = servicios.obtenerServicios();
            serviciosDG.Columns[1].Visible = false;
            serviciosDG.Columns[11].Visible = false;
            serviciosDG.Columns[12].Visible = false;
            serviciosDG.Columns[0].HeaderText = " ";
            
            serviciosDG.Columns[2].HeaderText = "TEMPORADA";
            serviciosDG.Columns[3].HeaderText = " ";
            serviciosDG.Columns[4].HeaderText = "BAJA";
            serviciosDG.Columns[5].HeaderText = "MEDIA";
            serviciosDG.Columns[6].HeaderText = "ALTA";
            serviciosDG.Columns[7].HeaderText = "BAJA";
            serviciosDG.Columns[8].HeaderText = "MEDIA";
            serviciosDG.Columns[9].HeaderText = "ALTA";
            serviciosDG.Columns[10].HeaderText = " ";

            serviciosDG.Columns[0].Width = 40;
            serviciosDG.Columns[4].Width = 70;
            serviciosDG.Columns[5].Width = 70;
            serviciosDG.Columns[6].Width = 70;
            serviciosDG.Columns[7].Width = 70;
            serviciosDG.Columns[8].Width = 70;
            serviciosDG.Columns[9].Width = 70;
            serviciosDG.Columns[10].Width = 60;
        }
    }
}
