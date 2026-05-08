using Ex025.Interface;
using Ex025.Models;

ITemSilvaNoNome verificador = new VerificarNomeUsuario("Maria da Silva Santos");

Console.WriteLine(verificador.NomeTemSilva());