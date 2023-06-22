internal class Program
{
    private static void Main(string[] args)
    {
        List<int> arr = new List<int> { 5, 3, 6, 2, 10 };
        Console.WriteLine(string.Join(", ", SelectionSort(arr)));
    }

    private static int[] SelectionSort(List<int> arr)
    {
        int[] novoArr = new int[arr.Count()];

        for (int indice = 0; indice < novoArr.Count(); indice++)
        {
            //Encontra o menor elemento da lista e adiciona ao novo array 
            int indiceMenorValor    = EncontrarMenor(arr);
            novoArr[indice]         = arr[indiceMenorValor];
            arr.Remove(arr[indiceMenorValor]);
        }

        return novoArr;
    }

    private static int EncontrarMenor(List<int> arr)
    {
        int menorValor          = arr[0];
        int indiceMenorValor    = 0;

        for (int indice = 0; indice < arr.Count; indice++)
        {
            if (arr[indice] < menorValor)
            {
                menorValor          = arr[indice];
                indiceMenorValor    = indice;
            }
        }
        
        return indiceMenorValor;
    }
}