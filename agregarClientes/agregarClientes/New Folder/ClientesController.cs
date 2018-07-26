/*
 * Created by SharpDevelop.
 * User: MIKE
 * Date: 14/07/2018
 * Time: 04:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;
using System.Windows.Forms;

namespace Clientes.Controllers
{
	/// <summary>
	/// Description of ClientesController.
	/// </summary>
	public class ClientesController
	{
		public string id_cliente { get; set; }
		public string Nombre { get; set; }
		public string Apellido_paterno { get; set; }
		public string Apellido_materno { get; set; }
		public string Direccion { get; set; }
		public string Numero_celular { get; set; }
		public string localidad { get; set; }
		
		public ClientesController()
		{
		}
		public void BuscarClientes( string cliente, DataGridView dgv)
		{
			string sql = "SELECT id_cliente AS 'CURP', Nombre AS 'NOMBRE', Apellido_paterno AS 'APELLIDO PATERNO',Apellido_materno AS 'APELLIDO MATERNO',Direccion AS 'DIRECCION',Numero_celular AS 'TELEFONO',localidad AS 'LOCALIDAD' FROM Clientes WHERE Nombre LIKE'" + cliente + "%'";
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember = "datos";
		}
		//public void Guardar()
		//{
			//string proc = String.Format("CALL AddCliente('{0}','{1}','{2}','{3}','{4}','{5}');",id_cliente,Nombre,Apellido_paterno,
			                          //  Apellido_materno,Direccion,Numero_celular);
			//FrameBD.SQLIDU(proc);
		//}
		public void Store()
		{
			string sql = string.Format("INSERT INTO Clientes (id_cliente, Nombre, Apellido_paterno, Apellido_materno,Direccion, Numero_celular, localidad) " +
			                           "VALUES ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}')", id_cliente, Nombre,Apellido_paterno,Apellido_materno,Direccion,Numero_celular,localidad);
			FrameBD.SQLIDU(sql);
		}
		public void Update(string pk, string Nom, string ApeP, string ApeM, string Direc, string Tele, string local)
		{
			string sql = string.Format("UPDATE Clientes SET Nombre='{1}', Apellido_paterno='{2}', Apellido_materno='{3}', Direccion='{4}', Numero_celular='{5}', localidad='{6}' WHERE id_cliente='{0}';",pk,Nom,ApeP,ApeM,Direc,Tele,local);
			FrameBD.SQLIDU(sql);
		}
		public void Eliminar(string pk)
		{
			string sql = string.Format("DELETE FROM Clientes WHERE id_cliente='{0}';", pk);
			//MessageBox.Show(sql);
			FrameBD.SQLIDU(sql);
		}
	}
}
