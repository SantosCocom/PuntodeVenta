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
using Herramientas;


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
			gpbEmpleados.Enabled=false;
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			btnAgregar.Visible=false;//Boton solo para llamar el groupbox se queda oculto
			btnAgregarUser.Visible=true;//Boton que hara la accion de agregar se queda visible
			btnModificar.Enabled=false;//Se bloquea el boton de modificar
			btnEliminar.Enabled=false;//Se bloquea el boton de eliminar
			btnModificarUser.Visible=false;//Se oculta el 2 boton de modificar
			
			gpbEmpleados.Enabled=true;//Se habilita el groupbox para poder agregar datos
		}
		void BtnModificarClick(object sender, EventArgs e)
		{
			btnModificar.Visible=false;//El primer boton de modificar se oculta
			btnModificarUser.Visible=true;//El segundo boton de modificar se activa
			btnAgregar.Enabled=false;//Se bloquea el boton de agregar
			btnEliminar.Enabled=false;//Se bloquea el boton de eliminar
			gpbEmpleados.Enabled=true;//Se activa el gruopbox para llenar datos
			
			//JALAMOS LOS DATOS DEL DATAGRID A LOS CAMPOS PARA QUE LOS PUEDA EDITAR
			txtCurp.Text = dgvEmpleados[0,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtNombre.Text = dgvEmpleados[1,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtApellidoP.Text = dgvEmpleados[2,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtApellidoM.Text = dgvEmpleados[3,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtLocalidad.Text = dgvEmpleados[4,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtDireccion.Text = dgvEmpleados[5,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtTelefono.Text = dgvEmpleados[6,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtUser.Text = dgvEmpleados[7,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtPassword.Text = dgvEmpleados[8,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			txtRol.Text = dgvEmpleados[9,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
			
		}
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			oEmpleados.BuscarEmpleado(txtBuscar.Text,dgvEmpleados);//Mostrar los datos en el datagrid
		}
		void BtnAgregarUserClick(object sender, EventArgs e)
		{
			//SE CARGAN LO QUE SE INGRESO PARA PODER MANDARLO A INSERSION
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
			
			oEmpleados.BuscarEmpleado(txtBuscar.Text,dgvEmpleados);//Actualiza el datagrid
			
			//SE LIMPIAN LOS TEXTBOXS
			txtCurp.Clear();
			txtNombre.Clear();
			txtApellidoP.Clear();
			txtApellidoM.Clear();
			txtLocalidad.Clear();
			txtDireccion.Clear();
			txtTelefono.Clear();
			txtUser.Clear();
			txtPassword.Clear();
			txtRol.Clear();
			txtCurp.Focus();
			
			gpbEmpleados.Enabled=false;
			
			btnAgregar.Visible=true;
			btnAgregarUser.Visible=false;
			btnModificar.Enabled=true;
			btnModificarUser.Visible=false;
			btnEliminar.Enabled=true;
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Esta seguro de eliminar este usuario?","Cuidado",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)== DialogResult.Yes) 
			{
				string clave = dgvEmpleados[0,dgvEmpleados.CurrentCellAddress.Y].Value.ToString();
				oEmpleados.EliminarEmpleadoDeLaLista(clave);
				oEmpleados.BuscarEmpleado(txtBuscar.Text,dgvEmpleados);//Actualiza el datagridview de los empleados
				
				
			}
			
			btnAgregar.Enabled=true;
			btnAgregarUser.Visible=false;
			btnModificarUser.Visible=false;
			btnModificar.Enabled=true;
			btnEliminar.Enabled=true;
			
		}
		void BtnModificarUserClick(object sender, EventArgs e)
		{
			oEmpleados.ActualizarEmpleado(txtNombre.Text,txtApellidoP.Text,txtApellidoM.Text,txtLocalidad.Text,txtDireccion.Text,txtTelefono.Text,txtUser.Text, txtPassword.Text, txtRol.Text,txtCurp.Text);
			oEmpleados.BuscarEmpleado(txtBuscar.Text,dgvEmpleados);//Actualiza el datagrid de empleados
			
			txtCurp.Clear();
			txtNombre.Clear();
			txtApellidoP.Clear();
			txtApellidoM.Clear();
			txtLocalidad.Clear();
			txtDireccion.Clear();
			txtTelefono.Clear();
			txtUser.Clear();
			txtPassword.Clear();
			txtRol.Clear();
			
			gpbEmpleados.Enabled=false;
			btnModificar.Visible=true;
			btnModificarUser.Visible=false;
			btnAgregar.Enabled=true;
			btnEliminar.Enabled=true;
			
		}
		void TxtBuscarKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar=Validaciones.valida("T",e.KeyChar);
		}
		void TxtCurpKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar=Validaciones.valida("U",e.KeyChar);
		}
		void TxtNombreKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar=Validaciones.valida("T",e.KeyChar);
		}
		void TxtApellidoPKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar=Validaciones.valida("T",e.KeyChar);
		}
		void TxtApellidoMKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar=Validaciones.valida("T",e.KeyChar);
		}
		void TxtLocalidadKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar=Validaciones.valida("T",e.KeyChar);
		}
		void TxtDireccionKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar=Validaciones.valida("U",e.KeyChar);
		}
		void TxtTelefonoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar=Validaciones.valida("N",e.KeyChar);
		}
		void TxtUserKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar=Validaciones.valida("U",e.KeyChar);
		}
		void TxtPasswordKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar=Validaciones.valida("U",e.KeyChar);
		}
		void TxtRolKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar=Validaciones.valida("T",e.KeyChar);
		}
		
		
		
	}
}
