/*
 * Created by SharpDevelop.
 * User: CC2_PC01
 * Date: 26/11/2026
 * Time: 07:18 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PROYECTO_EN_EQUIPO
{
	partial class Menor_y_Mayor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbOrden = new System.Windows.Forms.ComboBox();
			this.btnOrdenar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(5, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(276, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mayor a Menor   y   Menor a Mayor";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ingresa  un Número:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(5, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ingresa  un Número:";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(127, 48);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(145, 20);
			this.txt1.TabIndex = 3;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(127, 83);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(145, 20);
			this.txt2.TabIndex = 4;
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(19, 182);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(243, 65);
			this.lblRespuesta.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(11, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(149, 22);
			this.label4.TabIndex = 7;
			this.label4.Text = "Seleccionar el Orden:";
			// 
			// cmbOrden
			// 
			this.cmbOrden.FormattingEnabled = true;
			this.cmbOrden.Items.AddRange(new object[] {
									"",
									"Mayor a Menor",
									"Menor a Mayor"});
			this.cmbOrden.Location = new System.Drawing.Point(5, 130);
			this.cmbOrden.Name = "cmbOrden";
			this.cmbOrden.Size = new System.Drawing.Size(145, 21);
			this.cmbOrden.TabIndex = 8;
			// 
			// btnOrdenar
			// 
			this.btnOrdenar.Location = new System.Drawing.Point(186, 121);
			this.btnOrdenar.Name = "btnOrdenar";
			this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
			this.btnOrdenar.TabIndex = 9;
			this.btnOrdenar.Text = "Ordenar";
			this.btnOrdenar.UseVisualStyleBackColor = true;
			this.btnOrdenar.Click += new System.EventHandler(this.BtnOrdenarClick);
			// 
			// Menor_y_Mayor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnOrdenar);
			this.Controls.Add(this.cmbOrden);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Menor_y_Mayor";
			this.Text = "Menor_y_Mayor";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnOrdenar;
		private System.Windows.Forms.ComboBox cmbOrden;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
