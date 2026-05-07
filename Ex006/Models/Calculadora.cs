namespace Ex006.Models;

public class Calculadora : ICalculo

{
    private int Numero { get; set; }

    public Calculadora(int numero)
    {
        Numero = numero;
    }
    
    public int Calcular()
    {
        return Numero;
    }


    public int Dobro(int numero)
    {
        return numero * 2;
    }

    public int Triplo(int numero)
    {
        return numero * 3;
    }

    public double Raiz(int numero)
    {
        return Math.Sqrt(numero);
    }
    
    
}