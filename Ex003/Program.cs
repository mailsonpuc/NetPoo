
using Ex003.Models;

Console.WriteLine("Digite o primeiro valor");
int valor1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite o segundo valor");
int valor2 = Convert.ToInt16(Console.ReadLine());


Calculadora calc1 = new Calculadora(valor1, valor2);
Console.WriteLine($"A soma entre {valor1} e {valor2} = {calc1.Soma(valor1, valor2)}");


