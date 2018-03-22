using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Geometria.ConsoleApp
{
    class Elipse : Figura2D, ICapazDeCalcularArea
    {
        public double Area()
        {
            return 22.0;
        }
    }
}
