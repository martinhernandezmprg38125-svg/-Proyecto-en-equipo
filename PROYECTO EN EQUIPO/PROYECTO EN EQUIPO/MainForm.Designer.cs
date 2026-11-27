/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC03
 * Fecha: 25/11/2026
 * Hora: 08:17 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PROYECTO_EN_EQUIPO
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(216, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "BIENVENID@";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(339, 36);
			this.label2.TabIndex = 1;
			this.label2.Text = "NOMBRE DE USUARIO:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(357, 74);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(300, 37);
			this.txtUsuario.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(13, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(338, 37);
			this.label3.TabIndex = 3;
			this.label3.Text = "INGRESA LA CONTRACEÑA:";
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(358, 118);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(299, 37);
			this.txtContraseña.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.button1.Location = new System.Drawing.Point(335, 267);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(236, 47);
			this.button1.TabIndex = 5;
			this.button1.Text = "INICIAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.ImageLocation = "";
			this.pictureBox1.Location = new System.Drawing.Point(13, 155);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(255, 254);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(303, 347);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(354, 62);
			this.label4.TabIndex = 7;
			this.label4.Text = "CONTRACEÑA:1234                                                                  " +
			"  USU:CBTIS217";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 502);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.Name = "MainForm";
			this.Text = "PROYECTO EN EQUIPO";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
