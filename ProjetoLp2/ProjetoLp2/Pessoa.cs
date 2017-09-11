using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLp2
{
    class Pessoa
    {
        String nome, endereco;
        double telefone;

        public Pessoa()
        {
        }

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public double Telefone { get => telefone; set => telefone = value; }
    }
}
