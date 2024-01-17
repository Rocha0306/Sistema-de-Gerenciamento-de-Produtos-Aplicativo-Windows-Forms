using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_de_Gerenciamento_de_Produtos_Challenger
{
    public partial class AtualizarProdutos : Form
    {
        MySqlConnection Conexao;
        public AtualizarProdutos()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ListagemDeProdutos abrir = new ListagemDeProdutos();
            abrir.ShowDialog();
        }

        private void BotaoAlterarProduto_Click(object sender, EventArgs e)
        {

            try
            {
                string server = "localhost";
                string database = "GerenciadorDeProdutos";
                string username = "root";
                string password = "Lorenzo05*";
                string StringDeConexao = $"server={server};database={database};uid={username};password={password}";
                string IDUsuario = CodProduto.Text;
                string Produto = NomeProdutoBox2.Text;
                string ComandoSQL1 = $"UPDATE INFO SET PRODUTO = '{Produto}' WHERE COD_PRODUTO = {IDUsuario}";



                using (MySqlConnection Conexao = new MySqlConnection(StringDeConexao))
                {
                    Conexao.Open();


                    using (MySqlCommand Comando = new MySqlCommand(ComandoSQL1, Conexao))
                    {
                        Comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados editados com Sucesso");


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar dados");
            }

        }

        private void BotaoAlterarPreco_Click(object sender, EventArgs e)
        {
            try
            {
                string server = "localhost";
                string database = "GerenciadorDeProdutos";
                string username = "root";
                string password = "Lorenzo05*";
                string StringDeConexao = $"server={server};database={database};uid={username};password={password}";
                string IDUsuario = CodProduto.Text;
                string PrecoProduto = PrecoProdutoBox2.Text;
                int PrecoProduto1 = Convert.ToInt32(PrecoProdutoBox2.Text);
                string ComandoSQL2 = $"UPDATE INFO SET PRECO = '{PrecoProduto}' WHERE COD_PRODUTO = {IDUsuario}";
                using (MySqlConnection Conexao = new MySqlConnection(StringDeConexao))
                {
                    Conexao.Open();
                    using (MySqlCommand Comando = new MySqlCommand(ComandoSQL2, Conexao))
                    {
                        Comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados editados com Sucesso");  


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar dados");
            }
        }

        private void BotaoAlterarQuantidade_Click(object sender, EventArgs e)
        {
            try
            {
                string server = "localhost";
                string database = "GerenciadorDeProdutos";
                string username = "root";
                string password = "Lorenzo05*";
                string StringDeConexao = $"server={server};database={database};uid={username};password={password}";
                string IDUsuario = CodProduto.Text;
                string QuantidadeEmEstoque = QuantidadeEmEstoqueBox2.Text;
                int QuantidadeEmEstoque1 = Convert.ToInt32(QuantidadeEmEstoqueBox2.Text);
                string ComandoSQL3 = $"UPDATE INFO SET QuantidadeEmEstoque = '{QuantidadeEmEstoque}' WHERE COD_PRODUTO = {IDUsuario}";
                using (MySqlConnection Conexao = new MySqlConnection(StringDeConexao))
                {
                    Conexao.Open();
                    using (MySqlCommand Comando = new MySqlCommand(ComandoSQL3, Conexao))
                    {
                        Comando.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados editados com Sucesso");


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar dados");
            }




        }
    }
}




