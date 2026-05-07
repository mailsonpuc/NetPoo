namespace Ex004.Models;

public class Frase
{
    private string Palavra { get; }

    public Frase(string palavra)
    {
        Palavra = palavra;
    }
    
    

    public void Verifica()
    {
        Console.WriteLine($"O tipo primitivo desse valor é: {Palavra.GetType()} ");
        Console.WriteLine($"Só tem espaços?  {string.IsNullOrWhiteSpace(Palavra)} ");
        Console.WriteLine($"É um número?  {Palavra.All(char.IsDigit)} ");
        Console.WriteLine($"É alfabético?  {Palavra.All(char.IsLetter)} ");
        
        Console.WriteLine("É alfanumérico? " + Palavra.All(char.IsLetterOrDigit));

        Console.WriteLine("Está em maiúscula? " + (Palavra == Palavra.ToUpper() && Palavra.Any(char.IsLetter)));

        Console.WriteLine("Está em minúscula? " + (Palavra == Palavra.ToLower() && Palavra.Any(char.IsLetter)));

        Console.WriteLine("Está capitalizada? " + 
                          (char.IsUpper(Palavra[0]) && Palavra.Substring(1).All(c => char.IsLower(c))));
    }
    
}