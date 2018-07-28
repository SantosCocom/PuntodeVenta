/*
 * Created by SharpDevelop.
 * User: Santos
 * Date: 28/07/2018
 * Time: 11:26 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NovedadesLirio
{
	/// <summary>
	/// Description of FormDetalleVentas.
	/// </summary>
	public partial class FormDetalleVentas : Form
	{
		public FormDetalleVentas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TxtClaveVentasTextChanged(object sender, EventArgs e)
		{
			VentasController VER =new VentasController();
			VER.buscardetalles(txtClaveVentas,dgvVentas);
		}
	}
}
