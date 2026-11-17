using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split(' ');
            string[] peca2 = Console.ReadLine().Split(' ');


            int codigo1 = int.Parse(peca1[0]);
            int quantidade1 = int.Parse(peca1[1]);
            double valor1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            int codigo2 = int.Parse(peca2[0]);
            int quantidade2 = int.Parse(peca2[1]);
            double valor2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double valorPagar = quantidade1 * valor1 + quantidade2 * valor2;

            Console.WriteLine($"VALOR A PAGAR: R$ {valorPagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}