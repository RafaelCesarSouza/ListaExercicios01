using System;

namespace ListaExercicios.Exercicio02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a temperatura em graus Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"\nA temperatura em graus Celsius é: {celsius}");
            Console.ReadLine();
        }
    }
}