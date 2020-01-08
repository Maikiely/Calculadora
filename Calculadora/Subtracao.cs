using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Subtracao : IOperacao
    {
        public int Calcular(int a, int b)
        {
            int sub = a - b;
            return sub;
        }

        public void RetornarResultado(string operacao)
        {
            Console.WriteLine(operacao);

        }
    }
}
