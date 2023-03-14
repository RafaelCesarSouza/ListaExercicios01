using System;

namespace ListaExercicios.Exercicio16
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite o salário do funcionário: R$ ");
            double salario = double.Parse(Console.ReadLine());

            double aumento = salario * 0.15;
            double salarioAumentado = salario + aumento;
            double imposto = salarioAumentado * 0.08;
            double salarioFinal = salarioAumentado - imposto;

            Console.WriteLine($"\nSalário inicial: R$ {salario:F2}");
            Console.WriteLine($"Salário com aumento de 15%: R$ {salarioAumentado:F2}");
            Console.WriteLine($"Salário final com desconto de imposto de 8%: R$ {salarioFinal:F2}");

            Console.ReadKey();
        }
    }
}