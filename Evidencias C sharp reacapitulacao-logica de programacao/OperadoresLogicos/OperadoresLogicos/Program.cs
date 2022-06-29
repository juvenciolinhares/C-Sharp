// See https://aka.ms/new-console-template for more information

//operadores lógicos:
/* OBSERVAÇÕES:
 * precedencias: ! > && > ||
 * pode usar parentses a vontade
 */


//&&(e): duas condições verdadeiras
bool c1 =  2> 3 && 4 != 5;
Console.WriteLine(c1);// false

//||(ou): pelo menos uma verdadeira:
bool c2 = 2> 3 || 4 != 5;
Console.WriteLine(c2);

// ! (nao): 
bool c3 = !(2> 3) && 4 != 5;// nega o conteúdo dos parenteses
Console.WriteLine(c3);//true
Console.WriteLine("-----------------");

//precedencia:
bool c4 = 10 > 5;
bool c5 = c1 || c3 && c4;//&& maior(c3 && c4 vai ser resolvido primeiro) que ||
Console.WriteLine(c5);//true
/* c4: true e c3 true
 * c1: false
 */




