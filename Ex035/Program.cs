
FormaTriangulo formaTriangulo = new FormaTriangulo(9, 7, 8);
formaTriangulo.CalcularTriangulo();


public class FormaTriangulo
{
    public  double R1 { get; private set; }
    public double R2 { get; private set; }
    public double R3 { get; private set; }

    public FormaTriangulo(double r1, double r2, double r3)
    {
        R1 = r1;
        R2 = r2;
        R3 = r3;
    }


    public void CalcularTriangulo()
    {
        if ((R1 < R2 + R3) && (R2 < R1 + R3) && (R3 < R1 + R2))
        {
            Console.WriteLine("Os segumentos acima PODEM FORMA UM Triangulo");
        }
        else
            Console.WriteLine("Nao os segumentos  acima não pode forma um triangulo");
        
    }
}