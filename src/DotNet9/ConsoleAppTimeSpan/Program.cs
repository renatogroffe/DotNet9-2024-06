using System.Runtime.InteropServices;
using System.Text.Json;

Console.WriteLine("***** Testes com .NET 9 | Sobrecarga metodo FromSeconds - TimeSpan *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

string[] amostrasTempo = ["71.715", "71.716", "71.829", "71.830", "71.832"];
foreach (var amostra in amostrasTempo)
{
    Console.WriteLine();
    var valorAmostra = JsonSerializer.Deserialize<double>(amostra);
    Console.WriteLine($"Tempo em segundos = {amostra}");
    Console.WriteLine($"Tempo em segundos (double) = {valorAmostra}");
    TimeSpan amostraTimeSpan;
    amostraTimeSpan = TimeSpan.FromSeconds(value: valorAmostra);
    Console.WriteLine($"Tempo em segundos (TimeSpan) = {amostraTimeSpan} | TimeSpan.FromSeconds(value)");
    
    var partesAmostra = amostra.Split('.');
    var amostraSegundos = long.Parse(partesAmostra[0]);
    Console.WriteLine($"Segundos (long) = {amostraSegundos}");
    var amostraMilissegundos = long.Parse(partesAmostra[1]);
    Console.WriteLine($"Milissegundos (long) = {amostraMilissegundos}");
    amostraTimeSpan = TimeSpan.FromSeconds(
        seconds: amostraSegundos, milliseconds: amostraMilissegundos);
    Console.WriteLine(
        $"Tempo em segundos (TimeSpan) = {amostraTimeSpan} | TimeSpan.FromSeconds(seconds, milliseconds)");
}