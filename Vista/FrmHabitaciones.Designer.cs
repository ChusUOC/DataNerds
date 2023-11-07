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
            this.ajustesbtn = new System.Windows.Forms.Button();
            this.Usuariosbtn = new System.Windows.Forms.Button();
            this.incidenciasbtn = new System.Windows.Forms.Button();
            this.facturasBtn = new System.Windows.Forms.Button();
            this.SrvidioBtn = new System.Windows.Forms.Button();
            this.habitacionesBtn = new System.Windows.Forms.Button();
            this.reservasVtb = new System.Windows.Forms.Button();
            this.ClientesBtn = new System.Windows.Forms.Button();
            this.inicioBtn = new System.Windows.Forms.Button();
            this.hotelSQLDataSet = new Producto_2.HotelSQLDataSet();
            this.habitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.habitacionTableAdapter = new Producto_2.HotelSQLDataSetTableAdapters.HabitacionTableAdapter();
            this.numeroHabitacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoHabitacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridHabitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSet)).BeginInit();
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
            this.grpClientes.Location = new System.Drawing.Point(59, 72);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(680, 443);
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
            this.dbGridHabitacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroHabitacionDataGridViewTextBoxColumn,
            this.tipoHabitacionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.tipoIDDataGridViewTextBoxColumn});
            this.dbGridHabitacion.DataSource = this.habitacionBindingSource;
            this.dbGridHabitacion.Location = new System.Drawing.Point(19, 97);
            this.dbGridHabitacion.Name = "dbGridHabitacion";
            this.dbGridHabitacion.Size = new System.Drawing.Size(643, 311);
            this.dbGridHabitacion.TabIndex = 28;
            this.dbGridHabitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGridHabitacion_CellContentClick);
            // 
            // ajustesbtn
            // 
            this.ajustesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajustesbtn.Location = new System.Drawing.Point(659, 24);
            this.ajustesbtn.Name = "ajustesbtn";
            this.ajustesbtn.Size = new System.Drawing.Size(74, 42);
            this.ajustesbtn.TabIndex = 37;
            this.ajustesbtn.Text = "Ajustes";
            this.ajustesbtn.UseVisualStyleBackColor = true;
            // 
            // Usuariosbtn
            // 
            this.Usuariosbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariosbtn.Location = new System.Drawing.Point(584, 24);
            this.Usuariosbtn.Name = "Usuariosbtn";
            this.Usuariosbtn.Size = new System.Drawing.Size(74, 42);
            this.Usuariosbtn.TabIndex = 36;
            this.Usuariosbtn.Text = "Usuarios";
            this.Usuariosbtn.UseVisualStyleBackColor = true;
            // 
            // incidenciasbtn
            // 
            this.incidenciasbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidenciasbtn.Location = new System.Drawing.Point(509, 24);
            this.incidenciasbtn.Name = "incidenciasbtn";
            this.incidenciasbtn.Size = new System.Drawing.Size(74, 42);
            this.incidenciasbtn.TabIndex = 35;
            this.incidenciasbtn.Text = "Incidencias";
            this.incidenciasbtn.UseVisualStyleBackColor = true;
            // 
            // facturasBtn
            // 
            this.facturasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturasBtn.Location = new System.Drawing.Point(434, 24);
            this.facturasBtn.Name = "facturasBtn";
            this.facturasBtn.Size = new System.Drawing.Size(74, 42);
            this.facturasBtn.TabIndex = 34;
            this.facturasBtn.Text = "Facturas";
            this.facturasBtn.UseVisualStyleBackColor = true;
            // 
            // SrvidioBtn
            // 
            this.SrvidioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrvidioBtn.Location = new System.Drawing.Point(359, 24);
            this.SrvidioBtn.Name = "SrvidioBtn";
            this.SrvidioBtn.Size = new System.Drawing.Size(74, 42);
            this.SrvidioBtn.TabIndex = 33;
            this.SrvidioBtn.Text = "Servicio";
            this.SrvidioBtn.UseVisualStyleBackColor = true;
            // 
            // habitacionesBtn
            // 
            this.habitacionesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitacionesBtn.Location = new System.Drawing.Point(284, 24);
            this.habitacionesBtn.Name = "habitacionesBtn";
            this.habitacionesBtn.Size = new System.Drawing.Size(74, 42);
            this.habitacionesBtn.TabIndex = 32;
            this.habitacionesBtn.Text = "Habitaciones";
            this.habitacionesBtn.UseVisualStyleBackColor = true;
            // 
            // reservasVtb
            // 
            this.reservasVtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservasVtb.Location = new System.Drawing.Point(209, 24);
            this.reservasVtb.Name = "reservasVtb";
            this.reservasVtb.Size = new System.Drawing.Size(74, 42);
            this.reservasVtb.TabIndex = 31;
            this.reservasVtb.Text = "Reservas";
            this.reservasVtb.UseVisualStyleBackColor = true;
            // 
            // ClientesBtn
            // 
            this.ClientesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesBtn.Location = new System.Drawing.Point(134, 24);
            this.ClientesBtn.Name = "ClientesBtn";
            this.ClientesBtn.Size = new System.Drawing.Size(74, 42);
            this.ClientesBtn.TabIndex = 30;
            this.ClientesBtn.Text = "Clientes";
            this.ClientesBtn.UseVisualStyleBackColor = true;
            // 
            // inicioBtn
            // 
            this.inicioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioBtn.Location = new System.Drawing.Point(59, 24);
            this.inicioBtn.Name = "inicioBtn";
            this.inicioBtn.Size = new System.Drawing.Size(74, 42);
            this.inicioBtn.TabIndex = 29;
            this.inicioBtn.Text = "Inicio";
            this.inicioBtn.UseVisualStyleBackColor = true;
            // 
            // hotelSQLDataSet
            // 
            this.hotelSQLDataSet.DataSetName = "HotelSQLDataSet";
            this.hotelSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // habitacionBindingSource
            // 
            this.habitacionBindingSource.DataMember = "Habitacion";
            this.habitacionBindingSource.DataSource = this.hotelSQLDataSet;
            // 
            // habitacionTableAdapter
            // 
            this.habitacionTableAdapter.ClearBeforeFill = true;
            // 
            // numeroHabitacionDataGridViewTextBoxColumn
            // 
            this.numeroHabitacionDataGridViewTextBoxColumn.DataPropertyName = "numeroHabitacion";
            this.numeroHabitacionDataGridViewTextBoxColumn.HeaderText = "numeroHabitacion";
            this.numeroHabitacionDataGridViewTextBoxColumn.Name = "numeroHabitacionDataGridViewTextBoxColumn";
            // 
            // tipoHabitacionDataGridViewTextBoxColumn
            // 
            this.tipoHabitacionDataGridViewTextBoxColumn.DataPropertyName = "tipoHabitacion";
            this.tipoHabitacionDataGridViewTextBoxColumn.HeaderText = "tipoHabitacion";
            this.tipoHabitacionDataGridViewTextBoxColumn.Name = "tipoHabitacionDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // tipoIDDataGridViewTextBoxColumn
            // 
            this.tipoIDDataGridViewTextBoxColumn.DataPropertyName = "tipoID";
            this.tipoIDDataGridViewTextBoxColumn.HeaderText = "tipoID";
            this.tipoIDDataGridViewTextBoxColumn.Name = "tipoIDDataGridViewTextBoxColumn";
            // 
            // FrmHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 538);
            this.Controls.Add(this.grpClientes);
            this.Controls.Add(this.ajustesbtn);
            this.Controls.Add(this.Usuariosbtn);
            this.Controls.Add(this.incidenciasbtn);
            this.Controls.Add(this.facturasBtn);
            this.Controls.Add(this.SrvidioBtn);
            this.Controls.Add(this.habitacionesBtn);
            this.Controls.Add(this.reservasVtb);
            this.Controls.Add(this.ClientesBtn);
            this.Controls.Add(this.inicioBtn);
            this.Name = "FrmHabitaciones";
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.FrmHabitaciones_Load);
            this.grpClientes.ResumeLayout(false);
            this.grpClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridHabitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSet)).EndInit();
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
        private System.Windows.Forms.Button ajustesbtn;
        private System.Windows.Forms.Button Usuariosbtn;
        private System.Windows.Forms.Button incidenciasbtn;
        private System.Windows.Forms.Button facturasBtn;
        private System.Windows.Forms.Button SrvidioBtn;
        private System.Windows.Forms.Button habitacionesBtn;
        private System.Windows.Forms.Button reservasVtb;
        private System.Windows.Forms.Button ClientesBtn;
        private System.Windows.Forms.Button inicioBtn;
        private HotelSQLDataSet hotelSQLDataSet;
        private System.Windows.Forms.BindingSource habitacionBindingSource;
        private HotelSQLDataSetTableAdapters.HabitacionTableAdapter habitacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroHabitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoHabitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoIDDataGridViewTextBoxColumn;
    }
}