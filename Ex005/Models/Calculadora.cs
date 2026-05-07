
namespace Ex005.Models;

public class Calculadora
{
    public int Numero  { get; set; }


    public Calculadora(int numero)
    {
        Numero = numero;
    }


    public void Resultado()
    {
        Console.WriteLine($"O Sucessor: de {Numero} é {Numero + 1} e o antecessor é {Numero -1}");
    }
}