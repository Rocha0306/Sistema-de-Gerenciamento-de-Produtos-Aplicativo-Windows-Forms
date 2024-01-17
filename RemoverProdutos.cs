using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_de_Gerenciamento_de_Produtos_Challenger
{
    public partial class RemoverProdutos : Form
    {
        public RemoverProdutos()
        {
            MySqlConnection Conexao; 
            InitializeComponent();
        }

        private void BotaoExcluirDados_Click(object sender, EventArgs e)
        {
            try
            {
                string server = "localhost";
                string database = "GerenciadorDeProdutos";
                string username = "root";
                string password = "Lorenzo05*";
                string StringDeConexao = $"server={server};database={database};uid={username};password={password}";
                string IDUsuario = CodProdutoBox.Text.ToString();
                string ComandoSQL = $"DELETE FROM INFO WHERE COD_PRODUTO={IDUsuario}";

                using (MySqlConnection Conexao = new MySqlConnection(StringDeConexao))
                {
                    Conexao.Open();

                    using (MySqlCommand Comando = new MySqlCommand(ComandoSQL, Conexao))
                    {
                        Comando.ExecuteNonQuery();
                    }
                    MessageBox.Show("Dados deletados com sucesso");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao deletar dados");
            }
                }

        private void BotaoVerDados_Click(object sender, EventArgs e)
        {
            ListagemDeProdutos abrir = new ListagemDeProdutos();    
            abrir.ShowDialog();

        }
    }
        }
 
