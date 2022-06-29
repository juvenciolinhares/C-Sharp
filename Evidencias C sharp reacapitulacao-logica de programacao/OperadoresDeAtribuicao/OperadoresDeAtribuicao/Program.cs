// See https://aka.ms/new-console-template for more information

int a = 10;

a += 2;
Console.WriteLine(a);

a *= 3;
Console.WriteLine(a);

//concatenação de strings
string s = "abc";
Console.WriteLine(s);
s += "def";
Console.WriteLine(s);

//operadores ++ e --:
int aa = 10;
aa++;
Console.WriteLine(aa);
aa--;
Console.WriteLine(aa);

int b = aa++;//primeiro ele joga o valor de a, depois incrementa
Console.WriteLine(aa);
Console.WriteLine(b);//=10
b = ++aa;
Console.WriteLine(b);// primeiro incrementa, depois atribui o resultado a b
