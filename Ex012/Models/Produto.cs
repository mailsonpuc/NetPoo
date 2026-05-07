using System.Globalization;
using Ex012.Interfaces;

namespace Ex012.Models;

public struct Produto : ICalcularDesconto
{
    private double Preco { get; set; }

    
    public Produto(double preco)
    {
        Preco = preco;
    }

    public void Desconto()
    {
        double novoPreco = Preco - (Preco * 5 / 100);
        
        CultureInfo real = new CultureInfo("pt-BR");
        
        Console.WriteLine($"Um produto que custava {Preco.ToString("C", real)}, na promoção de 5% de desconto vai custar {novoPreco.ToString("C",  real)}");
    }
}

//cinco porcento de 1500.    1500 * 5 /100