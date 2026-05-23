namespace Ex033.Models;

public class VerificarManorMaior
{
    private  int Num1 { get;  set; }
    private  int Num2 { get; set; }
    private int Num3 { get;  set; }



    public VerificarManorMaior(int num1, int num2, int num3)
    {
        Num1 = num1;
        Num2 = num2;
        Num3 = num3;
    }
    
    
    public void VerificarManor()
    {
        int menor = Num1; 
        
        if (Num2 < menor) 
            menor = Num2;

        if (Num3 < menor) 
            menor = Num3;
        
        Console.WriteLine($"O MENOR valor digitado foi: {menor}");
    }
    

    public void VerificarMaior()
    {
        int maior = Num1;
        
        if (Num2 > maior) 
            maior = Num2;

        if (Num3 > maior) 
            maior = Num3;
        
        Console.WriteLine($"O MAIOR valor digitado foi: {maior}");
    }
    
}