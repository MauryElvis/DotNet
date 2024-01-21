namespace ExemploFundamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Faz a pessoa se apresentar, dizendo seu nome e idade
        /// </summary>
        public void Apresentar(){
            // Console.WriteLine($"Olá, meu nome é {Nome}," +
            // $"e tenho {Idade} anos");

            Console.WriteLine($"Olá, meu nome é {Nome}, \n e tenho {Idade} anos");
        }
        public void CadastrarNoERPXYZDaEmpresa(){
            // Console.WriteLine($"Olá, meu nome é {Nome}," +
            // $"e tenho {Idade} anos");

            Console.WriteLine($"Olá, meu nome é {Nome}, \n e tenho {Idade} anos");
        }
        
    }
}