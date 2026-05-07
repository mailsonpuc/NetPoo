using System.Globalization;

namespace Ex010;

public struct Dinheiro
{
    private double Carteira { get; }


    public Dinheiro(double carteira)
    {
        Carteira = carteira;
    }
    
    
    
    public void CalcularCarteira()
    {
        double dolarAtual = Carteira / 4.93;
        
        CultureInfo simboloReal =  new CultureInfo("pt-BR");
        CultureInfo simboloDolar = new CultureInfo("en-US");

        Console.WriteLine($"Com {Carteira.ToString("C", simboloReal)} voce pode comprar {dolarAtual.ToString("C", simboloDolar)}.");
    }
    
    
    
}