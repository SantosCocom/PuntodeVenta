/*
 * Created by SharpDevelop.
 * User: Santos
 * Date: 17/07/2018
 * Time: 09:55 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;
using Herramientas;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace NovedadesLirio
{
	/// <summary>
	/// Description of VentasController.
	/// </summary>
	public class VentasController
	{
		string id_producto{get;set;}
		
		public VentasController()
		{
		}
		
		public void total(DataGridView dgv, Label lvl)
		{
			int filas = dgv.RowCount;
			double sum=0;
			
			
			
			for (int i = 0; i < filas; i++)
			{	
			
				
				string valor=dgv[4,i].Value.ToString();
				
				sum=sum+Convert.ToDouble(valor);
				
			}
			lvl.Text=Convert.ToString(sum);
			
		}
		
		
		public void cambiar(DataGridView dgv)
		{
			int filas = dgv.RowCount;
			
			for (int i = 0; i < filas; i++)
			{	
				string clave=dgv[0,i].Value.ToString();
				string sqlchange=string.Format("UPDATE productos SET vendido = 1 WHERE id_producto={0}",clave);
				FrameBD.SQLIDU(sqlchange);	
			}
			
			
		}
		
		public string genera_clave(int l)
        {
            Random aleatorio = new Random();
            string res = "";
            string[] vals = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            for (int i = 0; i <= l; i++)
            {
                res = res + vals[aleatorio.Next(vals.GetUpperBound(0) + 1)];
            }
            
            return res;

            
        }
		
		
		public void insertar(DataGridView dgv,TextBox txt, string TEXT,Label lvl)
		{
			
			
			
			int filas = dgv.RowCount;
			string idventa=txt.Text;
			string tove=lvl.Text;
			string sqlchang=string.Format("INSERT INTO ventas(id_venta,Fecha_venta,total) VALUES ('{0}','{1}',{2})",idventa,TEXT,tove);
				FrameBD.SQLIDU(sqlchang);
			for (int i = 0; i < filas; i++)
			{	
				
			string clave=dgv[0,i].Value.ToString();
			string nombre=dgv[1,i].Value.ToString();
			string to=dgv[4,i].Value.ToString();
			
				
				
				string sqlchange=string.Format("INSERT INTO detalle_ventas(id_ventas,id_producto,nombre,total) VALUES ('{0}','{1}','{2}',{3})",idventa,clave,nombre,to);
				FrameBD.SQLIDU(sqlchange);	
				
			}
			
			
		}
		
		public void buscardetalles(TextBox txt,DataGridView dgv)
		{ string paarte=txt.Text;
			string sql=string.Format("SELECT ventas.id_venta AS 'Codigo de Venta',detalle_ventas.id_producto AS 'Clave de Producto',detalle_ventas.nombre as Productos,detalle_ventas.total as Total,ventas.Fecha_venta as 'Fecha de Venta' FROM (detalle_ventas INNER JOIN ventas ON id_venta=id_ventas) WHERE detalle_ventas.id_ventas LIKE '{0}%';",paarte);
			dgv.DataSource=FrameBD.SQLSEL(sql);
			dgv.DataMember="datos";
		}
		
	}
}
