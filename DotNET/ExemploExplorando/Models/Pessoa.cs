using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa(){

        }
        public Pessoa(string nome, string sobrenome){
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private int _idade;
        public string Nome 
        {
             get => _nome.ToUpper();
             
             set{
                //value é o valor que está passando para o set
                if (value == ""){
                    //faz o programa encerrar
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
             } 
        }
        public int Idade { 
            get=>_idade; 
            set{
                if(value<0){
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome.ToUpper()} {Sobrenome.ToUpper()}";
        public void Apresentar(){
            string anos = "anos";
            if (_idade >= 0 && _idade <= 1) anos = "ano";
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade} {anos}");
        }
    }
}