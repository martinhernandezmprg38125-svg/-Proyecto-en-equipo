using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
 	
namespace PROYECTO_EN_EQUIPO
{
	/// <summary>
	/// Description of Menor_y_Mayor.
	/// </summary>
	public partial class Menor_y_Mayor : Form
	{
		public Menor_y_Mayor()
		{
			InitializeComponent();
			cmbOrden.Items.Add("Mayor a Menor");
            cmbOrden.Items.Add("Menor a Mayor");
            cmbOrden.SelectedIndex = 0;
		}
		
		void BtnOrdenarClick(object sender, EventArgs e)
		{
          	try
            {
                int[] arreglo1 = txt1.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray();

                int[] arreglo2 = txt2.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToArray();

                string opcion = cmbOrden.SelectedItem.ToString();

                if (opcion == "Menor a Mayor")
                {
                    Array.Sort(arreglo1);
                    Array.Sort(arreglo2);
                }
                else if (opcion == "Mayor a Menor")
                {
                    Array.Sort(arreglo1);
                    Array.Reverse(arreglo1);

                    Array.Sort(arreglo2);
                    Array.Reverse(arreglo2);
                }

                string res1 = string.Join(", ", arreglo1);
                string res2 = string.Join(", ", arreglo2);

                MessageBox.Show("Arreglo 1 ({opcion}): {res1}\nArreglo 2 ({opcion}): {res2}", "Resultados");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa solo números separados por comas o espacios.", "Error de formato");
            }	
		}
    }          
 }


		
	

