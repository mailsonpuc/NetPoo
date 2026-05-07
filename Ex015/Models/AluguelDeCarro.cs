using System.Globalization;
using Ex015.Interfaces;

namespace Ex015.Models;

public struct AluguelDeCarro : Calcular
{
    private int DiasAlugados { get; set; }
    private double KmRodados { get; set; }

    public AluguelDeCarro(int diasAlugados, double kmRodados)
    {
        DiasAlugados = diasAlugados;
        KmRodados = kmRodados;
    }
    
    

    public void Calcular()
    {
        double pago = (DiasAlugados * 60) + (KmRodados * 0.15);
        
        CultureInfo real = new CultureInfo("pt-BR");

        Console.WriteLine($"O total a pagar é de {pago.ToString("C",  real)}");
    }
}