/*
 * Created by SharpDevelop.
 * User: Santos
 * Date: 30/07/2018
 * Time: 07:43 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MenuPrincipal
{
	partial class FormDetalleVentas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dgvVentas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtClaveVentas;
		private System.Windows.Forms.Button btnSalir;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvVentas = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtClaveVentas = new System.Windows.Forms.TextBox();
			this.btnSalir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvVentas
			// 
			this.dgvVentas.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvVentas.BackgroundColor = System.Drawing.Color.PaleTurquoise;
			this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvVentas.GridColor = System.Drawing.Color.MediumSeaGreen;
			this.dgvVentas.Location = new System.Drawing.Point(52, 59);
			this.dgvVentas.Name = "dgvVentas";
			this.dgvVentas.Size = new System.Drawing.Size(644, 317);
			this.dgvVentas.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.label1.Location = new System.Drawing.Point(52, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Clave de venta";
			// 
			// txtClaveVentas
			// 
			this.txtClaveVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F);
			this.txtClaveVentas.Location = new System.Drawing.Point(184, 17);
			this.txtClaveVentas.Name = "txtClaveVentas";
			this.txtClaveVentas.Size = new System.Drawing.Size(248, 26);
			this.txtClaveVentas.TabIndex = 3;
			this.txtClaveVentas.TextChanged += new System.EventHandler(this.TxtClaveVentasTextChanged);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(65, 484);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 6;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// FormDetalleVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleTurquoise;
			this.ClientSize = new System.Drawing.Size(773, 519);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.dgvVentas);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtClaveVentas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormDetalleVentas";
			this.Text = "FormDetalleVentas";
			this.Load += new System.EventHandler(this.FormDetalleVentasLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
