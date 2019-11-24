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
            this.lblTotalMonto = new System.Windows.Forms.Label();
            this.gbxDetalle = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboArticulo = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbxCabecera = new System.Windows.Forms.GroupBox();
            this.btnHabilitarDetalle = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.gbxCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotalMonto
            // 
            this.lblTotalMonto.AutoSize = true;
            this.lblTotalMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMonto.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalMonto.Location = new System.Drawing.Point(264, 606);
            this.lblTotalMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMonto.Name = "lblTotalMonto";
            this.lblTotalMonto.Size = new System.Drawing.Size(24, 25);
            this.lblTotalMonto.TabIndex = 84;
            this.lblTotalMonto.Text = "0";
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.Controls.Add(this.btnEliminar);
            this.gbxDetalle.Controls.Add(this.btnAgregar);
            this.gbxDetalle.Controls.Add(this.cboArticulo);
            this.gbxDetalle.Controls.Add(this.nudCantidad);
            this.gbxDetalle.Controls.Add(this.lblCantidad);
            this.gbxDetalle.Controls.Add(this.dgvFactura);
            this.gbxDetalle.Controls.Add(this.lblArticulo);
            this.gbxDetalle.Controls.Add(this.label6);
            this.gbxDetalle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalle.ForeColor = System.Drawing.Color.Black;
            this.gbxDetalle.Location = new System.Drawing.Point(55, 236);
            this.gbxDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDetalle.Size = new System.Drawing.Size(809, 326);
            this.gbxDetalle.TabIndex = 86;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Detalle de Factura";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Aqua;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(193, 266);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 29);
            this.btnEliminar.TabIndex = 89;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Aqua;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(49, 266);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 29);
            this.btnAgregar.TabIndex = 90;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // cboArticulo
            // 
            this.cboArticulo.FormattingEnabled = true;
            this.cboArticulo.Location = new System.Drawing.Point(165, 35);
            this.cboArticulo.Name = "cboArticulo";
            this.cboArticulo.Size = new System.Drawing.Size(175, 26);
            this.cboArticulo.TabIndex = 87;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(504, 38);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(85, 26);
            this.nudCantidad.TabIndex = 86;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(402, 43);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(74, 19);
            this.lblCantidad.TabIndex = 85;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Location = new System.Drawing.Point(48, 88);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.RowHeadersWidth = 51;
            this.dgvFactura.Size = new System.Drawing.Size(698, 150);
            this.dgvFactura.TabIndex = 69;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(69, 44);
            this.lblArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(64, 19);
            this.lblArticulo.TabIndex = 83;
            this.lblArticulo.Text = "Articulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 68;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Blue;
            this.lblMonto.Location = new System.Drawing.Point(68, 606);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(127, 25);
            this.lblMonto.TabIndex = 83;
            this.lblMonto.Text = "Monto Total";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Aqua;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(710, 590);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(154, 41);
            this.btnCancelar.TabIndex = 88;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Aqua;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(461, 590);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(154, 41);
            this.btnGuardar.TabIndex = 87;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // gbxCabecera
            // 
            this.gbxCabecera.Controls.Add(this.btnHabilitarDetalle);
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
            this.gbxCabecera.Location = new System.Drawing.Point(55, 36);
            this.gbxCabecera.Margin = new System.Windows.Forms.Padding(2);
            this.gbxCabecera.Name = "gbxCabecera";
            this.gbxCabecera.Padding = new System.Windows.Forms.Padding(2);
            this.gbxCabecera.Size = new System.Drawing.Size(809, 174);
            this.gbxCabecera.TabIndex = 85;
            this.gbxCabecera.TabStop = false;
            this.gbxCabecera.Text = "Datos de Factura";
            // 
            // btnHabilitarDetalle
            // 
            this.btnHabilitarDetalle.Location = new System.Drawing.Point(491, 119);
            this.btnHabilitarDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.btnHabilitarDetalle.Name = "btnHabilitarDetalle";
            this.btnHabilitarDetalle.Size = new System.Drawing.Size(144, 28);
            this.btnHabilitarDetalle.TabIndex = 75;
            this.btnHabilitarDetalle.Text = "Habilitar Detalle";
            this.btnHabilitarDetalle.UseVisualStyleBackColor = true;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(165, 105);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(175, 26);
            this.cboCliente.TabIndex = 74;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(558, 69);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(175, 26);
            this.cmbTipoPago.TabIndex = 73;
            // 
            // txtTimbrado
            // 
            this.txtTimbrado.Location = new System.Drawing.Point(165, 73);
            this.txtTimbrado.Name = "txtTimbrado";
            this.txtTimbrado.Size = new System.Drawing.Size(175, 26);
            this.txtTimbrado.TabIndex = 72;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(165, 36);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(175, 26);
            this.txtNroFactura.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(44, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 69;
            this.label5.Text = "Timbrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tipo de Pago";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(558, 29);
            this.dtpFechaFactura.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(175, 30);
            this.dtpFechaFactura.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(402, 34);
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
            this.label17.Location = new System.Drawing.Point(44, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 19);
            this.label17.TabIndex = 15;
            this.label17.Text = "Nro Factura";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(44, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 19);
            this.label18.TabIndex = 13;
            this.label18.Text = "Cliente";
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 685);
            this.Controls.Add(this.lblTotalMonto);
            this.Controls.Add(this.gbxDetalle);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbxCabecera);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.gbxDetalle.ResumeLayout(false);
            this.gbxDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.gbxCabecera.ResumeLayout(false);
            this.gbxCabecera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblTotalMonto;
        private System.Windows.Forms.GroupBox gbxDetalle;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboArticulo;
        internal System.Windows.Forms.NumericUpDown nudCantidad;
        internal System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DataGridView dgvFactura;
        internal System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbxCabecera;
        internal System.Windows.Forms.Button btnHabilitarDetalle;
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