using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLp2
{
    class DatabaseDict : IDatabase
    {
        private static Dictionary<long, Produto> lista = new Dictionary<long, Produto>();

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListAll()
        {
            List<Produto> prod = new List<Produto>();
            foreach(KeyValuePair<long,Produto> e in lista) {
                prod.Add(e.Value);
            }
            return prod;
        }

        public List<Produto> ListAll(string nome)
        {
            List<Produto> prod = new List<Produto>();
            if (nome.Equals("")) {
                prod = ListAll();
            }
            else {
                foreach (KeyValuePair<long, Produto> e in lista) {
                    if (e.Value.Nome.ToUpper().Contains(nome.ToUpper())) 
                        prod.Add(e.Value);
                }
            }
            return prod;
        }

        public void Read()
        {
        }

        public void Salvar(Produto a)
        {
            if (lista.ContainsKey(a.Codigo)) {
                lista[a.Codigo].Nome = a.Nome;
                lista[a.Codigo].Preco = a.Preco;
                lista[a.Codigo].Quantidade = a.Quantidade;
            }
            else {
                lista.Add(a.Codigo, a);
            }
        }

        public void Update(long a)
        {
            a++;
            CadProduto cad = new CadProduto();
            cad.TextNomeProd.Text = lista[a].Nome;
            cad.TextCodProd.Text = lista[a].Codigo.ToString();
            cad.TextPrecoProd.Text = lista[a].Preco.ToString();
            cad.TextQtdeProd.Text = lista[a].Quantidade.ToString();
            cad.ShowDialog();
            
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
