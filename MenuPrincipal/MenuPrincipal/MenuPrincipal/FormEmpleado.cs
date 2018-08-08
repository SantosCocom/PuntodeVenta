/*
 * Created by SharpDevelop.
 * User: Santos
 * Date: 30/07/2018
 * Time: 12:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Delette_Add_Users.Controllers;
using Herramientas;
namespace MenuPrincipal
{
	/// <summary>
	/// Description of FormEmpleado.
	/// </summary>
	public partial class FormEmpleado : Form
	{
		EmpleadosControllers oEmpleados = new EmpleadosControllers();
		public FormEmpleado()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FormEmpleadoLoad(object sender, EventArgs e)
		{
			btnAgregarUser.Visible=false;
			btnModificarUser.Visible=false;
			oEmpleados.BuscarEmpleado(txtBuscar.Text, dgvEmpleados);
			gpbEmpleados.Enabled=false;
			btnCancelar.Visible=false;
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			btnAgregar.Visible=false;//Boton solo para llamar el groupbox se queda oculto
			btnAgregarUser.Visible=true;//Boton que hara la accion de agregar se queda visible
			btnModificar.Enabled=false;//Se bloquea el boton de modificar
			btnEliminar.Enabled=false;//Se bloquea el boton de eliminar
			btnModificarUser.Visible=false;//Se oculta el 2 boton de modificar
			txtCurp.Enabled=true;
			
			gpbEmpleados.Enabled=true;//Se habilita el groupbox para poder agregar datos
			
			btnCancelar.Visible=true;//Se habilita el boton para poder cancelar
		}
		void BtnModificarClick(object sender, EventArgs e)
		{
			btnModificar.Visible=false;//El primer boton de modificar se oculta
			btnModificarUser.Visible=true;//El segundo boton de modificar se activa
			btnAgregar.Enabled=false;//Se bloquea el boton de agregar
			btnEliminar.Enabled=false;//Se bloquea el boton de eliminar
			gpbEmpleados.Enabled=true;//Se activa el gruopbox para llenar datos
			txtCurp.Enabled=false;
			
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
			
			btnCancelar.Visible=true;//Habilitamos el boton de cancelar 
			
		}
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			oEmpleados.BuscarEmpleado(txtBuscar.Text,dgvEmpleados);//Mostrar los datos en el datagrid
		}
		void BtnAgregarUserClick(object sender, EventArgs e)
		{
			LimpiarError();
			if (ValidarCampos()) 
			{
				MessageBox.Show("Datos ingresados correctamente");
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
				btnCancelar.Visible=false;
				
			}else
				MessageBox.Show("Por favor llene todos los campos");
			
			
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
			LimpiarError();
			if (ValidarCampos()) 
			{
				MessageBox.Show("Los datos se modificaron correctamente");
				
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
				btnCancelar.Enabled=false;
			}else
				MessageBox.Show("Por favor llene todos los campos");
			
			
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
		
		private bool ValidarCampos()
		{
			bool ok=true;
			if (txtCurp.Text=="") 
			{
				ok=false;
				epError.SetError(txtCurp,"Ingrese la curp del empleado");
			}
			
			if (txtNombre.Text=="") 
			{
				ok=false;
				epError.SetError(txtNombre,"Ingrese los nombres del empleado");
			}
			
			if (txtApellidoP.Text=="") 
			{
				ok=false;
				epError.SetError(txtApellidoP,"Ingrese el apellido paterno del empleado");
			}
			
			if (txtApellidoM.Text=="") 
			{
				ok=false;
				epError.SetError(txtApellidoM,"Ingrese el apellido materno del empleado");
			}
			
			if (txtLocalidad.Text=="") 
			{
				ok=false;
				epError.SetError(txtLocalidad,"Ingrese la localidad del empleado");
			}
			
			if (txtDireccion.Text=="") 
			{
				ok=false;
				epError.SetError(txtDireccion,"Ingrese la direccion del empleado");
			}
			
			if (txtTelefono.Text=="") 
			{
				ok=false;
				epError.SetError(txtTelefono,"Ingrese el numero de telefono del empleado");
			}
			
			if (txtUser.Text=="") 
			{
				ok=false;
				epError.SetError(txtUser,"Ingrese el nombre de usuario del empleado");
			}
			
			if (txtPassword.Text=="") 
			{
				ok=false;
				epError.SetError(txtPassword,"Ingrese la contraseña del empleado para poder iniciar sesión");
			}
			
			if (txtRol.Text=="") 
			{
				ok=false;
				epError.SetError(txtRol,"Ingrese el rol del empleado");
			}
			return ok;
		}
		
		private void LimpiarError()
		{
			epError.SetError(txtCurp,"");
			epError.SetError(txtNombre,"");
			epError.SetError(txtApellidoP,"");
			epError.SetError(txtApellidoM,"");
			epError.SetError(txtLocalidad,"");
			epError.SetError(txtDireccion,"");
			epError.SetError(txtTelefono,"");
			epError.SetError(txtUser,"");
			epError.SetError(txtPassword,"");
			epError.SetError(txtRol,"");
		}
		void BtnCancelarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Esta seguro de cancelar la operación?","",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes) 
			{
				LimpiarError();
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
				
				btnAgregar.Visible=true;
				btnAgregar.Enabled=true;
				btnAgregarUser.Visible=false;
				
				btnModificar.Visible=true;
				btnModificar.Enabled=true;
				btnModificarUser.Visible=false;
				
				btnEliminar.Visible=true;
				btnEliminar.Enabled=true;
				
				btnCancelar.Visible=false;
				
				gpbEmpleados.Enabled=false;
				
			}
		}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está usted seguro que desea salir?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
