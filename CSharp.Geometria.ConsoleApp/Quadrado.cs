using System;

namespace CSharp.Geometria.ConsoleApp
{
    internal class Quadrado : Figura2D, ICapazDeCalcularArea
    {
        public int Lado { get; private set; }

        public Quadrado(int lado)
        {
            this.Lado = lado;
        }

        public double Area()
        {
            return Math.Pow(Lado, 2);
        }
    }
}