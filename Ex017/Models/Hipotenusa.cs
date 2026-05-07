namespace Ex017.Models;

public class Hipotenusa: Triangulo
{

    public Hipotenusa(double saldo, double altura): base(saldo, altura)
    {
    }
    
    public override void Calcular()
    {
        double hipotenusa = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));

        Console.WriteLine("--- Cálculo de Triângulo Retângulo ---");
        Console.WriteLine($"Cateto Oposto: {Base}");
        Console.WriteLine($"Cateto Adjacente: {Altura}");
        Console.WriteLine($"Resultado da Hipotenusa: {hipotenusa:F2}");
        Console.WriteLine("--------------------------------------");
    }
}