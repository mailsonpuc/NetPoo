using Ex031.Interfaces;

namespace Ex031.Models;

public struct Distancia: ICalcularDistancia
{
    public double DistanciaPercorrida { get; private set; }

    public Distancia(double distanciaPercorrida)
    {
        DistanciaPercorrida = distanciaPercorrida;
    }


    public double Calcular(double preco)
    {
        
        if (DistanciaPercorrida <= 200)
        {
           return preco = DistanciaPercorrida * 0.50; 
        }

        else
        {
            return preco = DistanciaPercorrida * 0.45;
        }

       
    }
}