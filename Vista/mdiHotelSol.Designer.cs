namespace Producto_2.Vista
{
    partial class mdiHotelSol
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiHotelSol));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.mnuInicio = new System.Windows.Forms.ToolStripButton();
            this.mnuClientes = new System.Windows.Forms.ToolStripButton();
            this.mnuReservas = new System.Windows.Forms.ToolStripButton();
            this.mnuHabitaciones = new System.Windows.Forms.ToolStripButton();
            this.mnuServicios = new System.Windows.Forms.ToolStripButton();
            this.mnuFacturas = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mnuImportarXML = new System.Windows.Forms.ToolStripButton();
            this.mnuExportarXML = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(91, 46);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInicio,
            this.mnuClientes,
            this.mnuReservas,
            this.mnuHabitaciones,
            this.mnuServicios,
            this.mnuFacturas,
            this.toolStripSeparator1,
            this.mnuImportarXML,
            this.mnuExportarXML});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(824, 53);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // mnuInicio
            // 
            this.mnuInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuInicio.Image = ((System.Drawing.Image)(resources.GetObject("mnuInicio.Image")));
            this.mnuInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuInicio.Name = "mnuInicio";
            this.mnuInicio.Size = new System.Drawing.Size(95, 50);
            this.mnuInicio.ToolTipText = "Inicio";
            this.mnuInicio.Click += new System.EventHandler(this.mnuInicio_Click);
            // 
            // mnuClientes
            // 
            this.mnuClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuClientes.Image = ((System.Drawing.Image)(resources.GetObject("mnuClientes.Image")));
            this.mnuClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.mnuClientes.Size = new System.Drawing.Size(95, 50);
            this.mnuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.mnuClientes.ToolTipText = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.mnuClientes_Click);
            // 
            // mnuReservas
            // 
            this.mnuReservas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuReservas.Image = ((System.Drawing.Image)(resources.GetObject("mnuReservas.Image")));
            this.mnuReservas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuReservas.Name = "mnuReservas";
            this.mnuReservas.Size = new System.Drawing.Size(95, 50);
            this.mnuReservas.ToolTipText = "Reservas";
            this.mnuReservas.Click += new System.EventHandler(this.mnuReservas_Click);
            // 
            // mnuHabitaciones
            // 
            this.mnuHabitaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuHabitaciones.Image = ((System.Drawing.Image)(resources.GetObject("mnuHabitaciones.Image")));
            this.mnuHabitaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuHabitaciones.Name = "mnuHabitaciones";
            this.mnuHabitaciones.Size = new System.Drawing.Size(95, 50);
            this.mnuHabitaciones.ToolTipText = "Habitaciones";
            this.mnuHabitaciones.Click += new System.EventHandler(this.mnuHabitaciones_Click);
            // 
            // mnuServicios
            // 
            this.mnuServicios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuServicios.Image = ((System.Drawing.Image)(resources.GetObject("mnuServicios.Image")));
            this.mnuServicios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuServicios.Name = "mnuServicios";
            this.mnuServicios.Size = new System.Drawing.Size(95, 50);
            this.mnuServicios.ToolTipText = "Servicios";
            this.mnuServicios.Click += new System.EventHandler(this.mnuServicios_Click);
            // 
            // mnuFacturas
            // 
            this.mnuFacturas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuFacturas.Image = ((System.Drawing.Image)(resources.GetObject("mnuFacturas.Image")));
            this.mnuFacturas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFacturas.Name = "mnuFacturas";
            this.mnuFacturas.Size = new System.Drawing.Size(95, 50);
            this.mnuFacturas.ToolTipText = "Facturas";
            this.mnuFacturas.Click += new System.EventHandler(this.mnuFacturas_Click);
            // 
            // mnuImportarXML
            // 
            this.mnuImportarXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuImportarXML.Image = ((System.Drawing.Image)(resources.GetObject("mnuImportarXML.Image")));
            this.mnuImportarXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuImportarXML.Name = "mnuImportarXML";
            this.mnuImportarXML.Size = new System.Drawing.Size(95, 50);
            this.mnuImportarXML.Text = "toolStripButton1";
            this.mnuImportarXML.ToolTipText = "Importar";
            this.mnuImportarXML.Click += new System.EventHandler(this.mnuImportarXML_Click);
            // 
            // mnuExportarXML
            // 
            this.mnuExportarXML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuExportarXML.Image = ((System.Drawing.Image)(resources.GetObject("mnuExportarXML.Image")));
            this.mnuExportarXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuExportarXML.Name = "mnuExportarXML";
            this.mnuExportarXML.Size = new System.Drawing.Size(95, 50);
            this.mnuExportarXML.Text = "toolStripButton2";
            this.mnuExportarXML.ToolTipText = "Exportar";
            this.mnuExportarXML.Click += new System.EventHandler(this.mnuExportarXML_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // mdiHotelSol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 641);
            this.Controls.Add(this.toolStrip);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mdiHotelSol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "mdiHotelSol";
            this.Load += new System.EventHandler(this.mdiHotelSol_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton mnuClientes;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton mnuInicio;
        private System.Windows.Forms.ToolStripButton mnuReservas;
        private System.Windows.Forms.ToolStripButton mnuHabitaciones;
        private System.Windows.Forms.ToolStripButton mnuServicios;
        private System.Windows.Forms.ToolStripButton mnuFacturas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnuImportarXML;
        private System.Windows.Forms.ToolStripButton mnuExportarXML;
    }
}



