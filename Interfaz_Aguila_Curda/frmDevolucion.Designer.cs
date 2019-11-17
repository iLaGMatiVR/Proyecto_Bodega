namespace Interfaz_Aguila_Curda
{
    partial class frmDevolucion
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtgDetalleDevolucion = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            this.dtmFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblDescripcionDelProducto = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.txtMotivoDevolucion = new System.Windows.Forms.TextBox();
            this.lblMotivoDevolucion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(146, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 31);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Devolucion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(418, 440);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(66, 27);
            this.btnGuardar.TabIndex = 79;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dtgDetalleDevolucion
            // 
            this.dtgDetalleDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleDevolucion.Location = new System.Drawing.Point(12, 311);
            this.dtgDetalleDevolucion.Name = "dtgDetalleDevolucion";
            this.dtgDetalleDevolucion.Size = new System.Drawing.Size(454, 106);
            this.dtgDetalleDevolucion.TabIndex = 78;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(397, 258);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 30);
            this.btnEliminar.TabIndex = 77;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(277, 258);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 30);
            this.btnAgregar.TabIndex = 76;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Location = new System.Drawing.Point(170, 201);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(130, 21);
            this.cmbDescripcion.TabIndex = 85;
            // 
            // dtmFechaDevolucion
            // 
            this.dtmFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaDevolucion.Location = new System.Drawing.Point(170, 149);
            this.dtmFechaDevolucion.Name = "dtmFechaDevolucion";
            this.dtmFechaDevolucion.Size = new System.Drawing.Size(130, 20);
            this.dtmFechaDevolucion.TabIndex = 84;
            // 
            // lblDescripcionDelProducto
            // 
            this.lblDescripcionDelProducto.AutoSize = true;
            this.lblDescripcionDelProducto.Location = new System.Drawing.Point(38, 204);
            this.lblDescripcionDelProducto.Name = "lblDescripcionDelProducto";
            this.lblDescripcionDelProducto.Size = new System.Drawing.Size(126, 13);
            this.lblDescripcionDelProducto.TabIndex = 83;
            this.lblDescripcionDelProducto.Text = "Descripcion del Producto";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(38, 149);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(94, 13);
            this.lblFechaDevolucion.TabIndex = 82;
            this.lblFechaDevolucion.Text = "Fecha Devolucion";
            // 
            // txtMotivoDevolucion
            // 
            this.txtMotivoDevolucion.Location = new System.Drawing.Point(170, 102);
            this.txtMotivoDevolucion.Name = "txtMotivoDevolucion";
            this.txtMotivoDevolucion.Size = new System.Drawing.Size(130, 20);
            this.txtMotivoDevolucion.TabIndex = 81;
            // 
            // lblMotivoDevolucion
            // 
            this.lblMotivoDevolucion.AutoSize = true;
            this.lblMotivoDevolucion.Location = new System.Drawing.Point(39, 105);
            this.lblMotivoDevolucion.Name = "lblMotivoDevolucion";
            this.lblMotivoDevolucion.Size = new System.Drawing.Size(96, 13);
            this.lblMotivoDevolucion.TabIndex = 80;
            this.lblMotivoDevolucion.Text = "Motivo Devolucion";
            // 
            // frmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 537);
            this.Controls.Add(this.cmbDescripcion);
            this.Controls.Add(this.dtmFechaDevolucion);
            this.Controls.Add(this.lblDescripcionDelProducto);
            this.Controls.Add(this.lblFechaDevolucion);
            this.Controls.Add(this.txtMotivoDevolucion);
            this.Controls.Add(this.lblMotivoDevolucion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtgDetalleDevolucion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmDevolucion";
            this.Text = "frmDevolucion";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleDevolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtgDetalleDevolucion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.DateTimePicker dtmFechaDevolucion;
        private System.Windows.Forms.Label lblDescripcionDelProducto;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.TextBox txtMotivoDevolucion;
        private System.Windows.Forms.Label lblMotivoDevolucion;
    }
}