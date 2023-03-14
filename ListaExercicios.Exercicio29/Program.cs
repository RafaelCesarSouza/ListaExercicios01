using System;

namespace ListaExercicios.Exercicio29
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int max = 10;

            for (int i = 1; i <= max; i++)
            {
                for (int a = 1; a <= max; a++)
                {
                    int result = i * a;

                    Console.Write("{0,2} x {1,2} = {2,3}   ", i, a, result);
                }

                Console.WriteLine();
            }
        }
    }
}