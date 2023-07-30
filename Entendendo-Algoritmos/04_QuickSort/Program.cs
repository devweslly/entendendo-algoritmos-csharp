public class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine($"Soma = {SomaLoop(new[] { 1, 2, 3, 4 })}");

        //Console.WriteLine($"Soma = {SomaRecursao(new[] { 1, 2, 3, 4 })}");

        //Console.WriteLine($"Quantidade de elementos = {QuantidadeElementos(new[] { 1, 2, 3, 4 })}");

        //Console.WriteLine($"Maior elemento = {ElementoMaximo(new[] { 1, 3, 2, 5, 9, 8 })}");

        int[] arr = new int[] { 10, 5, 11, 3 };
        Console.WriteLine(string.Join(", ", QuickSort(arr)));
    }

    #region Soma por Loop
    private static int SomaLoop(IEnumerable<int> arr)
    {
        int total = 0;

        foreach (int i in arr)
        {
            total += i;
        }

        return total;
    }
    #endregion

    #region Soma por Recursao
    private static int SomaRecursao(IEnumerable<int> list)
    {
        // Caso-base: verifica se a lista está vazia (se tem pelo menos um elemento)
        if (!list.Any())
            return 0;

        //Caso Recursivo: retorna a soma do primeiro elemento da lista e
        //o retorno da função recursiva aplicada à lista com o primeiro elemento removido
            return list.Take(1).First() + SomaRecursao(list.Skip(1));
    }
    #endregion

    #region Contando quantidade de elementos
    private static int QuantidadeElementos(IEnumerable<int> list)
    {
       // Caso-base
       if(!list.Any())
            return 0;

        return 1 + QuantidadeElementos(list.Skip(1));
    }
    #endregion

    #region Max elemento
    private static int ElementoMaximo(IEnumerable<int> list)
    {
        // Se a lista estiver vazia, lança uma exceção
        if (!list.Any())
            throw new NotImplementedException(nameof(list));
        // Se a lista tiver apenas um elemento, retorna esse elemento
        else if (list.Count() == 1)
            return list.First();
        //Se a lista tiver dois elementos, compara o primeiro elemento com o segundo elemento e retorna o maior dos dois
        else if (list.Count() == 2)
            return list.First() > list.Skip(1).Take(1).First() ? list.First() : list.Skip(1).Take(1).First();

        int subMax = ElementoMaximo(list.Skip(1));

        return list.First() > subMax ? list.First() : subMax;
    }
    #endregion

    #region QuickSort

    /*
     * O método QuickSort() é um algoritmo de ordenação que funciona dividindo a lista em duas partes,
     * uma parte com elementos menores que o pivô e outra parte com elementos maiores que o pivô.
     * O método é recursivo, o que significa que ele chama a si mesmo para ordenar as duas partes da lista.
     
     * É importante notar que o QuickSort é um algoritmo de ordenação eficiente
     * e possui um bom desempenho na maioria dos casos.
     * No entanto, em certas situações, pode ter um desempenho pior do que outros algoritmos de ordenação,
     * como o MergeSort, por exemplo, principalmente quando a lista está quase ordenada
     * ou possui muitos elementos repetidos.
     */

    private static IEnumerable<int> QuickSort(IEnumerable<int> list)
    {
        if (list.Count() <= 1)
            return list;

        // O pivô é um elemento de referência que será usado para particionar a lista em dois grupos
        // um contendo os elementos menores ou iguais ao pivô e outro contendo os elementos maiores que o pivô
        int pivo = list.First();

        // cria uma nova lista com os elementos da lista original que são menores que o pivô
        IEnumerable<int> menor = list.Skip(1).Where(i => i <= pivo);

        // cria uma nova lista com os elementos da lista original que são maiores que o pivô
        IEnumerable<int> maior = list.Skip(1).Where(i => i > pivo);

        // Agora, é feita a chamada recursiva do método QuickSort para ordenar as duas sublistas.
        // A ordenação é feita separadamente para os elementos menores e maiores que o pivô,
        // e depois são unidas em uma única lista ordenada.
        // Para isso, utiliza-se o método "Union" para combinar as listas ordenadas com o pivô no meio.
        return QuickSort(menor).Union(new List<int> { pivo }).Union(QuickSort(maior));
    }
    #endregion
}