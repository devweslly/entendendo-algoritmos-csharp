public class Program
{
    /*
     * Recursão
     
     * Uma função recursiva chama a si mesma
     * A função recursiva tem duas partes
     * Caso-base: quando a função NÃO chama a si mesma (informa quando a recursão deve parar)
     * Caso recursivo: quando a função chama a si mesma
     */

    private static void Main(string[] args)
    {
        //ContagemRegressiva(5);

        //Saudar("Weslly");

        Console.WriteLine(Fatorial(5));
    }

    #region ContagemRegressiva

    private static void ContagemRegressiva(int contador)
    {
        Console.WriteLine(contador);

        // Caso-base
        if (contador == 0)
            return;

        ContagemRegressiva(contador - 1);
    }

    #endregion

    #region Saudar

    private static void Saudar(string nome)
    {
        Console.WriteLine($"Olá, {nome}!");

        Saudar2(nome);

        Console.WriteLine("preparando para dizer tchau...");

        tchau();
    }

    private static void Saudar2(string nome)
    {
        Console.WriteLine($"Como vai {nome}?");
    }

    private static void tchau()
    {
        Console.WriteLine($"ok tchau!");
    }

    #endregion

    #region Fatorial

    private static int Fatorial(int fat)
    {
        if (fat <= 1)
            return 1;

        return fat * Fatorial(fat - 1);
    }

    #endregion
}