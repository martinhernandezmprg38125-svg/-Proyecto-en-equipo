/*
 * Creado por SharpDevelop.
 * Usuario: AXEL
 * Fecha: 26/11/2026
 * Hora: 10:04 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace PROYECTO_EN_EQUIPO
{
	/// <summary>
	/// Description of Promedio.
	/// </summary>
	public partial class Promedio : Form
	{
		public Promedio()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			 try
            {
                // 1. Separar el texto del TextBox por comas y convertirlo a un arreglo de números (double[])
                double[] numeros = txtN.Text
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => double.Parse(n.Trim()))
                    .ToArray();

                // Validar que haya al menos un número
                if (numeros.Length == 0)
                {
                    MessageBox.Show("Por favor, ingresa al menos un número.");
                    return;
                }

                // 2. Utilizar las herramientas de LINQ sobre el arreglo
                double mayor = numeros.Max();
                double menor = numeros.Min();
                double promedio = numeros.Average();

                // 3. Mostrar resultados en los Labels
                lblMayor.Text = "Mayor: " + mayor;
                lblMenor.Text = "Menor: " + menor;
                lblPromedio.Text = "Promedio: " + promedio.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Asegúrate de ingresar solo números separados por comas.");
            }
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtN.Text=" ";
			lblMayor.Text=" ";
			lblMenor.Text=" ";
			lblPromedio.Text=" ";
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
