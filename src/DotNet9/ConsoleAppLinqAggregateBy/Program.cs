using ConsoleAppLinqAggregateBy.Models;
using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 9 | Metodo AggregateBy - LINQ *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

var estados = new Estado[]
{
    new("AC", "Acre", "Norte", 881935),
    new("AL", "Alagoas", "Nordeste", 3337357),
    new("AP", "Amapa", "Norte", 845731),
    new("AM", "Amazonas", "Norte", 4144597),
    new("BA", "Bahia", "Nordeste", 14930634),
    new("CE", "Ceara", "Nordeste", 9187103),
    new("DF", "Distrito Federal", "Centro-Oeste", 3015268),
    new("ES", "Espirito Santo", "Sudeste", 4064052),
    new("GO", "Goias", "Centro-Oeste", 7142070),
    new("MA", "Maranhao", "Nordeste", 7075181),
    new("MT", "Mato Grosso", "Centro-Oeste", 3526220),
    new("MS", "Mato Grosso do Sul", "Centro-Oeste", 2809394),
    new("MG", "Minas Gerais", "Sudeste", 21168791),
    new("PA", "Para", "Norte", 8690745),
    new("PB", "Paraiba", "Nordeste", 4039277),
    new("PR", "Parana", "Sul", 11516840),
    new("PE", "Pernambuco", "Nordeste", 9557071),
    new("PI", "Piaui", "Nordeste", 3273227),
    new("RJ", "Rio de Janeiro", "Sudeste", 17366189),
    new("RN", "Rio Grande do Norte", "Nordeste", 3534165),
    new("RS", "Rio Grande do Sul", "Sul", 11422973),
    new("RO", "Rondonia", "Norte", 1796460),
    new("RR", "Roraima", "Norte", 605761),
    new("SC", "Santa Catarina", "Sul", 7252502),
    new("SP", "Sao Paulo", "Sudeste", 46289333),
    new("SE", "Sergipe", "Nordeste", 2318822),
    new("TO", "Tocantins", "Norte", 1590248)
};

Console.WriteLine();
Console.WriteLine("Populacao estimada por regioes brasileiras:");
var populacaoPorRegiao = estados.AggregateBy(
    keySelector: estado => estado.Regiao!,
    seed: 0,
    (totalPopulacao, estado) => totalPopulacao + estado.Populacao
);
foreach (var (regiao, totalPopulacao) in populacaoPorRegiao)
    Console.WriteLine($"    Regiao: {regiao} - Populacao total: {totalPopulacao}");