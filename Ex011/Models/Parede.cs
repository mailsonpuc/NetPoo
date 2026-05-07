namespace Ex011.Models;

public struct Parede
{
    private double Largura { get; set; }
    private double Altura { get; set; }


    public Parede(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }
    
    
    public void CalcularArea()
    {
        double area = (Largura * Altura);
        double tinta = area / 2;

        Console.WriteLine($"Sua parede tem a dimensão de {Largura}x{Altura} e sua área é de {area}m²");
        Console.WriteLine($"Para pintar essa parede voce precisará de {tinta} litros de tintas.");
    }
}