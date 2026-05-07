

using Ex018.Enum;

namespace Ex018.Models;

public class SenoCossenoTangente : Base
{
    public SenoCossenoTangente(double angulo) : base(angulo)
    {
    }

 

    public override void Calcular()
    {
        // Conversão de Graus para Radianos: (angulo * PI / 180)
        double radiano = Angulo * Math.PI / 180;
        
        double seno = Math.Sin(radiano);
        double cosseno = Math.Cos(radiano);
        double tangente = Math.Tan(radiano);

        Console.WriteLine($"--- Resultados para o Ângulo {Angulo}° ---");
        Console.WriteLine($"{AnguloEnum.SENO}:     {seno:F2}");
        Console.WriteLine($"{AnguloEnum.COSSENO}:  {cosseno:F2}");
        Console.WriteLine($"{AnguloEnum.TANGENTE}: {tangente:F2}");
    }
}