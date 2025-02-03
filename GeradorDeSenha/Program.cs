// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Formats.Asn1;

string caminhoArquivo = "senha.txt";
using (StreamWriter writer = new StreamWriter(caminhoArquivo))
{
        
Console.Clear();
inicio:
Console.Write ("Qual o tamanho da senha desejada?");
 if (!int.TryParse(Console.ReadLine(), out int tamanho) || tamanho <= 4)
 {
    
    
        Console.WriteLine("Tamanho inválido, digite um número maior que 4");
        goto inicio;
    
 }
 segundo:
Console.WriteLine ("vai conter simbolos? (sim) (não)");
string afirmacao1 =Console.ReadLine().ToLower();
{
    if (afirmacao1 != "sim" && afirmacao1 != "não" && afirmacao1 != "nao")
    {
        Console.WriteLine("Resposta inválida");
        goto segundo;
    }
}
terceiro:
Console.WriteLine ("vai conter letras? (sim) (não)");
string afirmacao2 =Console.ReadLine().ToLower();
if (afirmacao2 != "sim" && afirmacao2 != "não" && afirmacao2 != "nao")
{
    if (afirmacao2 != "sim" && afirmacao2 != "não" && afirmacao2 != "nao")
    {
        Console.WriteLine("Resposta inválida");
        goto terceiro;
    }
}

char[] vagner = new char[10] {'1','2','3','4','5','6','7','8','9','0'};
char[] cleber = new char[26] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
char[] claudio = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
char[] roberto = new char[30] {'!', '"', '#', '$', '%', '&' , '(', ')', '*', '+', ',', '-', '.', '/',
    ':', ';', '<', '=', '>', '?', '@', '[', ']', '^', '_', '`', '{', '|', '}', '~'};

Random joana = new Random ();

List<char> senha =new List<char>{};

for(int i=0; i<=tamanho-1;i++)
{
    int charles=joana.Next(4);
    switch (charles){
        case 0:
        senha.Add(vagner[joana.Next(vagner.Length)]);
        break;

        case 1:
        if (afirmacao2 == "sim")
        {
            senha.Add(cleber[joana.Next(cleber.Length)]);
        }
        else
        {
            i--;
        }   
        break;

        case 2:
        if (afirmacao2 == "sim")
        {
            senha.Add(claudio[joana.Next(claudio.Length)]);
        }
        else
        {
            i--;
        }
        break;

        case 3:
        if (afirmacao1 == "sim")
        {
            senha.Add(roberto[joana.Next(roberto.Length)]);
        }
        else
        {
            i--;
        }
        break;
    }
}
writer.Write("Sua senha é: ");
Console.Write("Sua senha é: ");
foreach( char item in senha)
{
    Console.Write(item);
    writer.Write(item);
}
}
        