using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLp2
{
    public partial class ListaProduto : Form
    {
        public ListaProduto()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            CadProduto cad = new CadProduto();
            cad.ShowDialog();
            BtnVisualizar.PerformClick();
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            DatabaseDict data = new DatabaseDict();
            List<Produto> prod = data.ListAll("");
            foreach (Produto ae in prod) {
                dataGridView1.Rows.Add(ae.Codigo,ae.Nome,ae.Preco,ae.Quantidade);
            }
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string nome = TextBox1.Text;
            dataGridView1.Rows.Clear();
            DatabaseDict data = new DatabaseDict();
            List<Produto> prod = data.ListAll(nome);
            foreach (Produto ae in prod) {
                dataGridView1.Rows.Add(ae.Codigo, ae.Nome, ae.Preco, ae.Quantidade);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            long a = long.Parse(dataGridView1.CurrentRow.Index.ToString());
            DatabaseDict data = new DatabaseDict();
            data.Update(a);
            BtnVisualizar.PerformClick();
        }
    }
}
