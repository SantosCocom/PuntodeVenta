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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lvlResultado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.DataGridViewTextBoxColumn producto;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lvlResultado = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(84, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(202, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Empleado";
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(113, 48);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(126, 20);
			this.txtClave.TabIndex = 3;
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
			this.groupBox1.Location = new System.Drawing.Point(291, 51);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(460, 209);
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
			this.dgvProductos.AllowUserToOrderColumns = true;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.producto,
			this.nombre});
			this.dgvProductos.Location = new System.Drawing.Point(6, 19);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.Size = new System.Drawing.Size(448, 159);
			this.dgvProductos.TabIndex = 0;
			// 
			// producto
			// 
			this.producto.HeaderText = "Precio";
			this.producto.Name = "producto";
			// 
			// nombre
			// 
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(393, 266);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Completar venta";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(22, 266);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(248, 266);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(105, 23);
			this.btnAgregar.TabIndex = 8;
			this.btnAgregar.Text = "Agregar a carrito";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 323);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtClave);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "NovedadesLirio";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
