namespace Interfaz_Aguila_Curda
{
    partial class frmCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompra));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTotalMonto = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.btnAgre = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvCompra = new System.Windows.Forms.DataGridView();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxDetalle = new System.Windows.Forms.GroupBox();
            this.btnHabilitarItems = new System.Windows.Forms.Button();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.gbxCabecera = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).BeginInit();
            this.gbxDetalle.SuspendLayout();
            this.gbxCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(813, 473);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(155, 41);
            this.btnGuardar.TabIndex = 100;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTotalMonto
            // 
            this.lblTotalMonto.AutoSize = true;
            this.lblTotalMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMonto.ForeColor = System.Drawing.Color.Crimson;
            this.lblTotalMonto.Location = new System.Drawing.Point(239, 342);
            this.lblTotalMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMonto.Name = "lblTotalMonto";
            this.lblTotalMonto.Size = new System.Drawing.Size(24, 25);
            this.lblTotalMonto.TabIndex = 93;
            this.lblTotalMonto.Text = "0";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(140, 91);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(103, 26);
            this.txtCosto.TabIndex = 95;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Crimson;
            this.lblMonto.Location = new System.Drawing.Point(43, 342);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(127, 25);
            this.lblMonto.TabIndex = 92;
            this.lblMonto.Text = "Monto Total";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(44, 98);
            this.lblCosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(56, 19);
            this.lblCosto.TabIndex = 93;
            this.lblCosto.Text = "Costo:";
            // 
            // btnAgre
            // 
            this.btnAgre.Image = ((System.Drawing.Image)(resources.GetObject("btnAgre.Image")));
            this.btnAgre.Location = new System.Drawing.Point(486, 273);
            this.btnAgre.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgre.Name = "btnAgre";
            this.btnAgre.Size = new System.Drawing.Size(83, 54);
            this.btnAgre.TabIndex = 91;
            this.btnAgre.UseVisualStyleBackColor = true;
            this.btnAgre.Click += new System.EventHandler(this.btnAgre_Click);
            // 
            // btnElim
            // 
            this.btnElim.Image = ((System.Drawing.Image)(resources.GetObject("btnElim.Image")));
            this.btnElim.Location = new System.Drawing.Point(486, 201);
            this.btnElim.Margin = new System.Windows.Forms.Padding(4);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(83, 54);
            this.btnElim.TabIndex = 92;
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(447, 34);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(103, 26);
            this.txtCantidad.TabIndex = 76;
            // 
            // cboArticulo
            // 
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(140, 34);
            this.cboArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(175, 26);
            this.cboArticulo.TabIndex = 87;
            this.cboArticulo.SelectedIndexChanged += new System.EventHandler(this.cboArticulo_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(355, 38);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 19);
            this.lblCantidad.TabIndex = 85;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // dgvCompra
            // 
            this.dgvCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompra.Location = new System.Drawing.Point(38, 139);
            this.dgvCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCompra.Name = "dgvCompra";
            this.dgvCompra.RowHeadersWidth = 51;
            this.dgvCompra.Size = new System.Drawing.Size(419, 172);
            this.dgvCompra.TabIndex = 69;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(44, 42);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(69, 19);
            this.lblArticulo.TabIndex = 83;
            this.lblArticulo.Text = "Articulo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 68;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Aqua;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1067, 473);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(155, 41);
            this.btnCancelar.TabIndex = 101;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.Controls.Add(this.lblTotalMonto);
            this.gbxDetalle.Controls.Add(this.txtCosto);
            this.gbxDetalle.Controls.Add(this.lblMonto);
            this.gbxDetalle.Controls.Add(this.lblCosto);
            this.gbxDetalle.Controls.Add(this.btnAgre);
            this.gbxDetalle.Controls.Add(this.btnElim);
            this.gbxDetalle.Controls.Add(this.txtCantidad);
            this.gbxDetalle.Controls.Add(this.cboArticulo);
            this.gbxDetalle.Controls.Add(this.lblCantidad);
            this.gbxDetalle.Controls.Add(this.dgvCompra);
            this.gbxDetalle.Controls.Add(this.lblArticulo);
            this.gbxDetalle.Controls.Add(this.label6);
            this.gbxDetalle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalle.ForeColor = System.Drawing.Color.Black;
            this.gbxDetalle.Location = new System.Drawing.Point(653, 75);
            this.gbxDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxDetalle.Size = new System.Drawing.Size(590, 381);
            this.gbxDetalle.TabIndex = 99;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Detalle de Compra";
            // 
            // btnHabilitarItems
            // 
            this.btnHabilitarItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarItems.Location = new System.Drawing.Point(317, 326);
            this.btnHabilitarItems.Margin = new System.Windows.Forms.Padding(4);
            this.btnHabilitarItems.Name = "btnHabilitarItems";
            this.btnHabilitarItems.Size = new System.Drawing.Size(213, 38);
            this.btnHabilitarItems.TabIndex = 90;
            this.btnHabilitarItems.Text = "Habilitar Items";
            this.btnHabilitarItems.UseVisualStyleBackColor = true;
            this.btnHabilitarItems.Click += new System.EventHandler(this.btnHabilitarItems_Click);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(189, 104);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(232, 26);
            this.cmbProveedor.TabIndex = 75;
            this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(189, 152);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(232, 26);
            this.txtDireccion.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 69;
            this.label5.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 68;
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Items.AddRange(new object[] {
            "Credito",
            "Al contado"});
            this.cmbMedioPago.Location = new System.Drawing.Point(189, 242);
            this.cmbMedioPago.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(232, 26);
            this.cmbMedioPago.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Medio de Pago";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCompra.Location = new System.Drawing.Point(189, 194);
            this.dtpFechaCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(232, 30);
            this.dtpFechaCompra.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(40, 59);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 19);
            this.label17.TabIndex = 15;
            this.label17.Text = "Nro Factura";
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Enabled = false;
            this.txtNroFactura.Location = new System.Drawing.Point(189, 52);
            this.txtNroFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(232, 26);
            this.txtNroFactura.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(40, 111);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 19);
            this.label18.TabIndex = 13;
            this.label18.Text = "Proveedor";
            // 
            // gbxCabecera
            // 
            this.gbxCabecera.Controls.Add(this.btnHabilitarItems);
            this.gbxCabecera.Controls.Add(this.cmbProveedor);
            this.gbxCabecera.Controls.Add(this.txtDireccion);
            this.gbxCabecera.Controls.Add(this.label5);
            this.gbxCabecera.Controls.Add(this.label3);
            this.gbxCabecera.Controls.Add(this.cmbMedioPago);
            this.gbxCabecera.Controls.Add(this.label4);
            this.gbxCabecera.Controls.Add(this.dtpFechaCompra);
            this.gbxCabecera.Controls.Add(this.label2);
            this.gbxCabecera.Controls.Add(this.label17);
            this.gbxCabecera.Controls.Add(this.txtNroFactura);
            this.gbxCabecera.Controls.Add(this.label18);
            this.gbxCabecera.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCabecera.ForeColor = System.Drawing.Color.Black;
            this.gbxCabecera.Location = new System.Drawing.Point(85, 62);
            this.gbxCabecera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCabecera.Name = "gbxCabecera";
            this.gbxCabecera.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCabecera.Size = new System.Drawing.Size(562, 394);
            this.gbxCabecera.TabIndex = 98;
            this.gbxCabecera.TabStop = false;
            this.gbxCabecera.Text = "Datos de Compra";
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 577);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxDetalle);
            this.Controls.Add(this.gbxCabecera);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompra)).EndInit();
            this.gbxDetalle.ResumeLayout(false);
            this.gbxDetalle.PerformLayout();
            this.gbxCabecera.ResumeLayout(false);
            this.gbxCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Label lblTotalMonto;
        private System.Windows.Forms.TextBox txtCosto;
        internal System.Windows.Forms.Label lblMonto;
        internal System.Windows.Forms.Label lblCosto;
        internal System.Windows.Forms.Button btnAgre;
        internal System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboArticulo;
        internal System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgvCompra;
        internal System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbxDetalle;
        internal System.Windows.Forms.Button btnHabilitarItems;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox gbxCabecera;
    }
}