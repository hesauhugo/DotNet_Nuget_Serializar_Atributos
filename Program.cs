using Dotnet_Nuget_Serializar_Atributos.Models;
using Newtonsoft.Json;

var listaVendas = new List<Venda>();
var venda1 = new Venda(1,"Produto 1", 10.00M);
var venda2 = new Venda(2,"Produto 2", 20.00M);

listaVendas.Add(venda1);
listaVendas.Add(venda2);

string serializado  = JsonConvert.SerializeObject(listaVendas,Formatting.Indented);
File.WriteAllText("Arquivos/listaVendas.json",serializado);
Console.WriteLine(serializado);
