using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            int resultado = 0;
            int op = 0;
            do
            {

                Console.WriteLine("------------------- Vamos Calcular -------------------");
                Console.WriteLine("Digite a operação que deseja:");
                Console.WriteLine("Se desejar fazer uma divisão tecle 1:");
                Console.WriteLine("Se desejar fazer uma multiplicacao tecle 2:");
                Console.WriteLine("Se desejar fazer uma subtraão tecle 3:");
                Console.WriteLine("Se desejar fazer uma subtração tecle 4:");
                Console.WriteLine("Caso esteja cansado tecle 0 para sair");
                op = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite um valor Inteiro para A");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um valor Inteiro para B");
                int b = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        IOperacao operacao = new Divisao();
                        resultado = operacao.Calcular(a, b);
                        operacao.RetornarResultado("Divisao: " + resultado);
                        break;

                    case 2:
                        operacao = new Multiplicacao();
                        resultado = operacao.Calcular(a, b);
                        operacao.RetornarResultado("Multiplicacao: " + resultado);
                        break;

                    case 3:
                        operacao = new Subtracao();
                        resultado = operacao.Calcular(a, b);
                        operacao.RetornarResultado("Subtracao: " + resultado);
                        break;

                    case 4:
                        operacao = new Soma();
                        resultado = operacao.Calcular(a, b);
                        operacao.RetornarResultado("Soma: " + resultado);
                        break;

                    case 0:
                    default:
                        break;
                }
                Console.Clear();
            } while (op!=0);
           

           

        }
    }
}
