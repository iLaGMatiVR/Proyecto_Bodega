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
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            this.dtpFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblDescripcionDelProducto = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.txtMotivoDevolucion = new System.Windows.Forms.TextBox();
            this.lblMotivoDevolucion = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lstDevolucion = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtIDDevolucion = new System.Windows.Forms.TextBox();
            this.lblIdDevolucion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(144, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 31);
            this.lblTitulo.TabIndex = 42;
            this.lblTitulo.Text = "Devolucion";
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Location = new System.Drawing.Point(178, 208);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(130, 21);
            this.cmbDescripcion.TabIndex = 85;
            // 
            // dtpFechaDevolucion
            // 
            this.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDevolucion.Location = new System.Drawing.Point(178, 163);
            this.dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            this.dtpFechaDevolucion.Size = new System.Drawing.Size(130, 20);
            this.dtpFechaDevolucion.TabIndex = 84;
            // 
            // lblDescripcionDelProducto
            // 
            this.lblDescripcionDelProducto.AutoSize = true;
            this.lblDescripcionDelProducto.Location = new System.Drawing.Point(46, 211);
            this.lblDescripcionDelProducto.Name = "lblDescripcionDelProducto";
            this.lblDescripcionDelProducto.Size = new System.Drawing.Size(126, 13);
            this.lblDescripcionDelProducto.TabIndex = 83;
            this.lblDescripcionDelProducto.Text = "Descripcion del Producto";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(46, 163);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(94, 13);
            this.lblFechaDevolucion.TabIndex = 82;
            this.lblFechaDevolucion.Text = "Fecha Devolucion";
            // 
            // txtMotivoDevolucion
            // 
            this.txtMotivoDevolucion.Location = new System.Drawing.Point(178, 117);
            this.txtMotivoDevolucion.Name = "txtMotivoDevolucion";
            this.txtMotivoDevolucion.Size = new System.Drawing.Size(130, 20);
            this.txtMotivoDevolucion.TabIndex = 81;
            // 
            // lblMotivoDevolucion
            // 
            this.lblMotivoDevolucion.AutoSize = true;
            this.lblMotivoDevolucion.Location = new System.Drawing.Point(46, 119);
            this.lblMotivoDevolucion.Name = "lblMotivoDevolucion";
            this.lblMotivoDevolucion.Size = new System.Drawing.Size(96, 13);
            this.lblMotivoDevolucion.TabIndex = 80;
            this.lblMotivoDevolucion.Text = "Motivo Devolucion";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(321, 266);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 37);
            this.btnLimpiar.TabIndex = 95;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(135, 266);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 37);
            this.btnEditar.TabIndex = 94;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // lstDevolucion
            // 
            this.lstDevolucion.FormattingEnabled = true;
            this.lstDevolucion.Location = new System.Drawing.Point(40, 340);
            this.lstDevolucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstDevolucion.Name = "lstDevolucion";
            this.lstDevolucion.Size = new System.Drawing.Size(362, 95);
            this.lstDevolucion.TabIndex = 93;
            this.lstDevolucion.Click += new System.EventHandler(this.lstDevolucion_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(226, 266);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 37);
            this.btnEliminar.TabIndex = 92;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(40, 266);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 37);
            this.btnAgregar.TabIndex = 91;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtIDDevolucion
            // 
            this.txtIDDevolucion.Location = new System.Drawing.Point(178, 72);
            this.txtIDDevolucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDDevolucion.Name = "txtIDDevolucion";
            this.txtIDDevolucion.ReadOnly = true;
            this.txtIDDevolucion.Size = new System.Drawing.Size(130, 20);
            this.txtIDDevolucion.TabIndex = 97;
            // 
            // lblIdDevolucion
            // 
            this.lblIdDevolucion.AutoSize = true;
            this.lblIdDevolucion.Enabled = false;
            this.lblIdDevolucion.Location = new System.Drawing.Point(46, 74);
            this.lblIdDevolucion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdDevolucion.Name = "lblIdDevolucion";
            this.lblIdDevolucion.Size = new System.Drawing.Size(16, 13);
            this.lblIdDevolucion.TabIndex = 96;
            this.lblIdDevolucion.Text = "Id";
            // 
            // frmDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 492);
            this.Controls.Add(this.txtIDDevolucion);
            this.Controls.Add(this.lblIdDevolucion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lstDevolucion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbDescripcion);
            this.Controls.Add(this.dtpFechaDevolucion);
            this.Controls.Add(this.lblDescripcionDelProducto);
            this.Controls.Add(this.lblFechaDevolucion);
            this.Controls.Add(this.txtMotivoDevolucion);
            this.Controls.Add(this.lblMotivoDevolucion);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmDevolucion";
            this.Text = "frmDevolucion";
            this.Load += new System.EventHandler(this.frmDevolucion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaDevolucion;
        private System.Windows.Forms.Label lblDescripcionDelProducto;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.TextBox txtMotivoDevolucion;
        private System.Windows.Forms.Label lblMotivoDevolucion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ListBox lstDevolucion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtIDDevolucion;
        private System.Windows.Forms.Label lblIdDevolucion;
    }
}