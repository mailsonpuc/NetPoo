using Ex018.Interfaces;

namespace Ex018.Models;

public abstract class Base : IFiguraGeometrica
{
    public double Angulo { get; protected set; }

    public Base(double angulo)
    {
        Angulo = angulo;
    }
    
    
    
    public abstract void Calcular();
}