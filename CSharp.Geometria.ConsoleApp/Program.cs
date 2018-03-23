using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Geometria.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            EstudoGeometrico eg = new EstudoGeometrico();
            eg.RegistraFigura(new Quadrado(lado: 4));
            eg.RegistraFigura(new Triangulo(@base: 2, altura: 5));
            eg.RegistraFigura(new Circulo(raio: 4));
            eg.RegistraFigura(new Trapezio(@base: 3, altura: 4));
            eg.RegistraFigura(new Elipse(raio: 4));
            eg.RegistraFigura(new Cubo(lado: 3));
            eg.EmiteEstudoAreas();

        }
    }
}
