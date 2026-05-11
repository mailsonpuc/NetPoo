using System.Globalization;
using Ex031.Interfaces;
using Ex031.Models;

double kmViagem = 1000;

ICalcularDistancia distanciaDaViagem = new Distancia(kmViagem);


Console.WriteLine($"Voce está prestes a começar uma viagem de  {kmViagem}Km");

CultureInfo real = CultureInfo.GetCultureInfo("pt-BR");

Console.WriteLine($"E o preço da sua passagem será de: {distanciaDaViagem.Calcular(1000).ToString("C", real) }" );