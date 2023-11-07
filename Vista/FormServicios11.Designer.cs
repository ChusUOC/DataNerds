namespace Producto_2.Vista
{
    partial class FormServicios11
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facturasBtn = new System.Windows.Forms.Button();
            this.ajustesbtn = new System.Windows.Forms.Button();
            this.Usuariosbtn = new System.Windows.Forms.Button();
            this.incidenciasbtn = new System.Windows.Forms.Button();
            this.SrvidioBtn = new System.Windows.Forms.Button();
            this.habitacionesBtn = new System.Windows.Forms.Button();
            this.reservasVtb = new System.Windows.Forms.Button();
            this.ClientesBtn = new System.Windows.Forms.Button();
            this.inicioBtn = new System.Windows.Forms.Button();
            this.tipoServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviciosDS = new Producto_2.serviciosDS();
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioTableAdapter = new Producto_2.serviciosDSTableAdapters.ServicioTableAdapter();
            this.idServicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicioIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioAltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioBajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioMediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisoAltaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisoMediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisoBajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descVIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEMPORADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioNocheG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscVipG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addServiceBTN = new System.Windows.Forms.Button();
            this.grpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpClientes
            // 
            this.grpClientes.Controls.Add(this.addServiceBTN);
            this.grpClientes.Controls.Add(this.dataGridView2);
            this.grpClientes.Controls.Add(this.dataGridView1);
            this.grpClientes.Location = new System.Drawing.Point(12, 94);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(778, 432);
            this.grpClientes.TabIndex = 29;
            this.grpClientes.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idServicioDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.tipoServicioIDDataGridViewTextBoxColumn,
            this.precioAltaDataGridViewTextBoxColumn,
            this.precioBajaDataGridViewTextBoxColumn,
            this.precioMediaDataGridViewTextBoxColumn,
            this.permisoAltaDataGridViewTextBoxColumn,
            this.permisoMediaDataGridViewTextBoxColumn,
            this.permisoBajaDataGridViewTextBoxColumn,
            this.descVIPDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.servicioBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(766, 281);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEMPORADA,
            this.MEDIA,
            this.BAJA,
            this.ALTA,
            this.precioNocheG,
            this.dscVipG});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(766, 29);
            this.dataGridView1.TabIndex = 0;
            // 
            // facturasBtn
            // 
            this.facturasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturasBtn.Location = new System.Drawing.Point(436, 29);
            this.facturasBtn.Name = "facturasBtn";
            this.facturasBtn.Size = new System.Drawing.Size(74, 42);
            this.facturasBtn.TabIndex = 38;
            this.facturasBtn.Text = "Facturas";
            this.facturasBtn.UseVisualStyleBackColor = true;
            // 
            // ajustesbtn
            // 
            this.ajustesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajustesbtn.Location = new System.Drawing.Point(661, 29);
            this.ajustesbtn.Name = "ajustesbtn";
            this.ajustesbtn.Size = new System.Drawing.Size(74, 42);
            this.ajustesbtn.TabIndex = 37;
            this.ajustesbtn.Text = "Ajustes";
            this.ajustesbtn.UseVisualStyleBackColor = true;
            // 
            // Usuariosbtn
            // 
            this.Usuariosbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuariosbtn.Location = new System.Drawing.Point(586, 29);
            this.Usuariosbtn.Name = "Usuariosbtn";
            this.Usuariosbtn.Size = new System.Drawing.Size(74, 42);
            this.Usuariosbtn.TabIndex = 36;
            this.Usuariosbtn.Text = "Usuarios";
            this.Usuariosbtn.UseVisualStyleBackColor = true;
            // 
            // incidenciasbtn
            // 
            this.incidenciasbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidenciasbtn.Location = new System.Drawing.Point(511, 29);
            this.incidenciasbtn.Name = "incidenciasbtn";
            this.incidenciasbtn.Size = new System.Drawing.Size(74, 42);
            this.incidenciasbtn.TabIndex = 35;
            this.incidenciasbtn.Text = "Incidencias";
            this.incidenciasbtn.UseVisualStyleBackColor = true;
            // 
            // SrvidioBtn
            // 
            this.SrvidioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrvidioBtn.Location = new System.Drawing.Point(361, 29);
            this.SrvidioBtn.Name = "SrvidioBtn";
            this.SrvidioBtn.Size = new System.Drawing.Size(74, 42);
            this.SrvidioBtn.TabIndex = 34;
            this.SrvidioBtn.Text = "Servicio";
            this.SrvidioBtn.UseVisualStyleBackColor = true;
            // 
            // habitacionesBtn
            // 
            this.habitacionesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitacionesBtn.Location = new System.Drawing.Point(286, 29);
            this.habitacionesBtn.Name = "habitacionesBtn";
            this.habitacionesBtn.Size = new System.Drawing.Size(74, 42);
            this.habitacionesBtn.TabIndex = 33;
            this.habitacionesBtn.Text = "Habitaciones";
            this.habitacionesBtn.UseVisualStyleBackColor = true;
            // 
            // reservasVtb
            // 
            this.reservasVtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservasVtb.Location = new System.Drawing.Point(211, 29);
            this.reservasVtb.Name = "reservasVtb";
            this.reservasVtb.Size = new System.Drawing.Size(74, 42);
            this.reservasVtb.TabIndex = 32;
            this.reservasVtb.Text = "Reservas";
            this.reservasVtb.UseVisualStyleBackColor = true;
            // 
            // ClientesBtn
            // 
            this.ClientesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientesBtn.Location = new System.Drawing.Point(136, 29);
            this.ClientesBtn.Name = "ClientesBtn";
            this.ClientesBtn.Size = new System.Drawing.Size(74, 42);
            this.ClientesBtn.TabIndex = 31;
            this.ClientesBtn.Text = "Clientes";
            this.ClientesBtn.UseVisualStyleBackColor = true;
            // 
            // inicioBtn
            // 
            this.inicioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioBtn.Location = new System.Drawing.Point(61, 29);
            this.inicioBtn.Name = "inicioBtn";
            this.inicioBtn.Size = new System.Drawing.Size(74, 42);
            this.inicioBtn.TabIndex = 30;
            this.inicioBtn.Text = "Inicio";
            this.inicioBtn.UseVisualStyleBackColor = true;
            // 
            // tipoServicioBindingSource
            // 
            this.tipoServicioBindingSource.DataMember = "TipoServicio";
            // 
            // serviciosDS
            // 
            this.serviciosDS.DataSetName = "serviciosDS";
            this.serviciosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "Servicio";
            this.servicioBindingSource.DataSource = this.serviciosDS;
            // 
            // servicioTableAdapter
            // 
            this.servicioTableAdapter.ClearBeforeFill = true;
            // 
            // idServicioDataGridViewTextBoxColumn
            // 
            this.idServicioDataGridViewTextBoxColumn.DataPropertyName = "idServicio";
            this.idServicioDataGridViewTextBoxColumn.HeaderText = "";
            this.idServicioDataGridViewTextBoxColumn.Name = "idServicioDataGridViewTextBoxColumn";
            this.idServicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idServicioDataGridViewTextBoxColumn.Width = 40;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Temporada";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // tipoServicioIDDataGridViewTextBoxColumn
            // 
            this.tipoServicioIDDataGridViewTextBoxColumn.DataPropertyName = "tipoServicioID";
            this.tipoServicioIDDataGridViewTextBoxColumn.HeaderText = "";
            this.tipoServicioIDDataGridViewTextBoxColumn.Name = "tipoServicioIDDataGridViewTextBoxColumn";
            // 
            // precioAltaDataGridViewTextBoxColumn
            // 
            this.precioAltaDataGridViewTextBoxColumn.DataPropertyName = "precioAlta";
            this.precioAltaDataGridViewTextBoxColumn.HeaderText = "Alta";
            this.precioAltaDataGridViewTextBoxColumn.Name = "precioAltaDataGridViewTextBoxColumn";
            this.precioAltaDataGridViewTextBoxColumn.Width = 70;
            // 
            // precioBajaDataGridViewTextBoxColumn
            // 
            this.precioBajaDataGridViewTextBoxColumn.DataPropertyName = "precioBaja";
            this.precioBajaDataGridViewTextBoxColumn.HeaderText = "Baja";
            this.precioBajaDataGridViewTextBoxColumn.Name = "precioBajaDataGridViewTextBoxColumn";
            this.precioBajaDataGridViewTextBoxColumn.Width = 70;
            // 
            // precioMediaDataGridViewTextBoxColumn
            // 
            this.precioMediaDataGridViewTextBoxColumn.DataPropertyName = "precioMedia";
            this.precioMediaDataGridViewTextBoxColumn.HeaderText = "Media";
            this.precioMediaDataGridViewTextBoxColumn.Name = "precioMediaDataGridViewTextBoxColumn";
            this.precioMediaDataGridViewTextBoxColumn.Width = 70;
            // 
            // permisoAltaDataGridViewTextBoxColumn
            // 
            this.permisoAltaDataGridViewTextBoxColumn.DataPropertyName = "permisoAlta";
            this.permisoAltaDataGridViewTextBoxColumn.HeaderText = "Alta";
            this.permisoAltaDataGridViewTextBoxColumn.Name = "permisoAltaDataGridViewTextBoxColumn";
            this.permisoAltaDataGridViewTextBoxColumn.Width = 70;
            // 
            // permisoMediaDataGridViewTextBoxColumn
            // 
            this.permisoMediaDataGridViewTextBoxColumn.DataPropertyName = "permisoMedia";
            this.permisoMediaDataGridViewTextBoxColumn.HeaderText = "Media";
            this.permisoMediaDataGridViewTextBoxColumn.Name = "permisoMediaDataGridViewTextBoxColumn";
            this.permisoMediaDataGridViewTextBoxColumn.Width = 70;
            // 
            // permisoBajaDataGridViewTextBoxColumn
            // 
            this.permisoBajaDataGridViewTextBoxColumn.DataPropertyName = "permisoBaja";
            this.permisoBajaDataGridViewTextBoxColumn.HeaderText = "Baja";
            this.permisoBajaDataGridViewTextBoxColumn.Name = "permisoBajaDataGridViewTextBoxColumn";
            this.permisoBajaDataGridViewTextBoxColumn.Width = 70;
            // 
            // descVIPDataGridViewTextBoxColumn
            // 
            this.descVIPDataGridViewTextBoxColumn.DataPropertyName = "descVIP";
            this.descVIPDataGridViewTextBoxColumn.HeaderText = "";
            this.descVIPDataGridViewTextBoxColumn.Name = "descVIPDataGridViewTextBoxColumn";
            this.descVIPDataGridViewTextBoxColumn.Width = 60;
            // 
            // TEMPORADA
            // 
            this.TEMPORADA.HeaderText = "ID";
            this.TEMPORADA.Name = "TEMPORADA";
            this.TEMPORADA.ReadOnly = true;
            this.TEMPORADA.Width = 40;
            // 
            // MEDIA
            // 
            this.MEDIA.HeaderText = "DESCRIPCION";
            this.MEDIA.Name = "MEDIA";
            this.MEDIA.ReadOnly = true;
            // 
            // BAJA
            // 
            this.BAJA.HeaderText = "TIPO";
            this.BAJA.Name = "BAJA";
            this.BAJA.ReadOnly = true;
            // 
            // ALTA
            // 
            this.ALTA.HeaderText = "PERMITIDO";
            this.ALTA.Name = "ALTA";
            this.ALTA.ReadOnly = true;
            this.ALTA.Width = 210;
            // 
            // precioNocheG
            // 
            this.precioNocheG.HeaderText = "PRECIO NOCHE";
            this.precioNocheG.Name = "precioNocheG";
            this.precioNocheG.ReadOnly = true;
            this.precioNocheG.Width = 210;
            // 
            // dscVipG
            // 
            this.dscVipG.HeaderText = "DESC VIP";
            this.dscVipG.Name = "dscVipG";
            this.dscVipG.ReadOnly = true;
            // 
            // addServiceBTN
            // 
            this.addServiceBTN.Location = new System.Drawing.Point(301, 353);
            this.addServiceBTN.Name = "addServiceBTN";
            this.addServiceBTN.Size = new System.Drawing.Size(197, 23);
            this.addServiceBTN.TabIndex = 2;
            this.addServiceBTN.Text = "Add nuevo servicio";
            this.addServiceBTN.UseVisualStyleBackColor = true;
            // 
            // FormServicios11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 538);
            this.Controls.Add(this.facturasBtn);
            this.Controls.Add(this.ajustesbtn);
            this.Controls.Add(this.Usuariosbtn);
            this.Controls.Add(this.incidenciasbtn);
            this.Controls.Add(this.SrvidioBtn);
            this.Controls.Add(this.habitacionesBtn);
            this.Controls.Add(this.reservasVtb);
            this.Controls.Add(this.ClientesBtn);
            this.Controls.Add(this.inicioBtn);
            this.Controls.Add(this.grpClientes);
            this.Name = "FormServicios11";
            this.Text = "FormServicios11";
            this.Load += new System.EventHandler(this.FormServicios11_Load);
            this.grpClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.Button facturasBtn;
        private System.Windows.Forms.Button ajustesbtn;
        private System.Windows.Forms.Button Usuariosbtn;
        private System.Windows.Forms.Button incidenciasbtn;
        private System.Windows.Forms.Button SrvidioBtn;
        private System.Windows.Forms.Button habitacionesBtn;
        private System.Windows.Forms.Button reservasVtb;
        private System.Windows.Forms.Button ClientesBtn;
        private System.Windows.Forms.Button inicioBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tipoServicioBindingSource;
        private serviciosDS serviciosDS;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private serviciosDSTableAdapters.ServicioTableAdapter servicioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicioIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioBajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioMediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permisoAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permisoMediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permisoBajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descVIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMPORADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioNocheG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscVipG;
        private System.Windows.Forms.Button addServiceBTN;
    }
}