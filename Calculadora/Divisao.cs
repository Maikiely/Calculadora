using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Divisao : IOperacao
    {
        public int Calcular(int a, int b)
        {
            int div = a / b;
            return div;
        }

        public void RetornarResultado(string operacao)
        {
            Console.WriteLine(operacao);
        }
    }
}
