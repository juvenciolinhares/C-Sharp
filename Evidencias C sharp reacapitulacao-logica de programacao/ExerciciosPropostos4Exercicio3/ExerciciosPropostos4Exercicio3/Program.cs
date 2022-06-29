using System;
using System.Globalization;
namespace ExerciciosPropostos4Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite o número de casos de teste: ");
            int n = int.Parse(Console.ReadLine());

            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("digite os valores reais: ");
                string[] valores = Console.ReadLine().Split(' ');
                double valor1 = double.Parse(valores[0],CultureInfo.InvariantCulture);
                double valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (valor1 * 2.0 + valor2 * 3.0 + valor3 * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
             

        }
    }
}
