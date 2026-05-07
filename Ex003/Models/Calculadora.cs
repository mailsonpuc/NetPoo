using Ex003.Models.Interfaces;

namespace Ex003.Models;

public class Calculadora : ICalculadora
{
    private  int Num1 { get; }
    private int Num2 { get; }


    public Calculadora(int num1, int num2)
    {
        Num1 = num1;
        Num2 = num2;
    }
    
    
    
  public int Soma(int num1, int num2)
  {
      return Num1 + Num2;
  }
    
    
}