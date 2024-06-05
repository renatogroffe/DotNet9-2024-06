namespace ConsoleAppLinqAggregateBy.Models;

public class Estado(string sigla, string nome, string regiao, int populacao)
{
    public string? Sigla => sigla;
    public string? Nome => nome;
    public string? Regiao => regiao;
    public int Populacao => populacao;
}