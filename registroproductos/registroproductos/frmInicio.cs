/*
 * Created by SharpDevelop.
 * User: COMPAX
 * Date: 29/07/2018
 * Time: 08:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using AccesoADatos;
//using System.Windows.Forms;
using registroproductos.views;
using registroproductos.Controllers;

namespace registroproductos
{
	/// <summary>
	/// Description of frmInicio.
	/// </summary>
	public partial class frmInicio : Form
	{
		public frmInicio()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void AgregarProductosToolStripMenuItemClick(object sender, EventArgs e)
		{
			MainForm Aproducto = new MainForm();
			Aproducto.MdiParent=this;
			Aproducto.Show();
		}
		void MnuPanelDePeliculasClick(object sender, EventArgs e)
		{
			frmApartados Addapartados = new frmApartados();
			Addapartados.MdiParent=this;
			Addapartados.Show();
		}
		void DetalleDeApartadosToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmDetalleApartado Viewsdetalleapartado = new frmDetalleApartado();
			Viewsdetalleapartado.MdiParent=this;
			Viewsdetalleapartado.Show();
		}
	}
}
