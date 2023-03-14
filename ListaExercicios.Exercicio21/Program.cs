using System;

namespace ListaExercicios.Exercicio21
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int a;
            int b;
            int resultado;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                resultado = a + b;
                Console.WriteLine($"\nOs valores são iguais. A soma é: {resultado}");
            }
            else
            {
                resultado = a * b;
                Console.WriteLine($"\nOs valores são diferentes. A multiplicação é: {resultado}");
            }
        }
    }
}