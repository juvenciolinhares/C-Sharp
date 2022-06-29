// See https://aka.ms/new-console-template for more information

//criar uma variável sbyte:

SByte x = 100; //tipo do .net
//sbyte x = 100; // tipo do c#(pre-definido)

Console.WriteLine(x);

//boolean
bool completo = false;
Console.WriteLine(completo);

//char
char genero = 'F';
Console.WriteLine(genero);

//tambem posso colocar o código unicode:
char letra = '\u0041';
Console.WriteLine(letra); //A maiúsculo

//float
float n5 = 4.5f;// o f no final indica que é float, se nao tiver é double
Console.WriteLine(n5);

double n6 = 4.5;
Console.WriteLine(n6);

//string
//o string é uma cadeia de caracteres unicode e é imutável, está no tipo referencia e nao no tipo primitivo
string nome = "Maria Green";
Console.WriteLine(nome);

//object: objeto genérico, toda classe é subclasse de object(no exemplo uso object para string e double)
object obj1 = "Alex Brown";
object obj2 = 4.5;
Console.WriteLine(obj1);
Console.WriteLine(obj2);    


//byte
byte n1 = 126;

//byte nao aceita numero negativo: byte n1 = -1;(a faixa de valores dele é de 0 a 255)
Console.WriteLine(n1);

byte n2 = 255;
n2++; 
Console.WriteLine(n2);// o resultado vai ser 0 por que retorna para o limite oposto

//inteiros:
int n3 = 2147483647;// valor máximo aceito
Console.WriteLine(n3);

//long:
long n4 = 2147483648L; //o L inidca que estou trabalhando com Long
Console.WriteLine(n4);

//valores minimos e máximos:
int n7 = int.MinValue;
Console.WriteLine(n7);//imprime o valor minimo de int
int n8 = int.MaxValue;
Console.WriteLine(n8);// imprime o valor maximo

sbyte n9 = sbyte.MinValue;
Console.WriteLine(n9);

decimal n10 = decimal.MaxValue;
Console.WriteLine(n10);
