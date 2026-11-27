/*
 * Creado por SharpDevelop.
 * Usuario: miche
 * Fecha: 26/11/2026
 * Hora: 09:36 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_EN_EQUIPO
{
	/// <summary>
	/// Description of Arreglos.
	/// </summary>
	public partial class Arreglos : Form
	{
		public Arreglos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Menu y = new Menu();
				y.Show();
				this.Hide();
		}
		
		void ArreglosLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			try
    {
        string[] partes = textBox1.Text.Split(',');
        int[] numeros = new int[partes.Length];

        for (int i = 0; i < partes.Length; i++)
        {
            numeros[i] = int.Parse(partes[i].Trim());
        }

        Array.Sort(numeros);

        label3.Text = "RESULTADO: " + string.Join(", ", numeros);
    }
    catch
    {
        MessageBox.Show(
            "Escribe números separados por comas. Ejemplo: 8, 3, 12",
            "Dato incorrecto"
        );
    }
		}
	}
}
