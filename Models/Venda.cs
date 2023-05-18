using System;
using System.Threading.Tasks;

namespace Dotnet_Nuget_Serializar_Atributos.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Venda
    {
        public Venda(int id, string produto, decimal preco){
            Id = id;
            Produto = produto;
            Preco = preco;
        }

        public int Id {get;set;}
        public string Produto {get;set;}
        public decimal Preco {get; set;}
    }
}
