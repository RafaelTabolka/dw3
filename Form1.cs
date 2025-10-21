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

        private void InserirCliente(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Acer\\Documents\\Projetos\\DW\\aula03\\Banco-Atividade-VictorPortolani\\DatabaseLoja.mdf;Integrated Security=True";
            string stringDeComando = @"
                INSERT INTO Cliente (Nome_cliente, Endereco, Cidade, CEP, UF)
                VALUES 
                ('Victor Portolani', 'Avenida das Flores', 'Matão', '14910-000', 'SP'),
                ('Evelyn Yasmin', 'Rua Tabatinga', 'Tabatinga', '14910-000', 'SP'),
                ('Joaquim dos Santos', 'Rua Matonense', 'Matão', '14910-000', 'SP'),
                ('Vitoria Costa Cardoso', 'Rua Matonense', 'Matão', '14910-000', 'SP')";//pode alterar o valor do cliente aqui
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                MessageBox.Show("Clientes inserido com sucesso.");
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao inserir cliente, verefique se os campos não nulos estão preenchidos ou se a tabela existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void InserirVendedor(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Acer\\Documents\\Projetos\\DW\\aula03\\Banco-Atividade-VictorPortolani\\DatabaseLoja.mdf;Integrated Security=True";
            string stringDeComando = @"
                INSERT INTO Vendedor (Nome_vendedor, Faixa_comissao, Salario_fixo)
                VALUES 
                ('Victor Portolani', 1200, 3453.67),
                ('João', 1200, 3453.67),
                ('Maria', 1200, 3453.67)";//pode alterar o valor do vendedor aqui
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                MessageBox.Show("Vendedor inserido com sucesso.");
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao inserir vendedor, verefique se os campos não nulos estão preenchidos ou se a tabela existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }

        private void InserirProduto(object sender, EventArgs e)
        {
            string stringDeConexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Acer\\Documents\\Projetos\\DW\\aula03\\Banco-Atividade-VictorPortolani\\DatabaseLoja.mdf;Integrated Security=True";
            string stringDeComando = @"
                INSERT INTO Produto (Descricao, Endereco, Unidade, Valor_unitario)
                VALUES 
                ('Arroz Branco Tipo 1', 'Matão', 'Kg', 6.49),
                ('Feijão Carioca', 'Tabatinga', 'Kg', 7.29),
                ('Óleo de Soja', 'Matão', 'L', 5.89),
                ('Açúcar Refinado', 'Araraquara', 'Kg', 4.59),
                ('Café Torrado e Moído', 'Matão', 'Kg', 18.90),
                ('Macarrão Espaguete', 'Tabatinga', 'Kg', 4.79),
                ('Leite Integral', 'Matão', 'L', 5.49),
                ('Farinha de Trigo', 'Araraquara', 'Kg', 5.29),
                ('Sal Refinado', 'Matão', 'Kg', 2.99),
                ('Detergente Líquido', 'Tabatinga', 'Un', 2.49)";//pode alterar o valor do produto aqui. Observação: eu pedi para a IA gerar valores aleatórios
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(stringDeConexao);
                SqlCommand sqlCommand = new SqlCommand(stringDeComando, con);
                MessageBox.Show("Produto inserido com sucesso.");
                con.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao inserir produto, verefique se os campos não nulos estão preenchidos ou se a tabela existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
    }
}