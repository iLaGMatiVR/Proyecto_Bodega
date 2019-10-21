namespace Interfaz_Aguila_Curda
{
    partial class Compra
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimbrado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lstcompra = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Controls.Add(this.txtTimbrado);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbTipoPago);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpFechaFactura);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtProveedor);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtFactura);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(13, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1127, 332);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Compra";
            // 
            // txtTimbrado
            // 
            this.txtTimbrado.Enabled = false;
            this.txtTimbrado.Location = new System.Drawing.Point(180, 97);
            this.txtTimbrado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimbrado.Name = "txtTimbrado";
            this.txtTimbrado.Size = new System.Drawing.Size(260, 30);
            this.txtTimbrado.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(22, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 69;
            this.label5.Text = "Timbrado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(22, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 68;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Credito",
            "Al contado"});
            this.cmbTipoPago.Location = new System.Drawing.Point(180, 275);
            this.cmbTipoPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(260, 31);
            this.cmbTipoPago.TabIndex = 35;
            this.cmbTipoPago.Text = "Credito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tipo de Pago";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(180, 215);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(260, 35);
            this.dtpFechaFactura.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(22, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(184, 146);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(256, 30);
            this.txtProveedor.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(22, 48);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 23);
            this.label17.TabIndex = 15;
            this.label17.Text = "Nro Factura";
            // 
            // txtFactura
            // 
            this.txtFactura.Enabled = false;
            this.txtFactura.Location = new System.Drawing.Point(180, 38);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(260, 30);
            this.txtFactura.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(22, 158);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 23);
            this.label18.TabIndex = 13;
            this.label18.Text = "Proveedor";
            // 
            // lstcompra
            // 
            this.lstcompra.FormattingEnabled = true;
            this.lstcompra.ItemHeight = 20;
            this.lstcompra.Location = new System.Drawing.Point(29, 381);
            this.lstcompra.Name = "lstcompra";
            this.lstcompra.Size = new System.Drawing.Size(1101, 244);
            this.lstcompra.TabIndex = 42;
            this.lstcompra.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Aqua;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(639, 80);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 45);
            this.btnAgregar.TabIndex = 73;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Aqua;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(639, 216);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(160, 45);
            this.btnEliminar.TabIndex = 72;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Aqua;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(639, 144);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(160, 45);
            this.btnModificar.TabIndex = 71;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 645);
            this.Controls.Add(this.lstcompra);
            this.Controls.Add(this.groupBox2);
            this.Name = "Compra";
            this.Text = "Compra";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimbrado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox lstcompra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
    }
}