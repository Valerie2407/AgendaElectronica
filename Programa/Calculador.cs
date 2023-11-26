using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConPatrones
{
    internal class Calculadora
    {
        private static Calculadora instance;

        private Calculadora()
        {
        }

        public static Calculadora GetInstance()
        {
            if (instance == null)
            {
                instance = new Calculadora();
            }
            return instance;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Divisor no puede ser cero.");
            }
            return a / b;
        }
    }
}