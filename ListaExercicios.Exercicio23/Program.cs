using System;

namespace ListaExercicios.Exercicio23
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Números ímpares entre 100 e 200:");

            for (int i = 101; i < 200; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}