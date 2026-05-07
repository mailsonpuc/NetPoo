namespace Ex008.Models;

public class MediaAritmetica
{
    private double DistanciaEmMetro { get; set; }

    public MediaAritmetica(double distanciaEmMetro)
    {
        DistanciaEmMetro = distanciaEmMetro;
    }
    
    
    
    public void Calcular()
    {
        double cm = DistanciaEmMetro * 100;
        double mm = DistanciaEmMetro * 1000;

        Console.WriteLine($"A média de {DistanciaEmMetro}m corresponde a {cm}cm e {mm}mm");
    }
}