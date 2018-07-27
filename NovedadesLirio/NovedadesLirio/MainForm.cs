/*
 * Created by SharpDevelop.
 * User: Santos
 * Date: 17/07/2018
 * Time: 07:27 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AccesoADatos;
using  Herramientas;
namespace NovedadesLirio
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void DgvProductosKeyDown(object sender, KeyEventArgs e)
		{
			VentasController poner = new VentasController();
			if (e.KeyCode==Keys.Insert)
			{
				dgvProductos["cantidad",dgvProductos.CurrentCellAddress.Y].Value = Convert.ToInt32(dgvProductos["cantidad",dgvProductos.CurrentCellAddress.Y].Value) +1;
				dgvProductos["Total",dgvProductos.CurrentCellAddress.Y].Value = Convert.ToInt32(dgvProductos["cantidad",dgvProductos.CurrentCellAddress.Y].Value.ToString()) * Convert.ToDouble(dgvProductos[2,dgvProductos.CurrentCellAddress.Y].Value.ToString());
				poner.total(dgvProductos,lvlResultado);
				
			}
				
		}
		void TxtClaveKeyPress(object sender, KeyPressEventArgs e)
		{	
		
			  if((int)e.KeyChar == (int)Keys.Enter)
			  {
			  	if (txtClave.Text=="" && dgvProductos.RowCount<1) 
				{
				MessageBox.Show("Debe de ingresar una clave de producto");
				
			  	}else
			  	{
			  		
			  		VentasController poner = new VentasController();
			
			string condicion=string.Format("id_producto='{0}'",txtClave.Text);
			string[] sqls=FrameBD.ObtieneCampos("productos",condicion,"id_producto,nombre,precio,1,precio");
			
		
				dgvProductos.Rows.Add(FrameBD.ObtieneCampos("productos",condicion,"id_producto,nombre,precio,1,precio"));
			poner.total(dgvProductos,lvlResultado);
			
			txtClave.Focus();
				txtClave.Clear();
			
				
			  	}
        
			  } 
							
			
			
			
		}
		void BtnTerminarClick(object sender, EventArgs e)
			
		{
			int num=dgvProductos.RowCount;
			
			if (num<1) 
			{
				MessageBox.Show("Debe de ingresar productos al carrito");
				
			}else 
			{
				
			
			VentasController vender = new VentasController();
			vender.cambiar(dgvProductos);
			MessageBox.Show("Producto vendido");
			dgvProductos.ClearSelection();
			}
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			txtClave.Focus();
			
			
		}
		
		
		
	}
}
