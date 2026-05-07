namespace Ex022.Models;

public class Analize: ClassBase
{
    public Analize(string nomeCompleto) : base(nomeCompleto)
    {
    }

    public override void NomeAnaliza()
    {
        Console.WriteLine($"Analizando seu nome...");
        Thread.Sleep(20000);
        
        Console.WriteLine($"Seu nome em maiúsculas é {NomeCompleto.ToUpper()}");
        Console.WriteLine($"Seu nome em minúsculas é {NomeCompleto.ToLower()}");
        Console.WriteLine($"Seu nome tem ao todo {NomeCompleto.Length - NomeCompleto.Count(' ')} letras");
        
        var separa = NomeCompleto.Split();
        
        Console.WriteLine($"Seu primero nome é {separa[0]} e ele tem {separa[0].Length} letras ");
    }
}