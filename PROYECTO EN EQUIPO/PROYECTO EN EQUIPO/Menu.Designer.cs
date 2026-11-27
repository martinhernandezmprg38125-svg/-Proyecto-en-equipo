/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC02
 * Fecha: 26/11/2026
 * Hora: 07:20 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTO_EN_EQUIPO
{
	partial class Menu
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
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.BTNPROMEDIO = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(54, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menu Principal";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 46);
			this.button1.TabIndex = 1;
			this.button1.Text = "ARREGLOS";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(13, 149);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(105, 40);
			this.button3.TabIndex = 3;
			this.button3.Text = "PALABRA AL REVES";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(171, 149);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(101, 40);
			this.button4.TabIndex = 4;
			this.button4.Text = "¿CUANTAS VOCALES TIENE?";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// BTNPROMEDIO
			// 
			this.BTNPROMEDIO.Location = new System.Drawing.Point(171, 48);
			this.BTNPROMEDIO.Name = "BTNPROMEDIO";
			this.BTNPROMEDIO.Size = new System.Drawing.Size(101, 46);
			this.BTNPROMEDIO.TabIndex = 5;
			this.BTNPROMEDIO.Text = "ARREGLOS Y PROMEDIO";
			this.BTNPROMEDIO.UseVisualStyleBackColor = true;
			this.BTNPROMEDIO.Click += new System.EventHandler(this.BTNPROMEDIOClick);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Cyan;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.BTNPROMEDIO);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Menu";
			this.Text = "Menu";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button BTNPROMEDIO;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}
