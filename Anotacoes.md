## Git 
```console
    git config credential.username hesauhugo
    git pull --allow-unrelated-histories origin main
```
## Gerenciador de pacotes
* É um conjunto de códigos úteis, que posibilita compartilhamento e reuso do código.
## Nuget
* É um gerenciador de pacotes, que permite desenvolvedores compartilhem códigos e bibliotecas
* um projeto pode ter várias referências
* Ex: google maps, leitura de texto etc.
* .[nuget.org]
## Instalando newtonsoft .net cli
```ps
    dotnet add package Newtonsoft.Json --version 13.0.1
```
## Serializacao de dados
* O processo de serializar consiste em transformar objetos em fluxo de bytes para seu armazenamento ou transmissão.
* Json: Javascript Notation Object é um formato de texto que segue a sintaxe do Javascript, muito usado para transmitir dados entre aplicações.
## Serializando um objeto
```csharp 
    var venda = new Venda(1,"Produto 1", 10.00M);
    string serializado  = JsonConvert.SerializeObject(venda,Formatting.Indented);
    File.WriteAllText("Arquivos/vendas.json",serializado);
    Console.WriteLine(serializado);
```

## Serializando uma lista
```csharp 
    var listaVendas = new List<Venda>();
    var venda1 = new Venda(1,"Produto 1", 10.00M);
    var venda2 = new Venda(2,"Produto 2", 20.00M);

    listaVendas.Add(venda1);
    listaVendas.Add(venda2);

    string serializado  = JsonConvert.SerializeObject(listaVendas,Formatting.Indented);
    File.WriteAllText("Arquivos/listaVendas.json",serializado);
    Console.WriteLine(serializado);
```
## Site para validar o Json
* <a href="https://codebeautify.org/jsonviewer">Code Beautify</a>
* espaços  aumentam o tamanho do arquivo
## Datatime
* Csharp representa o padrão ISO 8601