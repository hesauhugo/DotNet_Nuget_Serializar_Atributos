using Dotnet_Nuget_Serializar_Atributos.Models;
using Newtonsoft.Json;

var conteudoArquivo = File.ReadAllText("Arquivos/listaVendas.json");
List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);
foreach (var venda in listaVendas)
{
    Console.WriteLine($"Id: {venda.Id} Produto: {venda.Produto}");
}