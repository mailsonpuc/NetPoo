

using Ex001.Models;

Console.WriteLine("Digite seu nome:");
string? nome = Console.ReadLine();

Pessoa p1 = new Pessoa(nome);
p1.Apresentar();
