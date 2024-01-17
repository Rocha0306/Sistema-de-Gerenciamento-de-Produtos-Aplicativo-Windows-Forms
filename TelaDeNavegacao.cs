using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gerenciamento_de_Produtos_Challenger
{
    public partial class TelaDeNavegação : Form
    {
        public TelaDeNavegação()
        {
            InitializeComponent();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarProduto abrir = new AdicionarProduto(); 
            abrir.ShowDialog();
        }

        private void listagemDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListagemDeProdutos abrir = new ListagemDeProdutos();
            abrir.ShowDialog(); 
        }

        private void atualizaçãoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarProdutos abrir = new AtualizarProdutos(); 
            abrir.ShowDialog();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoverProdutos abrir = new RemoverProdutos();
            abrir.ShowDialog();
        }
    }
}
