using Ex024.Interfaces;

public class VerificadorDeNome : ITemSantoNome
{
    public string Nome { get; private set; }

    public VerificadorDeNome(string nome)
    {
        Nome = nome;
    }


    public string TemSanto()
    {
        if (Nome.ToUpper().Contains("SANTO"))
        {
            return $"Sim, o nome '{Nome}' contém 'Santo'.";
        }
        return $"Não, o nome '{Nome}' não contém 'Santo'.";
        
    }
}