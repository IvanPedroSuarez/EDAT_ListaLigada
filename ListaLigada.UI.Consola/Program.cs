using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista ligada simple \n");

        var singleList = new SingleList<string>();

        singleList.Add("Juan");
        singleList.Add("Jose");
        singleList.Add("Jan");

        Console.WriteLine(singleList);



    }

}
