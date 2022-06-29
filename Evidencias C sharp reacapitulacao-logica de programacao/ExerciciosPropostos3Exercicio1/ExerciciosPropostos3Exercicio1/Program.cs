using System;

namespace ExerciciosPropostos3Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma senha");
            int senha = int.Parse(Console.ReadLine());
            while(senha != 2002)
            {
                Console.WriteLine("SEnha inválida");
                Console.WriteLine("Digite uma senha");
                senha = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
