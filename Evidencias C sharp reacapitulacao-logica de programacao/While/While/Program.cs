using System;
using System.Globalization;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            double numero = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            while(numero >= 0.0)
            {
                double raizQuadrada = Math.Sqrt(numero);
                Console.WriteLine(raizQuadrada.ToString("F3"),CultureInfo.InvariantCulture);
                Console.Write("Digite outro numero");
                numero = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 
            }
            Console.WriteLine("NUmero negativo!");
        }
    }
}
