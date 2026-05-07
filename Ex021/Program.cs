using System.Diagnostics;

string arquivo = "/home/mailson/RiderProject/Ex001/Ex021/Audio/YTDown_YouTube_Dance_Commerciale_Anni_90_a_TOP_DJ_MATTW_Media_dGomIu7zEQg.m4a";

Console.WriteLine("Iniciando reprodução...");

//  ffplay com flags para não abrir janela (-nodisp) e fechar ao terminar (-autoexit)
var psi = new ProcessStartInfo
{
    FileName = "ffplay",
    Arguments = $"-nodisp -autoexit -loglevel quiet \"{arquivo}\"",
    UseShellExecute = false,
    CreateNoWindow = true
};

using var processo = Process.Start(psi);

Console.WriteLine("Tocando... Pressione ENTER para parar.");
Console.ReadLine();

if (processo != null && !processo.HasExited)
{
    processo.Kill();
}