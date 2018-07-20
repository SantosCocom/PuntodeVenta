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
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtApellidoM;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtApellidoP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCurp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gpbUsuarios;
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
			this.gpbEmpleados = new System.Windows.Forms.GroupBox();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtApellidoM = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtApellidoP = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCurp = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvEmpleados = new System.Windows.Forms.DataGridView();
			this.gpbUsuarios = new System.Windows.Forms.GroupBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.btnAgregarUser = new System.Windows.Forms.Button();
			this.btnModificarUser = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.gpbEmpleados.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
			this.gpbUsuarios.SuspendLayout();
			this.SuspendLayout();
			// 
			// gpbEmpleados
			// 
			this.gpbEmpleados.Controls.Add(this.txtDireccion);
			this.gpbEmpleados.Controls.Add(this.label5);
			this.gpbEmpleados.Controls.Add(this.txtTelefono);
			this.gpbEmpleados.Controls.Add(this.label6);
			this.gpbEmpleados.Controls.Add(this.txtEdad);
			this.gpbEmpleados.Controls.Add(this.label7);
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
			this.gpbEmpleados.Size = new System.Drawing.Size(332, 219);
			this.gpbEmpleados.TabIndex = 0;
			this.gpbEmpleados.TabStop = false;
			this.gpbEmpleados.Text = "Datos del Empleado";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(106, 183);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(196, 20);
			this.txtDireccion.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(14, 186);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "Dirección:";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(106, 157);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(196, 20);
			this.txtTelefono.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(14, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "Teléfono:";
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(106, 131);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(196, 20);
			this.txtEdad.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 134);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 16);
			this.label7.TabIndex = 8;
			this.label7.Text = "Edad:";
			// 
			// txtApellidoM
			// 
			this.txtApellidoM.Location = new System.Drawing.Point(106, 105);
			this.txtApellidoM.Name = "txtApellidoM";
			this.txtApellidoM.Size = new System.Drawing.Size(196, 20);
			this.txtApellidoM.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(14, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(98, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Apellido Materno:";
			// 
			// txtApellidoP
			// 
			this.txtApellidoP.Location = new System.Drawing.Point(106, 79);
			this.txtApellidoP.Name = "txtApellidoP";
			this.txtApellidoP.Size = new System.Drawing.Size(196, 20);
			this.txtApellidoP.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(14, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 32);
			this.label3.TabIndex = 4;
			this.label3.Text = "Apellido Paterno:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(106, 53);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(196, 20);
			this.txtNombre.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombres:";
			// 
			// txtCurp
			// 
			this.txtCurp.Location = new System.Drawing.Point(106, 27);
			this.txtCurp.Name = "txtCurp";
			this.txtCurp.Size = new System.Drawing.Size(196, 20);
			this.txtCurp.TabIndex = 1;
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
			this.dgvEmpleados.Size = new System.Drawing.Size(459, 312);
			this.dgvEmpleados.TabIndex = 1;
			// 
			// gpbUsuarios
			// 
			this.gpbUsuarios.Controls.Add(this.txtPassword);
			this.gpbUsuarios.Controls.Add(this.label9);
			this.gpbUsuarios.Controls.Add(this.txtUser);
			this.gpbUsuarios.Controls.Add(this.label8);
			this.gpbUsuarios.Location = new System.Drawing.Point(20, 279);
			this.gpbUsuarios.Name = "gpbUsuarios";
			this.gpbUsuarios.Size = new System.Drawing.Size(331, 113);
			this.gpbUsuarios.TabIndex = 2;
			this.gpbUsuarios.TabStop = false;
			this.gpbUsuarios.Text = "Datos del Usuario";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(122, 58);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(178, 20);
			this.txtPassword.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(12, 61);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(86, 23);
			this.label9.TabIndex = 2;
			this.label9.Text = "Contraseña:";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(122, 29);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(178, 20);
			this.txtUser.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 32);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 23);
			this.label8.TabIndex = 0;
			this.label8.Text = "Nombre de Usuario:";
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(388, 378);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 3;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(516, 378);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 4;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(645, 378);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
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
			this.txtBuscar.TabIndex = 7;
			this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscarTextChanged);
			// 
			// btnAgregarUser
			// 
			this.btnAgregarUser.Location = new System.Drawing.Point(388, 378);
			this.btnAgregarUser.Name = "btnAgregarUser";
			this.btnAgregarUser.Size = new System.Drawing.Size(75, 23);
			this.btnAgregarUser.TabIndex = 8;
			this.btnAgregarUser.Text = "AgregarUser";
			this.btnAgregarUser.UseVisualStyleBackColor = true;
			// 
			// btnModificarUser
			// 
			this.btnModificarUser.Location = new System.Drawing.Point(516, 378);
			this.btnModificarUser.Name = "btnModificarUser";
			this.btnModificarUser.Size = new System.Drawing.Size(75, 23);
			this.btnModificarUser.TabIndex = 9;
			this.btnModificarUser.Text = "ModificarUser";
			this.btnModificarUser.UseVisualStyleBackColor = true;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(757, 378);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 23);
			this.btnCancelar.TabIndex = 10;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// FormUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 430);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnModificarUser);
			this.Controls.Add(this.btnAgregarUser);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.gpbUsuarios);
			this.Controls.Add(this.dgvEmpleados);
			this.Controls.Add(this.gpbEmpleados);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "FormUsuarios";
			this.Text = "Panel de Empleados";
			this.Load += new System.EventHandler(this.FormUsuariosLoad);
			this.gpbEmpleados.ResumeLayout(false);
			this.gpbEmpleados.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
			this.gpbUsuarios.ResumeLayout(false);
			this.gpbUsuarios.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
