using System;

namespace ListaExercicios.Exercicio06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"\nA temperatura em Fahrenheit é: {fahrenheit}");
            Console.ReadLine();
        }
    }
}