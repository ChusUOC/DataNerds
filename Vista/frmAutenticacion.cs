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
    public partial class frmAutenticacion : Form
    {
        public frmAutenticacion()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;    
           
        }

        private void FrmAutenticacion_VisibleChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

       

        private void frmAutenticacion_Load(object sender, EventArgs e)
        {

        }
    }
}
