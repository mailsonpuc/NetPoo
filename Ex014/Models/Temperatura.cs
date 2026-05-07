using Ex014.Models.Interfaces;

namespace Ex014.Models;

public class Temperatura: ICalcularTemperatura
{
    private double TemperaturaEmC { get; set; }


    public Temperatura(double temperaturaEmC)
    {
        TemperaturaEmC = temperaturaEmC;
    }
    
    

    public void CalcularTemperatura()
    {
        double f = (( 9 * TemperaturaEmC) / 5) + 32;

        Console.WriteLine($"A temperatura de {TemperaturaEmC}°C corresponde a {f:N1}°F");
    }
}