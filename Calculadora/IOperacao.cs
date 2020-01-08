using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    interface IOperacao
    {
        int Calcular(int a, int b);

        //exibir o rrsultao? 
        void RetornarResultado(string operacao);
       
    }
}
