using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLp2
{
    class Produto
    {
        long codigo;
        String nome;
        float preco;
        int quantidade;

        public Produto()
        {
            
        }

        public long Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public float Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
