namespace CSharp.Geometria.ConsoleApp
{
    internal class Trapezio : Figura2D
    {
        public int BaseMaior { get; private set; }
        public int BaseMenor { get; private set; }
        public int Altura { get; private set; }
        public int Lado1 { get; private set; }
        public int Lado2 { get; private set; }

        public Trapezio(int baseMenor, int baseMaior, int altura)
        {
            BaseMenor = baseMenor;
            BaseMaior = baseMaior;
            Altura = altura;
        }

        public override double Area()
        {
            return Altura * ((BaseMaior + BaseMenor) / 2);
        }

        public override double Perimetro()
        {
            return (BaseMaior + BaseMenor +  Lado1 + Lado2);
        }
    }
}