using Models.Venda;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {

        List<Venda> listaV = new List<Venda>();
        Venda v = new Venda(1, "Abacaxi", 10.95);
        Venda v2 = new Venda(1, "Abacaxi", 10.95);


        listaV.Add(v);
        listaV.Add(v2);
        string serializado = JsonConvert.SerializeObject(listaV, Formatting.Indented);
        Console.WriteLine(serializado);
        File.WriteAllText("Arquivos.json", serializado);

    }
}