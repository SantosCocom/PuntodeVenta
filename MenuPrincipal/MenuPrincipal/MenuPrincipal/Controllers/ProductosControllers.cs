/*
 * Created by SharpDevelop.
 * User: COMPAX
 * Date: 18/07/2018
 * Time: 07:11 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos; //para tener accesos a los datos
using System.Windows.Forms; //para tener accesos a los componentes

namespace registroproductos.Controllers
{
	/// <summary>
	/// Description of ProductosControllers.
	/// </summary>
	public class ProductosControllers
	{
		public string id_producto { get; set; }
		public string Nombre { get; set; }
		public float Precio { get; set; }
		public string Descripcion { get; set; }
		public string Talla { get; set; }
		
		public ProductosControllers()
		{
		}
		
		public void buscarproducto(string producto,DataGridView dgv)
		{
			string sql= "SELECT id_productos as'Clave',Nombre,Precio,Descripcion,Talla,vendido FROM productos WHERE nombre LIKE'" + producto + "%'";
			
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember = "datos";
		}
		
		public void store()
		{
			string sql= string.Format("INSERT INTO productos(id_productos,Nombre,Precio,Descripcion,Talla)VALUES('{0}','{1}',{2},'{3}','{4}')",
			                         id_producto,Nombre,Precio,Descripcion,Talla);
			FrameBD.SQLIDU(sql);
		}
		public void Destroy(string id_producto )
			
		{
			string sql = string.Format("DELETE FROM productos WHERE id_productos='{0}';",id_producto);
			FrameBD.SQLIDU(sql);
		}
		
		public void update(string id_producto, string Producto,float Precio,string Descripcion, string Talla)
		{
			
			string sql = string.Format("UPDATE productos SET Nombre='{1}',Precio={2},Descripcion='{3}',Talla='{4}' WHERE id_productos='{0}';",id_producto,Producto,Precio,Descripcion,Talla);
			FrameBD.SQLIDU(sql);
		}

	}
}
