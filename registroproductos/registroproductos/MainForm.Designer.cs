/*
 * Created by SharpDevelop.
 * User: COMPAX
 * Date: 18/07/2018
 * Time: 05:59 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace registroproductos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtBuscarProducto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGuardarU;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtTalla;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtProducto;
		private System.Windows.Forms.TextBox txtClaveProducto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		
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
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtBuscarProducto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGuardarU = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtTalla = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.txtClaveProducto = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(285, 498);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(80, 32);
			this.btnEditar.TabIndex = 20;
			this.btnEditar.Text = "Modificar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(172, 498);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(81, 32);
			this.btnEliminar.TabIndex = 19;
			this.btnEliminar.Text = "Elimnar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 177);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(723, 262);
			this.dataGridView1.TabIndex = 17;
			// 
			// txtBuscarProducto
			// 
			this.txtBuscarProducto.Location = new System.Drawing.Point(151, 30);
			this.txtBuscarProducto.Name = "txtBuscarProducto";
			this.txtBuscarProducto.Size = new System.Drawing.Size(585, 20);
			this.txtBuscarProducto.TabIndex = 12;
			this.txtBuscarProducto.TextChanged += new System.EventHandler(this.TxtBuscarProductoTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(18, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 23);
			this.label1.TabIndex = 11;
			this.label1.Text = "Buscar por nombres";
			// 
			// btnGuardarU
			// 
			this.btnGuardarU.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarU.Image")));
			this.btnGuardarU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarU.Location = new System.Drawing.Point(44, 498);
			this.btnGuardarU.Name = "btnGuardarU";
			this.btnGuardarU.Size = new System.Drawing.Size(89, 32);
			this.btnGuardarU.TabIndex = 21;
			this.btnGuardarU.Text = "Guardar";
			this.btnGuardarU.UseVisualStyleBackColor = true;
			this.btnGuardarU.Click += new System.EventHandler(this.BtnGuardarUClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(44, 498);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(89, 32);
			this.btnGuardar.TabIndex = 76;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtTalla
			// 
			this.txtTalla.Location = new System.Drawing.Point(345, 129);
			this.txtTalla.Name = "txtTalla";
			this.txtTalla.Size = new System.Drawing.Size(129, 20);
			this.txtTalla.TabIndex = 75;
			this.txtTalla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTallaKeyPress);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(273, 132);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 20);
			this.label8.TabIndex = 74;
			this.label8.Text = "Talla";
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(124, 132);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(129, 20);
			this.txtDescripcion.TabIndex = 69;
			this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcionKeyPress);
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(575, 74);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(129, 20);
			this.txtPrecio.TabIndex = 68;
			this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioKeyPress);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 17);
			this.label4.TabIndex = 67;
			this.label4.Text = "Descripcion";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(506, 77);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 17);
			this.label5.TabIndex = 66;
			this.label5.Text = "Precio";
			// 
			// txtProducto
			// 
			this.txtProducto.Location = new System.Drawing.Point(345, 77);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(129, 20);
			this.txtProducto.TabIndex = 65;
			this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductoKeyPress);
			// 
			// txtClaveProducto
			// 
			this.txtClaveProducto.Location = new System.Drawing.Point(124, 74);
			this.txtClaveProducto.Name = "txtClaveProducto";
			this.txtClaveProducto.Size = new System.Drawing.Size(129, 20);
			this.txtClaveProducto.TabIndex = 64;
			this.txtClaveProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClaveProductoKeyPress);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(273, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 14);
			this.label3.TabIndex = 63;
			this.label3.Text = "Producto";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(18, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 17);
			this.label2.TabIndex = 62;
			this.label2.Text = "Clave de producto";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 551);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtTalla);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtProducto);
			this.Controls.Add(this.txtClaveProducto);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnGuardarU);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtBuscarProducto);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "registroproductos";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
