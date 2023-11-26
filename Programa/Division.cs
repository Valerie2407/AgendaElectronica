using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConPatrones
{
    internal class Division : IMathOperation
    {
        public int Execute(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("El divisor no puede ser cero.");
            }
            return a / b;
        }
    }
}
