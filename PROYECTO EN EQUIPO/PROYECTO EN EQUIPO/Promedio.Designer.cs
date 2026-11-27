/*
 * Creado por SharpDevelop.
 * Usuario: AXEL
 * Fecha: 26/11/2026
 * Hora: 10:04 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTO_EN_EQUIPO
{
	partial class Promedio
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
			this.lblMayor = new System.Windows.Forms.Label();
			this.lblMenor = new System.Windows.Forms.Label();
			this.lblPromedio = new System.Windows.Forms.Label();
			this.txtN = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mayor a Menor y Promedio";
			// 
			// lblMayor
			// 
			this.lblMayor.Location = new System.Drawing.Point(57, 166);
			this.lblMayor.Name = "lblMayor";
			this.lblMayor.Size = new System.Drawing.Size(155, 25);
			this.lblMayor.TabIndex = 1;
			// 
			// lblMenor
			// 
			this.lblMenor.Location = new System.Drawing.Point(57, 196);
			this.lblMenor.Name = "lblMenor";
			this.lblMenor.Size = new System.Drawing.Size(155, 23);
			this.lblMenor.TabIndex = 2;
			// 
			// lblPromedio
			// 
			this.lblPromedio.Location = new System.Drawing.Point(57, 219);
			this.lblPromedio.Name = "lblPromedio";
			this.lblPromedio.Size = new System.Drawing.Size(155, 23);
			this.lblPromedio.TabIndex = 3;
			// 
			// txtN
			// 
			this.txtN.Location = new System.Drawing.Point(57, 62);
			this.txtN.Name = "txtN";
			this.txtN.Size = new System.Drawing.Size(165, 20);
			this.txtN.TabIndex = 4;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(101, 98);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(75, 23);
			this.btnCalcular.TabIndex = 5;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(11, 98);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 6;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(197, 98);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// Promedio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtN);
			this.Controls.Add(this.lblPromedio);
			this.Controls.Add(this.lblMenor);
			this.Controls.Add(this.lblMayor);
			this.Controls.Add(this.label1);
			this.Name = "Promedio";
			this.Text = "Promedio";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtN;
		private System.Windows.Forms.Label lblPromedio;
		private System.Windows.Forms.Label lblMenor;
		private System.Windows.Forms.Label lblMayor;
		private System.Windows.Forms.Label label1;
	}
}
