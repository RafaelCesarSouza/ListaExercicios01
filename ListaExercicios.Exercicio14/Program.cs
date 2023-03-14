using System;

namespace ListaExercicios.Exercicio14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int diasVida = idade * 365;

            Console.WriteLine($"\n{nome.ToUpper()}, VOCÊ JÁ VIVEU {diasVida} DIAS.");

            Console.ReadKey();
        }
    }
}