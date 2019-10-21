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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtmFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcionDelProducto = new System.Windows.Forms.TextBox();
            this.lblDescripcionDelProducto = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.txtMotivoDevolucion = new System.Windows.Forms.TextBox();
            this.lblMotivoDevolucion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(146, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(148, 29);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Devolucion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(275, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(107, 337);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 30);
            this.btnAceptar.TabIndex = 40;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(232, 273);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(130, 20);
            this.txtPrecioVenta.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "PrecioVenta";
            // 
            // dtmFechaDevolucion
            // 
            this.dtmFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaDevolucion.Location = new System.Drawing.Point(232, 157);
            this.dtmFechaDevolucion.Name = "dtmFechaDevolucion";
            this.dtmFechaDevolucion.Size = new System.Drawing.Size(130, 20);
            this.dtmFechaDevolucion.TabIndex = 37;
            // 
            // txtDescripcionDelProducto
            // 
            this.txtDescripcionDelProducto.Location = new System.Drawing.Point(232, 212);
            this.txtDescripcionDelProducto.Name = "txtDescripcionDelProducto";
            this.txtDescripcionDelProducto.Size = new System.Drawing.Size(130, 20);
            this.txtDescripcionDelProducto.TabIndex = 36;
            // 
            // lblDescripcionDelProducto
            // 
            this.lblDescripcionDelProducto.AutoSize = true;
            this.lblDescripcionDelProducto.Location = new System.Drawing.Point(85, 212);
            this.lblDescripcionDelProducto.Name = "lblDescripcionDelProducto";
            this.lblDescripcionDelProducto.Size = new System.Drawing.Size(126, 13);
            this.lblDescripcionDelProducto.TabIndex = 35;
            this.lblDescripcionDelProducto.Text = "Descripcion del Producto";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(85, 157);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(94, 13);
            this.lblFechaDevolucion.TabIndex = 34;
            this.lblFechaDevolucion.Text = "Fecha Devolucion";
            // 
            // txtMotivoDevolucion
            // 
            this.txtMotivoDevolucion.Location = new System.Drawing.Point(232, 110);
            this.txtMotivoDevolucion.Name = "txtMotivoDevolucion";
            this.txtMotivoDevolucion.Size = new System.Drawing.Size(130, 20);
            this.txtMotivoDevolucion.TabIndex = 33;
            // 
            // lblMotivoDevolucion
            // 
            this.lblMotivoDevolucion.AutoSize = true;
            this.lblMotivoDevolucion.Location = new System.Drawing.Point(86, 113);
            this.lblMotivoDevolucion.Name = "lblMotivoDevolucion";
            this.lblMotivoDevolucion.Size = new System.Drawing.Size(93, 13);
            this.lblMotivoDevolucion.TabIndex = 32;
            this.lblMotivoDevolucion.Text = "MotivoDevolucion";
            // 
            // frmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 433);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtmFechaDevolucion);
            this.Controls.Add(this.txtDescripcionDelProducto);
            this.Controls.Add(this.lblDescripcionDelProducto);
            this.Controls.Add(this.lblFechaDevolucion);
            this.Controls.Add(this.txtMotivoDevolucion);
            this.Controls.Add(this.lblMotivoDevolucion);
            this.Name = "frmDevolucion";
            this.Text = "frmDevolucion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtmFechaDevolucion;
        private System.Windows.Forms.TextBox txtDescripcionDelProducto;
        private System.Windows.Forms.Label lblDescripcionDelProducto;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.TextBox txtMotivoDevolucion;
        private System.Windows.Forms.Label lblMotivoDevolucion;
    }
}