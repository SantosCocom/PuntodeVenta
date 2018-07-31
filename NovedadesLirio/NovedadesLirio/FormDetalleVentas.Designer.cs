/*
 * Created by SharpDevelop.
 * User: Santos
 * Date: 28/07/2018
 * Time: 11:26 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NovedadesLirio
{
	partial class FormDetalleVentas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtClaveVentas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvVentas;
		
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
			this.txtClaveVentas = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvVentas = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
			this.SuspendLayout();
			// 
			// txtClaveVentas
			// 
			this.txtClaveVentas.Location = new System.Drawing.Point(134, 25);
			this.txtClaveVentas.Name = "txtClaveVentas";
			this.txtClaveVentas.Size = new System.Drawing.Size(248, 20);
			this.txtClaveVentas.TabIndex = 0;
			this.txtClaveVentas.TextChanged += new System.EventHandler(this.TxtClaveVentasTextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(28, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Clave de venta";
			// 
			// dgvVentas
			// 
			this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVentas.Location = new System.Drawing.Point(56, 91);
			this.dgvVentas.Name = "dgvVentas";
			this.dgvVentas.Size = new System.Drawing.Size(543, 272);
			this.dgvVentas.TabIndex = 2;
			// 
			// FormDetalleVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(613, 375);
			this.Controls.Add(this.dgvVentas);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtClaveVentas);
			this.Name = "FormDetalleVentas";
			this.Text = "FormDetalleVentas";
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
