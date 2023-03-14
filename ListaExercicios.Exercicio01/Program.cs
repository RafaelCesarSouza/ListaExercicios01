using System;

namespace ListaExercicios.Exercicio01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o comprimento da caixa: ");
            double comprimento = double.Parse(Console.ReadLine());

            Console.Write("Informe a largura da caixa: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura da caixa: ");
            double altura = double.Parse(Console.ReadLine());

            double volume = comprimento * largura * altura;

            Console.WriteLine("O volume da caixa é: " + volume);
            Console.ReadLine();
        }
    }
}