using Ex032.Models;

Console.Write("Que ano vocÊ quer analizar?: Coloque 0 para analizar o ano atual ");

if (int.TryParse(Console.ReadLine(), out int anoDigitado))
{
    if (anoDigitado == 0)
    {
        anoDigitado = DateTime.Now.Year;
    }
    
    AnoBissexto ano = new AnoBissexto(anoDigitado);
    ano.AnalisarAnoBissexto();
}
else
{
    Console.WriteLine("Por favor, insira um ano válido.");
}
