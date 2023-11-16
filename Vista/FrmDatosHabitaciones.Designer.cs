namespace Producto_2.Vista
{
    partial class FrmDatosHabitaciones
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
            this.grpClientes = new System.Windows.Forms.GroupBox();
            this.numericUpDownMaxPersonas = new System.Windows.Forms.NumericUpDown();
            this.checkClienteVip = new System.Windows.Forms.CheckBox();
            this.checkFueraDeServicio = new System.Windows.Forms.CheckBox();
            this.numUpDownPvPxNocheTMedia = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPvPxNocheTAlta = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPvPxNocheTBaja = new System.Windows.Forms.NumericUpDown();
            this.labelPrecioNoche = new System.Windows.Forms.Label();
            this.labelTempMedia = new System.Windows.Forms.Label();
            this.labelTempAlta = new System.Windows.Forms.Label();
            this.comboBoxTipoHab = new System.Windows.Forms.ComboBox();
            this.checkCamaExtra = new System.Windows.Forms.CheckBox();
            this.labelTipoHabitacion = new System.Windows.Forms.Label();
            this.BtnGuardarHabitacion = new System.Windows.Forms.Button();
            this.textBoxMinNocheTAlta = new System.Windows.Forms.TextBox();
            this.labelMinNoches = new System.Windows.Forms.Label();
            this.textBoxMinNocheTMedia = new System.Windows.Forms.TextBox();
            this.labelTempBaja = new System.Windows.Forms.Label();
            this.textBoxMinNocheTBaja = new System.Windows.Forms.TextBox();
            this.labelMaxPersonas = new System.Windows.Forms.Label();
            this.LabelNumHabitacion = new System.Windows.Forms.Label();
            this.textBoxNumHabitacion = new System.Windows.Forms.TextBox();
            this.labelDHabitacion = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.grpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPvPxNocheTMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPvPxNocheTAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPvPxNocheTBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // grpClientes
            // 
            this.grpClientes.Controls.Add(this.numericUpDownMaxPersonas);
            this.grpClientes.Controls.Add(this.checkClienteVip);
            this.grpClientes.Controls.Add(this.checkFueraDeServicio);
            this.grpClientes.Controls.Add(this.numUpDownPvPxNocheTMedia);
            this.grpClientes.Controls.Add(this.numUpDownPvPxNocheTAlta);
            this.grpClientes.Controls.Add(this.numUpDownPvPxNocheTBaja);
            this.grpClientes.Controls.Add(this.labelPrecioNoche);
            this.grpClientes.Controls.Add(this.labelTempMedia);
            this.grpClientes.Controls.Add(this.labelTempAlta);
            this.grpClientes.Controls.Add(this.comboBoxTipoHab);
            this.grpClientes.Controls.Add(this.checkCamaExtra);
            this.grpClientes.Controls.Add(this.labelTipoHabitacion);
            this.grpClientes.Controls.Add(this.BtnGuardarHabitacion);
            this.grpClientes.Controls.Add(this.textBoxMinNocheTAlta);
            this.grpClientes.Controls.Add(this.labelMinNoches);
            this.grpClientes.Controls.Add(this.textBoxMinNocheTMedia);
            this.grpClientes.Controls.Add(this.labelTempBaja);
            this.grpClientes.Controls.Add(this.textBoxMinNocheTBaja);
            this.grpClientes.Controls.Add(this.labelMaxPersonas);
            this.grpClientes.Controls.Add(this.LabelNumHabitacion);
            this.grpClientes.Controls.Add(this.textBoxNumHabitacion);
            this.grpClientes.Controls.Add(this.labelDHabitacion);
            this.grpClientes.Controls.Add(this.BtnCancelar);
            this.grpClientes.Location = new System.Drawing.Point(59, 30);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(680, 485);
            this.grpClientes.TabIndex = 38;
            this.grpClientes.TabStop = false;
            // 
            // numericUpDownMaxPersonas
            // 
            this.numericUpDownMaxPersonas.Location = new System.Drawing.Point(141, 160);
            this.numericUpDownMaxPersonas.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownMaxPersonas.Name = "numericUpDownMaxPersonas";
            this.numericUpDownMaxPersonas.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownMaxPersonas.TabIndex = 59;
            this.numericUpDownMaxPersonas.ValueChanged += new System.EventHandler(this.numericUpDownMaxPersonas_ValueChanged);
            // 
            // checkClienteVip
            // 
            this.checkClienteVip.AutoSize = true;
            this.checkClienteVip.Location = new System.Drawing.Point(415, 128);
            this.checkClienteVip.Name = "checkClienteVip";
            this.checkClienteVip.Size = new System.Drawing.Size(180, 17);
            this.checkClienteVip.TabIndex = 58;
            this.checkClienteVip.Text = "¿Permite descuento cliente VIP?";
            this.checkClienteVip.UseVisualStyleBackColor = true;
            this.checkClienteVip.CheckedChanged += new System.EventHandler(this.checkClienteVip_CheckedChanged);
            // 
            // checkFueraDeServicio
            // 
            this.checkFueraDeServicio.AutoSize = true;
            this.checkFueraDeServicio.Location = new System.Drawing.Point(415, 160);
            this.checkFueraDeServicio.Name = "checkFueraDeServicio";
            this.checkFueraDeServicio.Size = new System.Drawing.Size(140, 17);
            this.checkFueraDeServicio.TabIndex = 57;
            this.checkFueraDeServicio.Text = "¿Está fuera de servicio?";
            this.checkFueraDeServicio.UseVisualStyleBackColor = true;
            this.checkFueraDeServicio.CheckedChanged += new System.EventHandler(this.checkFueraDeServicio_CheckedChanged);
            // 
            // numUpDownPvPxNocheTMedia
            // 
            this.numUpDownPvPxNocheTMedia.DecimalPlaces = 2;
            this.numUpDownPvPxNocheTMedia.Location = new System.Drawing.Point(248, 280);
            this.numUpDownPvPxNocheTMedia.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDownPvPxNocheTMedia.Name = "numUpDownPvPxNocheTMedia";
            this.numUpDownPvPxNocheTMedia.Size = new System.Drawing.Size(85, 20);
            this.numUpDownPvPxNocheTMedia.TabIndex = 56;
            this.numUpDownPvPxNocheTMedia.ValueChanged += new System.EventHandler(this.numUpDownPvPxNocheTMedia_ValueChanged);
            // 
            // numUpDownPvPxNocheTAlta
            // 
            this.numUpDownPvPxNocheTAlta.DecimalPlaces = 2;
            this.numUpDownPvPxNocheTAlta.Location = new System.Drawing.Point(248, 312);
            this.numUpDownPvPxNocheTAlta.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDownPvPxNocheTAlta.Name = "numUpDownPvPxNocheTAlta";
            this.numUpDownPvPxNocheTAlta.Size = new System.Drawing.Size(85, 20);
            this.numUpDownPvPxNocheTAlta.TabIndex = 55;
            this.numUpDownPvPxNocheTAlta.ValueChanged += new System.EventHandler(this.numUpDownPvPxNocheTAlta_ValueChanged);
            // 
            // numUpDownPvPxNocheTBaja
            // 
            this.numUpDownPvPxNocheTBaja.DecimalPlaces = 2;
            this.numUpDownPvPxNocheTBaja.Location = new System.Drawing.Point(248, 249);
            this.numUpDownPvPxNocheTBaja.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDownPvPxNocheTBaja.Name = "numUpDownPvPxNocheTBaja";
            this.numUpDownPvPxNocheTBaja.Size = new System.Drawing.Size(85, 20);
            this.numUpDownPvPxNocheTBaja.TabIndex = 54;
            this.numUpDownPvPxNocheTBaja.ValueChanged += new System.EventHandler(this.numUpDownPvPxNocheTBaja_ValueChanged);
            // 
            // labelPrecioNoche
            // 
            this.labelPrecioNoche.AutoSize = true;
            this.labelPrecioNoche.Location = new System.Drawing.Point(245, 216);
            this.labelPrecioNoche.Name = "labelPrecioNoche";
            this.labelPrecioNoche.Size = new System.Drawing.Size(88, 13);
            this.labelPrecioNoche.TabIndex = 53;
            this.labelPrecioNoche.Text = "Precio por noche";
            // 
            // labelTempMedia
            // 
            this.labelTempMedia.AutoSize = true;
            this.labelTempMedia.Location = new System.Drawing.Point(25, 280);
            this.labelTempMedia.Name = "labelTempMedia";
            this.labelTempMedia.Size = new System.Drawing.Size(93, 13);
            this.labelTempMedia.TabIndex = 49;
            this.labelTempMedia.Text = "Temporada Media";
            // 
            // labelTempAlta
            // 
            this.labelTempAlta.AutoSize = true;
            this.labelTempAlta.Location = new System.Drawing.Point(25, 312);
            this.labelTempAlta.Name = "labelTempAlta";
            this.labelTempAlta.Size = new System.Drawing.Size(82, 13);
            this.labelTempAlta.TabIndex = 48;
            this.labelTempAlta.Text = "Temporada Alta";
            // 
            // comboBoxTipoHab
            // 
            this.comboBoxTipoHab.FormattingEnabled = true;
            this.comboBoxTipoHab.Items.AddRange(new object[] {
            "Individual",
            "Doble",
            "Triple",
            "Cuadruple",
            "Suite"});
            this.comboBoxTipoHab.Location = new System.Drawing.Point(141, 124);
            this.comboBoxTipoHab.Name = "comboBoxTipoHab";
            this.comboBoxTipoHab.Size = new System.Drawing.Size(95, 21);
            this.comboBoxTipoHab.TabIndex = 47;
            this.comboBoxTipoHab.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoHab_SelectedIndexChanged);
            // 
            // checkCamaExtra
            // 
            this.checkCamaExtra.AutoSize = true;
            this.checkCamaExtra.Location = new System.Drawing.Point(415, 94);
            this.checkCamaExtra.Name = "checkCamaExtra";
            this.checkCamaExtra.Size = new System.Drawing.Size(128, 17);
            this.checkCamaExtra.TabIndex = 46;
            this.checkCamaExtra.Text = "¿Permite cama extra?";
            this.checkCamaExtra.UseVisualStyleBackColor = true;
            this.checkCamaExtra.CheckedChanged += new System.EventHandler(this.checkCamaExtra_CheckedChanged);
            // 
            // labelTipoHabitacion
            // 
            this.labelTipoHabitacion.AutoSize = true;
            this.labelTipoHabitacion.Location = new System.Drawing.Point(21, 124);
            this.labelTipoHabitacion.Name = "labelTipoHabitacion";
            this.labelTipoHabitacion.Size = new System.Drawing.Size(82, 13);
            this.labelTipoHabitacion.TabIndex = 45;
            this.labelTipoHabitacion.Text = "Tipo Habitación";
            this.labelTipoHabitacion.Click += new System.EventHandler(this.labelTipoHabitacion_Click_1);
            // 
            // BtnGuardarHabitacion
            // 
            this.BtnGuardarHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnGuardarHabitacion.Location = new System.Drawing.Point(97, 377);
            this.BtnGuardarHabitacion.Name = "BtnGuardarHabitacion";
            this.BtnGuardarHabitacion.Size = new System.Drawing.Size(246, 23);
            this.BtnGuardarHabitacion.TabIndex = 44;
            this.BtnGuardarHabitacion.Text = "Guardar";
            this.BtnGuardarHabitacion.UseVisualStyleBackColor = false;
            this.BtnGuardarHabitacion.Click += new System.EventHandler(this.BtnGuardarHabitacion_Click);
            // 
            // textBoxMinNocheTAlta
            // 
            this.textBoxMinNocheTAlta.Location = new System.Drawing.Point(141, 312);
            this.textBoxMinNocheTAlta.Name = "textBoxMinNocheTAlta";
            this.textBoxMinNocheTAlta.Size = new System.Drawing.Size(70, 20);
            this.textBoxMinNocheTAlta.TabIndex = 42;
            this.textBoxMinNocheTAlta.TextChanged += new System.EventHandler(this.textBoxMinNocheTAlta_TextChanged);
            // 
            // labelMinNoches
            // 
            this.labelMinNoches.AutoSize = true;
            this.labelMinNoches.Location = new System.Drawing.Point(147, 216);
            this.labelMinNoches.Name = "labelMinNoches";
            this.labelMinNoches.Size = new System.Drawing.Size(64, 13);
            this.labelMinNoches.TabIndex = 41;
            this.labelMinNoches.Text = "Min Noches";
            // 
            // textBoxMinNocheTMedia
            // 
            this.textBoxMinNocheTMedia.Location = new System.Drawing.Point(141, 280);
            this.textBoxMinNocheTMedia.Name = "textBoxMinNocheTMedia";
            this.textBoxMinNocheTMedia.Size = new System.Drawing.Size(70, 20);
            this.textBoxMinNocheTMedia.TabIndex = 40;
            this.textBoxMinNocheTMedia.TextChanged += new System.EventHandler(this.textBoxMinNocheTMedia_TextChanged);
            // 
            // labelTempBaja
            // 
            this.labelTempBaja.AutoSize = true;
            this.labelTempBaja.Location = new System.Drawing.Point(25, 249);
            this.labelTempBaja.Name = "labelTempBaja";
            this.labelTempBaja.Size = new System.Drawing.Size(85, 13);
            this.labelTempBaja.TabIndex = 39;
            this.labelTempBaja.Text = "Temporada Baja";
            // 
            // textBoxMinNocheTBaja
            // 
            this.textBoxMinNocheTBaja.Location = new System.Drawing.Point(141, 249);
            this.textBoxMinNocheTBaja.Name = "textBoxMinNocheTBaja";
            this.textBoxMinNocheTBaja.Size = new System.Drawing.Size(70, 20);
            this.textBoxMinNocheTBaja.TabIndex = 38;
            this.textBoxMinNocheTBaja.TextChanged += new System.EventHandler(this.textBoxMinNocheTBaja_TextChanged);
            // 
            // labelMaxPersonas
            // 
            this.labelMaxPersonas.AutoSize = true;
            this.labelMaxPersonas.Location = new System.Drawing.Point(25, 157);
            this.labelMaxPersonas.Name = "labelMaxPersonas";
            this.labelMaxPersonas.Size = new System.Drawing.Size(74, 13);
            this.labelMaxPersonas.TabIndex = 37;
            this.labelMaxPersonas.Text = "Max Personas";
            // 
            // LabelNumHabitacion
            // 
            this.LabelNumHabitacion.AutoSize = true;
            this.LabelNumHabitacion.Location = new System.Drawing.Point(21, 91);
            this.LabelNumHabitacion.Name = "LabelNumHabitacion";
            this.LabelNumHabitacion.Size = new System.Drawing.Size(73, 13);
            this.LabelNumHabitacion.TabIndex = 34;
            this.LabelNumHabitacion.Text = "Nº Habitación";
            // 
            // textBoxNumHabitacion
            // 
            this.textBoxNumHabitacion.Location = new System.Drawing.Point(141, 91);
            this.textBoxNumHabitacion.Name = "textBoxNumHabitacion";
            this.textBoxNumHabitacion.Size = new System.Drawing.Size(95, 20);
            this.textBoxNumHabitacion.TabIndex = 33;
            this.textBoxNumHabitacion.TextChanged += new System.EventHandler(this.textBoxNumHabitacion_TextChanged);
            // 
            // labelDHabitacion
            // 
            this.labelDHabitacion.AutoSize = true;
            this.labelDHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDHabitacion.Location = new System.Drawing.Point(21, 28);
            this.labelDHabitacion.Name = "labelDHabitacion";
            this.labelDHabitacion.Size = new System.Drawing.Size(128, 13);
            this.labelDHabitacion.TabIndex = 31;
            this.labelDHabitacion.Text = "DATOS HABITACIÓN";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCancelar.Location = new System.Drawing.Point(353, 377);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(246, 23);
            this.BtnCancelar.TabIndex = 29;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmDatosHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 538);
            this.Controls.Add(this.grpClientes);
            this.Name = "FrmDatosHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos Habitaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDatosHabitaciones_Load);
            this.grpClientes.ResumeLayout(false);
            this.grpClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPvPxNocheTMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPvPxNocheTAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPvPxNocheTBaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.CheckBox checkCamaExtra;
        private System.Windows.Forms.Label labelTipoHabitacion;
        private System.Windows.Forms.Button BtnGuardarHabitacion;
        private System.Windows.Forms.TextBox textBoxMinNocheTAlta;
        private System.Windows.Forms.Label labelMinNoches;
        private System.Windows.Forms.TextBox textBoxMinNocheTMedia;
        private System.Windows.Forms.Label labelTempBaja;
        private System.Windows.Forms.TextBox textBoxMinNocheTBaja;
        private System.Windows.Forms.Label labelMaxPersonas;
        private System.Windows.Forms.Label LabelNumHabitacion;
        private System.Windows.Forms.TextBox textBoxNumHabitacion;
        private System.Windows.Forms.Label labelDHabitacion;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox comboBoxTipoHab;
        private System.Windows.Forms.Label labelTempMedia;
        private System.Windows.Forms.Label labelTempAlta;
        private System.Windows.Forms.Label labelPrecioNoche;
        private System.Windows.Forms.NumericUpDown numUpDownPvPxNocheTMedia;
        private System.Windows.Forms.NumericUpDown numUpDownPvPxNocheTAlta;
        private System.Windows.Forms.NumericUpDown numUpDownPvPxNocheTBaja;
        private System.Windows.Forms.CheckBox checkClienteVip;
        private System.Windows.Forms.CheckBox checkFueraDeServicio;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxPersonas;
    }
}