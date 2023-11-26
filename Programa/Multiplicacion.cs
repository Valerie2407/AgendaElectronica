using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConPatrones
{
    internal class Multiplicacion : IMathOperation
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}
