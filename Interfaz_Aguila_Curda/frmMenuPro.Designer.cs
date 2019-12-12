namespace Interfaz_Aguila_Curda
{
    partial class frmMenuPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPro));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.icoMaximizar = new System.Windows.Forms.PictureBox();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconRestaurar = new System.Windows.Forms.PictureBox();
            
            this.iconCerrar = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).BeginInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btnReporte);
            this.MenuVertical.Controls.Add(this.btnCompra);
            this.MenuVertical.Controls.Add(this.btnProveedor);
            this.MenuVertical.Controls.Add(this.btnVentas);
            this.MenuVertical.Controls.Add(this.btnCliente);
            this.MenuVertical.Controls.Add(this.btnArticulos);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.flowLayoutPanel1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 650);
            this.MenuVertical.TabIndex = 0;
            // 
            // btnReporte
            // 
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReporte.Image = global::Interfaz_Aguila_Curda.Properties.Resources.reportes;
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(0, 420);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(250, 40);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCompra.Image = global::Interfaz_Aguila_Curda.Properties.Resources.venta;
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.Location = new System.Drawing.Point(0, 347);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(250, 40);
            this.btnCompra.TabIndex = 6;
            this.btnCompra.Text = "Compras";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.ForeColor = System.Drawing.SystemColors.Window;
            this.btnProveedor.Image = global::Interfaz_Aguila_Curda.Properties.Resources.compras;
            this.btnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.Location = new System.Drawing.Point(2, 282);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(264, 40);
            this.btnProveedor.TabIndex = 5;
            this.btnProveedor.Text = "Proveedores";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 168);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(250, 40);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCliente.Image = global::Interfaz_Aguila_Curda.Properties.Resources.clientes;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 225);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(250, 40);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.FlatAppearance.BorderSize = 0;
            this.btnArticulos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.ForeColor = System.Drawing.SystemColors.Window;
            this.btnArticulos.Image = global::Interfaz_Aguila_Curda.Properties.Resources.articulo1;
            this.btnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulos.Location = new System.Drawing.Point(0, 101);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(250, 40);
            this.btnArticulos.TabIndex = 2;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz_Aguila_Curda.Properties.Resources.IMO2;
            this.pictureBox1.Location = new System.Drawing.Point(5, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(92, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.Controls.Add(this.iconRestaurar);
            this.BarraTitulo.Controls.Add(this.iconCerrar);
            this.BarraTitulo.Controls.Add(this.icoMaximizar);
            this.BarraTitulo.Controls.Add(this.iconMinimizar);
            
            this.BarraTitulo.Controls.Add(this.btnMenu);
            this.BarraTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTitulo_Paint);
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // icoMaximizar
            // 
            this.icoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icoMaximizar.Image = global::Interfaz_Aguila_Curda.Properties.Resources.icon_maximizar;
            this.icoMaximizar.Location = new System.Drawing.Point(992, 12);
            this.icoMaximizar.Name = "icoMaximizar";
            this.icoMaximizar.Size = new System.Drawing.Size(20, 20);
            this.icoMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoMaximizar.TabIndex = 5;
            this.icoMaximizar.TabStop = false;
            this.icoMaximizar.Click += new System.EventHandler(this.icoMaximizar_Click);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = global::Interfaz_Aguila_Curda.Properties.Resources.icon_minimizar;
            this.iconMinimizar.Location = new System.Drawing.Point(966, 12);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 4;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // iconRestaurar
            // 
            this.iconRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRestaurar.Image = global::Interfaz_Aguila_Curda.Properties.Resources.icon_restaurar;
            this.iconRestaurar.Location = new System.Drawing.Point(992, 12);
            this.iconRestaurar.Name = "iconRestaurar";
            this.iconRestaurar.Size = new System.Drawing.Size(20, 20);
            this.iconRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestaurar.TabIndex = 3;
            this.iconRestaurar.TabStop = false;
            this.iconRestaurar.Visible = false;
            this.iconRestaurar.Click += new System.EventHandler(this.iconRestaurar_Click);
            // 
            // iconMaximizar
            // 
          
            // 
            // iconCerrar
            // 
            this.iconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconCerrar.Image = global::Interfaz_Aguila_Curda.Properties.Resources.icon_cerrar2;
            this.iconCerrar.Location = new System.Drawing.Point(1018, 12);
            this.iconCerrar.Name = "iconCerrar";
            this.iconCerrar.Size = new System.Drawing.Size(20, 20);
            this.iconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconCerrar.TabIndex = 1;
            this.iconCerrar.TabStop = false;
            this.iconCerrar.Click += new System.EventHandler(this.iconCerrar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Image = global::Interfaz_Aguila_Curda.Properties.Resources.Mobile_Menu_Icon;
            this.btnMenu.Location = new System.Drawing.Point(9, 7);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 35);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnSlide_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(250, 50);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1050, 600);
            this.PanelContenedor.TabIndex = 2;
            // 
            // frmMenuPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuPro";
            this.Text = "frmMenuPro";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icoMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).EndInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.iconCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iconCerrar;
        
        private System.Windows.Forms.PictureBox iconRestaurar;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.PictureBox icoMaximizar;
    }
}