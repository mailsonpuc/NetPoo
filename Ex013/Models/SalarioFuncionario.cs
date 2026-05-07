using System.Globalization;
using Ex013.Models.Interfaces;

namespace Ex013.Models;

public struct SalarioFuncionario: ICalcularDesconto
{
    private double Salario { get; set; }


    public SalarioFuncionario(double Salario)
    {
        this.Salario = Salario;
    }
    
    
    public void Desconto()
    {
        double novoSalario = Salario + (Salario * 15 / 100);
        CultureInfo real =  new CultureInfo("pt-BR");
        
        Console.WriteLine($"Um funcionario que ganhava {Salario.ToString("C", real)}, com 15% de aumento, passa a receber {novoSalario.ToString("C",  real)}");
    }
}



//cinco porcento de 1500.    1500 * 5 /100