using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREADATOSFIGU
{
    public class RECTANGULO : FIGURAS
    {
        public double altura;
        public double bases;
        public RECTANGULO()
        { }
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double Base
        {
            get { return bases; }
            set { bases = value; }
        }

        public override double area()
        {
            return (Base * Altura);
        }

        public override double perimetro()
        {
            return (Base * 2 + Altura * 2);
        }
    }
}
