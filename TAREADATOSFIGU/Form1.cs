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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
        private void BtnRectangulo_Click(object sender, EventArgs e)
        {
            RectanForm llamar = new RectanForm(this);
            llamar.Show();
            this.Hide();
        }

        private void BtnCuadrado_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario CuadradoForm y pasar el formulario actual (Inicio)
            CuadradoForm cuadradoForm = new CuadradoForm(this);

            // Ocultar el formulario actual (Inicio)
            this.Hide();

            // Mostrar el formulario CuadradoForm
            cuadradoForm.Show();
        }

        private void BtnCirculo_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario CirculoForm y pasar el formulario actual (Inicio)
            CirculoForm circuloForm = new CirculoForm(this);

            // Ocultar el formulario actual (Inicio)
            this.Hide();

            // Mostrar el formulario CirculoForm
            circuloForm.Show();
        }

        private void BtnTriangulo_Click(object sender, EventArgs e)
        {
            // Crear una instancia de TrianguloForm y pasar el formulario actual como argumento
            TrianguloForm trianguloForm = new TrianguloForm(this);
            trianguloForm.Show(); // Mostrar el formulario TrianguloForm
            this.Hide(); // Ocultar el formulario de inicio
        }
    }
}
