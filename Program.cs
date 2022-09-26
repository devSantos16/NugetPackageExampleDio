using Models.Venda;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        string conteudo = File.ReadAllText("Arquivos.json");
        List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudo);
        
        foreach(var item in listaVenda){
            Console.WriteLine(item.Id);
            Console.WriteLine(item.Produto);
            Console.WriteLine(item.DataVenda.ToString("dd/MM/yyyy"));
        }

        


        // List<Venda> listaV = new List<Venda>();
        // Venda v = new Venda(1, "Abacaxi", 10.95, DateTime.Now);


        // listaV.Add(v);
        // string serializado = JsonConvert.SerializeObject(listaV, Formatting.Indented);
        // Console.WriteLine(serializado);
        // File.WriteAllText("Arquivos.json", serializado);

    }
}