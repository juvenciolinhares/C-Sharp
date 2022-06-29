using System;

namespace ExerciciosPropostos2Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(s[0]);
            int horaFinal = int.Parse(s[1]);

            int duracao;
            if (horaInicial > horaFinal)
            {
                duracao = 24 - horaInicial + horaFinal;
                Console.WriteLine("O JOGO DUROU {0} HORAS(S)", duracao);
            }
            else if (horaFinal > horaInicial)
            {
                duracao = horaFinal - horaInicial;
                Console.WriteLine("O JOGO DUROU {0} HORAS(S)", duracao);

            }
            else
            {
                Console.WriteLine("O JOGO DUROU 24 HORAS(S)");
            }
        }
    }
}
