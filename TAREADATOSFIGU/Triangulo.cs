using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREADATOSFIGU
{
    public class TRIANGULO : FIGURAS
    {
        public double bases;
        public double alturas;
        public double lado1;
        public double lado2;
        public double lado3;

        public TRIANGULO()
        {

        }

        public double Baze
        {
            get { return bases; }
            set { bases = value; }
        }

        public double Altu
        {
            get { return alturas; }
            set { alturas = value; }
        }

        public double Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }

        public double Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }

        public double Lado3
        {
            get { return lado3; }
            set { lado3 = value; }
        }


        public override double area()
        {
            return (bases * alturas) / 2;
        }

        public override double perimetro()
        {
            return lado1 + lado2 + lado3;
        }

    }
}
