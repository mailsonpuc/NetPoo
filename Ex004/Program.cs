
using Ex004.Models;

Console.Write("Digite algo: ");
string myFrase = Console.ReadLine();

Frase p = new Frase(myFrase);
p.Verifica();
