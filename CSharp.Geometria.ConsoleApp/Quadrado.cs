using System;

namespace CSharp.Geometria.ConsoleApp
{
    internal class Quadrado : Figura2D
    {
        public int Lado { get; private set; }

        public Quadrado(int lado)
        {
            this.Lado = lado;
        }

        public override double Area()
        {
            return Math.Pow(Lado, 2);
        }

        public override double Perimetro()
        {
            return Lado * 4;
        }
    }
}