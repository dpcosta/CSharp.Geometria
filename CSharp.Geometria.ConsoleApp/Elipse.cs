using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Geometria.ConsoleApp
{
    class Elipse : Figura2D
    {
        public int Raio { get; private set; }

        public Elipse(int raio)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Raio*45.0;
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }
}
