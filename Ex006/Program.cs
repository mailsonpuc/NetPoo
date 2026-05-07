using Ex006.Models;

Console.WriteLine("Digite um número:");

int numero;
while (!int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Entrada inválida. Digite um número inteiro:");
}

Calculadora calc = new Calculadora(numero);

Console.WriteLine($"Número informado: {calc.Calcular()}");
Console.WriteLine($"Dobro: {calc.Dobro(numero)}");
Console.WriteLine($"Triplo: {calc.Triplo(numero)}");
Console.WriteLine($"Raiz quadrada: {calc.Raiz(numero):F2}");