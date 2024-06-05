using ConsoleAppIndentationOptions.Models;
using System.Runtime.InteropServices;
using System.Text.Json;


Console.WriteLine("***** Testes com .NET 9 | Indentation options *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

var localidades = new Localidade[]
{
    new () { Id = 1, NomeCidade = "Sao Paulo", NomePais = "Brasil", NomeContinente = "America do Sul" },
    new () { Id = 2, NomeCidade = "Roma", NomePais = "Italia", NomeContinente = "Europa" }
};

var options = new JsonSerializerOptions
{
    WriteIndented = true,
    IndentCharacter = '\t',
    IndentSize = 1
};

Console.WriteLine();
Console.WriteLine("*** Resultados da serializacao ***");
foreach (var localidade in localidades)
{
    Console.WriteLine();
    Console.WriteLine(JsonSerializer.Serialize(localidade, options));
}