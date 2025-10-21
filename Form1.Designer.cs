namespace Banco_de_dados_local_manualmente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCadastrarTabela = new Button();
            buttonTabelaProduto = new Button();
            buttonTabelaPedido = new Button();
            buttonTabelaVendedor = new Button();
            buttonTabelaItemPedido = new Button();
            buttonInserirCliente = new Button();
            buttonInserirVendedor = new Button();
            buttonInserirProduto = new Button();
            SuspendLayout();
            // 
            // buttonCadastrarTabela
            // 
            buttonCadastrarTabela.Location = new Point(63, 38);
            buttonCadastrarTabela.Name = "buttonCadastrarTabela";
            buttonCadastrarTabela.Size = new Size(192, 29);
            buttonCadastrarTabela.TabIndex = 0;
            buttonCadastrarTabela.Text = "Cadastrar Tabela Cliente";
            buttonCadastrarTabela.UseVisualStyleBackColor = true;
            buttonCadastrarTabela.Click += CadastrarTabela;
            // 
            // buttonTabelaProduto
            // 
            buttonTabelaProduto.Location = new Point(63, 73);
            buttonTabelaProduto.Name = "buttonTabelaProduto";
            buttonTabelaProduto.Size = new Size(172, 29);
            buttonTabelaProduto.TabIndex = 1;
            buttonTabelaProduto.Text = "Criar Tabela Produtos";
            buttonTabelaProduto.UseVisualStyleBackColor = true;
            buttonTabelaProduto.Click += TabelaProdutos;
            // 
            // buttonTabelaPedido
            // 
            buttonTabelaPedido.Location = new Point(63, 108);
            buttonTabelaPedido.Name = "buttonTabelaPedido";
            buttonTabelaPedido.Size = new Size(172, 29);
            buttonTabelaPedido.TabIndex = 2;
            buttonTabelaPedido.Text = "Criar Tabela Pedido";
            buttonTabelaPedido.UseVisualStyleBackColor = true;
            buttonTabelaPedido.Click += TabelaPedido;
            // 
            // buttonTabelaVendedor
            // 
            buttonTabelaVendedor.Location = new Point(63, 143);
            buttonTabelaVendedor.Name = "buttonTabelaVendedor";
            buttonTabelaVendedor.Size = new Size(172, 29);
            buttonTabelaVendedor.TabIndex = 3;
            buttonTabelaVendedor.Text = "Criar Tabela Vendedor";
            buttonTabelaVendedor.UseVisualStyleBackColor = true;
            buttonTabelaVendedor.Click += TabelaVendedor;
            // 
            // buttonTabelaItemPedido
            // 
            buttonTabelaItemPedido.Location = new Point(63, 178);
            buttonTabelaItemPedido.Name = "buttonTabelaItemPedido";
            buttonTabelaItemPedido.Size = new Size(192, 29);
            buttonTabelaItemPedido.TabIndex = 4;
            buttonTabelaItemPedido.Text = "Criar Tabela Item Pedido";
            buttonTabelaItemPedido.UseVisualStyleBackColor = true;
            buttonTabelaItemPedido.Click += TabelaItemPedido;
            // 
            // buttonInserirCliente
            // 
            buttonInserirCliente.Location = new Point(358, 38);
            buttonInserirCliente.Name = "buttonInserirCliente";
            buttonInserirCliente.Size = new Size(113, 29);
            buttonInserirCliente.TabIndex = 5;
            buttonInserirCliente.Text = "Inserir Cliente";
            buttonInserirCliente.UseVisualStyleBackColor = true;
            buttonInserirCliente.Click += InserirCliente;
            // 
            // buttonInserirVendedor
            // 
            buttonInserirVendedor.Location = new Point(358, 73);
            buttonInserirVendedor.Name = "buttonInserirVendedor";
            buttonInserirVendedor.Size = new Size(125, 29);
            buttonInserirVendedor.TabIndex = 6;
            buttonInserirVendedor.Text = "Inserir Vendedor";
            buttonInserirVendedor.UseVisualStyleBackColor = true;
            buttonInserirVendedor.Click += InserirVendedor;
            // 
            // buttonInserirProduto
            // 
            buttonInserirProduto.Location = new Point(358, 108);
            buttonInserirProduto.Name = "buttonInserirProduto";
            buttonInserirProduto.Size = new Size(125, 29);
            buttonInserirProduto.TabIndex = 7;
            buttonInserirProduto.Text = "Inserir Produto";
            buttonInserirProduto.UseVisualStyleBackColor = true;
            buttonInserirProduto.Click += InserirProduto;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInserirProduto);
            Controls.Add(buttonInserirVendedor);
            Controls.Add(buttonInserirCliente);
            Controls.Add(buttonTabelaItemPedido);
            Controls.Add(buttonTabelaVendedor);
            Controls.Add(buttonTabelaPedido);
            Controls.Add(buttonTabelaProduto);
            Controls.Add(buttonCadastrarTabela);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCadastrarTabela;
        private Button buttonTabelaProduto;
        private Button buttonTabelaPedido;
        private Button buttonTabelaVendedor;
        private Button buttonTabelaItemPedido;
        private Button buttonInserirCliente;
        private Button buttonInserirVendedor;
        private Button buttonInserirProduto;
    }
}