namespace CSharp.Geometria.ConsoleApp
{
    internal class Triangulo : Figura2D, ICapazDeCalcularArea
    {
        public int Base { get; private set; }
        public int Altura { get; private set; }

        public Triangulo(int @base, int altura)
        {
            Base = @base;
            Altura = altura;
        }

        public double Area()
        {
            return (Base * Altura) / 2.0;
        }
    }
}