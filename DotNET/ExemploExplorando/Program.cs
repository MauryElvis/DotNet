using ExemploExplorando.Models;
using System.Globalization;

string dataString = "2022-192-17 18:00";

// Tentar converter a data em um tipo DateTime
bool sucesso = DateTime.TryParseExact(dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None, 
                        out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
}
else Console.WriteLine($"{dataString} não é uma data válida");
















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