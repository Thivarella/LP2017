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
            Refresh("");
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            CadProduto cad = new CadProduto();
            cad.ShowDialog();
            Refresh("");
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            long a = long.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            DatabaseDict data = new DatabaseDict();
            data.Read(a);
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string nome = TextBox1.Text;
            Refresh(nome);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            long a = long.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            DatabaseDict data = new DatabaseDict();
            data.Update(a);
            Refresh("");
        }

        private void btnRmProd_Click(object sender, EventArgs e)
        {
            long a = long.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            DatabaseDict data = new DatabaseDict();
            data.Delete(a);
            Refresh("");
        }

        private void Refresh(String a)
        {
            dataGridView1.Rows.Clear();
            DatabaseDict data = new DatabaseDict();
            List<Produto> prod = data.ListAll(a);
            foreach (Produto ae in prod) {
                dataGridView1.Rows.Add(ae.Codigo, ae.Nome, ae.Preco, ae.Quantidade);
            }
        }
    }
}
