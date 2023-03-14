using System;

namespace ListaExercicios.Exercicio13
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite a quantidade de pães vendidos: ");
            int qtdPaes = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de broas vendidas: ");
            int qtdBroas = int.Parse(Console.ReadLine());

            double valorPao = 0.12;
            double valorBroa = 1.5;

            double totalPao = qtdPaes * valorPao;
            double totalBroa = qtdBroas * valorBroa;

            double arrecadacaoTotal = totalPao + totalBroa;
            double poupanca = arrecadacaoTotal * 0.1;

            Console.WriteLine($"\nA arrecadação total foi de R$ {arrecadacaoTotal:F2}.");
            Console.WriteLine($"O valor a ser guardado na poupança é de R$ {poupanca:F2}.");

            Console.ReadKey();
        }
    }
}