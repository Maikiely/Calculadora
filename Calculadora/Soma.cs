using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Soma : IOperacao
    {
        public int Calcular(int a, int b)
        {
            int soma = a + b;
            return soma;
        }

        public void RetornarResultado(string operacao)
        {
            Console.WriteLine(operacao);
        }
    }
}
