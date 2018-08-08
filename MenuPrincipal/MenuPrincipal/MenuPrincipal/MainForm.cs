/*
 * Created by SharpDevelop.
 * User: MIKE
 * Date: 20/07/2018
 * Time: 06:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using  Delette_Add_Users.Controllers;
using AccesoADatos;
namespace MenuPrincipal
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
				if (FrameBD.check!="ADMINISTRADOR") 
				{
					btnEmpleados.Enabled=false;
					btnClientes.Enabled=false;
					btnCompras.Enabled=false;
					
				}
		}
		
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
		void BtnListaClick(object sender, EventArgs e)
		{
			if (MenuVertical.Width == 250) 
				MenuVertical.Width = 70;
			else
				MenuVertical.Width=250;
		}
		void BtnCerraClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está usted seguro que desea salir?", "", MessageBoxButtons.YesNo)== DialogResult.Yes) 
			{
				Application.Exit();
			}
		}
		int LX, LY;
		void BtnMaximizarClick(object sender, EventArgs e)
		{
			//this.WindowState = FormWindowState.Maximized;
			LX = this.Location.X;
			LY = this.Location.Y;
			this.Size = Screen.PrimaryScreen.WorkingArea.Size;
			this.Location = Screen.PrimaryScreen.WorkingArea.Location;
			btnRestaurar.Visible = true;
			btnMaximizar.Visible = false;
		}
		void BtnRestaurarClick(object sender, EventArgs e)
		{
			//this.WindowState = FormWindowState.Normal;
			this.Size = new Size(1120,570);
			this.Location = new Point(LX,LY);
			btnRestaurar.Visible = false;
			btnMaximizar.Visible = true;
		}
		void BtnMinimizarClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		void Panel1MouseDown(object sender, MouseEventArgs e)
		{
			 ReleaseCapture();
 			 SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		  private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
           
        }

		
		
		protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84; //Ubicacion de la parte derecha inferior del form
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
            	
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamañoAreaForm.Width - 16 && CoordenadaArea.Y >= TamañoAreaForm.Height - 16 && TamañoAreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }
		private void BtnProductosClick(object sender, EventArgs e)
		{
            AbrirFormHija(new FormProductos());   
        }
		 private void btninicio_Click(object sender, EventArgs e)
        {
          
        }
		void BtnVentasClick(object sender, EventArgs e)
		{
				AbrirFormHija(new FormVentas());
		}
		void BtnComprasClick(object sender, EventArgs e)
		{
			AbrirFormHija(new FormDetalleVentas());
		}

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FormClientes());
        }

        private void btnSingOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está usted seguro que desea Cerrar sesión?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                FormLogin og = new FormLogin();
                og.ShowDialog();
            }
        }

        void BtnEmpleadosClick(object sender, EventArgs e)
		{
			AbrirFormHija(new FormEmpleado());
		}
	}
}
