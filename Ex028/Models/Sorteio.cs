using Ex028.Interfaces;

namespace Ex028.Models;

public class Sorteio: ISorteioNumero
{
    public  int NumeroPersoun { get; private set; }

    public Sorteio(int numeroPersoun)
    {
        NumeroPersoun = numeroPersoun;
    }
    
    
    public void Sortear()
    {
        Random random = new();
        int computador = random.Next(0, 5);
        if (computador == NumeroPersoun)
        {
            Console.WriteLine($"Acertou eu pensei no {computador} e voce no {NumeroPersoun}!");
        }
        
        else
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"Errou eu pensei no numero {computador} e não no {NumeroPersoun}");
            Console.ResetColor();
        }
       
        
        
    }
}