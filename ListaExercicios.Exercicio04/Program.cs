using System;

namespace ListaExercicios.Exercicio04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quilometragem inicial do percurso: ");
            double kmInicial = double.Parse(Console.ReadLine());

            Console.Write("Informe a quilometragem final do percurso: ");
            double kmFinal = double.Parse(Console.ReadLine());

            Console.Write("Informe o consumo de combustível em litros: ");
            double consumo = double.Parse(Console.ReadLine());

            double distancia = kmFinal - kmInicial;
            double consumoPorKm = distancia / consumo;

            Console.WriteLine($"\nO consumo de combustível por km foi de: {consumoPorKm} litros/km");
            Console.ReadLine();
        }
    }
}