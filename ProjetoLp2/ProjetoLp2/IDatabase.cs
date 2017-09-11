using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLp2
{
    interface IDatabase
    {
        void Salvar(Produto a);

        void Update();

        void Read();

        void Delete();

        List<Produto> ListAll();

        List<Produto> ListAll(String nome);
    }
}
