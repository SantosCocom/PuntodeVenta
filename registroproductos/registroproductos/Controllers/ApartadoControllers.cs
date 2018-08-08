/*
 * Created by SharpDevelop.
 * User: COMPAX
 * Date: 29/07/2018
 * Time: 08:16 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;
using System.Windows.Forms;

namespace registroproductos.Controllers
{
	/// <summary>
	/// Description of ApartadoControllers.
	/// </summary>
	public class ApartadoControllers
	{
		public string id_apartado {get; set;}
		public float saldo {get; set;}
		public string fecha_inicio {get; set;}
		public string fecha_fin {get; set;}
		public string id_cliente {get; set;}
		public string id_producto {get; set;}
		
		public ApartadoControllers()
		{
		}
		public void store1()
		{
			string sql= string.Format("INSERT INTO apartados(id_apartado,saldo,fecha_inicio,fecha_fin,id_producto,id_cliente)VALUES('{0}',{1},'{2}','{3}','{4}','{5}')",
			                         id_apartado,saldo,fecha_inicio,fecha_fin,id_producto,id_cliente);
			     
			FrameBD.SQLIDU(sql);
		}
		public void buscarApartados(string apartado,DataGridView dgv)
		{
			string sql= "SELECT * FROM apartados WHERE id_apartado LIKE'" + apartado + "%'";
			
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember = "datos";
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
		public void detalleproductos(DataGridView dgv, TextBox txt)
		{
			string prueba= "SELECT clientes.nombre,apartados.id_cliente,detalle_apartados.id_apartado,productos.nombre,productos.id_productos,abonos.id_abono FROM" +
" ((((clientes INNER JOIN  apartados ON id_clientes=id_cliente) INNER JOIN detalle_apartados on id_apartados=id_apartado)" + 
" INNER JOIN	productos ON id_productos=id_productos)INNER JOIN abonos ON id_apartados=id_apartados)" + 
" WHERE apartados.id_apartados='" + txt.Text +"'";
			
			dgv.DataSource = FrameBD.SQLSEL(prueba);
			dgv.DataMember = "datos";
		}
	}
}
