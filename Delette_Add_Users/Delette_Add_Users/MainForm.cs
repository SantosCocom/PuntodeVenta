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
			gpbUsuarios.Visible=false;
			btnAgregarUser.Visible=false;
			btnModificarUser.Visible=false;
			oEmpleados.BuscarEmpleado(txtBuscar.Text, dgvEmpleados);
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			gpbUsuarios.Visible=true;
			btnAgregar.Visible=false;
			btnModificar.Enabled=false;
			btnEliminar.Enabled=false;
			btnModificarUser.Visible=false;
			btnAgregarUser.Visible=true;
		}
		void BtnModificarClick(object sender, EventArgs e)
		{
			btnModificar.Visible=false;
			btnModificarUser.Visible=true;
			gpbUsuarios.Visible=true;
			btnAgregar.Enabled=false;
			btnEliminar.Enabled=false;
			
		}
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			oEmpleados.BuscarEmpleado(txtBuscar.Text,dgvEmpleados);
		}
		
		
		
		
	}
}
