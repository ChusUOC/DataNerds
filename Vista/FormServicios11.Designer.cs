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
            this.addServiceBTN = new System.Windows.Forms.Button();
            this.serviciosDG = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.servicioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
=======
>>>>>>> juan
            this.TEMPORADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioNocheG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscVipG = new System.Windows.Forms.DataGridViewTextBoxColumn();
<<<<<<< HEAD
=======
            this.servicioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
>>>>>>> juan
            this.grpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpClientes
            // 
            this.grpClientes.Controls.Add(this.addServiceBTN);
            this.grpClientes.Controls.Add(this.serviciosDG);
            this.grpClientes.Controls.Add(this.dataGridView1);
<<<<<<< HEAD
            this.grpClientes.Location = new System.Drawing.Point(12, 94);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(778, 432);
=======
            this.grpClientes.Location = new System.Drawing.Point(12, 29);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(778, 497);
>>>>>>> juan
            this.grpClientes.TabIndex = 29;
            this.grpClientes.TabStop = false;
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
            // serviciosDG
            // 
            this.serviciosDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviciosDG.Location = new System.Drawing.Point(6, 44);
            this.serviciosDG.Name = "serviciosDG";
            this.serviciosDG.Size = new System.Drawing.Size(766, 281);
            this.serviciosDG.TabIndex = 1;
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
<<<<<<< HEAD
            // servicioBindingSource1
            // 
            this.servicioBindingSource1.DataMember = "Servicio";
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "Servicio";
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
=======
>>>>>>> juan
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
            this.dscVipG.HeaderText = "VIP";
            this.dscVipG.Name = "dscVipG";
            this.dscVipG.ReadOnly = true;
            this.dscVipG.Width = 60;
            // 
<<<<<<< HEAD
=======
            // servicioBindingSource1
            // 
            this.servicioBindingSource1.DataMember = "Servicio";
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "Servicio";
            // 
            // tipoServicioBindingSource
            // 
            this.tipoServicioBindingSource.DataMember = "TipoServicio";
            // 
>>>>>>> juan
            // FormServicios11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 538);
<<<<<<< HEAD
            this.Controls.Add(this.facturasBtn);
            this.Controls.Add(this.ajustesbtn);
            this.Controls.Add(this.Usuariosbtn);
            this.Controls.Add(this.incidenciasbtn);
            this.Controls.Add(this.SrvidioBtn);
            this.Controls.Add(this.habitacionesBtn);
            this.Controls.Add(this.reservasVtb);
            this.Controls.Add(this.ClientesBtn);
            this.Controls.Add(this.inicioBtn);
=======
>>>>>>> juan
            this.Controls.Add(this.grpClientes);
            this.Name = "FormServicios11";
            this.Text = "FormServicios11";
            this.Load += new System.EventHandler(this.FormServicios11_Load);
            this.grpClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClientes;
<<<<<<< HEAD
        private System.Windows.Forms.Button facturasBtn;
        private System.Windows.Forms.Button ajustesbtn;
        private System.Windows.Forms.Button Usuariosbtn;
        private System.Windows.Forms.Button incidenciasbtn;
        private System.Windows.Forms.Button SrvidioBtn;
        private System.Windows.Forms.Button habitacionesBtn;
        private System.Windows.Forms.Button reservasVtb;
        private System.Windows.Forms.Button ClientesBtn;
        private System.Windows.Forms.Button inicioBtn;
=======
>>>>>>> juan
        private System.Windows.Forms.DataGridView serviciosDG;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tipoServicioBindingSource;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioBajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permisoAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permisoMediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permisoBajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descVIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addServiceBTN;
        private System.Windows.Forms.BindingSource servicioBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMPORADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioNocheG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscVipG;
    }
}