using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Geometria.ConsoleApp
{
    class Elipse : Figura2D, ICapazDeCalcularArea
    {
        public int Raio { get; private set; }

        public Elipse(int raio)
        {
            Raio = raio;
        }

        public double Area()
        {
            return Raio*45.0;
        }
    }
}
