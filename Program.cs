using Dotnet_Nuget_Serializar_Atributos.Models;
using Newtonsoft.Json;

var venda = new Venda(1,"Produto 1", 10.00M);
string serializado  = JsonConvert.SerializeObject(venda,Formatting.Indented);
File.WriteAllText("Arquivos/vendas.json",serializado);
Console.WriteLine(serializado);
