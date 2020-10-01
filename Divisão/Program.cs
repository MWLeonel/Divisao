using System;

namespace Divisão
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            double valor3;

            Console.Write("Digite o 1ºValor: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2ºValor: ");
            valor2 = double.Parse(Console.ReadLine());
            Console.Write("\n");

            valor3 = valor1 / valor2;
            
            if(valor2 > 0)
            {
                Console.WriteLine($"{valor1} dividido por {valor2} é = {valor3}");
            }
            else
            {
                Console.WriteLine("Não é possivel dividir por zero");
            }
        }
    }
}
