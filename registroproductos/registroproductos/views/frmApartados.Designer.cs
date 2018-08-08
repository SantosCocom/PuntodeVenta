/*
 * Created by SharpDevelop.
 * User: COMPAX
 * Date: 29/07/2018
 * Time: 08:12 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace registroproductos.views
{
	partial class frmApartados
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNombreCliente;
		private System.Windows.Forms.DateTimePicker dtpFechaInicio;
		private System.Windows.Forms.TextBox txtClave;
		private System.Windows.Forms.DateTimePicker dtpFechaFin;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtClaveApartado;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSaldo;
		private System.Windows.Forms.Button btnApartados;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombreCliente = new System.Windows.Forms.TextBox();
			this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
			this.txtClave = new System.Windows.Forms.TextBox();
			this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtClaveApartado = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSaldo = new System.Windows.Forms.TextBox();
			this.btnApartados = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtNombreCliente);
			this.groupBox1.Controls.Add(this.dtpFechaInicio);
			this.groupBox1.Controls.Add(this.txtClave);
			this.groupBox1.Controls.Add(this.dtpFechaFin);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtClaveApartado);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtSaldo);
			this.groupBox1.Location = new System.Drawing.Point(41, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(418, 288);
			this.groupBox1.TabIndex = 17;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Registrate";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 74);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 28);
			this.label3.TabIndex = 12;
			this.label3.Text = "Clave Cliente";
			// 
			// txtNombreCliente
			// 
			this.txtNombreCliente.Location = new System.Drawing.Point(120, 71);
			this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombreCliente.Name = "txtNombreCliente";
			this.txtNombreCliente.Size = new System.Drawing.Size(265, 20);
			this.txtNombreCliente.TabIndex = 13;
			this.txtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreClienteKeyPress);
			// 
			// dtpFechaInicio
			// 
			this.dtpFechaInicio.Location = new System.Drawing.Point(120, 154);
			this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4);
			this.dtpFechaInicio.Name = "dtpFechaInicio";
			this.dtpFechaInicio.Size = new System.Drawing.Size(265, 20);
			this.dtpFechaInicio.TabIndex = 10;
			// 
			// txtClave
			// 
			this.txtClave.Location = new System.Drawing.Point(120, 198);
			this.txtClave.Margin = new System.Windows.Forms.Padding(4);
			this.txtClave.Name = "txtClave";
			this.txtClave.Size = new System.Drawing.Size(265, 20);
			this.txtClave.TabIndex = 9;
			this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClaveKeyPress);
			// 
			// dtpFechaFin
			// 
			this.dtpFechaFin.Location = new System.Drawing.Point(120, 108);
			this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4);
			this.dtpFechaFin.Name = "dtpFechaFin";
			this.dtpFechaFin.Size = new System.Drawing.Size(265, 20);
			this.dtpFechaFin.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(7, 159);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 28);
			this.label7.TabIndex = 5;
			this.label7.Text = "Fecha inicio";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(7, 201);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 28);
			this.label8.TabIndex = 6;
			this.label8.Text = "Clave Productos";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(7, 113);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(114, 28);
			this.label9.TabIndex = 7;
			this.label9.Text = "Fecha finalizada";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 30);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Clave apartado";
			// 
			// txtClaveApartado
			// 
			this.txtClaveApartado.Enabled = false;
			this.txtClaveApartado.Location = new System.Drawing.Point(120, 27);
			this.txtClaveApartado.Margin = new System.Windows.Forms.Padding(4);
			this.txtClaveApartado.Name = "txtClaveApartado";
			this.txtClaveApartado.Size = new System.Drawing.Size(265, 20);
			this.txtClaveApartado.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 243);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 28);
			this.label2.TabIndex = 0;
			this.label2.Text = "Abono inicial";
			// 
			// txtSaldo
			// 
			this.txtSaldo.Location = new System.Drawing.Point(120, 240);
			this.txtSaldo.Margin = new System.Windows.Forms.Padding(4);
			this.txtSaldo.Name = "txtSaldo";
			this.txtSaldo.Size = new System.Drawing.Size(265, 20);
			this.txtSaldo.TabIndex = 1;
			this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaldoKeyPress);
			// 
			// btnApartados
			// 
			this.btnApartados.Location = new System.Drawing.Point(48, 307);
			this.btnApartados.Margin = new System.Windows.Forms.Padding(4);
			this.btnApartados.Name = "btnApartados";
			this.btnApartados.Size = new System.Drawing.Size(168, 28);
			this.btnApartados.TabIndex = 16;
			this.btnApartados.Text = "Registrar Apartado";
			this.btnApartados.UseVisualStyleBackColor = true;
			this.btnApartados.Click += new System.EventHandler(this.BtnApartadosClick);
			// 
			// frmApartados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 363);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnApartados);
			this.Name = "frmApartados";
			this.Text = "frmApartados";
			this.Load += new System.EventHandler(this.FrmApartadosLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
