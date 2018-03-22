using System;

namespace CSharp.Geometria.ConsoleApp
{
    internal class Circulo : Figura2D, ICapazDeCalcularArea
    {
        public int Raio { get; private set; }

        public Circulo(int raio)
        {
            Raio = raio;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}