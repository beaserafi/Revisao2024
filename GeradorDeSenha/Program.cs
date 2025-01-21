// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Collections.Generic;

Console.Write ("Qual o tamanho da senha desejada?");
 if (!int.TryParse (Console.ReadLine(),out int tamanho))
 {

 }
Console.WriteLine ("vai conter simbolos? (sim) (não)");
string afirmacao1 =Console.ReadLine().ToLower();
if (afirmacao1 != "sim" && afirmacao1 != "não" && afirmacao1 != "nao")
{

}
Console.WriteLine ("vai conter letras? (sim) (não)");
string afirmacao2 =Console.ReadLine().ToLower();
if (afirmacao2 != "sim" && afirmacao2 != "não" && afirmacao2 != "nao")
{

}

char[] vagner = new char[10] {'1','2','3','4','5','6','7','8','9','0'};
char[] cleber = new char[26] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
char[] claudio = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
char[] roberto = new char[30] {'!', '"', '#', '$', '%', '&' , '(', ')', '*', '+', ',', '-', '.', '/',
    ':', ';', '<', '=', '>', '?', '@', '[', ']', '^', '_', '`', '{', '|', '}', '~'};

Random joana = new Random ();

List<char> senha =new List<char>{};

for(int i=0; i==tamanho;i++)
{
    int charles=joana.Next(4);
    switch (charles){
        case 0:

        break;

        case 1:

        break;

        case 2:

        break;

        case 3:

        break;
    }
}