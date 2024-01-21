using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }
        //     assinatura de método começa no void
        public void AdicionarAluno(Pessoa Aluno){
            Alunos.Add(Aluno);
        }

        public bool RemoverAluno(Pessoa Aluno){
            return Alunos.Remove(Aluno);
        }

        public void ListarAlunos(){
            Console.WriteLine($"Alunos do Curso de: {Nome}");
            foreach (Pessoa aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

        public int ObterQuantidadeDeAlunosMatriculados(){
            int quantidade = Alunos.Count;
            return quantidade;
        }
    }
}