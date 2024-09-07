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
    public partial class RectanForm : Form
    {
        private Form Inicio;
        private RECTANGULO rectangulo; // Instancia de la clase RECTANGULO
        private ErrorProvider errorProvider; // Instancia de ErrorProvider para mostrar errores

        public RectanForm(Form formInicio)
        {
            InitializeComponent();
            Inicio = formInicio;
            rectangulo = new RECTANGULO(); // Inicializar la instancia del rectángulo
            errorProvider = new ErrorProvider(); // Inicializar ErrorProvider
        }

        private void BtnCalcularArea_Click(object sender, EventArgs e)
        {
            if (IsDecimal(BaseAreaRec.Text) && IsDecimal(AlturaAreaRect.Text))
            {
                double baseRect = Convert.ToDouble(BaseAreaRec.Text);
                double alturaRect = Convert.ToDouble(AlturaAreaRect.Text);

                rectangulo.Base = baseRect;
                rectangulo.Altura = alturaRect;

                // Calcular y mostrar el área
                double area = rectangulo.area(); // Utiliza el método area() de tu clase RECTANGULO
                txtResultadoArea.Text = area.ToString("F2"); // Formato de dos decimales
                errorProvider.SetError(BaseAreaRec, ""); // Limpiar mensaje de error
                errorProvider.SetError(AlturaAreaRect, ""); // Limpiar mensaje de error
            }
            else
            {
                errorProvider.SetError(BaseAreaRec, "Introducir solo valores numéricos");
                errorProvider.SetError(AlturaAreaRect, "Introducir solo valores numéricos");
                MessageBox.Show("Por favor ingresa valores numéricos válidos para la base y la altura.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCalcularPerimetro_Click(object sender, EventArgs e)
        {
            if (IsDecimal(basePerimRect.Text) && IsDecimal(AlturaPerimRect.Text))
            {
                double baseRect = Convert.ToDouble(basePerimRect.Text);
                double alturaRect = Convert.ToDouble(AlturaPerimRect.Text);

                rectangulo.Base = baseRect;
                rectangulo.Altura = alturaRect;

                // Calcular y mostrar el perímetro
                double perimetro = rectangulo.perimetro(); // Utiliza el método perimetro() de tu clase RECTANGULO
                txtResultadoPerimetro.Text = perimetro.ToString("F2"); // Formato de dos decimales
                errorProvider.SetError(basePerimRect, ""); // Limpiar mensaje de error
                errorProvider.SetError(AlturaPerimRect, ""); // Limpiar mensaje de error
            }
            else
            {
                errorProvider.SetError(basePerimRect, "Introducir solo valores numéricos");
                errorProvider.SetError(AlturaPerimRect, "Introducir solo valores numéricos");
                MessageBox.Show("Por favor ingresa valores numéricos válidos para la base y la altura.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnRegreMenuRectg_Click(object sender, EventArgs e)
        {
            Inicio.Show();
            this.Close();
        }

        private void RectanForm_Load(object sender, EventArgs e)
        {
            // Lógica de inicialización si es necesario
        }

        private bool IsDecimal(string text)
        {
            return decimal.TryParse(text, out _);
        }
    }
}

