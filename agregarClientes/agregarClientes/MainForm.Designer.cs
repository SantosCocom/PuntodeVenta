/*
 * Created by SharpDevelop.
 * User: MIKE
 * Date: 13/07/2018
 * Time: 07:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace agregarClientes
{
	partial class FormAgregarCliente
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellidoP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtApellidoM;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox grbDatos;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAñadir;
		private System.Windows.Forms.TextBox txtCurp;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnGuardarEdi;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtLocalidad;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnCancelar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregarCliente));
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtApellidoM = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtApellidoP = new System.Windows.Forms.TextBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.grbDatos = new System.Windows.Forms.GroupBox();
			this.txtLocalidad = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtCurp = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAñadir = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnGuardarEdi = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnCancelar = new System.Windows.Forms.Button();
			this.grbDatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(19, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre completo:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(19, 54);
			this.txtNombre.MaxLength = 60;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(212, 20);
			this.txtNombre.TabIndex = 1;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(19, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellido paterno:";
			// 
			// txtApellidoM
			// 
			this.txtApellidoM.Location = new System.Drawing.Point(135, 112);
			this.txtApellidoM.MaxLength = 60;
			this.txtApellidoM.Name = "txtApellidoM";
			this.txtApellidoM.Size = new System.Drawing.Size(96, 20);
			this.txtApellidoM.TabIndex = 5;
			this.txtApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoMKeyPress);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(135, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "Apellido materno:";
			// 
			// txtApellidoP
			// 
			this.txtApellidoP.Location = new System.Drawing.Point(19, 112);
			this.txtApellidoP.MaxLength = 60;
			this.txtApellidoP.Name = "txtApellidoP";
			this.txtApellidoP.Size = new System.Drawing.Size(96, 20);
			this.txtApellidoP.TabIndex = 6;
			this.txtApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoPKeyPress);
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(19, 227);
			this.txtDireccion.MaxLength = 60;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(212, 20);
			this.txtDireccion.TabIndex = 10;
			this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccionKeyPress);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(19, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 22);
			this.label5.TabIndex = 9;
			this.label5.Text = "Dirección:";
			// 
			// grbDatos
			// 
			this.grbDatos.Controls.Add(this.txtLocalidad);
			this.grbDatos.Controls.Add(this.label8);
			this.grbDatos.Controls.Add(this.txtCurp);
			this.grbDatos.Controls.Add(this.label4);
			this.grbDatos.Controls.Add(this.txtTelefono);
			this.grbDatos.Controls.Add(this.label7);
			this.grbDatos.Controls.Add(this.txtDireccion);
			this.grbDatos.Controls.Add(this.label5);
			this.grbDatos.Controls.Add(this.txtApellidoP);
			this.grbDatos.Controls.Add(this.txtApellidoM);
			this.grbDatos.Controls.Add(this.label3);
			this.grbDatos.Controls.Add(this.label2);
			this.grbDatos.Controls.Add(this.txtNombre);
			this.grbDatos.Controls.Add(this.label1);
			this.grbDatos.Location = new System.Drawing.Point(655, 53);
			this.grbDatos.Name = "grbDatos";
			this.grbDatos.Size = new System.Drawing.Size(252, 373);
			this.grbDatos.TabIndex = 11;
			this.grbDatos.TabStop = false;
			this.grbDatos.Text = "Datos del clíente";
			// 
			// txtLocalidad
			// 
			this.txtLocalidad.Location = new System.Drawing.Point(19, 342);
			this.txtLocalidad.MaxLength = 10;
			this.txtLocalidad.Name = "txtLocalidad";
			this.txtLocalidad.Size = new System.Drawing.Size(212, 20);
			this.txtLocalidad.TabIndex = 16;
			this.txtLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLocalidadKeyPress);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(19, 317);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(125, 22);
			this.label8.TabIndex = 15;
			this.label8.Text = "Localidad:";
			// 
			// txtCurp
			// 
			this.txtCurp.Location = new System.Drawing.Point(19, 169);
			this.txtCurp.MaxLength = 18;
			this.txtCurp.Name = "txtCurp";
			this.txtCurp.Size = new System.Drawing.Size(212, 20);
			this.txtCurp.TabIndex = 14;
			this.txtCurp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCurpKeyPress);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(19, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(125, 22);
			this.label4.TabIndex = 13;
			this.label4.Text = "CURP:";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(19, 284);
			this.txtTelefono.MaxLength = 10;
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(212, 20);
			this.txtTelefono.TabIndex = 12;
			this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoKeyPress);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(19, 259);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(125, 22);
			this.label7.TabIndex = 11;
			this.label7.Text = "Número de teléfono:";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(82, 27);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(576, 20);
			this.txtBuscar.TabIndex = 13;
			this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscarTextChanged);
			this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarKeyPress);
			// 
			// label6
			// 
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label6.Location = new System.Drawing.Point(12, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 22);
			this.label6.TabIndex = 12;
			this.label6.Text = "Buscar";
			// 
			// dgvClientes
			// 
			this.dgvClientes.AllowUserToAddRows = false;
			this.dgvClientes.AllowUserToDeleteRows = false;
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Location = new System.Drawing.Point(12, 53);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.ReadOnly = true;
			this.dgvClientes.Size = new System.Drawing.Size(646, 373);
			this.dgvClientes.TabIndex = 14;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(655, 444);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(105, 38);
			this.btnGuardar.TabIndex = 15;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(452, 444);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(105, 38);
			this.btnEliminar.TabIndex = 16;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnAñadir
			// 
			this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
			this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAñadir.Location = new System.Drawing.Point(124, 444);
			this.btnAñadir.Name = "btnAñadir";
			this.btnAñadir.Size = new System.Drawing.Size(105, 38);
			this.btnAñadir.TabIndex = 17;
			this.btnAñadir.Text = "Añadir";
			this.btnAñadir.UseVisualStyleBackColor = true;
			this.btnAñadir.Click += new System.EventHandler(this.BtnAñadirClick);
			// 
			// btnEditar
			// 
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(452, 444);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(105, 38);
			this.btnEditar.TabIndex = 18;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnGuardarEdi
			// 
			this.btnGuardarEdi.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarEdi.Image")));
			this.btnGuardarEdi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarEdi.Location = new System.Drawing.Point(655, 444);
			this.btnGuardarEdi.Name = "btnGuardarEdi";
			this.btnGuardarEdi.Size = new System.Drawing.Size(105, 38);
			this.btnGuardarEdi.TabIndex = 19;
			this.btnGuardarEdi.Text = "Guardar";
			this.btnGuardarEdi.UseVisualStyleBackColor = true;
			this.btnGuardarEdi.Click += new System.EventHandler(this.BtnGuardarEdiClick);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(802, 444);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(105, 38);
			this.btnCancelar.TabIndex = 20;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// FormAgregarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(928, 505);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardarEdi);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAñadir);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.grbDatos);
			this.MaximizeBox = false;
			this.Name = "FormAgregarCliente";
			this.Text = "Clientes";
			this.Load += new System.EventHandler(this.FormAgregarClienteLoad);
			this.grbDatos.ResumeLayout(false);
			this.grbDatos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
