using ConsoleAppLinqCountBy.Models;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 9 | Metodo CountBy - LINQ *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

var localidades = new Localidade[]
{
    new Localidade { NomeCidade = "Belo Horizonte", SiglaEstado = "MG" },
    new Localidade { NomeCidade = "Campinas", SiglaEstado = "SP" },
    new Localidade { NomeCidade = "Feira de Santana", SiglaEstado = "BA" },
    new Localidade { NomeCidade = "Juiz de Fora", SiglaEstado = "MG" },
    new Localidade { NomeCidade = "Niterói", SiglaEstado = "RJ" },
    new Localidade { NomeCidade = "Ouro Preto", SiglaEstado = "MG" },
    new Localidade { NomeCidade = "Porto Alegre", SiglaEstado = "RS" },
    new Localidade { NomeCidade = "Ribeirão Preto", SiglaEstado = "SP" },
    new Localidade { NomeCidade = "Rio de Janeiro", SiglaEstado = "RJ" },
    new Localidade { NomeCidade = "Salvador", SiglaEstado = "BA" },
    new Localidade { NomeCidade = "Santos", SiglaEstado = "SP" },
    new Localidade { NomeCidade = "São Paulo", SiglaEstado = "SP" },
    new Localidade { NomeCidade = "Uberlândia", SiglaEstado = "MG" },
    new Localidade { NomeCidade = "Belém", SiglaEstado = "PA" }
};
Console.WriteLine();
Console.WriteLine("Algumas cidades brasileiras:");
foreach (var localidade in localidades)
    Console.WriteLine($"    {localidade.NomeCidade}-{localidade.SiglaEstado}");

IEnumerable<KeyValuePair<string, int>> contagemLocalidades =
    localidades.Select(estado => estado.SiglaEstado!)
        .CountBy(siglaEstado => siglaEstado);
Console.WriteLine();
Console.WriteLine("Quantidade de cidades encontradas por estado:");
foreach (var estado in contagemLocalidades)
    Console.WriteLine($"    {estado.Key} = {estado.Value}");