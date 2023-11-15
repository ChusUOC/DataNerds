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
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.labelConfirmacionPendiente = new System.Windows.Forms.Label();
            this.labelCheckInPendiente = new System.Windows.Forms.Label();
            this.labelCheckInHecho = new System.Windows.Forms.Label();
            this.btnVerFacturas = new System.Windows.Forms.Button();
            this.btnVerDisponibilidad = new System.Windows.Forms.Button();
            this.txtCambioTurno = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dbGrid = new System.Windows.Forms.DataGridView();
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelSQLDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelSQLDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.grpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSetBindingSource1)).BeginInit();
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
            this.grpClientes.Location = new System.Drawing.Point(59, 27);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(680, 488);
            this.grpClientes.TabIndex = 38;
            this.grpClientes.TabStop = false;
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
            this.dbGrid.DataSource = this.reservasBindingSource;
            this.dbGrid.Location = new System.Drawing.Point(0, 10);
            this.dbGrid.Name = "dbGrid";
            this.dbGrid.Size = new System.Drawing.Size(674, 198);
            this.dbGrid.TabIndex = 28;
            this.dbGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGrid_CellContentClick);
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataMember = "Reservas";
            // 
            // FrmMenuInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 538);
            this.Controls.Add(this.grpClientes);
            this.Name = "FrmMenuInicio";
            this.Text = "Menú Inicio";
            this.Load += new System.EventHandler(this.FrmMenuInicio_Load);
            this.grpClientes.ResumeLayout(false);
            this.grpClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelSQLDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.Button btnNuevaReserva;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dbGrid;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.BindingSource hotelSQLDataSetBindingSource1;
       // private HotelSQLDataSet hotelSQLDataSet;
        private System.Windows.Forms.BindingSource hotelSQLDataSetBindingSource;
       // private HotelSQLDataSet1 hotelSQLDataSet1;
        private System.Windows.Forms.BindingSource reservasBindingSource;
       // private HotelSQLDataSet1TableAdapters.ReservasTableAdapter reservasTableAdapter;
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