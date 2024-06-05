using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text;

Console.WriteLine("***** Testes com .NET 9 | CryptographicOperations.HashData API *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

var content = Encoding.ASCII.GetBytes("Testes com .NET 9");

Console.WriteLine();
Console.WriteLine("*** Versoes one-shot usando tipos que representam algoritmos ***");
Console.WriteLine("SHA256.HashData() = " +
    JsonSerializer.Serialize(SHA256.HashData(content)));
Console.WriteLine("SHA384.HashData() = " +
    JsonSerializer.Serialize(SHA384.HashData(content)));
Console.WriteLine("SHA512.HashData() = " +
    JsonSerializer.Serialize(SHA512.HashData(content)));
Console.WriteLine("MD5.HashData() = " +
    JsonSerializer.Serialize(MD5.HashData(content)));

Console.WriteLine();
Console.WriteLine("*** Testes com CryptographicOperations.HashData() ***");
Console.WriteLine("HashAlgorithmName.SHA256 = " +
    JsonSerializer.Serialize(CryptographicOperations.HashData(HashAlgorithmName.SHA256, content)));
Console.WriteLine("HashAlgorithmName.SHA384 = " +
    JsonSerializer.Serialize(CryptographicOperations.HashData(HashAlgorithmName.SHA384, content)));
Console.WriteLine("HashAlgorithmName.SHA512 = " +
    JsonSerializer.Serialize(CryptographicOperations.HashData(HashAlgorithmName.SHA512, content)));
Console.WriteLine("HashAlgorithmName.MD5 = " +
    JsonSerializer.Serialize(CryptographicOperations.HashData(HashAlgorithmName.MD5, content)));