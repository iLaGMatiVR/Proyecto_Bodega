namespace Interfaz_Aguila_Curda
{
    partial class frmFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturas));
            this.btnHabilitarDetalle = new System.Windows.Forms.Button();
            this.lblTotalMonto = new System.Windows.Forms.Label();
            this.gbxDetalle = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.gbxCabecera = new System.Windows.Forms.GroupBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.txtTimbrado = new System.Windows.Forms.TextBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gbxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.gbxCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHabilitarDetalle
            // 
            this.btnHabilitarDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitarDetalle.Location = new System.Drawing.Point(249, 184);
            this.btnHabilitarDetalle.Name = "btnHabilitarDetalle";
            this.btnHabilitarDetalle.Size = new System.Drawing.Size(160, 31);
            this.btnHabilitarDetalle.TabIndex = 89;
            this.btnHabilitarDetalle.Text = "Habilitar Detalle";
            this.btnHabilitarDetalle.UseVisualStyleBackColor = true;
            this.btnHabilitarDetalle.Click += new System.EventHandler(this.btnHabilitarDetalle_Click_1);
            // 
            // lblTotalMonto
            // 
            this.lblTotalMonto.AutoSize = true;
            this.lblTotalMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMonto.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalMonto.Location = new System.Drawing.Point(195, 478);
            this.lblTotalMonto.Name = "lblTotalMonto";
            this.lblTotalMonto.Size = new System.Drawing.Size(19, 20);
            this.lblTotalMonto.TabIndex = 91;
            this.lblTotalMonto.Text = "0";
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.Controls.Add(this.txtPrecio);
            this.gbxDetalle.Controls.Add(this.label1);
            this.gbxDetalle.Controls.Add(this.btnAgregar);
            this.gbxDetalle.Controls.Add(this.btnEliminar);
            this.gbxDetalle.Controls.Add(this.txtCantidad);
            this.gbxDetalle.Controls.Add(this.cboArticulo);
            this.gbxDetalle.Controls.Add(this.lblCantidad);
            this.gbxDetalle.Controls.Add(this.dgvFactura);
            this.gbxDetalle.Controls.Add(this.lblArticulo);
            this.gbxDetalle.Controls.Add(this.label6);
            this.gbxDetalle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalle.ForeColor = System.Drawing.Color.Black;
            this.gbxDetalle.Location = new System.Drawing.Point(43, 220);
            this.gbxDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDetalle.Size = new System.Drawing.Size(607, 231);
            this.gbxDetalle.TabIndex = 93;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Detalle de Factura";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(105, 61);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(78, 22);
            this.txtPrecio.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 93;
            this.label1.Text = "Precio unitario:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(381, 82);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(62, 44);
            this.btnAgregar.TabIndex = 91;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(381, 138);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(62, 44);
            this.btnEliminar.TabIndex = 92;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(335, 28);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(78, 22);
            this.txtCantidad.TabIndex = 76;
            // 
            // cboArticulo
            // 
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(105, 28);
            this.cboArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(132, 24);
            this.cboArticulo.TabIndex = 87;
            this.cboArticulo.SelectedIndexChanged += new System.EventHandler(this.cboArticulo_SelectedIndexChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(266, 31);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(63, 16);
            this.lblCantidad.TabIndex = 85;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(36, 87);
            this.dgvFactura.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.RowHeadersWidth = 51;
            this.dgvFactura.Size = new System.Drawing.Size(314, 140);
            this.dgvFactura.TabIndex = 69;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(33, 34);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(56, 16);
            this.lblArticulo.TabIndex = 83;
            this.lblArticulo.Text = "Articulo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 68;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Aqua;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(534, 465);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 33);
            this.btnCancelar.TabIndex = 95;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(348, 465);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 33);
            this.btnGuardar.TabIndex = 94;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Blue;
            this.lblMonto.Location = new System.Drawing.Point(48, 478);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(104, 20);
            this.lblMonto.TabIndex = 90;
            this.lblMonto.Text = "Monto Total";
            // 
            // gbxCabecera
            // 
            this.gbxCabecera.Controls.Add(this.cboCliente);
            this.gbxCabecera.Controls.Add(this.cmbTipoPago);
            this.gbxCabecera.Controls.Add(this.txtTimbrado);
            this.gbxCabecera.Controls.Add(this.txtNroFactura);
            this.gbxCabecera.Controls.Add(this.label5);
            this.gbxCabecera.Controls.Add(this.label3);
            this.gbxCabecera.Controls.Add(this.label4);
            this.gbxCabecera.Controls.Add(this.dtpFechaFactura);
            this.gbxCabecera.Controls.Add(this.label2);
            this.gbxCabecera.Controls.Add(this.label17);
            this.gbxCabecera.Controls.Add(this.label18);
            this.gbxCabecera.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCabecera.ForeColor = System.Drawing.Color.Black;
            this.gbxCabecera.Location = new System.Drawing.Point(43, 58);
            this.gbxCabecera.Margin = new System.Windows.Forms.Padding(2);
            this.gbxCabecera.Name = "gbxCabecera";
            this.gbxCabecera.Padding = new System.Windows.Forms.Padding(2);
            this.gbxCabecera.Size = new System.Drawing.Size(607, 121);
            this.gbxCabecera.TabIndex = 92;
            this.gbxCabecera.TabStop = false;
            this.gbxCabecera.Text = "Datos de Factura";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(124, 85);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(132, 24);
            this.cboCliente.TabIndex = 74;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(418, 56);
            this.cmbTipoPago.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(132, 24);
            this.cmbTipoPago.TabIndex = 73;
            // 
            // txtTimbrado
            // 
            this.txtTimbrado.Location = new System.Drawing.Point(124, 59);
            this.txtTimbrado.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimbrado.Name = "txtTimbrado";
            this.txtTimbrado.Size = new System.Drawing.Size(132, 22);
            this.txtTimbrado.TabIndex = 72;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(124, 29);
            this.txtNroFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(132, 22);
            this.txtNroFactura.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Timbrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tipo de Pago";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(418, 24);
            this.dtpFechaFactura.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(132, 26);
            this.dtpFechaFactura.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(302, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(33, 29);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 16);
            this.label17.TabIndex = 15;
            this.label17.Text = "Nro Factura";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(33, 87);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 16);
            this.label18.TabIndex = 13;
            this.label18.Text = "Cliente";
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 557);
            this.Controls.Add(this.btnHabilitarDetalle);
            this.Controls.Add(this.lblTotalMonto);
            this.Controls.Add(this.gbxDetalle);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.gbxCabecera);
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.Load += new System.EventHandler(this.frmFacturas_Load_1);
            this.Click += new System.EventHandler(this.frmFacturas_Load_1);
            this.gbxDetalle.ResumeLayout(false);
            this.gbxDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.gbxCabecera.ResumeLayout(false);
            this.gbxCabecera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnHabilitarDetalle;
        internal System.Windows.Forms.Label lblTotalMonto;
        private System.Windows.Forms.GroupBox gbxDetalle;
        private System.Windows.Forms.TextBox txtPrecio;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboArticulo;
        internal System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgvFactura;
        internal System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.GroupBox gbxCabecera;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.TextBox txtTimbrado;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}