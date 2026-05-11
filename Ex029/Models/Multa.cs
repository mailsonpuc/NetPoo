using System.Globalization;

namespace Ex029.Models;

public struct Multa
{
    public double Valocidade { get; private set; }

    public Multa(double valocidade)
    {
        Valocidade = valocidade;
    }
    
    

    public void MultaVelocidade()
    {
        if (Valocidade > 80)
        {
            Console.WriteLine("MULTADO: vocẽ excedeu o limite permitido que é de 80Km/h");
            
            double multa = (Valocidade - 80) * 7;
            
            CultureInfo real =  new CultureInfo("pt-BR");
            
            Console.WriteLine($"Vocẽ deve pagar uma multar de {multa.ToString("C", real)}");
        }
        else
        {
            Console.WriteLine("Tenha um bom dia dirija com segurança.");
        }
        
    }
}