/*
 * Created by SharpDevelop.
 * User: Santos
 * Date: 30/07/2018
 * Time: 11:14 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using AccesoADatos;
namespace MenuPrincipal
{
	/// <summary>
	/// Description of FormLogin.
	/// </summary>
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TxtUsuarioEnter(object sender, EventArgs e)
		{
			if (txtUsuario.Text=="Usuario") 
			{
				txtUsuario.Text="";
				txtUsuario.ForeColor=Color.LightGray;
			}
		}
		void TxtUsuarioLeave(object sender, EventArgs e)
		{
			if (txtUsuario.Text=="")
			{
				txtUsuario.Text="Usuario";
				txtUsuario.ForeColor=Color.DimGray;
			}
		}
		void TxtPasswordEnter(object sender, EventArgs e)
		{
			if (txtPassword.Text=="Contraseña") 
			{
				txtPassword.Text="";
				txtPassword.ForeColor=Color.LightGray;
				txtPassword.UseSystemPasswordChar=true;
			}
		}
		void TxtPasswordLeave(object sender, EventArgs e)
		{
			if (txtPassword.Text=="") 
			{
				txtPassword.Text="Contraseña";
				txtPassword.ForeColor=Color.DimGray;
			}
		}
		void BtnCerrarClick(object sender, EventArgs e)
		{if (MessageBox.Show("¿Está usted seguro que desea salir?", "", MessageBoxButtons.YesNo)== DialogResult.Yes) 
			{
			Application.Exit();
			}
			
		}
		void BtnMinimizarClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		void BtnAccederClick(object sender, EventArgs e)
		{
			string condicion = String.Format("Usuario='{0}'",txtUsuario.Text);
			string [] datos = FrameBD.ObtieneCampos("empleados",condicion,"Id_empleado,Nombre,Apellido_paterno,Apellido_materno,Localidad,Direccion,Telefono,Usuario,Password,Rol,Despedido");
			
			if (datos.Length>1) 
			{
				if (datos[8]==txtPassword.Text)
				{
					if (datos[10]=="1")
					{
						MessageBox.Show("El usuario " + datos[7]+ " ya esta dado de baja en el sistema");
					}else
						if (datos[10]=="0") 
					{
						FrameBD.quienAccede= datos[1]+" "+datos[2]+" "+datos[3];;
						FrameBD.vl=datos[0];
                        FrameBD.check = datos[9];
						MainForm mv= new MainForm();
						this.Hide();
						mv.Show();
						
						}
				}else
					MessageBox.Show("La contraseña es incorrecta");
			}else
				MessageBox.Show("El usuario no existe");
		}
		
		
		
		
		
		
		
		
		
	}
}
