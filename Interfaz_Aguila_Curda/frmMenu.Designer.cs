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
			this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmArticulo = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.salirToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 28);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mantenimientoToolStripMenuItem
			// 
			this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCliente,
            this.tsmProveedor});
			this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
			this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
			this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
			// 
			// tsmCliente
			// 
			this.tsmCliente.Name = "tsmCliente";
			this.tsmCliente.Size = new System.Drawing.Size(160, 26);
			this.tsmCliente.Text = "Cliente";
			this.tsmCliente.Click += new System.EventHandler(this.tsmCliente_Click);
			// 
			// tsmProveedor
			// 
			this.tsmProveedor.Name = "tsmProveedor";
			this.tsmProveedor.Size = new System.Drawing.Size(160, 26);
			this.tsmProveedor.Text = "Proveedor";
			this.tsmProveedor.Click += new System.EventHandler(this.tsmProveedor_Click);
			// 
			// procesosToolStripMenuItem
			// 
			this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArticulo});
			this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
			this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
			this.procesosToolStripMenuItem.Text = "Procesos";
			// 
			// tsmArticulo
			// 
			this.tsmArticulo.Name = "tsmArticulo";
			this.tsmArticulo.Size = new System.Drawing.Size(144, 26);
			this.tsmArticulo.Text = "Articulo";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// frmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
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
		private System.Windows.Forms.ToolStripMenuItem tsmArticulo;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
	}
}