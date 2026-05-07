using EX019.Interfaces;

namespace EX019.Models;

public abstract class Base : ISorteiaAluno
{
    public string Aluno1  { get; private set; }
    public string Aluno2  { get; private set; }
    public string Aluno3  { get; private set; }
    public string Aluno4  { get; private set; }

    public Base(string aluno1, string aluno2, string aluno3, string aluno4)
    {
        Aluno1 = aluno1;
        Aluno2 = aluno2;
        Aluno3 = aluno3;
        Aluno4 = aluno4;
    }


    public abstract void SorteiaAluno();

}
    
    
