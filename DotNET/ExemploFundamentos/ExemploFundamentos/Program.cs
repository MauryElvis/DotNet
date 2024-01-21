using ExemploFundamentos.Common.Models;

// Instância da classe pessoa
Pessoa p = new Pessoa();

/*
    Atribui o nome e idade para pessoa
    passando o nome Buta
    e passando a idade 20
*/
p.Nome = "Buta";
p.Idade = 20;

// Faz a pessoa se apresentar
p.Apresentar();

// Cadastra no ERP de clientes XYZ
p.CadastrarNoERPXYZDaEmpresa();

Calculadora c = new Calculadora();
c.Somar(12, 3);
c.Subtrair(12, 6);



// List<string> listaString = new List<string>();

// listaString.Add("SP");
// listaString.Add("BA");
// listaString.Add("MG");
// listaString.Add("RJ");
// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Add("SC");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// listaString.Remove("MG");

// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");













// Console.WriteLine("Percorrendo o Array com FOR");
// for(int i = 0; i<listaString.Count; i++){
//     Console.WriteLine($"Posição nº {i} - {listaString[i]}");
// }


// int contadorForEach = 0;
// Console.WriteLine("Percorrendo o Array com ForEach");
// foreach(string valor in listaString){
//     Console.WriteLine($"Posição nº {contadorForEach} - {valor}");
//     contadorForEach++;
// }





















// int[] arrayInteiros = new int[4];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[2] = 50;
// arrayInteiros[3] = 1;

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Console.WriteLine("Percorrendo o Array com FOR");
// for(int i = 0; i<arrayInteiros.Length; i++){
//     Console.WriteLine($"Posição nº {i} - {arrayInteiros[i]}");
// }












// int contadorForEach = 0;
// Console.WriteLine("Percorrendo o Array com ForEach");
// foreach(int valor in arrayInteiros){
//     Console.WriteLine($"Posição nº {contadorForEach} - {valor}");
//     contadorForEach++;
// }



// Calculadora calculadora = new Calculadora();



// string opcao;

// bool exibirMenu = true;
//  while(exibirMenu){
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");
//     Console.WriteLine("1. Cadastrar Cliente");
//     Console.WriteLine("2. Buscar Cliente");
//     Console.WriteLine("3. Apagar Cliente");
//     Console.WriteLine("4. Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de Cliente");
//             break;
        
//         case "2":
//             Console.WriteLine("Busca de Cliente");
//             break;
        
//         case "3":
//             Console.WriteLine("Apagar Cliente");
//             break;
        
//         case "4":
//             Console.WriteLine("Encerrando...");
//             exibirMenu = false;
//             // Environment.Exit(0) -> encerra o programa
//             break;
//         default:
//             Console.WriteLine("Opção Inválida");
//             break;
//     }
//  }

// Console.WriteLine("O programa encerrou");

























// int numero = 10;
// int i = 1;


// for (int i = 1; i<=10; i++){
//     Console.WriteLine($"{numero} x {i} = {numero * i}");

// }

// while(i<=10){
//     Console.WriteLine($"{numero} x {i} = {numero * i}");
//     i++;

//     if(i==6){
//         break;
//     }
// }
// int soma = 0, numero = 0;
// do{
//     Console.WriteLine("Digite um numero (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;
// }while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");
// Console ReadLine não funciona no terminal de saída do VSCode quando debugado
// Para corrigir, deve mudar a saida para outro terminal
// Para isso vá em .vscode -> launch.json e alterar console para integratedTerminal










// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);
// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10");
// numero = numero + 1;

// Console.WriteLine(numero);


















// bool choveu = true;
// bool estaTarde = false;

// if (!choveu && !estaTarde){
//     Console.WriteLine("Vou pedalar hoje");
// } else {
//     Console.WriteLine("Não vou pedalar hoje");
// }











// bool presencaMinima = false;
// double mediaNecessaria = 5;

// if (presencaMinima && mediaNecessaria>=7){
//     Console.WriteLine("Aprovado");
// } else {
//     Console.WriteLine("Reprovado");
    
//     if (!presencaMinima){
//         Console.WriteLine("Motivo: Não possui Presença Mínima");
//     }
//     if(!(mediaNecessaria>=7)){
//         Console.WriteLine("Motivo: Não possui Média Necessária");
//     }
// }






// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoResponsavel = false;

// if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel){
//     Console.WriteLine("Entrada liberada");
// } else {
//     Console.WriteLine("Entrada não liberada");
// }




// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é vogal");
//         break;
// }









// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else {
//     Console.WriteLine("Não é uma vogal");
// }








// int quantidadeEmEstoque = 10;


// bool parada = false;
// while(parada == false){
//     Console.WriteLine("QUANTIDADE EM ESTOQUE: " + quantidadeEmEstoque);

//     Console.WriteLine("Quantos itens deseja comprar? ");
//     int quantidadeCompra = int.Parse(Console.ReadLine());
    
//     if (quantidadeCompra == 0) {

//         Console.WriteLine("Venda inválida");

//     } else if(quantidadeEmEstoque >= quantidadeCompra){
        
//         Console.WriteLine("Venda Realizada");
//         quantidadeEmEstoque -= quantidadeCompra;

//     } else {
//         Console.WriteLine("Desculpe não temos a quantidade em estoque");
//         parada = true;
//     }
// }



// using ExemploFundamentos.Models;

// string a = "15";

// // associa a saída como zero caso der erro
// int.TryParse(a, out int u);
// Console.WriteLine(u);
// // int inteiro = 89;
// // string s = inteiro.ToString();
// // decimal t = 8.98M;
// // Console.WriteLine((5.00F).GetType());

// // int a = 10;
// // int b = 20;

// // int c = a+b;
// // c = c+5;

// // int x = Convert.ToInt32(null);
// // decimal y = int.Parse("5");
// // Console.WriteLine(y.GetType());



// // Processo de Conversão de chama Cast ou Casting
// // Posso usar o Convert. para isso
// // Tenho a opção do int.Parse("") também

// // DateTime dataAtual = DateTime.Now.AddDays(5);
// // Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));
// // Pessoa pessoa1 = new Pessoa();
// // pessoa1.Nome = "Maury";
// // pessoa1.Idade = 22;
// // pessoa1.Apresentar();

// // Pessoa pessoaFisicaRepresentacao = new Pessoa();

// // string apresentação = "Olá, seja bem vindo";

// // int quantidade = 1;
// // quantidade = 10;
// // double altura = 1.80;
// // decimal preco = 1.80M;

// // bool condicao = true;

// // Console.WriteLine(apresentação);
// // Console.WriteLine("Valor da Variável Quantidade: "+ quantidade);
// // Console.WriteLine("Valor da Variável altura: "+ altura.ToString("0.00"));
// // Console.WriteLine("Valor da Variável preco: "+ preco);
// // Console.WriteLine("Valor da Variável condicao: "+ condicao);

// Console.WriteLine("Olá Developers");

