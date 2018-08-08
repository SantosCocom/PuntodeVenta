/*
 * Created by SharpDevelop.
 * User: Santos
 * Date: 30/07/2018
 * Time: 12:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MenuPrincipal
{
	partial class FormEmpleado
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView dgvEmpleados;
		private System.Windows.Forms.GroupBox gpbEmpleados;
		private System.Windows.Forms.TextBox txtRol;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtLocalidad;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label label8;
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
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnModificarUser;
		private System.Windows.Forms.Button btnAgregarUser;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.ErrorProvider epError;
		private System.Windows.Forms.Label label7;
		
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.gpbEmpleados = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificarUser = new System.Windows.Forms.Button();
            this.btnAgregarUser = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.gpbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(440, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(556, 20);
            this.txtBuscar.TabIndex = 15;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscarTextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarKeyPress);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(367, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Buscar:";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dgvEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmpleados.Location = new System.Drawing.Point(377, 65);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(619, 433);
            this.dgvEmpleados.TabIndex = 13;
            // 
            // gpbEmpleados
            // 
            this.gpbEmpleados.Controls.Add(this.label7);
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
            this.gpbEmpleados.Location = new System.Drawing.Point(14, 65);
            this.gpbEmpleados.Name = "gpbEmpleados";
            this.gpbEmpleados.Size = new System.Drawing.Size(347, 515);
            this.gpbEmpleados.TabIndex = 12;
            this.gpbEmpleados.TabStop = false;
            this.gpbEmpleados.Text = "Datos del Empleado";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(116, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Datos para la cuenta:";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(116, 480);
            this.txtRol.MaxLength = 60;
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(196, 20);
            this.txtRol.TabIndex = 10;
            this.txtRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRolKeyPress);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 480);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Rol:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(116, 219);
            this.txtLocalidad.MaxLength = 60;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(196, 20);
            this.txtLocalidad.TabIndex = 5;
            this.txtLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLocalidadKeyPress);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Localidad:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 440);
            this.txtPassword.MaxLength = 60;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(196, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPasswordKeyPress);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Contraseña:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(116, 259);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(196, 20);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDireccionKeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dirección:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(116, 399);
            this.txtUser.MaxLength = 60;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(196, 20);
            this.txtUser.TabIndex = 8;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserKeyPress);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre de Usuario:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(116, 301);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(196, 20);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoKeyPress);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Teléfono:";
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.Location = new System.Drawing.Point(116, 176);
            this.txtApellidoM.MaxLength = 60;
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(196, 20);
            this.txtApellidoM.TabIndex = 4;
            this.txtApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoMKeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido Materno:";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(116, 131);
            this.txtApellidoP.MaxLength = 60;
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(196, 20);
            this.txtApellidoP.TabIndex = 3;
            this.txtApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoPKeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido Paterno:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 82);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres:";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(116, 39);
            this.txtCurp.MaxLength = 18;
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(196, 20);
            this.txtCurp.TabIndex = 1;
            this.txtCurp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCurpKeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curp:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCancelar.Location = new System.Drawing.Point(800, 521);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 35);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
            // 
            // btnModificarUser
            // 
            this.btnModificarUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnModificarUser.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnModificarUser.Location = new System.Drawing.Point(517, 521);
            this.btnModificarUser.Name = "btnModificarUser";
            this.btnModificarUser.Size = new System.Drawing.Size(148, 35);
            this.btnModificarUser.TabIndex = 20;
            this.btnModificarUser.Text = "Modificar Usuario";
            this.btnModificarUser.UseVisualStyleBackColor = false;
            this.btnModificarUser.Click += new System.EventHandler(this.BtnModificarUserClick);
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarUser.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAgregarUser.Location = new System.Drawing.Point(367, 521);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(144, 35);
            this.btnAgregarUser.TabIndex = 19;
            this.btnAgregarUser.Text = "Agregar Usuario";
            this.btnAgregarUser.UseVisualStyleBackColor = false;
            this.btnAgregarUser.Click += new System.EventHandler(this.BtnAgregarUserClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnEliminar.Location = new System.Drawing.Point(672, 521);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 35);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnModificar.Location = new System.Drawing.Point(518, 521);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(126, 35);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAgregar.Location = new System.Drawing.Point(419, 521);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(92, 34);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(959, 520);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 35);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(10, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 23);
            this.label13.TabIndex = 79;
            this.label13.Text = "-Apartado empleados-";
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1039, 612);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificarUser);
            this.Controls.Add(this.btnAgregarUser);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.gpbEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleado";
            this.Text = "FormEmpleado";
            this.Load += new System.EventHandler(this.FormEmpleadoLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.gpbEmpleados.ResumeLayout(false);
            this.gpbEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label13;
    }
}
