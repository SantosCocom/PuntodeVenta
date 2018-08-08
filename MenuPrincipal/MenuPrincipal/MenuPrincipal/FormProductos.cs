/*
 * Created by SharpDevelop.
 * User: Santos
 * Date: 31/07/2018
 * Time: 06:27 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using registroproductos.Controllers;
using Herramientas;
namespace MenuPrincipal
{
	/// <summary>
	/// Description of FormProductos.
	/// </summary>
	public partial class FormProductos : Form
	{
        ProductosControllers oProducto = new ProductosControllers();
        public FormProductos()
		{
            ProductosControllers oProducto = new ProductosControllers();
           
                //
                // The InitializeComponent() call is required for Windows Forms designer support.
                //
                InitializeComponent();

                //
                // TODO: Add constructor code after the InitializeComponent() call.
                //
            
            
           
            
            //ELIMINAR PRODUCTO
            
            //EDITAR PRODUCTO
            
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProductosControllers oProducto = new ProductosControllers();
            //VALIDANDO LAS CAJAS DE TEXTO 

            if (txtClaveProducto.Text == "")
            {
                MessageBox.Show("Ingrese datos");
            }
            if (txtProducto.Text == "")
            {
                MessageBox.Show("Ingrese datos");
            }
            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "0";
            }
            if (txtTalla.Text == "")
            {
                MessageBox.Show("Ingrese datos");
            }
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese datos");
            }
            else
            {
                //AGREGAR PRODUCTO
                oProducto.id_producto = txtClaveProducto.Text;
                oProducto.Nombre = txtProducto.Text;
                oProducto.Precio = Convert.ToSingle(txtPrecio.Text);
                oProducto.Talla = txtTalla.Text;
                oProducto.Descripcion = txtDescripcion.Text;
                oProducto.store();
            }
            //BUSCAR PRODUCTO
            oProducto.buscarproducto(txtBuscarProducto.Text, dataGridView1);
            txtClaveProducto.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();
            txtTalla.Clear();
            txtDescripcion.Clear();
            txtBuscarProducto.Focus();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            ProductosControllers oProducto = new ProductosControllers();
            oProducto.buscarproducto(txtBuscarProducto.Text, dataGridView1);
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            oProducto.buscarproducto(txtBuscarProducto.Text, dataGridView1);




        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                string id_producto = dataGridView1[0, dataGridView1.CurrentCellAddress.Y].Value.ToString();
                oProducto.Destroy(id_producto);
                oProducto.buscarproducto(txtBuscarProducto.Text, dataGridView1);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            txtClaveProducto.Text = dataGridView1[0, dataGridView1.CurrentCellAddress.Y].Value.ToString();
            txtProducto.Text = dataGridView1[1, dataGridView1.CurrentCellAddress.Y].Value.ToString();
            txtPrecio.Text = dataGridView1[2, dataGridView1.CurrentCellAddress.Y].Value.ToString();
            txtDescripcion.Text = dataGridView1[3, dataGridView1.CurrentCellAddress.Y].Value.ToString();
            txtTalla.Text = dataGridView1[4, dataGridView1.CurrentCellAddress.Y].Value.ToString();

            txtProducto.Focus();
            btnGuardarU.Visible = true;
            btnGuardar.Visible = false;
            btnEliminar.Visible = false;
            btnCancelar.Visible = true;
        }

        private void btnGuardarU_Click(object sender, EventArgs e)
        {

            oProducto.update(txtClaveProducto.Text, txtProducto.Text, Convert.ToSingle(txtPrecio.Text), txtDescripcion.Text, txtTalla.Text);
            oProducto.buscarproducto(txtBuscarProducto.Text, dataGridView1);
            txtClaveProducto.Clear();
            txtProducto.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
            txtTalla.Clear();

            btnGuardarU.Visible = false;
            btnGuardar.Visible = true;
        }

        private void txtClaveProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Validaciones.valida("U", e.KeyChar);

        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Validaciones.valida("T", e.KeyChar);
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Validaciones.valida("T", e.KeyChar);
        }

        private void txtTalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Validaciones.valida("U", e.KeyChar);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Validaciones.validaReal(txtPrecio, e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está usted seguro que desea salir?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtClaveProducto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtTalla.Clear();
            txtProducto.Clear();
        }
    }
}
