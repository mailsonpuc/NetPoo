namespace Ex009.Models;

public struct Tabuada
{
    public int Numero { get; set; }

    public Tabuada(int num)
    {
        Numero = num;
    }
    
    
    
    public void Exibir()
    {
        Console.WriteLine($"Tabuada do numero: {Numero}");
        for (int num = 1; num <= 10; num++)
        {
            Console.WriteLine($"{num} X {Numero} = {num * Numero}");
        }
    }
    
}