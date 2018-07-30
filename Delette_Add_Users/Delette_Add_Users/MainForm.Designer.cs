/*
 * Created by SharpDevelop.
 * User: Abraham
 * Date: 14/07/2018
 * Time: 16:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Delette_Add_Users
{
	partial class FormUsuarios
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox gpbEmpleados;
		private System.Windows.Forms.DataGridView dgvEmpleados;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtApellidoM;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtApellidoP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCurp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Button btnAgregarUser;
		private System.Windows.Forms.Button btnModificarUser;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.TextBox txtLocalidad;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtRol;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ErrorProvider epError;
		
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
			this.gpbEmpleados = new System.Windows.Forms.GroupBox();
			this.txtRol = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtLocalidad = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtApellidoM = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtApellidoP = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCurp = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvEmpleados = new System.Windows.Forms.DataGridView();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.btnAgregarUser = new System.Windows.Forms.Button();
			this.btnModificarUser = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.epError = new System.Windows.Forms.ErrorProvider(this.components);
			this.gpbEmpleados.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
			this.SuspendLayout();
			// 
			// gpbEmpleados
			// 
			this.gpbEmpleados.Controls.Add(this.txtRol);
			this.gpbEmpleados.Controls.Add(this.label11);
			this.gpbEmpleados.Controls.Add(this.txtLocalidad);
			this.gpbEmpleados.Controls.Add(this.label12);
			this.gpbEmpleados.Controls.Add(this.txtPassword);
			this.gpbEmpleados.Controls.Add(this.label9);
			this.gpbEmpleados.Controls.Add(this.txtDireccion);
			this.gpbEmpleados.Controls.Add(this.label5);
			this.gpbEmpleados.Controls.Add(this.txtUser);
			this.gpbEmpleados.Controls.Add(this.label8);
			this.gpbEmpleados.Controls.Add(this.txtTelefono);
			this.gpbEmpleados.Controls.Add(this.label6);
			this.gpbEmpleados.Controls.Add(this.txtApellidoM);
			this.gpbEmpleados.Controls.Add(this.label4);
			this.gpbEmpleados.Controls.Add(this.txtApellidoP);
			this.gpbEmpleados.Controls.Add(this.label3);
			this.gpbEmpleados.Controls.Add(this.txtNombre);
			this.gpbEmpleados.Controls.Add(this.label2);
			this.gpbEmpleados.Controls.Add(this.txtCurp);
			this.gpbEmpleados.Controls.Add(this.label1);
			this.gpbEmpleados.Location = new System.Drawing.Point(20, 46);
			this.gpbEmpleados.Name = "gpbEmpleados";
			this.gpbEmpleados.Size = new System.Drawing.Size(347, 414);
			this.gpbEmpleados.TabIndex = 0;
			this.gpbEmpleados.TabStop = false;
			this.gpbEmpleados.Text = "Datos del Empleado";
			// 
			// txtRol
			// 
			this.txtRol.Location = new System.Drawing.Point(116, 373);
			this.txtRol.MaxLength = 60;
			this.txtRol.Name = "txtRol";
			this.txtRol.Size = new System.Drawing.Size(196, 20);
			this.txtRol.TabIndex = 10;
			this.txtRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRolKeyPress);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(12, 373);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(104, 23);
			this.label11.TabIndex = 4;
			this.label11.Text = "Rol:";
			// 
			// txtLocalidad
			// 
			this.txtLocalidad.Location = new System.Drawing.Point(118, 180);
			this.txtLocalidad.MaxLength = 60;
			this.txtLocalidad.Name = "txtLocalidad";
			this.txtLocalidad.Size = new System.Drawing.Size(196, 20);
			this.txtLocalidad.TabIndex = 5;
			this.txtLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLocalidadKeyPress);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(14, 183);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(98, 17);
			this.label12.TabIndex = 14;
			this.label12.Text = "Localidad:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(116, 334);
			this.txtPassword.MaxLength = 60;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(196, 20);
			this.txtPassword.TabIndex = 9;
			this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPasswordKeyPress);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(12, 334);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(104, 23);
			this.label9.TabIndex = 2;
			this.label9.Text = "Contraseña:";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(118, 217);
			this.txtDireccion.MaxLength = 60;
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(196, 20);
			this.txtDireccion.TabIndex = 6;
			this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccionKeyPress);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(14, 220);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "Dirección:";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(116, 296);
			this.txtUser.MaxLength = 60;
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(196, 20);
			this.txtUser.TabIndex = 8;
			this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserKeyPress);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 299);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(106, 23);
			this.label8.TabIndex = 0;
			this.label8.Text = "Nombre de Usuario:";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(118, 256);
			this.txtTelefono.MaxLength = 10;
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(196, 20);
			this.txtTelefono.TabIndex = 7;
			this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoKeyPress);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(14, 256);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "Teléfono:";
			// 
			// txtApellidoM
			// 
			this.txtApellidoM.Location = new System.Drawing.Point(118, 139);
			this.txtApellidoM.MaxLength = 60;
			this.txtApellidoM.Name = "txtApellidoM";
			this.txtApellidoM.Size = new System.Drawing.Size(196, 20);
			this.txtApellidoM.TabIndex = 4;
			this.txtApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoMKeyPress);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(14, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Apellido Materno:";
			// 
			// txtApellidoP
			// 
			this.txtApellidoP.Location = new System.Drawing.Point(118, 98);
			this.txtApellidoP.MaxLength = 60;
			this.txtApellidoP.Name = "txtApellidoP";
			this.txtApellidoP.Size = new System.Drawing.Size(196, 20);
			this.txtApellidoP.TabIndex = 3;
			this.txtApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoPKeyPress);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(14, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 32);
			this.label3.TabIndex = 4;
			this.label3.Text = "Apellido Paterno:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(118, 66);
			this.txtNombre.MaxLength = 60;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(196, 20);
			this.txtNombre.TabIndex = 2;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombres:";
			// 
			// txtCurp
			// 
			this.txtCurp.Location = new System.Drawing.Point(118, 27);
			this.txtCurp.MaxLength = 18;
			this.txtCurp.Name = "txtCurp";
			this.txtCurp.Size = new System.Drawing.Size(196, 20);
			this.txtCurp.TabIndex = 1;
			this.txtCurp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCurpKeyPress);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Curp:";
			// 
			// dgvEmpleados
			// 
			this.dgvEmpleados.AllowUserToAddRows = false;
			this.dgvEmpleados.AllowUserToDeleteRows = false;
			this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmpleados.Location = new System.Drawing.Point(373, 46);
			this.dgvEmpleados.Name = "dgvEmpleados";
			this.dgvEmpleados.ReadOnly = true;
			this.dgvEmpleados.Size = new System.Drawing.Size(459, 393);
			this.dgvEmpleados.TabIndex = 1;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(388, 449);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 3;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(516, 449);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 4;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(648, 449);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(373, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 6;
			this.label10.Text = "Buscar:";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(446, 6);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(373, 20);
			this.txtBuscar.TabIndex = 11;
			this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscarTextChanged);
			this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarKeyPress);
			// 
			// btnAgregarUser
			// 
			this.btnAgregarUser.Location = new System.Drawing.Point(388, 449);
			this.btnAgregarUser.Name = "btnAgregarUser";
			this.btnAgregarUser.Size = new System.Drawing.Size(75, 23);
			this.btnAgregarUser.TabIndex = 8;
			this.btnAgregarUser.Text = "AgregarUser";
			this.btnAgregarUser.UseVisualStyleBackColor = true;
			this.btnAgregarUser.Click += new System.EventHandler(this.BtnAgregarUserClick);
			// 
			// btnModificarUser
			// 
			this.btnModificarUser.Location = new System.Drawing.Point(516, 449);
			this.btnModificarUser.Name = "btnModificarUser";
			this.btnModificarUser.Size = new System.Drawing.Size(75, 23);
			this.btnModificarUser.TabIndex = 9;
			this.btnModificarUser.Text = "ModificarUser";
			this.btnModificarUser.UseVisualStyleBackColor = true;
			this.btnModificarUser.Click += new System.EventHandler(this.BtnModificarUserClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(757, 449);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 10;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// epError
			// 
			this.epError.ContainerControl = this;
			// 
			// FormUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 504);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnModificarUser);
			this.Controls.Add(this.btnAgregarUser);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dgvEmpleados);
			this.Controls.Add(this.gpbEmpleados);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "FormUsuarios";
			this.Text = "Panel de Empleados";
			this.Load += new System.EventHandler(this.FormUsuariosLoad);
			this.gpbEmpleados.ResumeLayout(false);
			this.gpbEmpleados.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
