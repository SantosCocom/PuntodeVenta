/*
 * Created by SharpDevelop.
 * User: COMPAX
 * Date: 30/07/2018
 * Time: 08:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace registroproductos.views
{
	partial class frmDetalleApartado
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgbApartados;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtApartado;
		
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
			this.dgbApartados = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtApartado = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgbApartados)).BeginInit();
			this.SuspendLayout();
			// 
			// dgbApartados
			// 
			this.dgbApartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgbApartados.Location = new System.Drawing.Point(51, 67);
			this.dgbApartados.Margin = new System.Windows.Forms.Padding(4);
			this.dgbApartados.Name = "dgbApartados";
			this.dgbApartados.Size = new System.Drawing.Size(624, 232);
			this.dgbApartados.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(65, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 26);
			this.label1.TabIndex = 20;
			this.label1.Text = "Buscar Apartado";
			// 
			// txtApartado
			// 
			this.txtApartado.Location = new System.Drawing.Point(157, 16);
			this.txtApartado.Name = "txtApartado";
			this.txtApartado.Size = new System.Drawing.Size(200, 20);
			this.txtApartado.TabIndex = 22;
			this.txtApartado.TextChanged += new System.EventHandler(this.TxtApartadoTextChanged);
			// 
			// frmDetalleApartado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(726, 363);
			this.Controls.Add(this.txtApartado);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgbApartados);
			this.Name = "frmDetalleApartado";
			this.Text = "frmDetalleApartado";
			this.Load += new System.EventHandler(this.FrmDetalleApartadoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgbApartados)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
