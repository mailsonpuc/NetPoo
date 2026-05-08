namespace Ex026.Models;

public class Nome
{
    public string Frase { get; private set; }
    
    public Nome(string frase)
    {
        Frase = frase.ToUpper();
    }

    public void VerificarFrase()
    {
        Console.WriteLine($"A letra A aparece {Frase.Count('A')} vezes na frase");
        Console.WriteLine($"A primeira letra A apareceu na posiçao {Frase.IndexOf('A')} ");
        Console.WriteLine($"A última letra A apareceu na posição {Frase.LastIndexOf('A')}");
    }
}