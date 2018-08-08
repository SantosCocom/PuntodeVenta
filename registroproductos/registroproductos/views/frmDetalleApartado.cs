/*
 * Created by SharpDevelop.
 * User: COMPAX
 * Date: 30/07/2018
 * Time: 08:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using AccesoADatos;
using registroproductos.Controllers;
using registroproductos.views;

namespace registroproductos.views
{
	/// <summary>
	/// Description of frmDetalleApartado.
	/// </summary>
	public partial class frmDetalleApartado : Form
	{
		public frmDetalleApartado()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmDetalleApartadoLoad(object sender, EventArgs e)
		{
			ApartadoControllers buscar = new ApartadoControllers();
			buscar.detalleproductos(dgbApartados,txtApartado);
		}
		void TxtApartadoTextChanged(object sender, EventArgs e)
		{
			ApartadoControllers buscar = new ApartadoControllers();
			buscar.detalleproductos(dgbApartados,txtApartado);
		}
		
	}
}
