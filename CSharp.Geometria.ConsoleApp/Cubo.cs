using System;

namespace CSharp.Geometria.ConsoleApp
{
    internal class Cubo : ICapazDeCalcularArea
    {
        public int Lado { get; private set; }

        public Cubo(int lado)
        {
            Lado = lado;
        }

        public double Area()
        {
            return 6 * Math.Pow(Lado, 2);
        }
    }
}