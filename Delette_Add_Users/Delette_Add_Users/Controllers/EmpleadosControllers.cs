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
		
		public EmpleadosControllers()
		{
		}
		
		public void BuscarEmpleado(string nom, DataGridView dgv)
		{
			string sql="SELECT * from Empleados WHERE Nombre LIKE'" + nom + "%'";
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember= "datos";
		}
		public void BuscarUsuario(string user, DataGridView data)
		{
			string sql="SELECT * from Usuarios WHERE Usuario LIKE'" + user + "%'";
			data.DataSource = FrameBD.SQLSEL(sql);
			data.DataMember= "datos";
		}
		public void InsertarEmpleado()
		{
			string sql= string.Format("INSERT INTO empleados(Id_empleado,Nombre,Apellido_paterno,Apellido_materno,Localidad,Direccion,Telefono) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
			                         Id_empleado,Nombre,Apellido_paterno,Apellido_materno,Localidad,Direccion,Telefono);
			FrameBD.SQLIDU(sql);
		}
		public void InsertarUsuario()
		{
			string sql= string.Format("INSERT INTO usuarios(Usuario,Password,Rol) VALUES ('{0}','{1}','{2}')",
			                         Usuario,Password,Rol);
			FrameBD.SQLIDU(sql);
		}
		
		public void EliminarEmpleado(string pk)
		{
			string sql=string.Format("DELETE FROM empleados WHERE Id_empleado='{0}';",pk);
			FrameBD.SQLIDU(sql);
		}
		public void ActualizarEmpleado(string nom, string ap, string am, string loc, string dir, string tel, string pk)
		{
			string sql= string.Format("UPDATE empleados SET Nombre='{0}',Apellido_paterno='{1}',Apellido_materno='{2}',Localidad='{3}',Direccion='{4}',Telefono='{5}' WHERE Id_empleado ='{6}';",nom,ap,am,loc,dir,tel,pk);
			FrameBD.SQLIDU(sql);
		}
		public void ActualizarUsuario(string user, string pass, string rool, string pk)
		{
			string sql= string.Format("UPDATE usuarios SET Usuario='{0}',Password='{1}',Rol='{2}' WHERE Id_empleado='{3}';",user,pass,rool,pk);
			FrameBD.SQLIDU(sql);
		
		}
		
		
	}
}
