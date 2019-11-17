namespace Interfaz_Aguila_Curda
{
    partial class frmCliente
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
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.txtCodCliente = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtCI = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblSexo = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.lblCI = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblCodCliente = new System.Windows.Forms.Label();
			this.lstCliente = new System.Windows.Forms.ListBox();
			this.lstSexo = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(47, 462);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(156, 37);
			this.btnAgregar.TabIndex = 84;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(281, 462);
			this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(156, 37);
			this.btnEditar.TabIndex = 83;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(748, 462);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(156, 37);
			this.btnEliminar.TabIndex = 82;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(517, 462);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(156, 37);
			this.btnCancelar.TabIndex = 81;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
			// 
			// txtCodCliente
			// 
			this.txtCodCliente.Location = new System.Drawing.Point(216, 50);
			this.txtCodCliente.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodCliente.Name = "txtCodCliente";
			this.txtCodCliente.ReadOnly = true;
			this.txtCodCliente.Size = new System.Drawing.Size(132, 22);
			this.txtCodCliente.TabIndex = 80;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(689, 52);
			this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(132, 22);
			this.txtTelefono.TabIndex = 77;
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(689, 103);
			this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(132, 22);
			this.txtDireccion.TabIndex = 76;
			// 
			// txtCI
			// 
			this.txtCI.Location = new System.Drawing.Point(216, 169);
			this.txtCI.Margin = new System.Windows.Forms.Padding(4);
			this.txtCI.Name = "txtCI";
			this.txtCI.Size = new System.Drawing.Size(132, 22);
			this.txtCI.TabIndex = 74;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(216, 108);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(132, 22);
			this.txtNombre.TabIndex = 73;
			// 
			// lblSexo
			// 
			this.lblSexo.AutoSize = true;
			this.lblSexo.Location = new System.Drawing.Point(539, 174);
			this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSexo.Name = "lblSexo";
			this.lblSexo.Size = new System.Drawing.Size(43, 17);
			this.lblSexo.TabIndex = 71;
			this.lblSexo.Text = "Sexo:";
			// 
			// lblDireccion
			// 
			this.lblDireccion.AutoSize = true;
			this.lblDireccion.Location = new System.Drawing.Point(539, 112);
			this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(71, 17);
			this.lblDireccion.TabIndex = 70;
			this.lblDireccion.Text = "Dirección:";
			// 
			// lblTelefono
			// 
			this.lblTelefono.AutoSize = true;
			this.lblTelefono.Location = new System.Drawing.Point(539, 55);
			this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(68, 17);
			this.lblTelefono.TabIndex = 69;
			this.lblTelefono.Text = "Telefono:";
			// 
			// lblCI
			// 
			this.lblCI.AutoSize = true;
			this.lblCI.Location = new System.Drawing.Point(65, 177);
			this.lblCI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCI.Name = "lblCI";
			this.lblCI.Size = new System.Drawing.Size(24, 17);
			this.lblCI.TabIndex = 68;
			this.lblCI.Text = "CI:";
			// 
			// lblNombre
			// 
			this.lblNombre.AutoSize = true;
			this.lblNombre.Location = new System.Drawing.Point(65, 117);
			this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(62, 17);
			this.lblNombre.TabIndex = 67;
			this.lblNombre.Text = "Nombre:";
			// 
			// lblCodCliente
			// 
			this.lblCodCliente.AutoSize = true;
			this.lblCodCliente.Location = new System.Drawing.Point(65, 59);
			this.lblCodCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodCliente.Name = "lblCodCliente";
			this.lblCodCliente.Size = new System.Drawing.Size(103, 17);
			this.lblCodCliente.TabIndex = 66;
			this.lblCodCliente.Text = "Código Cliente:";
			// 
			// lstCliente
			// 
			this.lstCliente.FormattingEnabled = true;
			this.lstCliente.ItemHeight = 16;
			this.lstCliente.Location = new System.Drawing.Point(52, 268);
			this.lstCliente.Margin = new System.Windows.Forms.Padding(4);
			this.lstCliente.Name = "lstCliente";
			this.lstCliente.Size = new System.Drawing.Size(852, 164);
			this.lstCliente.TabIndex = 85;
			// 
			// lstSexo
			// 
			this.lstSexo.FormattingEnabled = true;
			this.lstSexo.ItemHeight = 16;
			this.lstSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
			this.lstSexo.Location = new System.Drawing.Point(689, 174);
			this.lstSexo.Name = "lstSexo";
			this.lstSexo.Size = new System.Drawing.Size(132, 20);
			this.lstSexo.TabIndex = 87;
			// 
			// frmCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(973, 533);
			this.Controls.Add(this.lstSexo);
			this.Controls.Add(this.lstCliente);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.txtCodCliente);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtCI);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblSexo);
			this.Controls.Add(this.lblDireccion);
			this.Controls.Add(this.lblTelefono);
			this.Controls.Add(this.lblCI);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.lblCodCliente);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmCliente";
			this.Text = "frmCliente";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.ListBox lstCliente;
		private System.Windows.Forms.ListBox lstSexo;
	}
}