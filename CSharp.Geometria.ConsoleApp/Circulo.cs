using System;

namespace CSharp.Geometria.ConsoleApp
{
    internal class Circulo : Figura2D
    {
        public int Raio { get; private set; }

        public Circulo(int raio)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Raio;
        }
    }
}