/*
 * Created by SharpDevelop.
 * User: Abraham
 * Date: 14/07/2018
 * Time: 16:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AccesoADatos;
using Delette_Add_Users.Controllers;


namespace Delette_Add_Users
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class FormUsuarios : Form
	{
		EmpleadosControllers oEmpleados = new EmpleadosControllers();
		public FormUsuarios()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FormUsuariosLoad(object sender, EventArgs e)
		{
			btnAgregarUser.Visible=false;
			btnModificarUser.Visible=false;
			oEmpleados.BuscarEmpleado(txtBuscar.Text, dgvEmpleados);
			oEmpleados.BuscarUsuario(txtBuscar.Text, dgvUsuarios);//Actualiza el datagrid de usuarios
			gpbEmpleados.Enabled=false;
			gpbUsuarios.Enabled=false;
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			btnAgregar.Visible=false;
			btnModificar.Enabled=false;
			btnEliminar.Enabled=false;
			btnModificarUser.Visible=false;
			btnAgregarUser.Visible=true;
			gpbEmpleados.Enabled=true;
			gpbUsuarios.Enabled=true;
		}
		void BtnModificarClick(object sender, EventArgs e)
		{
			btnModificar.Visible=false;
			btnModificarUser.Visible=true;
			gpbUsuarios.Visible=true;
			btnAgregar.Enabled=false;
			btnEliminar.Enabled=false;
			gpbUsuarios.Enabled=true;
			gpbEmpleados.Enabled=true;
			
			txtCurp.Text = dgvEmpleados[0,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtNombre.Text = dgvEmpleados[1,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtApellidoP.Text = dgvEmpleados[2,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtApellidoM.Text = dgvEmpleados[3,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtLocalidad.Text = dgvEmpleados[4,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtDireccion.Text = dgvEmpleados[5,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtTelefono.Text = dgvEmpleados[6,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			
			txtUser.Text = dgvUsuarios[0,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtPassword.Text = dgvUsuarios[1,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtRol.Text = dgvUsuarios[2,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtCurpUser.Text = dgvUsuarios[3,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			
		}
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			oEmpleados.BuscarEmpleado(txtBuscar.Text,dgvEmpleados);
		}
		void BtnAgregarUserClick(object sender, EventArgs e)
		{
			oEmpleados.Id_empleado=txtCurp.Text;
			oEmpleados.Nombre=txtNombre.Text;
			oEmpleados.Apellido_paterno=txtApellidoP.Text;
			oEmpleados.Apellido_materno=txtApellidoM.Text;
			oEmpleados.Localidad=txtLocalidad.Text;
			oEmpleados.Direccion=txtDireccion.Text;
			oEmpleados.Telefono=txtTelefono.Text;
			
			
			oEmpleados.Usuario=txtUser.Text;
			oEmpleados.Password=txtPassword.Text;
			oEmpleados.Rol=txtRol.Text;
			
			oEmpleados.InsertarEmpleado();
			
			string curp=txtCurp.Text;
			
			txtCurpUser.Text=curp;
			
			oEmpleados.InsertarUsuario();
			oEmpleados.BuscarEmpleado(txtBuscar.Text,dgvEmpleados);//Actualiza el datagrid
			oEmpleados.BuscarUsuario(txtBuscar.Text, dgvUsuarios);//Actualiza el datagrid de users
			
			txtCurp.Clear();
			txtNombre.Clear();
			txtApellidoP.Clear();
			txtApellidoM.Clear();
			txtLocalidad.Clear();
			txtDireccion.Clear();
			txtTelefono.Clear();
			
			txtCurpUser.Clear();
			txtUser.Clear();
			txtPassword.Clear();
			txtRol.Clear();
			
			txtCurp.Focus();
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta seguro de eliminar","Cuidado",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)== DialogResult.Yes) 
			{
				string clave = dgvEmpleados[0,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
				oEmpleados.EliminarEmpleado(clave);
				oEmpleados.BuscarEmpleado(txtBuscar.Text,dgvEmpleados);//Actualiza el datagridview de los empleados 
				
			}
		}
		void BtnModificarUserClick(object sender, EventArgs e)
		{
			oEmpleados.ActualizarEmpleado(txtCurp.Text,txtNombre.Text,txtApellidoP.Text,txtApellidoM.Text,txtLocalidad.Text,txtDireccion.Text,txtTelefono.Text);
			oEmpleados.ActualizarUsuario(txtCurpUser.Text,txtUser.Text, txtPassword.Text, txtRol.Text);
			oEmpleados.BuscarEmpleado(txtBuscar.Text,dgvEmpleados);//Actualiza el datagrid de empleados
			oEmpleados.BuscarUsuario(txtBuscar.Text, dgvUsuarios);//Actualiza el datagrid de usuarios
			
			txtCurp.Clear();
			txtNombre.Clear();
			txtApellidoP.Clear();
			txtApellidoM.Clear();
			txtLocalidad.Clear();
			txtDireccion.Clear();
			txtTelefono.Clear();
			
			txtCurpUser.Clear();
			txtUser.Clear();
			txtPassword.Clear();
			txtRol.Clear();
			
			btnModificar.Visible=true;
			btnModificarUser.Visible=false;
		}
		
		
		
		
		
		
		
		
		
		
	}
}
