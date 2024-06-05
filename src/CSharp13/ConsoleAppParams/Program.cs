using System.Runtime.InteropServices;

Console.WriteLine("***** Testes com .NET 9 + C# 13 | params collections *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");
Console.WriteLine();

ProcessWords("Mais", "uma", "live", "no", "Canal", ".NET");

ProcessWords(["Dessa", "vez", "com", "o", "Tio", "do", "C#", "e", "o", "Tio", "do", "Container"]);

string[] group3 = ["Vamos", "aprender", "mais", "sobre", "C#"];
ProcessWords(group3);

List<string> group4 = ["E", "ainda", "tem", "muito", "mais", "por", "vir"];
ProcessWords(group4);

static void ProcessWords(params IEnumerable<string> words)
{
    Console.WriteLine($"Tipo encontrado = {words.GetType().FullName}");
    Console.WriteLine($"Numero de palavras = {words.Count()}");
    Console.Write("Concatenacao = ");
    foreach (var word in words)
        Console.Write(word + " ");
    Console.WriteLine();
    Console.WriteLine();
}