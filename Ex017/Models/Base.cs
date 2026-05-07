using Ex017.Interfaces;

namespace Ex017.Models;

public abstract class Triangulo: IFiguraGeometrica
{
    public double Base { get; protected set; }
    public double Altura { get; protected set; }

    public Triangulo(double base_, double altura_)
    {
        Base = base_;
        Altura = altura_;
    }
    
    
    public abstract void Calcular(); // Cada triângulo calcula de um jeito
    
}