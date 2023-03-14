using System;

namespace ListaExercicios.Exercicio10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Informe a nota da primeira prova: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o peso da primeira prova: ");
            double peso1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a nota da segunda prova: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Informe o peso da segunda prova: ");
            double peso2 = double.Parse(Console.ReadLine());

            double mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine($"\nA média ponderada das provas é: {mediaPonderada}");
            Console.ReadLine();
        }
    }
}