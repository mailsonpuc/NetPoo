namespace Ex007.Models;

public class Aluno
{
    private double Nota1 { get; set; }
    private double Nota2 { get; set; }


    public Aluno(double nota1, double nota2)
    {
        Nota1 = nota1;
        Nota2 = nota2;
    }
    
    
    
    public void Validar()
    {
        double media  = (Nota1 + Nota2) / 2;
        Console.WriteLine($"A media entre {Nota1} e {Nota2} e igual a {media}");
    }
    
    
}