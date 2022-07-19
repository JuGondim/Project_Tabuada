using System;

namespace Calculadora_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Mallu! Bem vinda a sua calculadora de mutiplicação!");
            Console.WriteLine("Digite o valor que deseja multiplicar hoje: ");
               int valor = int.Parse (Console.ReadLine());

            int x = 0;

            while (x <= 20)
            {
                int multiplicacao = valor * x;
                Console.WriteLine($"{valor} x {x} : {multiplicacao}.");
                x++;
            }

        }
    }
}
