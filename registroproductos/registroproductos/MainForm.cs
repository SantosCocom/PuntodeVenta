/*
 * Created by SharpDevelop.
 * User: COMPAX
 * Date: 18/07/2018
 * Time: 05:59 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using registroproductos.Controllers;
using Herramientas;



namespace registroproductos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		ProductosControllers oProducto = new ProductosControllers();
		
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
		void BtnGuardarClick(object sender, EventArgs e)
		{
			oProducto.id_producto=txtClaveProducto.Text;
			oProducto.Nombre=txtProducto.Text;
			oProducto.Precio=Convert.ToSingle(txtPrecio.Text);
			oProducto.Descripcion=txtDescripcion.Text;
			oProducto.store();
			
			oProducto.buscarproducto(txtBuscarProducto.Text,dataGridView1);
			txtClaveProducto.Clear();
			txtProducto.Clear();
			txtPrecio.Clear();
			txtDescripcion.Clear();
			txtBuscarProducto.Focus();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			oProducto.buscarproducto(txtBuscarProducto.Text,dataGridView1);
		}
		void TxtBuscarProductoTextChanged(object sender, EventArgs e)
		{
			oProducto.buscarproducto(txtBuscarProducto.Text,dataGridView1);
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Estas seguro de eliminar","Cuidado",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
			{
				string id_producto = dataGridView1[0,dataGridView1.CurrentCellAddress.Y].Value.ToString();
				oProducto.Destroy(id_producto);
				oProducto.buscarproducto(txtBuscarProducto.Text,dataGridView1);
			}
		}
		void BtnEditarClick(object sender, EventArgs e)
		{
			txtClaveProducto.Text = dataGridView1[0,dataGridView1.CurrentCellAddress.Y].Value.ToString();
			txtProducto.Text = dataGridView1[1,dataGridView1.CurrentCellAddress.Y].Value.ToString();
			txtPrecio.Text =dataGridView1[2,dataGridView1.CurrentCellAddress.Y].Value.ToString();
			txtTalla.Text = dataGridView1[3,dataGridView1.CurrentCellAddress.Y].Value.ToString();
			txtDescripcion.Text = dataGridView1[4,dataGridView1.CurrentCellAddress.Y].Value.ToString();
			txtProducto.Focus();
			btnGuardarU.Visible=true;
			btnGuardar.Visible=false;
		}
		void BtnGuardarUClick(object sender, EventArgs e)
		{
			oProducto.update(txtClaveProducto.Text,txtProducto.Text,Convert.ToSingle(txtPrecio.Text),txtTalla.Text,txtDescripcion.Text);
			oProducto.buscarproducto(txtBuscarProducto.Text,dataGridView1);
			txtClaveProducto.Clear();
			txtProducto.Clear();
			txtPrecio.Clear();
			txtTalla.Clear();
			txtDescripcion.Clear();
			btnGuardarU.Visible=false;
			btnGuardar.Visible=true;
		}
		
		
		
		
	}
}
