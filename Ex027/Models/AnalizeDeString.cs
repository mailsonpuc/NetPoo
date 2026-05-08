namespace Ex027.Models;

public class AnalizeDeString
{
    public string Nome { get; private set; }

    public AnalizeDeString(string nome)
    {
        Nome = nome.Trim();
    }

    public void Analizer()
    {
        string[] separar = Nome.Split(' ');

        Console.WriteLine($"Muito prazer em te conhecer!");
        
 
        Console.WriteLine($"Seu primeiro nome é: {separar[0]}");

        // posição do array usando ^1 (índice reverso do C#) 
        // ou separar[separar.Length - 1]
        Console.WriteLine($"Seu último nome é: {separar[^1]}");
    }
}