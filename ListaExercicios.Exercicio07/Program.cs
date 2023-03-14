using System;

namespace ListaExercicios.Exercicio07
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Informe o salário base do vendedor: R$ ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Informe o total de vendas do vendedor: R$ ");
            double totalVendas = double.Parse(Console.ReadLine());

            Console.Write("Informe o percentual de comissão sobre as vendas (ex: 10 para 10%): ");
            double percentualComissao = double.Parse(Console.ReadLine()) / 100.0;

            double comissao = totalVendas * percentualComissao;
            double salarioTotal = salarioBase + comissao;

            Console.WriteLine($"\nO salário total do vendedor é: R$ {salarioTotal}");
            Console.ReadLine();
        }
    }
}