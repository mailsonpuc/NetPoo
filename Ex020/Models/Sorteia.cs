using Ex020.Interfaces;

namespace Ex020.Models;

public class Sorteia: Base
{
    public Sorteia(string aluno1, string aluno2, string aluno3, string aluno4) : base(aluno1, aluno2, aluno3, aluno4)
    {
    }

    
    public override void SorteiaPessoa()
    {
        List<string> nomesList = new List<string>
        {
            Aluno1, Aluno2, Aluno3, Aluno4
        };
        
        
        var listaEmbaralhada = nomesList.OrderBy(x => Random.Shared.Next()).ToList();

      
        Console.WriteLine("A ordem de apresentação será:");
        
        Console.WriteLine(string.Join(", ", listaEmbaralhada));
    }
    
    
}