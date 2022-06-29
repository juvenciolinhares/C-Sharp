using System;

namespace ExerciciosPropostosExercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());



            if(n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    int primeiro = i;
                    int segundo = i * i;
                    int terceiro = i * i * i;
                    Console.WriteLine($"{primeiro} {segundo} {terceiro}");
                }
            }
            


        }
    }
}
