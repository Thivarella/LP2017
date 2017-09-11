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
    public partial class CadProduto : Form
    {
        private static long codigo = 1;
        public CadProduto()
        {
            InitializeComponent();
            TextCodProd.Text = codigo.ToString();
        }
            
        private void BtnSave_Click(object sender, EventArgs e)
        {   
            DatabaseDict data = new DatabaseDict();
            Produto prod = new Produto();
            prod.Nome = textNomeProd.Text;
            bool a = long.TryParse(textCodProd.Text, out long cod);
            prod.Codigo = cod;
            a = int.TryParse(textQtdeProd.Text, out int qtde);
            prod.Quantidade = qtde;
            a = float.TryParse(textPrecoProd.Text, out float preco);
            prod.Preco = preco;
            data.Salvar(prod);
            if(codigo==cod)
                codigo++;
            Form.ActiveForm.Close();
        }
        
    }
}
