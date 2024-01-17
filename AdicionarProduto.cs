using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sistema_de_Gerenciamento_de_Produtos_Challenger
{
    public partial class AdicionarProduto : Form
    {
        bool VerifyCodigo = false;
        bool VerifyNome = false;
        bool VerifyPreco = false;
        bool VerifyQuantidade = false;


        MySqlConnection Conexao; //Criação da Variavel de Conexao que irá armazenar informaçoes da Conexao
        // todos estao como textchanged mas na verdade são leave errei ai mudei nos eventos 

        public AdicionarProduto()
        {
            InitializeComponent();
        }

        private void NomeProdutoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecoProdutoBox_TextChanged(object sender, EventArgs e)
        {
            
            if(PrecoProdutoBox.Text.All(char.IsLetter))
            {
                VerifyPreco = true;
                MessageBox.Show("Só é permitido numeros nesse campo");
            }

        }

        private void QuantidadeEstoqueBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CodigoDoProdutoBox_TextChanged(object sender, EventArgs e)
        {
            if(CodigoDoProdutoBox.Text.All(char.IsLetter)) 
            {
                VerifyCodigo = true;
                MessageBox.Show("Só são permitidos numeros nesses campos");

            }
        }

      


        private void BotaoSalvarDados_Click(object sender, EventArgs e)
        {
            while (VerifyCodigo == true || VerifyNome == true || VerifyPreco == true || VerifyQuantidade == true)
            {
                MessageBox.Show("Dados inseridos de forma incorreta");
                Thread.Sleep(1000);
                if(VerifyCodigo == false && VerifyNome == false && VerifyPreco == false && VerifyQuantidade && false)
                {
                    break;
                }

            }
            try
            {
                string server = "localhost";
                string database = "gerenciadordeprodutos";
                string username = "root";
                string password = "Lorenzo05*";
                string StringDeConexao = $"server={server};database={database};uid={username};password={password}";
                string ComandoSQL = "INSERT INTO INFO(COD_PRODUTO, PRODUTO, PRECO, QuantidadeEmEstoque) VALUES (@Cod_Produto, @Produto, @Preco, @QuantidadeEmEstoque)";

                using (MySqlConnection conn = new MySqlConnection(StringDeConexao))
                {
                    conn.Open();

                using(MySqlCommand comando = new MySqlCommand(ComandoSQL, conn))
                    {
                        comando.Parameters.AddWithValue("@Cod_Produto", CodigoDoProdutoBox.Text);
                        comando.Parameters.AddWithValue("@Produto", NomeProdutoBox.Text);
                        comando.Parameters.AddWithValue("@Preco", PrecoProdutoBox.Text);
                        comando.Parameters.AddWithValue("@QuantidadeEmEstoque", QuantidadeEstoqueBox.Text);
                        comando.ExecuteNonQuery();
                    }

                    



                }

                MessageBox.Show("Dados inseridos com sucesso");
            } 
            
            
            catch(Exception ex) {
                MessageBox.Show("Erro na hora de salvar os dados, tente novamente");
            
            }

        }

        private void BotaoLimpar_Click(object sender, EventArgs e)
        {
            CodigoDoProdutoBox.Text = string.Empty;
            NomeProdutoBox.Text = string.Empty;
            PrecoProdutoBox.Text = string.Empty;
            QuantidadeEstoqueBox.Text = string.Empty;
        }

        
    }
}
