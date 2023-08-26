public class Program
{
    private static Dictionary<string, bool> _voto = new Dictionary<string, bool>();
    private static void Main(string[] args)
    {

        //MostraPrecoMecearia();
                
        ChacandoVoto("Weslly");        
        ChacandoVoto("João");        
        ChacandoVoto("José");        
    }

    private static void ChacandoVoto(string eleitor)
    {
        if (_voto.ContainsKey(eleitor))
        {
            Console.WriteLine("Vai embora, carolho!");
        }
        else
        {
            _voto.Add(eleitor, true);
            Console.WriteLine("Vota logo, porra!");
        }
    }

    private static void MostraPrecoMecearia()
    {
        Dictionary<string, double> book = new Dictionary<string, double>
        {
            {"Suco", 7.90 },
            {"Pão", 1.90 }
        };

        book.Add("maça", 0.67);
        book.Add("leite", 1.49);
        book.Add("abacate", 0.90);

        foreach (KeyValuePair<string, double> item in book)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }
}