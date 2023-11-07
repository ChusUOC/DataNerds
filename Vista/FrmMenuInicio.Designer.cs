namespace Producto_2.Vista
{
    partial class FrmMenuInicio
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
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.ajustesbtn = new System.Windows.Forms.Button();
            this.Usuariosbtn = new System.Windows.Forms.Button();
            this.incidenciasbtn = new System.Windows.Forms.Button();
            this.facturasBtn = new System.Windows.Forms.Button();
            this.SrvidioBtn = new System.Windows.Forms.Button();
            this.habitacionesBtn = new System.Windows.Forms.Button();
            this.reservasVtb = new System.Windows.Forms.Button();
            this.ClientesBtn = new System.Windows.Forms.Button();
            this.inicioBtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.hotelSQLDataSet = new Producto_2.HotelSQLDataSet();
            this.hotelSQLDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelSQLDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelSQLDataSet1 = new Producto_2.HotelSQLDataSet1();
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasTableAdapter = new Producto_2.HotelSQLDataSet1TableAdapters.ReservasTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroHabitacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporadaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCambioTurno = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnVerDisponibilidad = new System.Windows.Forms.Button();
            this.btnVerFacturas = new System.Windows.Forms.Button();
            this.labelCheckInHecho = new System.Windows.Forms.Label();
            this.labelCheckInPendiente = new System.Windows.Forms.Label();
            this.labelConfirmacionPendiente = new System.Windows.Forms.Label();
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.grpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpClientes
            // 
            this.grpClientes.Controls.Add(this.btnGuardarNota);
            this.grpClientes.Controls.Add(this.labelConfirmacionPendiente);
            this.grpClientes.Controls.Add(this.labelCheckInPendiente);
            this.grpClientes.Controls.Add(this.labelCheckInHecho);
            this.grpClientes.Controls.Add(this.btnVerFacturas);
            this.grpClientes.Controls.Add(this.btnVerDisponibilidad);
            this.grpClientes.Controls.Add(this.txtCambioTurno);
            this.grpClientes.Controls.Add(this.monthCalendar1);
            this.grpClientes.Controls.Add(this.btnNuevaReserva);
            this.grpClientes.Controls.Add(this.btnBuscarCliente);
            this.grpClientes.Controls.Add(this.dbGrid);
            this.grpClientes.Location = new System.Drawing.Point(59, 72);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(680, 443);
            this.grpClientes.TabIndex = 38;
            this.grpClientes.TabStop = false;
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.Location = new System.Drawing.Point(10, 405);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.Size = new System.Drawing.Size(139, 23);
            this.btnNuevaReserva.TabIndex = 44;
            this.btnNuevaReserva.Text = "Nueva Reserva";
            this.btnNuevaReserva.UseVisualStyleBackColor = true;
            this.btnNuevaReserva.Click += new System.EventHandler(this.btnNuevaReserva_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(160, 405);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(139, 23);
            this.btnBuscarCliente.TabIndex = 29;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // dbGrid
            // 
            this.dbGrid.AutoGenerateColumns = false;
            this.dbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firmadoDataGridViewTextBoxColumn,
            this.fechaEntradaDataGridViewTextBoxColumn,
            this.fechaSalidaDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn,
            this.numeroHabitacionDataGridViewTextBoxColumn,
            this.temporadaIDDataGridViewTextBoxColumn});
            this.dbGrid.DataSource = this.reservasBindingSource;
            this.dbGrid.Location = new System.Drawing.Point(0, 10);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.Size = new System.Drawing.Size(674, 198);
            this.dbGrid.TabIndex = 28;
            this.dbGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGrid_CellContentClick);
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
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(0, 220);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 49;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // hotelSQLDataSet
            // 
            this.hotelSQLDataSet.DataSetName = "HotelSQLDataSet";
            this.hotelSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelSQLDataSetBindingSource
            // 
            this.hotelSQLDataSetBindingSource.DataSource = this.hotelSQLDataSet;
            this.hotelSQLDataSetBindingSource.Position = 0;
            // 
            // hotelSQLDataSetBindingSource1
            // 
            this.hotelSQLDataSetBindingSource1.DataSource = this.hotelSQLDataSet;
            this.hotelSQLDataSetBindingSource1.Position = 0;
            // 
            // hotelSQLDataSet1
            // 
            this.hotelSQLDataSet1.DataSetName = "HotelSQLDataSet1";
            this.hotelSQLDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "Reservas";
            this.reservasBindingSource.DataSource = this.hotelSQLDataSet1;
            // 
            // reservasTableAdapter
            // 
            this.reservasTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firmadoDataGridViewTextBoxColumn
            // 
            this.firmadoDataGridViewTextBoxColumn.DataPropertyName = "firmado";
            this.firmadoDataGridViewTextBoxColumn.HeaderText = "firmado";
            this.firmadoDataGridViewTextBoxColumn.Name = "firmadoDataGridViewTextBoxColumn";
            // 
            // fechaEntradaDataGridViewTextBoxColumn
            // 
            this.fechaEntradaDataGridViewTextBoxColumn.DataPropertyName = "fechaEntrada";
            this.fechaEntradaDataGridViewTextBoxColumn.HeaderText = "fechaEntrada";
            this.fechaEntradaDataGridViewTextBoxColumn.Name = "fechaEntradaDataGridViewTextBoxColumn";
            // 
            // fechaSalidaDataGridViewTextBoxColumn
            // 
            this.fechaSalidaDataGridViewTextBoxColumn.DataPropertyName = "fechaSalida";
            this.fechaSalidaDataGridViewTextBoxColumn.HeaderText = "fechaSalida";
            this.fechaSalidaDataGridViewTextBoxColumn.Name = "fechaSalidaDataGridViewTextBoxColumn";
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            // 
            // numeroHabitacionDataGridViewTextBoxColumn
            // 
            this.numeroHabitacionDataGridViewTextBoxColumn.DataPropertyName = "numeroHabitacion";
            this.numeroHabitacionDataGridViewTextBoxColumn.HeaderText = "numeroHabitacion";
            this.numeroHabitacionDataGridViewTextBoxColumn.Name = "numeroHabitacionDataGridViewTextBoxColumn";
            // 
            // temporadaIDDataGridViewTextBoxColumn
            // 
            this.temporadaIDDataGridViewTextBoxColumn.DataPropertyName = "temporadaID";
            this.temporadaIDDataGridViewTextBoxColumn.HeaderText = "temporadaID";
            this.temporadaIDDataGridViewTextBoxColumn.Name = "temporadaIDDataGridViewTextBoxColumn";
            // 
            // txtCambioTurno
            // 
            this.txtCambioTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCambioTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambioTurno.Location = new System.Drawing.Point(205, 248);
            this.txtCambioTurno.Multiline = true;
            this.txtCambioTurno.Name = "txtCambioTurno";
            this.txtCambioTurno.Size = new System.Drawing.Size(469, 110);
            this.txtCambioTurno.TabIndex = 50;
            this.txtCambioTurno.Text = "NOTAS PARA EL SIGUIENTE TURNO:";
            this.txtCambioTurno.TextChanged += new System.EventHandler(this.txtCambioTurno_TextChanged);
            // 
            // btnVerDisponibilidad
            // 
            this.btnVerDisponibilidad.Location = new System.Drawing.Point(460, 405);
            this.btnVerDisponibilidad.Name = "btnVerDisponibilidad";
            this.btnVerDisponibilidad.Size = new System.Drawing.Size(139, 23);
            this.btnVerDisponibilidad.TabIndex = 51;
            this.btnVerDisponibilidad.Text = "Ver Disponibilidad";
            this.btnVerDisponibilidad.UseVisualStyleBackColor = true;
            this.btnVerDisponibilidad.Click += new System.EventHandler(this.btnVerDisponibilidad_Click);
            // 
            // btnVerFacturas
            // 
            this.btnVerFacturas.Location = new System.Drawing.Point(310, 405);
            this.btnVerFacturas.Name = "btnVerFacturas";
            this.btnVerFacturas.Size = new System.Drawing.Size(139, 23);
            this.btnVerFacturas.TabIndex = 52;
            this.btnVerFacturas.Text = "Ver Facturas";
            this.btnVerFacturas.UseVisualStyleBackColor = true;
            this.btnVerFacturas.Click += new System.EventHandler(this.btnVerFacturas_Click);
            // 
            // labelCheckInHecho
            // 
            this.labelCheckInHecho.AutoSize = true;
            this.labelCheckInHecho.BackColor = System.Drawing.Color.Lime;
            this.labelCheckInHecho.Location = new System.Drawing.Point(205, 220);
            this.labelCheckInHecho.Name = "labelCheckInHecho";
            this.labelCheckInHecho.Size = new System.Drawing.Size(82, 13);
            this.labelCheckInHecho.TabIndex = 53;
            this.labelCheckInHecho.Text = "CheckIn Hecho";
            // 
            // labelCheckInPendiente
            // 
            this.labelCheckInPendiente.AutoSize = true;
            this.labelCheckInPendiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelCheckInPendiente.Location = new System.Drawing.Point(307, 220);
            this.labelCheckInPendiente.Name = "labelCheckInPendiente";
            this.labelCheckInPendiente.Size = new System.Drawing.Size(98, 13);
            this.labelCheckInPendiente.TabIndex = 54;
            this.labelCheckInPendiente.Text = "CheckIn Pendiente";
            // 
            // labelConfirmacionPendiente
            // 
            this.labelConfirmacionPendiente.AutoSize = true;
            this.labelConfirmacionPendiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelConfirmacionPendiente.Location = new System.Drawing.Point(426, 220);
            this.labelConfirmacionPendiente.Name = "labelConfirmacionPendiente";
            this.labelConfirmacionPendiente.Size = new System.Drawing.Size(119, 13);
            this.labelConfirmacionPendiente.TabIndex = 55;
            this.labelConfirmacionPendiente.Text = "Confirmación Pendiente";
            // 
            // btnGuardarNota
            // 
            this.btnGuardarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarNota.Location = new System.Drawing.Point(205, 357);
            this.btnGuardarNota.Name = "btnGuardarNota";
            this.btnGuardarNota.Size = new System.Drawing.Size(469, 25);
            this.btnGuardarNota.TabIndex = 56;
            this.btnGuardarNota.Text = "Guardar";
            this.btnGuardarNota.UseVisualStyleBackColor = false;
            // 
            // FrmMenuInicio
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
            this.Name = "FrmMenuInicio";
            this.Text = "Menú Inicio";
            this.Load += new System.EventHandler(this.FrmMenuInicio_Load);
            this.grpClientes.ResumeLayout(false);
            this.grpClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.Button btnNuevaReserva;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.Button ajustesbtn;
        private System.Windows.Forms.Button Usuariosbtn;
        private System.Windows.Forms.Button incidenciasbtn;
        private System.Windows.Forms.Button facturasBtn;
        private System.Windows.Forms.Button SrvidioBtn;
        private System.Windows.Forms.Button habitacionesBtn;
        private System.Windows.Forms.Button reservasVtb;
        private System.Windows.Forms.Button ClientesBtn;
        private System.Windows.Forms.Button inicioBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.BindingSource hotelSQLDataSetBindingSource1;
        private HotelSQLDataSet hotelSQLDataSet;
        private System.Windows.Forms.BindingSource hotelSQLDataSetBindingSource;
        private HotelSQLDataSet1 hotelSQLDataSet1;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private HotelSQLDataSet1TableAdapters.ReservasTableAdapter reservasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroHabitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporadaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCambioTurno;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelConfirmacionPendiente;
        private System.Windows.Forms.Label labelCheckInPendiente;
        private System.Windows.Forms.Label labelCheckInHecho;
        private System.Windows.Forms.Button btnVerFacturas;
        private System.Windows.Forms.Button btnVerDisponibilidad;
        private System.Windows.Forms.Button btnGuardarNota;
    }
}