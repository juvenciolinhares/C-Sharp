// See https://aka.ms/new-console-template for more information
//numero de um funcionario
//numero de horas trabalhadas
//valor que recebe por hora
//calcular salario
//imprimir numero do func e salario com 2 casas decimais 

using System.Globalization;

int numFunc = int.Parse(Console.ReadLine());  
int numHorasTrab = int.Parse(Console.ReadLine());
double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double salario = valorPorHora * numHorasTrab;

Console.WriteLine("NUMBER = " + numFunc);
Console.WriteLine("SALARY = U$ {0:F2}", salario.ToString("F2", CultureInfo.InvariantCulture));