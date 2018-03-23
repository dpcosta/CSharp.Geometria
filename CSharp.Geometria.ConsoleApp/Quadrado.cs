using System;

namespace CSharp.Geometria.ConsoleApp
{
    internal class Quadrado : Figura2D, ICapazDeCalcularArea, ICapazDeCalcularPerimetro
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

        public double Perimetro()
        {
            return Lado * 4;
        }
    }
}