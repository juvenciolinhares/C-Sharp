using System;

namespace FuncoesSintaxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fazer um programa que leia 3 numeros e diag qual o maior dos 3:
            Console.WriteLine("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            //4- faço a chamada da função passando os valores no parametro:
            double resultado = Maior(n1, n2, n3);

            //5-imprimo o resultado
            Console.WriteLine("Maior = " + resultado);


        }
        //declara a função como estática, depois o tipo de saída:
        static int Maior(int a, int b, int c)
        {
            //1- declaro uma variavel para guardar o maior 
            int m;

            //2-crio a lógica
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            //3-retorno o valor 
            return m;
        }
    }
}
/*executar o debug: f9
 * iniciar o debug: f5 
 * rodar passo-a-passo f10
 * o f10 não entra na função,
 * caso eu queira entrar na função: usaria o f11 para entrar na função 
 */
