﻿namespace Producto_2.Vista
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
            this.mnuUsuarios = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.mnuUsuarios});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(798, 53);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // mnuInicio
            // 
            this.mnuInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuInicio.Image = ((System.Drawing.Image)(resources.GetObject("mnuInicio.Image")));
            this.mnuInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuInicio.Name = "mnuInicio";
            this.mnuInicio.Size = new System.Drawing.Size(88, 50);
            this.mnuInicio.Text = "toolStripButton1";
            this.mnuInicio.ToolTipText = "Inicio";
            this.mnuInicio.Click += new System.EventHandler(this.mnuInicio_Click);
            // 
            // mnuClientes
            // 
            this.mnuClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuClientes.Image = ((System.Drawing.Image)(resources.GetObject("mnuClientes.Image")));
            this.mnuClientes.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.mnuClientes.Size = new System.Drawing.Size(88, 50);
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
            this.mnuReservas.Text = "toolStripButton2";
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
            this.mnuHabitaciones.Text = "toolStripButton3";
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
            this.mnuServicios.Text = "mnuServicios";
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
            this.mnuFacturas.Text = "toolStripButton1";
            this.mnuFacturas.ToolTipText = "Facturas";
            this.mnuFacturas.Click += new System.EventHandler(this.mnuFacturas_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("mnuUsuarios.Image")));
            this.mnuUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(95, 50);
            this.mnuUsuarios.Text = "toolStripButton1";
            this.mnuUsuarios.ToolTipText = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mdiHotelSol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 641);
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
        private System.Windows.Forms.ToolStripButton mnuUsuarios;
    }
}



