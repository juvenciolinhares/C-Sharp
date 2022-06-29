using System;

namespace ExerciciosPropostos3Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipos de combustivel:
            //1. alcool
            //2.gasolina
            //3.diesel
            //4.fim


            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("digite um numero de 1 a 4");
            int numero = int.Parse(Console.ReadLine());
            while (numero != 4)
            {
                if (numero == 1)
                {
                    alcool++;
                    
                }
                else if (numero == 2)
                {
                    gasolina++;
                    
                }
                else if (numero == 3)
                {
                    diesel++;
                    
                }
                else
                {
                    Console.WriteLine("código invalido");
                    Console.WriteLine("digite um numero de 1 a 4");
                    numero = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}
