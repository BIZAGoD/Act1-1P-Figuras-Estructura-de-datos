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
    public partial class CirculoForm : Form
    {
        private Form Inicio;
        private CIRCULO circulo; // Instancia de la clase CIRCULO
        private ErrorProvider errorProvider; // Instancia de ErrorProvider para mostrar errores

        public CirculoForm(Form formInicio)
        {
            InitializeComponent();
            Inicio = formInicio;
            circulo = new CIRCULO(); // Inicializar la instancia del círculo
            errorProvider = new ErrorProvider(); // Inicializar ErrorProvider
        }

        private void BtnCalcularArea_Click(object sender, EventArgs e)
        {
            if (IsDecimal(txtRadio.Text))
            {
                double radio = Convert.ToDouble(txtRadio.Text);
                circulo.Radio = radio;

                // Calcular y mostrar el área
                double area = circulo.area(); // Utiliza el método area() de tu clase CIRCULO
                txtResultadoArea.Text = area.ToString("F2"); // Formato de dos decimales
                errorProvider.SetError(txtRadio, ""); // Limpiar mensaje de error
            }
            else
            {
                errorProvider.SetError(txtRadio, "Introducir solo valores numéricos");
                MessageBox.Show("Por favor ingresa un valor numérico válido para el radio.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCalcularPerimetro_Click(object sender, EventArgs e)
        {
            if (IsDecimal(txtRadioPerimetro.Text))
            {
                double radio = Convert.ToDouble(txtRadioPerimetro.Text);
                circulo.Radio = radio;

                // Calcular y mostrar el perímetro
                double perimetro = circulo.perimetro(); // Utiliza el método perimetro() de tu clase CIRCULO
                txtResultadoPerimetro.Text = perimetro.ToString("F2"); // Formato de dos decimales
                errorProvider.SetError(txtRadioPerimetro, ""); // Limpiar mensaje de error
            }
            else
            {
                errorProvider.SetError(txtRadioPerimetro, "Introducir solo valores numéricos");
                MessageBox.Show("Por favor ingresa un valor numérico válido para el radio.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRegreMenuCirc_Click(object sender, EventArgs e)
        {
            Inicio.Show(); // Mostrar el formulario de inicio al regresar
            this.Close(); // Cerrar el formulario actual
        }

        private void CirculoForm_Load(object sender, EventArgs e)
        {
            // Lógica de inicialización si es necesario
        }

        private bool IsDecimal(string text)
        {
            return decimal.TryParse(text, out _);
        }
    }
}

