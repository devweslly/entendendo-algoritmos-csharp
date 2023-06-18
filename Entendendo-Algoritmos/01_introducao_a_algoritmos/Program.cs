public class Program
{

    /*
     * Busca Binária
     
     * Sua entrada é uma lista ordenada (DEVE SER UMA LISTA ORDENADA)
     * Se o elemento está na lista, a pesquisa binária retorna sua localização (o indice da lista)
     * Caso contrário é retornado -1
     * O objetivo é encontrar a localização no menor número de tentativas possíveis (log tamanhoLista na base 2)
     * A pesquisa binária é executada com tempo logarítmico
     * Com a pesquisa binária, é elimindado em cada etapa o número de elementos pela metade até que reste um elemento
     */

    private static void Main(string[] args)
    {
        List<int> lista = new List<int> { 1, 3, 5, 7, 9 };
        int item        = -2;
        int indice      = BuscaBinaria(lista, item);

        if (indice == -1)
            Console.WriteLine($"O item '{item}' não foi encontrado na lista.");
        else
            Console.WriteLine($"O item '{item}' está localizada em lista[{indice}].");
    }

    public static int BuscaBinaria(List<int> lista, int item)
    {
        int baixo       = 0;
        int alto        = lista.Count() - 1;

        while (baixo <= alto)
        {
            // A cada tentativa é testado para o elemento central
            int medio   = (baixo + alto) / 2;
            int chute   = lista[medio];

            if (chute == item)
                return medio;
            else if (chute > item)
                alto    = medio - 1;
            else
                baixo   = medio + 1;
        }

        return -1;
    }
}