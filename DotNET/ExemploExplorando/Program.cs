using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (var venda in listaVenda)
{
    Console.WriteLine($"ID: {venda.ID}\n" +
                      $"Produto: {venda.Produto}\n" +
                      $"Preco: {venda.Preco}\n" +
                      $"Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}\n" +
                      "---------------------------------------");
}





// // tenho 3 opções -> receber e-mail, não receber e-mail, não informado
// // o .HasValue verifica se TEM VALOR, o .Value verifica O VALOR

// bool? desejaReceberEmail = false;
// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value){
//     Console.WriteLine("O usuário optou por receber e-mail");
// } else{
//     Console.WriteLine("O usuário não respondeu ou optou por não receber e-mail");
// }

















// DateTime dataAtual = DateTime.Now;
// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// Console.WriteLine(serializado);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// // ISO 8601 => padrão de data entre sistemas
























// int numero = 10;
// bool ehPar = false;

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

// if (numero % 2 == 0){
//     Console.WriteLine($"O número {numero} é par");
// } else {
//     Console.WriteLine($"O número {numero} é ímpar");
// }














// Pessoa p1 = new Pessoa("João", "Silva");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");























// LeituraArquivo arquivo = new LeituraArquivo();

// //esse underline é o descarte -> descarto uma informação que não utilizo
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// if (sucesso){
//     foreach (string linha in linhasArquivo){
//         Console.WriteLine(linha);
//     }
// } else {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }



















// isso é uma tupla -> uma variável que armazena diferentes valores de diferentes tipos
// uma alternativa a uma classe
// (int, string, string, decimal) tupla = (1, "Maury Elvis", "Pereira de Souza", 10.8M);

// (int ID, string Nome, string Sobrenome, decimal Altura) tupla2 = (1, "Maury Elvis", "Pereira de Souza", 10.8M);

// ValueTuple<int, string, string, decimal> tupla3 = (1, "Maury Elvis", "Pereira de Souza", 10.8M);

// var tupla4 = Tuple.Create(1, "Maury Elvis", "Pereira de Souza", 10.8M);

// Console.WriteLine($"ID: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");

































// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("GO", "Goiás");
// estados.Add("BA", "Bahia");
// estados.Add("BA2", "Bahia");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);
// foreach (KeyValuePair<string, string> item in estados){
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
    
// }

// estados.Remove("BA2");
// estados["MG"] = "Minas Gerais - Valor Alterado";

// Console.WriteLine("--------------------------------------------");
// foreach (KeyValuePair<string, string> item in estados){
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
    
// }

// string chave = "PA";
// Console.WriteLine($"Verificando o elemento {chave}");

// if(estados.ContainsKey(chave)){
//     Console.WriteLine($"Valor existente: {chave}");
// } else {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }























// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);


// foreach (int item in pilha)
// {
//     Console.WriteLine(item);   
// }
// Console.WriteLine($"Removendo o Elemento do Topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);   
// }














//new ExemploExcecao().Metodo1();

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);    
// }

// Console.WriteLine($"Removendo o Elemento: {fila.Dequeue()}");
// fila.Enqueue(10);
// foreach (int item in fila)
// {
//     Console.WriteLine(item);    
// }

















//string[] linhas3 = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");
//com o try catch consigo prosseguir com o código mesmo com a excessão, continua no catch
// try
// {
    
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// } catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// } catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }  catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// } finally
// {
//     Console.WriteLine("Chegou até aqui!");
// } 















// string dataString = "2022-192-17 18:00";

// // Tentar converter a data em um tipo DateTime
// bool sucesso = DateTime.TryParseExact(dataString, 
//                         "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None, 
//                         out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}");
// }
// else Console.WriteLine($"{dataString} não é uma data válida");
















//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
//escrevendo valores monetários
//Uso do $"" -> se chama interpolação de String
// decimal valorMonetario = 1482.40M;

// Console.WriteLine(valorMonetario.ToString("N1"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("###-###"));
























//nome: "", é uma forma de mostrar para o desenvolvedor o nome do parâmetro. 
// posso trocar a ordem dos parâmetro, cool :D
// Pessoa p1 = new Pessoa(sobrenome: "Maury Elvis", nome: "Pereira de Souza");
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();







// Pessoa p1 = new Pessoa();
// p1.Nome = "Maury Elvis";
// p1.Sobrenome = "Pereira de Souza";
// p1.Idade = 2;
// p1.Apresentar();