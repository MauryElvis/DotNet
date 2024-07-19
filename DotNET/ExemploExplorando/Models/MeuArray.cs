using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class MeuArray<T>
    {
        private static int capacidade = 10;
        private T[] array = new T[capacidade];
        private static int contador = 0;

        public void AdicionarElementoArray(T elemento){
            if (contador + 1 <capacidade+1){
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]{
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}