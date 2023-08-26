using System;
using System.Xml.Linq;

public class Program
{
    private static Dictionary<string, string[]> _grafo = new Dictionary<string, string[]>();
    private static void Main(string[] args)
    {
        _grafo.Add("voce", new[] { "alice", "bob", "claire" });
        _grafo.Add("bob", new[] { "anuj", "peggy" });
        _grafo.Add("alice", new[] { "peggy" });
        _grafo.Add("claire", new[] { "thom", "jonny" });
        _grafo.Add("anuj", Array.Empty<string>());
        _grafo.Add("peggy", Array.Empty<string>());
        _grafo.Add("thom", Array.Empty<string>());
        _grafo.Add("jonny", Array.Empty<string>());
        Pesquisa("voce");
    }

    private static bool Pesquisa(string nome)
    {
        // Insere amigos na fila
        Queue<string> pesquisaFila  = new Queue<string>(_grafo[nome]);
        List<string> verificado     = new List<string>();

        while (pesquisaFila.Any())
        {
            string pessoa = pesquisaFila.Dequeue();
            if (!verificado.Contains(pessoa))
            {
                if (verificaPessoaVendedor(pessoa))
                {
                    Console.WriteLine($"{pessoa} é um vendedor de manga");
                    return true;
                }
                else
                {
                    // insere amigos da pessoa na fila
                    pesquisaFila = new Queue<string>(pesquisaFila.Concat(_grafo[pessoa]));
                    verificado.Add(pessoa);
                }
            }
        }

        return false;
    }

    private static bool verificaPessoaVendedor(string nome)
    {
        return nome.EndsWith("m");
    }
}