using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Multiplicacao : IOperacao
    {
        public int Calcular(int a, int b)
        {
            int mult = a * b;
            return mult;
        }

        public void RetornarResultado(string operacao)
        {
            Console.WriteLine(operacao);
        }
    }
}
