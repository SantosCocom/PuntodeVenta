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
				string valor=dgv[0,i].Value.ToString();
				
				sum=sum+Convert.ToDouble(valor);
				
			}
			lvl.Text=Convert.ToString(sum/filas);
			
		}
		
		
		
		
		
		
		
		
	}
}
