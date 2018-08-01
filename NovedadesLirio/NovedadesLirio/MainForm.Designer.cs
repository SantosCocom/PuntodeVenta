/*
 * Created by SharpDevelop.
 * User: Santos
 * Date: 17/07/2018
 * Time: 07:27 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NovedadesLirio
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtEmpleado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lvlResultado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Button btnTerminar;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn producto;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.TextBox txtFolio;
		
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
			this.txtEmpleado = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvlResultado = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnTerminar = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.txtFolio = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEmpleado
			// 
			this.txtEmpleado.Enabled = false;
			this.txtEmpleado.Location = new System.Drawing.Point(99, 10);
			this.txtEmpleado.Name = "txtEmpleado";
			this.txtEmpleado.Size = new System.Drawing.Size(202, 20);
			this.txtEmpleado.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bienvenido";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Clave de producto";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lvlResultado);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dgvProductos);
			this.groupBox1.Location = new System.Drawing.Point(22, 73);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(559, 209);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Carrito";
			// 
			// lvlResultado
			// 
			this.lvlResultado.Location = new System.Drawing.Point(68, 185);
			this.lvlResultado.Name = "lvlResultado";
			this.lvlResultado.Size = new System.Drawing.Size(100, 23);
			this.lvlResultado.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(21, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Total: ";
			// 
			// dgvProductos
			// 
			this.dgvProductos.AllowUserToAddRows = false;
			this.dgvProductos.AllowUserToDeleteRows = false;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Clave,
			this.nombre,
			this.producto,
			this.Cantidad,
			this.Total});
			this.dgvProductos.Location = new System.Drawing.Point(12, 19);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			this.dgvProductos.Size = new System.Drawing.Size(544, 159);
			this.dgvProductos.TabIndex = 0;
			this.dgvProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvProductosKeyDown);
			// 
			// Clave
			// 
			this.Clave.HeaderText = "Clave";
			this.Clave.Name = "Clave";
			this.Clave.ReadOnly = true;
			// 
			// nombre
			// 
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			// 
			// producto
			// 
			this.producto.HeaderText = "Precio";
			this.producto.Name = "producto";
			this.producto.ReadOnly = true;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			// 
			// Total
			// 
			this.Total.HeaderText = "Total";
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			// 
			// btnTerminar
			// 
			this.btnTerminar.Location = new System.Drawing.Point(393, 288);
			this.btnTerminar.Name = "btnTerminar";
			this.btnTerminar.Size = new System.Drawing.Size(104, 23);
			this.btnTerminar.TabIndex = 6;
			this.btnTerminar.Text = "Completar venta";
			this.btnTerminar.UseVisualStyleBackColor = true;
			this.btnTerminar.Click += new System.EventHandler(this.BtnTerminarClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(22, 288);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(130, 51);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(100, 20);
			this.txtClave.TabIndex = 8;
			this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClaveKeyPress);
			// 
			// txtFolio
			// 
			this.txtFolio.Location = new System.Drawing.Point(423, 13);
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new System.Drawing.Size(100, 20);
			this.txtFolio.TabIndex = 9;
			this.txtFolio.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 323);
			this.Controls.Add(this.txtFolio);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnTerminar);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEmpleado);
			this.Name = "MainForm";
			this.Text = "NovedadesLirio";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
