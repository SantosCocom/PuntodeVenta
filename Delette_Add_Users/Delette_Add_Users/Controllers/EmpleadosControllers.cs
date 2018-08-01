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
		public string Localidad {get; set;}
		public string Direccion {get; set;}
		public string Telefono {get; set;}
		public string Usuario {get; set;}
		public string Password {get; set;}
		public string Rol {get; set;}
		public string Despedido {get; set;}
		
		public EmpleadosControllers()
		{
		}
		
		public void BuscarEmpleado(string nom, DataGridView dgv)
		{
			string sql="SELECT Id_empleado AS CURP, Nombre, Apellido_paterno AS 'Apellido Paterno', Apellido_materno AS 'Apellido Materno', Localidad, Direccion, Telefono, Usuario, Password AS Contraseña, Rol from Empleados WHERE Nombre LIKE'" + nom + "%' AND Despedido='0'";
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember= "datos";
		}
		public void InsertarEmpleado()
		{
			string sql= string.Format("INSERT INTO empleados(Id_empleado,Nombre,Apellido_paterno,Apellido_materno,Localidad,Direccion,Telefono, Usuario, Password, Rol, Despedido) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','0')",
			                         Id_empleado,Nombre,Apellido_paterno,Apellido_materno,Localidad,Direccion,Telefono,Usuario,Password,Rol);
			FrameBD.SQLIDU(sql);
		}
		
		//public void EliminarEmpleado(string pk)
		//{
			//string sql=string.Format("DELETE FROM empleados WHERE Id_empleado='{0}';",pk);
			//FrameBD.SQLIDU(sql);
		//}
		public void ActualizarEmpleado(string nom, string ap, string am, string loc, string dir, string tel, string user, string pass, string rol, string pk)
		{
			string sql= string.Format("UPDATE empleados SET Nombre='{1}',Apellido_paterno='{2}',Apellido_materno='{3}',Localidad='{4}',Direccion='{5}',Telefono='{6}',Usuario='{7}',Password='{8}',Rol='{9}' WHERE Id_empleado ='{0}';",pk,nom,ap,am,loc,dir,tel,user,pass,rol);
			FrameBD.SQLIDU(sql);
		}
		public void EliminarEmpleadoDeLaLista(string pk)
		{
			string sql= string.Format("UPDATE empleados SET Despedido='1' WHERE Id_empleado='{0}';",pk);
			FrameBD.SQLIDU(sql);
		}
		
	}
}
