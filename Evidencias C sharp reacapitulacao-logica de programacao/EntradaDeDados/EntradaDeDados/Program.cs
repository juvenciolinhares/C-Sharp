// See https://aka.ms/new-console-template for more information
using System.Globalization;

/*
//entrada de dados Parte 1:
string frase = Console.ReadLine();
string x = Console.ReadLine();
string y = Console.ReadLine();  
string z = Console.ReadLine();

Console.WriteLine("VOcê digitou: " + frase);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

//usando o split(recortar uma string)
//(declaro um vetor uso o '' como divisor das palavras):

//recortar variavel s:
string[] v = Console.ReadLine().Split(' ');//recebo os dados de entrada e ja aplico o split.
string a = v[0];
string b = v[1];
string c = v[2];
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
*/
//entrada de dados Parte 2:

//conversão de strings metodo .Parse:
/*int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//uso o cultureinfo por conta do System.Globalization
//obs.:o ponto decimal vai ser a "," por conta do idioma, pra corrigir isso, importa o using System.Globalization
Console.WriteLine("Voce digitou: ");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));// CultureInfo para imprimir com "."
*/
//ler a linha: Maria F 23 1.68 e separar as informações
/*string[] vet = Console.ReadLine().Split(' ');
string nome = vet[0];
char sexo = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3],CultureInfo.InvariantCulture);
Console.WriteLine(nome);
Console.WriteLine(sexo);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));
*/

//exercicio de fixação:
//entradas de dados:
Console.WriteLine("Entre com seu nome completo:");
string nomeCompleto = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa?");
int quartos = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preço de um produto");
double precoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Entre com seu último nome, idade e altura(mesma linha)");
string[] mesmaLinha = Console.ReadLine().Split(' ');
string ultimoNome = mesmaLinha[0];
int idade = int.Parse(mesmaLinha[1]);
double altura = double.Parse(mesmaLinha[2], CultureInfo.InvariantCulture);

//saidas de dados 
Console.WriteLine(nomeCompleto);
Console.WriteLine(quartos);
Console.WriteLine(precoProduto.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine(ultimoNome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));







