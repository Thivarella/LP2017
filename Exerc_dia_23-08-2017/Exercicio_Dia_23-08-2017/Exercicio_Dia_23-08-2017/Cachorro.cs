using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Dia_23_08_2017
{
    class Cachorro
    {
        private string nome, raca;
        private bool vacinado;

        public Cachorro()
        {

        }
        public Cachorro(string nome, string raca, bool vacinado)
        {
            this.Nome = nome;
            this.Raca = raca;
            this.Vacinado = vacinado;
        }

        public override string ToString()
        {
            return "Nome: " + nome + " Raça: " + raca + " Vacinado: " + (vacinado ? "Sim" : "Não");
        }

        public string Nome { get => nome; set => nome = value; }
        public string Raca { get => raca; set => raca = value; }
        public bool Vacinado { get => vacinado; set => vacinado = value; }
    }
}
