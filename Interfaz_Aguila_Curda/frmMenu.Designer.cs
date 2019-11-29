namespace Interfaz_Aguila_Curda
{
	partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDevolucion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.tsmSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCliente,
            this.tsmProveedor,
            this.tsmArticulo});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // tsmCliente
            // 
            this.tsmCliente.Name = "tsmCliente";
            this.tsmCliente.Size = new System.Drawing.Size(224, 26);
            this.tsmCliente.Text = "Cliente";
            this.tsmCliente.Click += new System.EventHandler(this.tsmCliente_Click);
            // 
            // tsmProveedor
            // 
            this.tsmProveedor.Name = "tsmProveedor";
            this.tsmProveedor.Size = new System.Drawing.Size(224, 26);
            this.tsmProveedor.Text = "Proveedor";
            this.tsmProveedor.Click += new System.EventHandler(this.tsmProveedor_Click);
            // 
            // tsmArticulo
            // 
            this.tsmArticulo.Name = "tsmArticulo";
            this.tsmArticulo.Size = new System.Drawing.Size(224, 26);
            this.tsmArticulo.Text = "Articulo";
            this.tsmArticulo.Click += new System.EventHandler(this.tsmArticulo_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDevolucion,
            this.tsmFactura,
            this.tsmCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // tsmDevolucion
            // 
            this.tsmDevolucion.Name = "tsmDevolucion";
            this.tsmDevolucion.Size = new System.Drawing.Size(224, 26);
            this.tsmDevolucion.Text = "Devolucion";
            this.tsmDevolucion.Click += new System.EventHandler(this.tsmDevolucion_Click_1);
            // 
            // tsmFactura
            // 
            this.tsmFactura.Name = "tsmFactura";
            this.tsmFactura.Size = new System.Drawing.Size(224, 26);
            this.tsmFactura.Text = "Factura";
            this.tsmFactura.Click += new System.EventHandler(this.tsmFactura_Click);
            // 
            // tsmCompra
            // 
            this.tsmCompra.Name = "tsmCompra";
            this.tsmCompra.Size = new System.Drawing.Size(224, 26);
            this.tsmCompra.Text = "Compra";
            this.tsmCompra.Click += new System.EventHandler(this.tsmCompra_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(52, 24);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasPorFechaToolStripMenuItem,
            this.comprasPorFechaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ventasPorFechaToolStripMenuItem
            // 
            this.ventasPorFechaToolStripMenuItem.Name = "ventasPorFechaToolStripMenuItem";
            this.ventasPorFechaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ventasPorFechaToolStripMenuItem.Text = "Ventas por Fecha";
            // 
            // comprasPorFechaToolStripMenuItem
            // 
            this.comprasPorFechaToolStripMenuItem.Name = "comprasPorFechaToolStripMenuItem";
            this.comprasPorFechaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.comprasPorFechaToolStripMenuItem.Text = "Compras por Fecha";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmCliente;
		private System.Windows.Forms.ToolStripMenuItem tsmProveedor;
		private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmDevolucion;
		private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmFactura;
        private System.Windows.Forms.ToolStripMenuItem tsmArticulo;
        private System.Windows.Forms.ToolStripMenuItem tsmCompra;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorFechaToolStripMenuItem;
    }
}