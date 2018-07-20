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
		
		
		void BtnAgregarClick(object sender, EventArgs e)
		{	
			
			VentasController poner = new VentasController();
			
			string condicion=string.Format("id_producto='{0}'",txtClave.Text);
			dgvProductos.Rows.Add(FrameBD.ObtieneCampos("productos",condicion,"precio,nombre"));
			poner.total(dgvProductos,lvlResultado);
			
		}
		
		
	}
}
