/*
 * Created by SharpDevelop.
 * User: Santos
 * Date: 27/07/2018
 * Time: 12:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using NovedadesLirio;
using AccesoADatos;
namespace MenuPrincipal
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class FormVentas : Form
	{
		public FormVentas()
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
                    btnCancelar.Visible = true;
                    VentasController poner = new VentasController();
			
			string condicion=string.Format("id_productos='{0}' and vendido=0",txtClave.Text);
				
			string[] datos= FrameBD.ObtieneCampos("productos",condicion,"id_productos,nombre,precio,1,precio");
				
				if (datos.Length>1)
				{
					
					dgvProductos.Rows.Add(datos);
			poner.total(dgvProductos,lvlResultado);
			
			txtClave.Focus();
				txtClave.Clear();
					
				}else 
					MessageBox.Show("Producto no disponible");
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
			string nada = DateTime.Now.ToString("yyyy-MM-dd");
			txtFolio.Text=vender.genera_clave(10);
			vender.cambiar(dgvProductos);
			vender.insertar(dgvProductos,txtFolio,nada,lvlResultado,FrameBD.vl);
			
			dgvProductos.Rows.Clear();
                
			MessageBox.Show("Venta Exitosa");
                ExportExcel OG = new ExportExcel();
                OG.ExportarExcel(dgvProductos);
                txtClave.Focus();
			lvlResultado.Text="";
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
				if (MessageBox.Show("¿Está usted seguro que desea cancelar?", "", MessageBoxButtons.YesNo)== DialogResult.Yes) 
			{
					dgvProductos.Rows.Clear();
			}
		}
        
		void FormVentasLoad(object sender, EventArgs e)
		{
			lvlNombre.Text=FrameBD.quienAccede;
            


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está usted seguro que desea salir?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                
            }
        }
    }
}
