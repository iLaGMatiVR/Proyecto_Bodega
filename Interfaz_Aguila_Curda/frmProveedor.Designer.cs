namespace Interfaz_Aguila_Curda
{
    partial class frmProveedor
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
			this.txtContacto = new System.Windows.Forms.TextBox();
			this.lblContacto = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtCodProveedor = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtRUC = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.lblRUC = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblCodProveedor = new System.Windows.Forms.Label();
			this.lstProveedor = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// txtContacto
			// 
			this.txtContacto.Location = new System.Drawing.Point(795, 170);
			this.txtContacto.Margin = new System.Windows.Forms.Padding(4);
			this.txtContacto.Name = "txtContacto";
			this.txtContacto.Size = new System.Drawing.Size(132, 22);
			this.txtContacto.TabIndex = 80;
			// 
			// lblContacto
			// 
			this.lblContacto.AutoSize = true;
			this.lblContacto.Location = new System.Drawing.Point(644, 178);
			this.lblContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblContacto.Name = "lblContacto";
			this.lblContacto.Size = new System.Drawing.Size(125, 17);
			this.lblContacto.TabIndex = 79;
			this.lblContacto.Text = "Persona Contacto:";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(78, 479);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(156, 37);
			this.btnAgregar.TabIndex = 78;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(312, 479);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(156, 37);
			this.btnEditar.TabIndex = 77;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(779, 479);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(156, 37);
			this.btnEliminar.TabIndex = 76;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(548, 479);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(156, 37);
			this.btnCancelar.TabIndex = 75;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
			// 
			// txtCodProveedor
			// 
			this.txtCodProveedor.Location = new System.Drawing.Point(225, 52);
			this.txtCodProveedor.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodProveedor.Name = "txtCodProveedor";
			this.txtCodProveedor.Size = new System.Drawing.Size(132, 22);
			this.txtCodProveedor.TabIndex = 74;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(795, 58);
			this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(132, 22);
			this.txtTelefono.TabIndex = 73;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(795, 110);
			this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(132, 22);
			this.txtDireccion.TabIndex = 72;
			// 
			// txtRUC
			// 
			this.txtRUC.Location = new System.Drawing.Point(225, 170);
			this.txtRUC.Margin = new System.Windows.Forms.Padding(4);
			this.txtRUC.Name = "txtRUC";
			this.txtRUC.Size = new System.Drawing.Size(132, 22);
			this.txtRUC.TabIndex = 71;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(225, 110);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(132, 22);
			this.txtNombre.TabIndex = 70;
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.Location = new System.Drawing.Point(644, 118);
			this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(71, 17);
			this.lblDireccion.TabIndex = 69;
			this.lblDireccion.Text = "Dirección:";
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.Location = new System.Drawing.Point(644, 62);
			this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(68, 17);
			this.lblTelefono.TabIndex = 68;
			this.lblTelefono.Text = "Telefono:";
			// 
			// lblRUC
			// 
			this.lblRUC.AutoSize = true;
			this.lblRUC.Location = new System.Drawing.Point(75, 178);
			this.lblRUC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRUC.Name = "lblRUC";
			this.lblRUC.Size = new System.Drawing.Size(41, 17);
			this.lblRUC.TabIndex = 67;
			this.lblRUC.Text = "RUC:";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(75, 118);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(62, 17);
			this.lblNombre.TabIndex = 66;
			this.lblNombre.Text = "Nombre:";
			// 
			// lblCodProveedor
			// 
			this.lblCodProveedor.AutoSize = true;
			this.lblCodProveedor.Location = new System.Drawing.Point(75, 60);
			this.lblCodProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodProveedor.Name = "lblCodProveedor";
			this.lblCodProveedor.Size = new System.Drawing.Size(126, 17);
			this.lblCodProveedor.TabIndex = 65;
			this.lblCodProveedor.Text = "Código Proveedor:";
			// 
			// lstProveedor
			// 
			this.lstProveedor.FormattingEnabled = true;
			this.lstProveedor.ItemHeight = 16;
			this.lstProveedor.Location = new System.Drawing.Point(75, 253);
			this.lstProveedor.Margin = new System.Windows.Forms.Padding(4);
			this.lstProveedor.Name = "lstProveedor";
			this.lstProveedor.Size = new System.Drawing.Size(852, 164);
			this.lstProveedor.TabIndex = 86;
			this.lstProveedor.Click += new System.EventHandler(this.lstProveedor_Click);
			// 
			// frmProveedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(988, 574);
			this.Controls.Add(this.lstProveedor);
			this.Controls.Add(this.txtContacto);
			this.Controls.Add(this.lblContacto);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.txtCodProveedor);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtRUC);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblDireccion);
			this.Controls.Add(this.lblTelefono);
			this.Controls.Add(this.lblRUC);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblCodProveedor);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmProveedor";
			this.Text = "Mantenimiento de Proveedor";
			this.Load += new System.EventHandler(this.frmProveedor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCodProveedor;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblRUC;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodProveedor;
        private System.Windows.Forms.ListBox lstProveedor;
    }
}