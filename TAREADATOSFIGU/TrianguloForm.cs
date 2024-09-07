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
    public partial class TrianguloForm : Form
    {
        private Form Inicio;
        private TRIANGULO triangulo; // Instancia de la clase TRIANGULO
        private ErrorProvider errorProvider; // Instancia de ErrorProvider para mostrar errores

        public TrianguloForm(Form formInicio)
        {
            InitializeComponent();
            Inicio = formInicio;
            triangulo = new TRIANGULO(); // Inicializar la instancia del triángulo
            errorProvider = new ErrorProvider(); // Inicializar ErrorProvider
        }

        private void BtnCalcularArea_Click(object sender, EventArgs e)
        {
            if (IsDecimal(txtBase.Text) && IsDecimal(txtAltura.Text))
            {
                double baseTriangulo = Convert.ToDouble(txtBase.Text);
                double altura = Convert.ToDouble(txtAltura.Text);
                triangulo.Baze = baseTriangulo;
                triangulo.Altu = altura;

                // Calcular y mostrar el área
                double area = triangulo.area(); // Utiliza el método area() de tu clase TRIANGULO
                txtResultadoArea.Text = area.ToString("F2"); // Formato de dos decimales
                errorProvider.SetError(txtBase, ""); // Limpiar mensaje de error
                errorProvider.SetError(txtAltura, ""); // Limpiar mensaje de error
            }
            else
            {
                errorProvider.SetError(txtBase, "Introducir solo valores numéricos");
                errorProvider.SetError(txtAltura, "Introducir solo valores numéricos");
                MessageBox.Show("Por favor ingresa valores numéricos válidos para la base y la altura.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCalcularPerimetro_Click(object sender, EventArgs e)
        {
            if (IsDecimal(txtLado1.Text) && IsDecimal(txtLado2.Text) && IsDecimal(txtLado3.Text))
            {
                double lado1 = Convert.ToDouble(txtLado1.Text);
                double lado2 = Convert.ToDouble(txtLado2.Text);
                double lado3 = Convert.ToDouble(txtLado3.Text);
                triangulo.Lado1 = lado1;
                triangulo.Lado2 = lado2;
                triangulo.Lado3 = lado3;

                // Calcular y mostrar el perímetro
                double perimetro = triangulo.perimetro(); // Utiliza el método perimetro() de tu clase TRIANGULO
                txtResultadoPerimetro.Text = perimetro.ToString("F2"); // Formato de dos decimales
                errorProvider.SetError(txtLado1, ""); // Limpiar mensaje de error
                errorProvider.SetError(txtLado2, ""); // Limpiar mensaje de error
                errorProvider.SetError(txtLado3, ""); // Limpiar mensaje de error
            }
            else
            {
                errorProvider.SetError(txtLado1, "Introducir solo valores numéricos");
                errorProvider.SetError(txtLado2, "Introducir solo valores numéricos");
                errorProvider.SetError(txtLado3, "Introducir solo valores numéricos");
                MessageBox.Show("Por favor ingresa valores numéricos válidos para los lados del triángulo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRegreMenuTriang_Click(object sender, EventArgs e)
        {
            Inicio.Show(); // Mostrar el formulario de inicio al regresar
            this.Close(); // Cerrar el formulario actual
        }

        private void TrianguloForm_Load(object sender, EventArgs e)
        {
            // Lógica de inicialización si es necesario
        }

        private void BtnTriangulo_Click(object sender, EventArgs e)
        {
            // Implementación si es necesaria
        }

        private bool IsDecimal(string text)
        {
            return decimal.TryParse(text, out _);
        }
    }
}


