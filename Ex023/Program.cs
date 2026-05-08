
using System.ComponentModel;
using Ex023.Models;

Console.WriteLine("Digite um numero");
int numero = Convert.ToInt32(Console.ReadLine());

int unidade =  numero    / 1 % 10;
int dezena  =  numero   / 10 % 10;
int centena =  numero  / 100 % 10;
int milhar  =  numero / 1000 % 10;

Console.WriteLine($"Analizando o numero {numero}");



Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Unidade: {unidade}");
Console.WriteLine($"Dezena: {dezena}");
Console.WriteLine($"Centena: {centena}");
Console.WriteLine($"Milhar: {milhar}");
Console.ResetColor();

