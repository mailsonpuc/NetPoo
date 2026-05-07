namespace EX019.Models;

public class Sorteio : Base
{
    public Sorteio(string aluno1, string aluno2, string aluno3, string aluno4) : base(aluno1, aluno2, aluno3, aluno4)
    {
    }

    
    public override void SorteiaAluno()
    {
        List<string> alunosList = new List<string>()
        {
            Aluno1,
            Aluno2,
            Aluno3,
        };
        
        
        Random gerador = new Random();
        int indiceSorteado = gerador.Next(alunosList.Count);
        string escolhido = alunosList[indiceSorteado];
        
        Console.WriteLine($"O aluno escolhido foi: {escolhido}");
    }
    
    
}