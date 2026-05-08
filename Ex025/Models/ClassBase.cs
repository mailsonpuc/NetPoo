using Ex025.Interface;

namespace Ex025.Models;

public abstract class ClassBase: ITemSilvaNoNome
{
    public string Nome { get; private set; }

    public ClassBase(string nome)
    {
        this.Nome = nome;
    }


    public abstract string NomeTemSilva();
}