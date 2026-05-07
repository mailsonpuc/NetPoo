
using Ex009.Models;

Console.WriteLine("Digite um numero");

int numero = Convert.ToInt32(Console.ReadLine());

Tabuada num =  new Tabuada(numero);
num.Exibir();
