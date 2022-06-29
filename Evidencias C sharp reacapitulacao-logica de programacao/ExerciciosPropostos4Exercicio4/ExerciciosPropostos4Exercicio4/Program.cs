using System;
using System.Globalization;
namespace ExerciciosPropostos4Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("digite dois numeros");
                string[] numero = Console.ReadLine().Split(' ');
                int primeiro = int.Parse(numero[0]);
                int segundo = int.Parse(numero[1]);

                if (segundo == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double resultado = (double)primeiro / segundo;
                    Console.WriteLine(resultado.ToString("F1",CultureInfo.InvariantCulture));
                    
                }
            }
        }
    }
}
