using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Geometria.ConsoleApp
{
    abstract class Figura2D : ICapazDeCalcularArea, ICapazDeCalcularPerimetro
    {
        public abstract double Area();

        public abstract double Perimetro();
    }
}
