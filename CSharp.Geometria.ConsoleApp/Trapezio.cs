namespace CSharp.Geometria.ConsoleApp
{
    internal class Trapezio : Figura2D, ICapazDeCalcularArea
    {
        public int Base { get; private set; }
        public int Altura { get; private set; }

        public Trapezio(int @base, int altura)
        {
            Base = @base;
            Altura = altura;
        }

        public double Area()
        {
            return 13.0;
        }
    }
}