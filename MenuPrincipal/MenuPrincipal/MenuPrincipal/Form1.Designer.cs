/*
 * Created by SharpDevelop.
 * User: Santos
 * Date: 27/07/2018
 * Time: 12:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MenuPrincipal
{
	partial class FormVentas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnTerminar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lvlResultado;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn producto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label lvlNombre;
		
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvlResultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvlNombre = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtClave.Location = new System.Drawing.Point(309, 82);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(299, 26);
            this.txtClave.TabIndex = 15;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClaveKeyPress);
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTerminar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnTerminar.Location = new System.Drawing.Point(507, 400);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(149, 30);
            this.btnTerminar.TabIndex = 13;
            this.btnTerminar.Text = "Completar venta";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.BtnTerminarClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvlResultado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dgvProductos);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(154, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 310);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrito";
            // 
            // lvlResultado
            // 
            this.lvlResultado.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.lvlResultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lvlResultado.Location = new System.Drawing.Point(76, 231);
            this.lvlResultado.Name = "lvlResultado";
            this.lvlResultado.Size = new System.Drawing.Size(144, 47);
            this.lvlResultado.TabIndex = 2;
            this.lvlResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(22, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total: ";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.nombre,
            this.producto,
            this.Cantidad,
            this.Total});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvProductos.GridColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvProductos.Location = new System.Drawing.Point(6, 19);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(544, 209);
            this.dgvProductos.TabIndex = 0;
            // 
            // Clave
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Clave.DefaultCellStyle = dataGridViewCellStyle11;
            this.Clave.HeaderText = "Clave";
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            // 
            // nombre
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.nombre.DefaultCellStyle = dataGridViewCellStyle12;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // producto
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.producto.DefaultCellStyle = dataGridViewCellStyle13;
            this.producto.HeaderText = "Precio";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle14;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Total.DefaultCellStyle = dataGridViewCellStyle15;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(145, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clave de producto";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(200, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bienvenido";
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(770, 335);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(10, 20);
            this.txtFolio.TabIndex = 16;
            this.txtFolio.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnCancelar.Location = new System.Drawing.Point(411, 400);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnSalir.Location = new System.Drawing.Point(330, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lvlNombre
            // 
            this.lvlNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lvlNombre.Location = new System.Drawing.Point(305, 47);
            this.lvlNombre.Name = "lvlNombre";
            this.lvlNombre.Size = new System.Drawing.Size(373, 23);
            this.lvlNombre.TabIndex = 19;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(805, 449);
            this.Controls.Add(this.lvlNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormVentasLoad);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
