using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREADATOSFIGU
{
    public partial class CuadradoForm : Form
    {
        private Form Inicio;
        private CUADRADO cuadrado; // Instancia de la clase CUADRADO
        private ErrorProvider errorProvider; // Instancia de ErrorProvider para mostrar errores

        public CuadradoForm(Form formInicio)
        {
            InitializeComponent();
            Inicio = formInicio;
            cuadrado = new CUADRADO(); // Inicializar la instancia del cuadrado
            errorProvider = new ErrorProvider(); // Inicializar ErrorProvider
        }

        private void BtnCalcularArea_Click(object sender, EventArgs e)
        {
            if (IsDecimal(txtLado.Text))
            {
                double lado = Convert.ToDouble(txtLado.Text);
                cuadrado.Lado = lado;

                // Calcular y mostrar el área
                double area = cuadrado.area(); // Utiliza el método area() de tu clase CUADRADO
                txtResultadoArea.Text = area.ToString("F2"); // Formato de dos decimales
                errorProvider.SetError(txtLado, ""); // Limpiar mensaje de error
            }
            else
            {
                errorProvider.SetError(txtLado, "Introducir solo valores numéricos");
                MessageBox.Show("Por favor ingresa un valor numérico válido para el lado.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCalcularPerimetro_Click(object sender, EventArgs e)
        {
            if (IsDecimal(txtLadoPerimetro.Text))
            {
                double lado = Convert.ToDouble(txtLadoPerimetro.Text);
                cuadrado.Lado = lado;

                // Calcular y mostrar el perímetro
                double perimetro = cuadrado.perimetro(); // Utiliza el método perimetro() de tu clase CUADRADO
                txtResultadoPerimetro.Text = perimetro.ToString("F2"); // Formato de dos decimales
                errorProvider.SetError(txtLadoPerimetro, ""); // Limpiar mensaje de error
            }
            else
            {
                errorProvider.SetError(txtLadoPerimetro, "Introducir solo valores numéricos");
                MessageBox.Show("Por favor ingresa un valor numérico válido para el lado.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRegreMenuCuad_Click(object sender, EventArgs e)
        {
            Inicio.Show(); // Mostrar el formulario de inicio al regresar
            this.Close(); // Cerrar el formulario actual
        }

        private void CuadradoForm_Load(object sender, EventArgs e)
        {
            // Este método puede contener lógica de inicialización si es necesario
        }

        private bool IsDecimal(string text)
        {
            return decimal.TryParse(text, out _);
        }
    }
}



