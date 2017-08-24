using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Dia_23_08_2017
{
    class Pessoa
    {
        private string nome;
        private long cpf;
        private List<Cachorro> cachorros = new List<Cachorro>();
        
        public Pessoa()
        {

        }
        public Pessoa(string nome, long cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }

        public void AddCachorros(Cachorro c)
        {
            cachorros.Add(c);
        }

        public void RmCachorros(Cachorro c)
        {
            cachorros.Remove(c);
        }

        public void RmCachorros(int c)
        {
            cachorros.RemoveAt(c);
        }

        public Cachorro GetCachorro (int i)
        {
            return cachorros[i];
        }

        public int SizeOfCachorros()
        {
            return cachorros.Count;
        }

        public void ListAll()
        {
            foreach(Cachorro c in cachorros) {
                Console.WriteLine(c);
            }
        }

        public override string ToString()
        {
            String s = "CPF: " + cpf + " Nome: " + nome + " ";
            foreach(Cachorro c in cachorros)
                s += c + ", ";

            return s;
        }
        public string Nome { get => nome; set => nome = value; }
        public long Cpf { get => cpf; set => cpf = value; }
    }
}
