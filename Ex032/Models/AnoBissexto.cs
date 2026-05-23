namespace Ex032.Models;

public struct AnoBissexto
{
    public int Ano { get; private set; }

    public AnoBissexto(int ano)
    {
        Ano = ano;
    }

    public void AnalisarAnoBissexto()
    {
        if ((Ano % 4 == 0 && Ano % 100 != 0) || (Ano % 400 == 0))
        {
            Console.WriteLine($"{Ano} é um ano bissexto.");
        }
        else
        {
            Console.WriteLine($"{Ano} não é um ano bissexto.");
        }
    }
}