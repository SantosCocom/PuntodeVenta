/*
 * Created by SharpDevelop.
 * User: MIKE
 * Date: 20/07/2018
 * Time: 06:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MenuPrincipal
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel MenuVertical;
		private System.Windows.Forms.Panel panelTitulo;
		private System.Windows.Forms.Panel panelContenedor;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox btnLista;
		private System.Windows.Forms.PictureBox btnMinimizar;
		private System.Windows.Forms.PictureBox btnMaximizar;
		private System.Windows.Forms.PictureBox btnCerra;
		private System.Windows.Forms.PictureBox btnRestaurar;
		private System.Windows.Forms.Button btnEmpleados;
		private System.Windows.Forms.Button btnVentas;
		private System.Windows.Forms.Button btnClientes;
		private System.Windows.Forms.Button btnProveedores;
		private System.Windows.Forms.Button btnCompras;
		private System.Windows.Forms.Button btnProductos;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MenuVertical = new System.Windows.Forms.Panel();
			this.btnEmpleados = new System.Windows.Forms.Button();
			this.btnVentas = new System.Windows.Forms.Button();
			this.btnClientes = new System.Windows.Forms.Button();
			this.btnProveedores = new System.Windows.Forms.Button();
			this.btnCompras = new System.Windows.Forms.Button();
			this.btnProductos = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panelTitulo = new System.Windows.Forms.Panel();
			this.btnRestaurar = new System.Windows.Forms.PictureBox();
			this.btnMaximizar = new System.Windows.Forms.PictureBox();
			this.btnMinimizar = new System.Windows.Forms.PictureBox();
			this.btnCerra = new System.Windows.Forms.PictureBox();
			this.btnLista = new System.Windows.Forms.PictureBox();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.MenuVertical.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panelTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnLista)).BeginInit();
			this.SuspendLayout();
			// 
			// MenuVertical
			// 
			this.MenuVertical.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.MenuVertical.Controls.Add(this.btnEmpleados);
			this.MenuVertical.Controls.Add(this.btnVentas);
			this.MenuVertical.Controls.Add(this.btnClientes);
			this.MenuVertical.Controls.Add(this.btnProveedores);
			this.MenuVertical.Controls.Add(this.btnCompras);
			this.MenuVertical.Controls.Add(this.btnProductos);
			this.MenuVertical.Controls.Add(this.pictureBox2);
			this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
			this.MenuVertical.Location = new System.Drawing.Point(0, 0);
			this.MenuVertical.Name = "MenuVertical";
			this.MenuVertical.Size = new System.Drawing.Size(250, 650);
			this.MenuVertical.TabIndex = 0;
			// 
			// btnEmpleados
			// 
			this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEmpleados.FlatAppearance.BorderSize = 0;
			this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEmpleados.ForeColor = System.Drawing.Color.White;
			this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
			this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEmpleados.Location = new System.Drawing.Point(0, 350);
			this.btnEmpleados.Name = "btnEmpleados";
			this.btnEmpleados.Size = new System.Drawing.Size(250, 40);
			this.btnEmpleados.TabIndex = 6;
			this.btnEmpleados.Text = "Empleados";
			this.btnEmpleados.UseVisualStyleBackColor = true;
			// 
			// btnVentas
			// 
			this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnVentas.FlatAppearance.BorderSize = 0;
			this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVentas.ForeColor = System.Drawing.Color.White;
			this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
			this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnVentas.Location = new System.Drawing.Point(0, 212);
			this.btnVentas.Name = "btnVentas";
			this.btnVentas.Size = new System.Drawing.Size(250, 40);
			this.btnVentas.TabIndex = 5;
			this.btnVentas.Text = "Ventas";
			this.btnVentas.UseVisualStyleBackColor = true;
			this.btnVentas.Click += new System.EventHandler(this.BtnVentasClick);
			// 
			// btnClientes
			// 
			this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClientes.FlatAppearance.BorderSize = 0;
			this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClientes.ForeColor = System.Drawing.Color.White;
			this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
			this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClientes.Location = new System.Drawing.Point(0, 304);
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(250, 40);
			this.btnClientes.TabIndex = 4;
			this.btnClientes.Text = "Clientes";
			this.btnClientes.UseVisualStyleBackColor = true;
			// 
			// btnProveedores
			// 
			this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnProveedores.FlatAppearance.BorderSize = 0;
			this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProveedores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProveedores.ForeColor = System.Drawing.Color.White;
			this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
			this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProveedores.Location = new System.Drawing.Point(0, 442);
			this.btnProveedores.Name = "btnProveedores";
			this.btnProveedores.Size = new System.Drawing.Size(250, 40);
			this.btnProveedores.TabIndex = 3;
			this.btnProveedores.Text = "Proveedores";
			this.btnProveedores.UseVisualStyleBackColor = true;
			this.btnProveedores.Visible = false;
			// 
			// btnCompras
			// 
			this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCompras.FlatAppearance.BorderSize = 0;
			this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCompras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCompras.ForeColor = System.Drawing.Color.White;
			this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
			this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCompras.Location = new System.Drawing.Point(0, 258);
			this.btnCompras.Name = "btnCompras";
			this.btnCompras.Size = new System.Drawing.Size(250, 40);
			this.btnCompras.TabIndex = 2;
			this.btnCompras.Text = "Compras";
			this.btnCompras.UseVisualStyleBackColor = true;
			this.btnCompras.Click += new System.EventHandler(this.BtnComprasClick);
			// 
			// btnProductos
			// 
			this.btnProductos.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnProductos.FlatAppearance.BorderSize = 0;
			this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProductos.ForeColor = System.Drawing.Color.White;
			this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
			this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProductos.Location = new System.Drawing.Point(0, 396);
			this.btnProductos.Name = "btnProductos";
			this.btnProductos.Size = new System.Drawing.Size(250, 40);
			this.btnProductos.TabIndex = 1;
			this.btnProductos.Text = "Productos";
			this.btnProductos.UseVisualStyleBackColor = false;
			this.btnProductos.Click += new System.EventHandler(this.BtnProductosClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(12, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(238, 160);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// panelTitulo
			// 
			this.panelTitulo.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.panelTitulo.Controls.Add(this.btnRestaurar);
			this.panelTitulo.Controls.Add(this.btnMaximizar);
			this.panelTitulo.Controls.Add(this.btnMinimizar);
			this.panelTitulo.Controls.Add(this.btnCerra);
			this.panelTitulo.Controls.Add(this.btnLista);
			this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitulo.Location = new System.Drawing.Point(250, 0);
			this.panelTitulo.Name = "panelTitulo";
			this.panelTitulo.Size = new System.Drawing.Size(1050, 50);
			this.panelTitulo.TabIndex = 1;
			this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1MouseDown);
			// 
			// btnRestaurar
			// 
			this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
			this.btnRestaurar.Location = new System.Drawing.Point(969, 12);
			this.btnRestaurar.Name = "btnRestaurar";
			this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
			this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnRestaurar.TabIndex = 4;
			this.btnRestaurar.TabStop = false;
			this.btnRestaurar.Visible = false;
			this.btnRestaurar.Click += new System.EventHandler(this.BtnRestaurarClick);
			// 
			// btnMaximizar
			// 
			this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
			this.btnMaximizar.Location = new System.Drawing.Point(969, 12);
			this.btnMaximizar.Name = "btnMaximizar";
			this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
			this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMaximizar.TabIndex = 2;
			this.btnMaximizar.TabStop = false;
			this.btnMaximizar.Click += new System.EventHandler(this.BtnMaximizarClick);
			// 
			// btnMinimizar
			// 
			this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
			this.btnMinimizar.Location = new System.Drawing.Point(926, 12);
			this.btnMinimizar.Name = "btnMinimizar";
			this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
			this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimizar.TabIndex = 3;
			this.btnMinimizar.TabStop = false;
			this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizarClick);
			// 
			// btnCerra
			// 
			this.btnCerra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCerra.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerra.Image = ((System.Drawing.Image)(resources.GetObject("btnCerra.Image")));
			this.btnCerra.Location = new System.Drawing.Point(1012, 12);
			this.btnCerra.Name = "btnCerra";
			this.btnCerra.Size = new System.Drawing.Size(25, 25);
			this.btnCerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCerra.TabIndex = 1;
			this.btnCerra.TabStop = false;
			this.btnCerra.Click += new System.EventHandler(this.BtnCerraClick);
			// 
			// btnLista
			// 
			this.btnLista.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.btnLista.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLista.Image = ((System.Drawing.Image)(resources.GetObject("btnLista.Image")));
			this.btnLista.Location = new System.Drawing.Point(20, 9);
			this.btnLista.Name = "btnLista";
			this.btnLista.Size = new System.Drawing.Size(35, 35);
			this.btnLista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnLista.TabIndex = 0;
			this.btnLista.TabStop = false;
			this.btnLista.Click += new System.EventHandler(this.BtnListaClick);
			// 
			// panelContenedor
			// 
			this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panelContenedor.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panelContenedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelContenedor.BackgroundImage")));
			this.panelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panelContenedor.Location = new System.Drawing.Point(250, 50);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(1050, 588);
			this.panelContenedor.TabIndex = 2;
			this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedorPaint);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(1300, 650);
			this.Controls.Add(this.panelContenedor);
			this.Controls.Add(this.panelTitulo);
			this.Controls.Add(this.MenuVertical);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(680, 480);
			this.Name = "MainForm";
			this.Text = "MenuPrincipal";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.MenuVertical.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panelTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnLista)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
