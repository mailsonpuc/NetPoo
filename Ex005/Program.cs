using Ex005.Models;

Console.WriteLine("Digite um numero");
int numero = Convert.ToInt32(Console.ReadLine());

Calculadora num = new Calculadora(numero);
num.Resultado();