using System;

namespace CSharp.Geometria.ConsoleApp
{
    internal class EstudoGeometrico
    {
        private int totalFiguras;
        private ICapazDeCalcularArea[] figuras;

        public EstudoGeometrico()
        {
            figuras = new ICapazDeCalcularArea[10];
        }

        internal void RegistraFigura(ICapazDeCalcularArea figura)
        {
            figuras[totalFiguras] = figura;
            totalFiguras++;
        }

        internal void EmiteEstudoAreas()
        {
            for (int i = 0; i < totalFiguras; i++)
            {
                Console.WriteLine("Área da figura é " + figuras[i].Area());
            }
        }

        internal void EmiteEstudoPerimetro()
        {
            for (int i = 0; i < totalFiguras; i++)
            {
                var f = figuras[i];
                if (f is Quadrado)
                {
                    var q = (Quadrado)f;
                    Console.WriteLine("Perímetro da figura é " + q.Perimetro());
                }
            }
        }
    }
}