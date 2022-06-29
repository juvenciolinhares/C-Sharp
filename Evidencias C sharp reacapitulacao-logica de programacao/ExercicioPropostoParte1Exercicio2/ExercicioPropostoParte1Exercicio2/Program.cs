// See https://aka.ms/new-console-template for more information
using System.Globalization;
//valor do rario do circulo, mostrat o valor com 4 casas decimais

//fórmula do raio = pi * (raio* raio)
// pi = 3.14159;

double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double pi = 3.14159;

double area = pi * Math.Pow(raio, 2);
Console.WriteLine("A=" + area.ToString("F4",CultureInfo.InvariantCulture));



