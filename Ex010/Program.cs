
using Ex010;


while (true)
{
    Console.WriteLine("Quanto dinheiro voce tem na carteira?");

    double carteira = double.Parse(Console.ReadLine());

    Dinheiro cartaira1 = new Dinheiro(carteira);
    cartaira1.CalcularCarteira();

    Console.WriteLine("Continuar? [s/n]: ");
    string? resposta = Console.ReadLine().ToUpper();
    
    if (resposta?.ToUpper() == "S")
    {
        Console.Clear();
        continue;
    }

    else
    {
        break;
    }
    
    
}
