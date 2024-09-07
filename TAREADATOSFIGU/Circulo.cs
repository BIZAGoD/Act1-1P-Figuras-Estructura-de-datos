using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREADATOSFIGU
{
    public class CIRCULO : FIGURAS
    {
        private double radio;

        public CIRCULO()
        { }

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public override double area()
        {
            return Math.PI * (Radio * Radio);
        }

        public override double perimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }

}
