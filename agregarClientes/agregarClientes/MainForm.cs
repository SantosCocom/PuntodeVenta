/*
 * Created by SharpDevelop.
 * User: MIKE
 * Date: 13/07/2018
 * Time: 07:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Clientes.Controllers;
using Herramientas;

namespace agregarClientes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class FormAgregarCliente : Form
	{
		ClientesController oClientes = new ClientesController();
		
		public FormAgregarCliente()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			txtBuscar.Focus();
			
			grbDatos.Enabled=false;
			btnGuardar.Visible=false;
			btnGuardarEdi.Visible=false;
			btnCancelar.Visible=false;
			btnEliminar.Visible=false;
			
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FormAgregarClienteLoad(object sender, EventArgs e)
		{
			oClientes.BuscarClientes(txtBuscar.Text, dgvClientes);
		}
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			oClientes.BuscarClientes(txtBuscar.Text, dgvClientes);
		}
		
		void BtnAñadirClick(object sender, EventArgs e)
		{
			grbDatos.Enabled=true;
			btnAñadir.Visible=false;
			btnEditar.Visible=false;
			btnEliminar.Visible=false;
			
			btnCancelar.Visible=true;
			btnGuardar.Visible=true;
			txtNombre.Focus();
		}
		//Guardar el nuevo registro
		void BtnGuardarClick(object sender, EventArgs e)
		{
			txtBuscar.Focus();
			ClearError();
			if (validarcampos())
			{
				
			MessageBox.Show("Datos ingresados correctamente");
			oClientes.id_cliente = txtCurp.Text;
			oClientes.Nombre = txtNombre.Text;
			oClientes.Apellido_paterno = txtApellidoP.Text;
			oClientes.Apellido_materno = txtApellidoM.Text;
			oClientes.Direccion = txtDireccion.Text;
			oClientes.Numero_celular = txtTelefono.Text;
			oClientes.localidad = txtLocalidad.Text;
			
			oClientes.Store();
			
			oClientes.BuscarClientes(txtBuscar.Text, dgvClientes);
			
			txtCurp.Clear();
			txtNombre.Clear();
			txtApellidoP.Clear();
			txtApellidoM.Clear();
			txtDireccion.Clear();
			txtTelefono.Clear();
			txtLocalidad.Clear();
			
			btnGuardar.Visible=false;
			
			btnAñadir.Visible=true;
			btnEditar.Visible=true;
			btnEliminar.Visible=false;
			btnCancelar.Visible=false;
			grbDatos.Enabled=false;
			
			txtBuscar.Focus();
			}else
			{
				MessageBox.Show("Favor de llenar todos los campos");
			}
		}
		void BtnEditarClick(object sender, EventArgs e)
		{
			grbDatos.Enabled=true;
			btnAñadir.Visible=false;
			btnEditar.Visible=false;
			btnEliminar.Visible=false;
			
			txtCurp.Enabled=false;
			
			txtCurp.Text = dgvClientes[0, dgvClientes.CurrentCellAddress.Y].Value.ToString();
			txtNombre.Text = dgvClientes[1, dgvClientes.CurrentCellAddress.Y].Value.ToString();
			txtApellidoP.Text = dgvClientes[2, dgvClientes.CurrentCellAddress.Y].Value.ToString(); 
			txtApellidoM.Text = dgvClientes[3, dgvClientes.CurrentCellAddress.Y].Value.ToString();
			txtDireccion.Text = dgvClientes[4, dgvClientes.CurrentCellAddress.Y].Value.ToString();
			txtTelefono.Text = dgvClientes[5, dgvClientes.CurrentCellAddress.Y].Value.ToString();
			txtLocalidad.Text = dgvClientes[6, dgvClientes.CurrentCellAddress.Y].Value.ToString();
			txtNombre.Focus();
			
			btnCancelar.Visible=true;
			btnGuardarEdi.Visible=true;
		}
		//GUARda EDICIÓN DE LOS REGISTROS
		void BtnGuardarEdiClick(object sender, EventArgs e)
		{
			ClearError();
			if (validarcampos())
			{
			MessageBox.Show("Datos actualizados correctamente");
			oClientes.Update(txtCurp.Text,txtNombre.Text,txtApellidoP.Text,txtApellidoM.Text,txtDireccion.Text,txtTelefono.Text,txtLocalidad.Text);
			oClientes.BuscarClientes(txtBuscar.Text, dgvClientes);
			
			txtCurp.Clear();
			txtNombre.Clear();
			txtApellidoP.Clear();
			txtApellidoM.Clear();
			txtDireccion.Clear();
			txtTelefono.Clear();
			txtLocalidad.Clear();
			btnGuardarEdi.Visible=false;
			
			
			btnAñadir.Visible=true;
			btnEditar.Visible=true;
			btnEliminar.Visible=false;
			btnCancelar.Visible=false;
			grbDatos.Enabled=false;
			
			txtBuscar.Focus();
			}else
			{
				MessageBox.Show("Favor de llenar todos los campos");
			}

		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta seguro para eliminar", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.Yes)
			{
			string clave = dgvClientes[0, dgvClientes.CurrentCellAddress.Y].Value.ToString();
			oClientes.Eliminar(clave);
			oClientes.BuscarClientes(txtBuscar.Text, dgvClientes);
			}
			txtBuscar.Focus();
		}
		void BtnCancelarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Esta seguro de cancelar la operación", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)==DialogResult.Yes)
			{
			ClearError();
			txtCurp.Clear();
			txtNombre.Clear();
			txtApellidoP.Clear();
			txtApellidoM.Clear();
			txtDireccion.Clear();
			txtTelefono.Clear();
			txtLocalidad.Clear();
			
			btnGuardar.Visible=false;
			btnGuardarEdi.Visible=false;
			
			btnAñadir.Visible=true;
			btnEditar.Visible=true;
			btnEliminar.Visible=false;
			btnCancelar.Visible=false;
			grbDatos.Enabled=false;
			txtBuscar.Focus();
			}
		}
		
		//MÉTODOS PARA VALIDAR CAMPOS
		private bool validarcampos()
		{
			bool ok = true;
			if(txtNombre.Text == "")
			{
				ok = false;
				errorProvider1.SetError(txtNombre, "Ingresar nombre");
			}
			if(txtApellidoP.Text == "")
			{
				ok = false;
				errorProvider1.SetError(txtApellidoP, "Ingresar apellido");
			}
			if(txtApellidoM.Text == "")
			{
				ok = false;
				errorProvider1.SetError(txtApellidoM, "Ingresar apellido");
			}
			if(txtCurp.Text == "")
			{
				ok = false;
				errorProvider1.SetError(txtCurp, "Ingresar la CURP");
			}
			if(txtDireccion.Text == "")
			{
				ok = false;
				errorProvider1.SetError(txtDireccion, "Ingresar direccion");
			}
			if(txtTelefono.Text == "")
			{
				ok = false;
				errorProvider1.SetError(txtTelefono, "Ingresar numero de teléfono");
			}
			if(txtLocalidad.Text == "")
			{
				ok = false;
				errorProvider1.SetError(txtLocalidad, "Ingresar numero de localidad");
			}
			return ok;
		}
		private void ClearError()
		{
			errorProvider1.SetError(txtNombre, "");
			errorProvider1.SetError(txtApellidoP, "");
			errorProvider1.SetError(txtApellidoM, "");
			errorProvider1.SetError(txtCurp, "");
			errorProvider1.SetError(txtDireccion, "");
			errorProvider1.SetError(txtTelefono, "");
			errorProvider1.SetError(txtLocalidad, "");
		}
		void TxtNombreKeyPress(object sender, KeyPressEventArgs e)
		{
		   	e.KeyChar = Validaciones.valida("T", e.KeyChar);
		}
		void TxtApellidoPKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T", e.KeyChar);
		}
		void TxtApellidoMKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T", e.KeyChar);
		}
		void TxtCurpKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U", e.KeyChar);
		}
		void TxtDireccionKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U", e.KeyChar);
		}
		void TxtTelefonoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("N", e.KeyChar);
		}
		void TxtBuscarKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T", e.KeyChar);
		}
		void TxtLocalidadKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T", e.KeyChar);
		}
		
	}
}
