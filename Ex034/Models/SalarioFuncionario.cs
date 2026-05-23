using System.Globalization;
using Ex034.Interfaces;

namespace Ex034.Models;

public struct SalarioFuncionario: ISalario
{
    public double Salario { get; private set; }

    public SalarioFuncionario(double salario)
    {
        Salario = salario;
    }
    
    

    public void CalcularSalario()
    {
        double novo = 0;

        if (Salario <= 1250)
            novo = Salario + (Salario * 15 / 100); 
        
        else 
            novo = Salario + (Salario * 10  / 100);

        CultureInfo real =  new CultureInfo("pt-BR");
        
        Console.WriteLine($"Quem ganhava {Salario.ToString("C", real)} passa a ganhar {novo.ToString("C", real)} agora");
        
    }
}