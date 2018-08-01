/*
 * Created by SharpDevelop.
 * User: COMPAX
 * Date: 29/07/2018
 * Time: 08:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using AccesoADatos;
using registroproductos.Controllers;
using registroproductos.views;
using Herramientas;

namespace registroproductos.views
{
	/// <summary>
	/// Description of frmApartados.
	/// </summary>
	public partial class frmApartados : Form
	{
		ApartadoControllers Lapartados =  new ApartadoControllers();
		public frmApartados()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnApartadosClick(object sender, EventArgs e)
		{
			txtClaveApartado.Text=Lapartados.genera_clave(6);
			
			if ( txtClaveApartado.Text== "")
			{
				MessageBox.Show("Ingrese datos");
			}
			
			if ( txtSaldo.Text== "")
			{
				txtSaldo.Text="0";
			}
			if ( txtClave.Text== "")
			{
				MessageBox.Show("Ingrese datos");
			}
			if ( txtNombreCliente.Text== "")
			{
				MessageBox.Show("Ingrese datos");
			}
			else{
			
			Lapartados.id_apartado=txtClaveApartado.Text;
			Lapartados.saldo=Convert.ToSingle(txtSaldo.Text);
			Lapartados.fecha_inicio=dtpFechaInicio.Value.ToString("yyyy-MM-dd");
			Lapartados.fecha_fin=dtpFechaFin.Value.ToString("yyyy-MM-dd");
			Lapartados.id_producto=txtClave.Text;
			Lapartados.id_cliente=txtNombreCliente.Text;
			Lapartados.store1();
			}
			
			
			
			txtSaldo.Clear();
			txtNombreCliente.Clear();
			txtClave.Clear();
			txtClaveApartado.Focus();
		}
		void FrmApartadosLoad(object sender, EventArgs e)
		{
			txtClaveApartado.Text=Lapartados.genera_clave(6);
		}
		void TxtNombreClienteKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U",e.KeyChar);
		}
		void TxtSaldoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.validaReal(txtSaldo,e.KeyChar);
		}
		void TxtClaveKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U",e.KeyChar);
		}
		
		
	}
}
