// See https://aka.ms/new-console-template for more information

using System.Globalization;// atribui o . como separador decimal

//saida com quebra de linha:
Console.WriteLine("Bom dia");
Console.WriteLine("Boa tarde");

//saida sem quebra de linha
Console.Write("Bom dia");
Console.WriteLine("Boa tarde");
//bom dia e boa tarde um do lado do outro
Console.WriteLine();
//saida de variaveis:

double saldo = 10.35784;
Console.WriteLine(saldo.ToString("F2"));//o F2 delimita o número de casas
Console.WriteLine(saldo.ToString("F4"));//4 casas decimais
Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));// imprimir os separadores decimais com.


Console.WriteLine();
//Placeholdes, concatenação e interpolação:
//obs.:não consigo colocar o . como separador de decimais em placeholders e concatenação, apenas em interpolação

char genero = 'F';
int idade = 32;
string nome = "Maria";

//placeholdes:
//nas {} entram as varias, os numero na {} são a posição delas, {2:F2} é o numero de casas decimais


Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais ", nome, idade, saldo);

//interpolação:
Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");

//concatenação:
Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo .ToString("F2", CultureInfo.InvariantCulture)+ " reais");



