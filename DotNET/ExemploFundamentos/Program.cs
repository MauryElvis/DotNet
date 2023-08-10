using ExemploFundamentos.Models;

string a = "15";

// associa a saída como zero caso der erro
int.TryParse(a, out int x);
Console.WriteLine(x);
// int inteiro = 89;
// string s = inteiro.ToString();
// decimal t = 8.98M;
// Console.WriteLine((5.00F).GetType());

// int a = 10;
// int b = 20;

// int c = a+b;
// c = c+5;

// int x = Convert.ToInt32(null);
// decimal y = int.Parse("5");
// Console.WriteLine(y.GetType());



// Processo de Conversão de chama Cast ou Casting
// Posso usar o Convert. para isso
// Tenho a opção do int.Parse("") também

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Maury";
// pessoa1.Idade = 22;
// pessoa1.Apresentar();

// Pessoa pessoaFisicaRepresentacao = new Pessoa();

// string apresentação = "Olá, seja bem vindo";

// int quantidade = 1;
// quantidade = 10;
// double altura = 1.80;
// decimal preco = 1.80M;

// bool condicao = true;

// Console.WriteLine(apresentação);
// Console.WriteLine("Valor da Variável Quantidade: "+ quantidade);
// Console.WriteLine("Valor da Variável altura: "+ altura.ToString("0.00"));
// Console.WriteLine("Valor da Variável preco: "+ preco);
// Console.WriteLine("Valor da Variável condicao: "+ condicao);


