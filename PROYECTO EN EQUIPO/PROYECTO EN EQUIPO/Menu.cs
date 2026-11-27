/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC02
 * Fecha: 26/11/2026
 * Hora: 07:20 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_EN_EQUIPO
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public partial class Menu : Form
	{
		public Menu()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Arreglos t = new Arreglos();
			t.Show();
			this.Hide();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			//Reves r = new Reves();
			//r.Show();
			//this.Hide();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			//Vocales m = new Vocales();
			//m.Show();
			//this.Hide();
		}
		
		void BTNPROMEDIOClick(object sender, EventArgs e)
		{
			Promedio y = new Promedio();
			y.Show();
			this.Hide();
		}
	}
}
