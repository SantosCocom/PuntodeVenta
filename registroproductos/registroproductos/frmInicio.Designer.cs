/*
 * Created by SharpDevelop.
 * User: COMPAX
 * Date: 29/07/2018
 * Time: 08:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace registroproductos
{
	partial class frmInicio
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem peliculasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuPanelDePeliculas;
		private System.Windows.Forms.ToolStripMenuItem detalleDeApartadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem MnuPanelDeClientes;
		private System.Windows.Forms.ToolStripMenuItem agregarClientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarProductosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem respaldarBDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem restaurarBDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.peliculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuPanelDePeliculas = new System.Windows.Forms.ToolStripMenuItem();
			this.detalleDeApartadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MnuPanelDeClientes = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.respaldarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restaurarBDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.catalogosToolStripMenuItem,
			this.herramientasToolStripMenuItem,
			this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(751, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// catalogosToolStripMenuItem
			// 
			this.catalogosToolStripMenuItem.BackColor = System.Drawing.Color.White;
			this.catalogosToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.peliculasToolStripMenuItem,
			this.clientesToolStripMenuItem,
			this.agregarProductosToolStripMenuItem});
			this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
			this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.catalogosToolStripMenuItem.Text = "&Catalogos";
			// 
			// peliculasToolStripMenuItem
			// 
			this.peliculasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mnuPanelDePeliculas,
			this.detalleDeApartadosToolStripMenuItem});
			this.peliculasToolStripMenuItem.Name = "peliculasToolStripMenuItem";
			this.peliculasToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.peliculasToolStripMenuItem.Text = "Apartados";
			// 
			// mnuPanelDePeliculas
			// 
			this.mnuPanelDePeliculas.Name = "mnuPanelDePeliculas";
			this.mnuPanelDePeliculas.Size = new System.Drawing.Size(180, 22);
			this.mnuPanelDePeliculas.Text = "Panel de apartados";
			this.mnuPanelDePeliculas.ToolTipText = "Gestion de peliculas";
			this.mnuPanelDePeliculas.Click += new System.EventHandler(this.MnuPanelDePeliculasClick);
			// 
			// detalleDeApartadosToolStripMenuItem
			// 
			this.detalleDeApartadosToolStripMenuItem.Name = "detalleDeApartadosToolStripMenuItem";
			this.detalleDeApartadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.detalleDeApartadosToolStripMenuItem.Text = "detalle de apartados";
			this.detalleDeApartadosToolStripMenuItem.Click += new System.EventHandler(this.DetalleDeApartadosToolStripMenuItemClick);
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.MnuPanelDeClientes,
			this.agregarClientesToolStripMenuItem});
			this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.clientesToolStripMenuItem.Text = "Clientes";
			// 
			// MnuPanelDeClientes
			// 
			this.MnuPanelDeClientes.Name = "MnuPanelDeClientes";
			this.MnuPanelDeClientes.Size = new System.Drawing.Size(162, 22);
			this.MnuPanelDeClientes.Text = "Panel de clientes";
			// 
			// agregarClientesToolStripMenuItem
			// 
			this.agregarClientesToolStripMenuItem.Name = "agregarClientesToolStripMenuItem";
			this.agregarClientesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.agregarClientesToolStripMenuItem.Text = "Agregar clientes";
			// 
			// agregarProductosToolStripMenuItem
			// 
			this.agregarProductosToolStripMenuItem.Name = "agregarProductosToolStripMenuItem";
			this.agregarProductosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.agregarProductosToolStripMenuItem.Text = "Agregar Productos";
			this.agregarProductosToolStripMenuItem.Click += new System.EventHandler(this.AgregarProductosToolStripMenuItemClick);
			// 
			// herramientasToolStripMenuItem
			// 
			this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.respaldarBDToolStripMenuItem,
			this.restaurarBDToolStripMenuItem,
			this.calculadoraToolStripMenuItem});
			this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
			this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.herramientasToolStripMenuItem.Text = "Herramientas";
			// 
			// respaldarBDToolStripMenuItem
			// 
			this.respaldarBDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("respaldarBDToolStripMenuItem.Image")));
			this.respaldarBDToolStripMenuItem.Name = "respaldarBDToolStripMenuItem";
			this.respaldarBDToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.respaldarBDToolStripMenuItem.Text = "Respaldar BD";
			// 
			// restaurarBDToolStripMenuItem
			// 
			this.restaurarBDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restaurarBDToolStripMenuItem.Image")));
			this.restaurarBDToolStripMenuItem.Name = "restaurarBDToolStripMenuItem";
			this.restaurarBDToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.restaurarBDToolStripMenuItem.Text = "Restaurar BD";
			// 
			// calculadoraToolStripMenuItem
			// 
			this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
			this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.calculadoraToolStripMenuItem.Text = "Calculadora";
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.acercaToolStripMenuItem,
			this.fAQToolStripMenuItem});
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// acercaToolStripMenuItem
			// 
			this.acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
			this.acercaToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.acercaToolStripMenuItem.Text = "Acerca";
			// 
			// fAQToolStripMenuItem
			// 
			this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
			this.fAQToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.fAQToolStripMenuItem.Text = "FAQ";
			// 
			// frmInicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(751, 390);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.Name = "frmInicio";
			this.Text = "frmInicio";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
