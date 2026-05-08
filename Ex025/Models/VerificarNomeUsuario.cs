namespace Ex025.Models;

public class VerificarNomeUsuario: ClassBase
{
    public VerificarNomeUsuario(string nome) : base(nome)
    {
    }


    public override string NomeTemSilva()
    {
        if (Nome.ToUpper().Contains("SILVA"))
        {
            return ("Tem Silva no nome");
        }

        else
        {
            return ("Não Tem Silva no nome");
        }
    }
}