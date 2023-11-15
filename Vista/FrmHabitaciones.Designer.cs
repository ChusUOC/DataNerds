namespace Producto_2.Vista
{
    partial class FrmHabitaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpClientes = new System.Windows.Forms.GroupBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnModificarHabitacion = new System.Windows.Forms.Button();
            this.BtnEliminarHabitacion = new System.Windows.Forms.Button();
            this.txtBuscarHabitacion = new System.Windows.Forms.TextBox();
            this.labelDHabitaciones = new System.Windows.Forms.Label();
            this.addHabitacion = new System.Windows.Forms.Button();
            this.dbGridHabitacion = new System.Windows.Forms.DataGridView();
            this.habitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridHabitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpClientes
            // 
            this.grpClientes.Controls.Add(this.btnImportar);
            this.grpClientes.Controls.Add(this.btnExportar);
            this.grpClientes.Controls.Add(this.button1);
            this.grpClientes.Controls.Add(this.BtnModificarHabitacion);
            this.grpClientes.Controls.Add(this.BtnEliminarHabitacion);
            this.grpClientes.Controls.Add(this.txtBuscarHabitacion);
            this.grpClientes.Controls.Add(this.labelDHabitaciones);
            this.grpClientes.Controls.Add(this.addHabitacion);
            this.grpClientes.Controls.Add(this.dbGridHabitacion);
            this.grpClientes.Location = new System.Drawing.Point(59, 31);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(680, 484);
            this.grpClientes.TabIndex = 38;
            this.grpClientes.TabStop = false;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(375, 59);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(87, 23);
            this.btnImportar.TabIndex = 29;
            this.btnImportar.Text = "Importar XML";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(497, 59);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(87, 23);
            this.btnExportar.TabIndex = 48;
            this.btnExportar.Text = "Exportar XML";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Producto_2.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(262, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 47;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnModificarHabitacion
            // 
            this.BtnModificarHabitacion.Location = new System.Drawing.Point(243, 414);
            this.BtnModificarHabitacion.Name = "BtnModificarHabitacion";
            this.BtnModificarHabitacion.Size = new System.Drawing.Size(180, 23);
            this.BtnModificarHabitacion.TabIndex = 44;
            this.BtnModificarHabitacion.Text = "Modificar Datos Habitación";
            this.BtnModificarHabitacion.UseVisualStyleBackColor = true;
            this.BtnModificarHabitacion.Click += new System.EventHandler(this.BtnModificarHabitacion_Click);
            // 
            // BtnEliminarHabitacion
            // 
            this.BtnEliminarHabitacion.Location = new System.Drawing.Point(450, 414);
            this.BtnEliminarHabitacion.Name = "BtnEliminarHabitacion";
            this.BtnEliminarHabitacion.Size = new System.Drawing.Size(180, 23);
            this.BtnEliminarHabitacion.TabIndex = 43;
            this.BtnEliminarHabitacion.Text = "Eliminar Habitación";
            this.BtnEliminarHabitacion.UseVisualStyleBackColor = true;
            this.BtnEliminarHabitacion.Click += new System.EventHandler(this.BtnEliminarHabitacion_Click);
            // 
            // txtBuscarHabitacion
            // 
            this.txtBuscarHabitacion.Location = new System.Drawing.Point(19, 62);
            this.txtBuscarHabitacion.Name = "txtBuscarHabitacion";
            this.txtBuscarHabitacion.Size = new System.Drawing.Size(237, 20);
            this.txtBuscarHabitacion.TabIndex = 32;
            this.txtBuscarHabitacion.Text = "Buscar Habitación...";
            this.txtBuscarHabitacion.TextChanged += new System.EventHandler(this.txtBuscarHabitacion_TextChanged);
            // 
            // labelDHabitaciones
            // 
            this.labelDHabitaciones.AutoSize = true;
            this.labelDHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDHabitaciones.Location = new System.Drawing.Point(279, 27);
            this.labelDHabitaciones.Name = "labelDHabitaciones";
            this.labelDHabitaciones.Size = new System.Drawing.Size(144, 13);
            this.labelDHabitaciones.TabIndex = 31;
            this.labelDHabitaciones.Text = "Listado de Habitaciones";
            // 
            // addHabitacion
            // 
            this.addHabitacion.Location = new System.Drawing.Point(33, 414);
            this.addHabitacion.Name = "addHabitacion";
            this.addHabitacion.Size = new System.Drawing.Size(180, 23);
            this.addHabitacion.TabIndex = 29;
            this.addHabitacion.Text = "Nueva Habitación";
            this.addHabitacion.UseVisualStyleBackColor = true;
            this.addHabitacion.Click += new System.EventHandler(this.addHabitacion_Click);
            // 
            // dbGridHabitacion
            // 
            this.dbGridHabitacion.AutoGenerateColumns = false;
            this.dbGridHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridHabitacion.DataSource = this.habitacionBindingSource;
            this.dbGridHabitacion.Location = new System.Drawing.Point(19, 97);
            this.dbGridHabitacion.Name = "dbGridHabitacion";
            this.dbGridHabitacion.Size = new System.Drawing.Size(643, 311);
            this.dbGridHabitacion.TabIndex = 28;
            this.dbGridHabitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGridHabitacion_CellContentClick);
            // 
            // habitacionBindingSource
            // 
            this.habitacionBindingSource.DataMember = "Habitacion";
            // 
            // FrmHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 538);
            this.Controls.Add(this.grpClientes);
            this.Name = "FrmHabitaciones";
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.FrmHabitaciones_Load);
            this.grpClientes.ResumeLayout(false);
            this.grpClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridHabitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnModificarHabitacion;
        private System.Windows.Forms.Button BtnEliminarHabitacion;
        private System.Windows.Forms.TextBox txtBuscarHabitacion;
        private System.Windows.Forms.Label labelDHabitaciones;
        private System.Windows.Forms.Button addHabitacion;
        private System.Windows.Forms.DataGridView dbGridHabitacion;
       // private HotelSQLDataSet hotelSQLDataSet;
        private System.Windows.Forms.BindingSource habitacionBindingSource;
        //private HotelSQLDataSetTableAdapters.HabitacionTableAdapter habitacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroHabitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoHabitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoIDDataGridViewTextBoxColumn;
    }
}