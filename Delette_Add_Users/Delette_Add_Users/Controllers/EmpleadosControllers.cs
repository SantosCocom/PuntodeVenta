/*
 * Created by SharpDevelop.
 * User: Abraham
 * Date: 14/07/2018
 * Time: 18:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;
using System.Windows.Forms;

namespace Delette_Add_Users.Controllers
{
	/// <summary>
	/// Description of EmpleadosControllers.
	/// </summary>
	public class EmpleadosControllers
	{
		public string Id_empleado {get; set;}
		public string Nombre {get; set;}
		public string Apellido_paterno {get; set;}
		public string Apellido_materno {get; set;}
		public string Direccion {get; set;}
		public string Telefono {get; set;}
		
		public string FormUsuarios {get; set;}
		public string Password {get; set;}
		
		public EmpleadosControllers()
		{
		}
		
		public void BuscarEmpleado(string nom, DataGridView dgv)
		{
			string sql="SELECT * from Empleados WHERE Nombre LIKE'" + nom + "%'";
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember= "datos";
		}
	}
}
