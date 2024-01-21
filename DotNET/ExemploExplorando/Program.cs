using ExemploExplorando.Models;

//nome: "", é uma forma de mostrar para o desenvolvedor o nome do parâmetro. 
// posso trocar a ordem dos parâmetro, cool :D
Pessoa p1 = new Pessoa(sobrenome: "Maury Elvis", nome: "Pereira de Souza");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();







// Pessoa p1 = new Pessoa();
// p1.Nome = "Maury Elvis";
// p1.Sobrenome = "Pereira de Souza";
// p1.Idade = 2;
// p1.Apresentar();