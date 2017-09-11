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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            Dictionary<long, Button> list = new Dictionary<long, Button>();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ListaProduto form = new ListaProduto();
            form.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CadProduto cad = new CadProduto();
            cad.ShowDialog();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Button hora = new Button();
            hora.Text = txtHorario.Text;
            PaneHorario.Controls.Add(hora);
            hora.Dock = DockStyle.Top;
            
            
        }
        
    }
}       