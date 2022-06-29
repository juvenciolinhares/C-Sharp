// See https://aka.ms/new-console-template for more information

//precedencia: () > * e/ > +/-
int n1 = 3 + 4 * 2;
Console.WriteLine(n1);
int n2 = (3 + 4) * 2;
Console.WriteLine(n2);

//resto da divisão
int n3 = 17 % 3;
Console.WriteLine(n3);

//divisão de numero double:

// double n4 = 10 / 8; o compliador não entende como double, o resultaldo vai ser um int
double n4 = 10.0 / 8.0; //agora o compilador entende como double
Console.WriteLine(n4);

//calcular fórmula de baskara:
double a = 1.0, b = -3.0, c = -4.0;
double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);//parenteses no começo e fechando depois do delta(precedencia)
double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
Console.WriteLine(delta);
Console.WriteLine(x1);
Console.WriteLine(x2);
