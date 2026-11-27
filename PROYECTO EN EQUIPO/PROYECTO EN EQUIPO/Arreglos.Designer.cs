/*
 * Creado por SharpDevelop.
 * Usuario: miche
 * Fecha: 26/11/2026
 * Hora: 09:36 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTO_EN_EQUIPO
{
	partial class Arreglos
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(368, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ESCREBE LOS NUMEROS SEPARADOS POR COMAS:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(75, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(220, 22);
			this.textBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(57, 82);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 46);
			this.button1.TabIndex = 2;
			this.button1.Text = "MENOR A MAYOR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(151, 82);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(86, 46);
			this.button2.TabIndex = 3;
			this.button2.Text = "MAYOR A MENOR";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(243, 82);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(95, 46);
			this.button3.TabIndex = 4;
			this.button3.Text = "REGRESAR";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "RESULTADO:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(368, 23);
			this.label3.TabIndex = 6;
			// 
			// Arreglos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 253);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "Arreglos";
			this.Text = "Arreglos";
			this.Load += new System.EventHandler(this.ArreglosLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}
