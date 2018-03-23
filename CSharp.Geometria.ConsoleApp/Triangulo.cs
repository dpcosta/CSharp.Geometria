namespace CSharp.Geometria.ConsoleApp
{
    internal class Triangulo : Figura2D, ICapazDeCalcularArea
    {
        public int Base { get; private set; }
        public int Altura { get; private set; }
        public int Lado1 { get; private set; }
        public int Lado2 { get; private set; }

        public Triangulo(int @base, int altura)
        {
            Base = @base;
            Altura = altura;
        }

        public override double Area()
        {
            return (Base * Altura) / 2.0;
        }

        public override double Perimetro()
        {
            return Base + Lado1 + Lado2;
        }
    }
}