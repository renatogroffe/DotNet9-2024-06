using ConsoleAppDefaultWebOptions.Models;
using System.Runtime.InteropServices;
using System.Text.Json;


Console.WriteLine("***** Testes com .NET 9 | Serializacao com Default web options *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

var localidades = new Localidade[]
{
    new () { Id = 1, NomeCidade = "Sao Paulo", NomePais = "Brasil", NomeContinente = "America do Sul" },
    new () { Id = 2, NomeCidade = "Roma", NomePais = "Italia", NomeContinente = "Europa" }
};

Console.WriteLine();
Console.WriteLine("*** Resultados da serializacao ***");
foreach (var localidade in localidades)
{
    Console.WriteLine();
    Console.WriteLine(JsonSerializer.Serialize(localidade, JsonSerializerOptions.Web));
}