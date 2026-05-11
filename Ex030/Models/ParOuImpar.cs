namespace Ex030.Models;

public struct ParOuImpar
{
    public int Numero { get; private set; }

    public ParOuImpar(int numero)
    {
        Numero = numero;
    }

    public void Verificar()
    {
        if (Numero % 2 == 0)
        {
            Console.WriteLine($"O número: {Numero} é PAR");
        }
        else
            Console.WriteLine($"O Número {Numero} é IMPAR");
    }
}