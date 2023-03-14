using System;

namespace ListaExercicios.Exercicio19
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"\nIMC = {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("\nCondição: Abaixo do peso.");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("\nCondição: Peso normal.");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("\nCondição: Acima do peso.");
            }
            else
            {
                Console.WriteLine("\nCondição: Obeso.");
            }

            Console.ReadKey();
        }
    }
}