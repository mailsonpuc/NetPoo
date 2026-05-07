namespace Ex001.Models;

public class Pessoa
{
    public string Nome { get; set; } =  string.Empty;


    public Pessoa(string nome)
    {
        Nome = nome;
    }
    

    public virtual void Apresentar()
    {
        Console.WriteLine($"È um prazer te conhecer {Nome.ToUpper()}!");
    }
}