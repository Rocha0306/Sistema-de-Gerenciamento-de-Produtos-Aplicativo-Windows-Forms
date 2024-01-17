using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Dapper;
using MySql.Data.MySqlClient;

namespace Sistema_de_Gerenciamento_de_Produtos_Challenger
{
    public partial class ListagemDeProdutos : Form
    {

        public ListagemDeProdutos()
        {
            InitializeComponent();
            ListView.View = View.Details;
            ListView.GridLines = true;
            ListView.FullRowSelect = true;

            // Adicione colunas ao ListView
            ListView.Columns.Add("Codigo do Produto", 100);
            ListView.Columns.Add("Produto", 300);
            ListView.Columns.Add("Preco", 100);
            ListView.Columns.Add("Quantidade", 100);

           
        }

        private void BotaoMostrarDados_Click(object sender, EventArgs e)
        {
            try
            {
                string server = "localhost";
                string database = "gerenciadordeprodutos";
                string username = "root";
                string password = "Lorenzo05*";
                string StringDeConexao = $"server={server};database={database};uid={username};password={password}";
                string ComandoSQL = "SELECT * FROM INFO";

                using (MySqlConnection conn = new MySqlConnection(StringDeConexao))
                {
                    conn.Open();

                    using (MySqlCommand comando = new MySqlCommand(ComandoSQL, conn))
                    {
                        MySqlDataReader reader = comando.ExecuteReader(); 
                        ListView.Items.Clear(); 
                        while (reader.Read()) {
                            string[] row = {
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            };

                            var LinhasListView = new ListViewItem(row);
                            ListView.Items.Add(LinhasListView);
                        
                        }
                    }





                }

                
            }


            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca dos dados");

            }
        }
    }
}
