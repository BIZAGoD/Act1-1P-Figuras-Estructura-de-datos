using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREADATOSFIGU
{
    public class CUADRADO : FIGURAS
    {
        public double lado;

        public CUADRADO()
        { }

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double area()
        {
            return (Lado * Lado);
        }

        public override double perimetro()
        {
            return 4 * Lado;
        }
    }
}
