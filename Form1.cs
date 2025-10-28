using System.Data;
using System.Data.SqlClient;

namespace Banco_de_dados_local_manualmente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CadastrarTabela(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Acer\\Documents\\Projetos\\DW\\aula03\\Banco-Atividade-VictorPortolani\\DatabaseLoja.mdf;Integrated Security=True";
            string stringDeComando = "CREATE TABLE Cliente (Cod_cliente int NOT NULL IDENTITY PRIMARY KEY, Nome_Cliente nchar(100) NOT NULL, Endereco nchar(200), Cidade nchar(100), CEP nchar(9), UF nchar(2))";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                MessageBox.Show("Tabela Criada com sucesso.");
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Criar Tabela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void TabelaProdutos(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Acer\\Documents\\Projetos\\DW\\aula03\\Banco-Atividade-VictorPortolani\\DatabaseLoja.mdf;Integrated Security=True";
            string stringDeComando = "CREATE TABLE Produto (Cod_produto int NOT NULL IDENTITY PRIMARY KEY, Descricao nchar(200), Endereco nchar(200), Unidade char(2) NOT NULL, Valor_unitario money NOT NULL )";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                MessageBox.Show("Tabela Criada com sucesso.");
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Criar Tabela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void TabelaPedido(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Acer\\Documents\\Projetos\\DW\\aula03\\Banco-Atividade-VictorPortolani\\DatabaseLoja.mdf;Integrated Security=True";
            string stringDeComando = "CREATE TABLE Pedido (Num_Pedido int NOT NULL IDENTITY PRIMARY KEY,Prazo_entrega date NOT NULL, Cod_cliente int NOT NULL REFERENCES Cliente(Cod_cliente), Cod_vendedor int NOT NULL REFERENCES Vendedor(Cod_vendedor))";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                MessageBox.Show("Tabela Criada com sucesso.");
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Criar Tabela, verefique se tem a tabela cliente e a tabela vendedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void TabelaVendedor(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Acer\\Documents\\Projetos\\DW\\aula03\\Banco-Atividade-VictorPortolani\\DatabaseLoja.mdf;Integrated Security=True";
            string stringDeComando = "CREATE TABLE Vendedor (Cod_vendedor int NOT NULL IDENTITY PRIMARY KEY, Nome_vendedor nchar(100), Faixa_comissao money, Salario_fixo money)";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                MessageBox.Show("Tabela Criada com sucesso.");
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Criar Tabela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void TabelaItemPedido(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Acer\\Documents\\Projetos\\DW\\aula03\\Banco-Atividade-VictorPortolani\\DatabaseLoja.mdf;Integrated Security=True";
            string stringDeComando = "CREATE TABLE Item_Pedido (Num_pedido int NOT NULL REFERENCES Pedido(Num_pedido), Cod_produto int NOT NULL REFERENCES Produto(Cod_produto), Quantidade int NOT NULL, PRIMARY KEY(Num_pedido, Cod_produto))";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                MessageBox.Show("Tabela Criada com sucesso.");
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao Criar Tabela, verefique se tem a tabela pedido e a tabela produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
    }
}