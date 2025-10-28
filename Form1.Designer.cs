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
            SuspendLayout();
            // 
            // buttonCadastrarTabela
            // 
            buttonCadastrarTabela.Location = new Point(55, 28);
            buttonCadastrarTabela.Margin = new Padding(3, 2, 3, 2);
            buttonCadastrarTabela.Name = "buttonCadastrarTabela";
            buttonCadastrarTabela.Size = new Size(168, 22);
            buttonCadastrarTabela.TabIndex = 0;
            buttonCadastrarTabela.Text = "Cadastrar Tabela Cliente";
            buttonCadastrarTabela.UseVisualStyleBackColor = true;
            buttonCadastrarTabela.Click += CadastrarTabela;
            // 
            // buttonTabelaProduto
            // 
            buttonTabelaProduto.Location = new Point(55, 55);
            buttonTabelaProduto.Margin = new Padding(3, 2, 3, 2);
            buttonTabelaProduto.Name = "buttonTabelaProduto";
            buttonTabelaProduto.Size = new Size(150, 22);
            buttonTabelaProduto.TabIndex = 1;
            buttonTabelaProduto.Text = "Criar Tabela Produtos";
            buttonTabelaProduto.UseVisualStyleBackColor = true;
            buttonTabelaProduto.Click += TabelaProdutos;
            // 
            // buttonTabelaPedido
            // 
            buttonTabelaPedido.Location = new Point(55, 81);
            buttonTabelaPedido.Margin = new Padding(3, 2, 3, 2);
            buttonTabelaPedido.Name = "buttonTabelaPedido";
            buttonTabelaPedido.Size = new Size(150, 22);
            buttonTabelaPedido.TabIndex = 2;
            buttonTabelaPedido.Text = "Criar Tabela Pedido";
            buttonTabelaPedido.UseVisualStyleBackColor = true;
            buttonTabelaPedido.Click += TabelaPedido;
            // 
            // buttonTabelaVendedor
            // 
            buttonTabelaVendedor.Location = new Point(55, 107);
            buttonTabelaVendedor.Margin = new Padding(3, 2, 3, 2);
            buttonTabelaVendedor.Name = "buttonTabelaVendedor";
            buttonTabelaVendedor.Size = new Size(150, 22);
            buttonTabelaVendedor.TabIndex = 3;
            buttonTabelaVendedor.Text = "Criar Tabela Vendedor";
            buttonTabelaVendedor.UseVisualStyleBackColor = true;
            buttonTabelaVendedor.Click += TabelaVendedor;
            // 
            // buttonTabelaItemPedido
            // 
            buttonTabelaItemPedido.Location = new Point(55, 134);
            buttonTabelaItemPedido.Margin = new Padding(3, 2, 3, 2);
            buttonTabelaItemPedido.Name = "buttonTabelaItemPedido";
            buttonTabelaItemPedido.Size = new Size(168, 22);
            buttonTabelaItemPedido.TabIndex = 4;
            buttonTabelaItemPedido.Text = "Criar Tabela Item Pedido";
            buttonTabelaItemPedido.UseVisualStyleBackColor = true;
            buttonTabelaItemPedido.Click += TabelaItemPedido;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonTabelaItemPedido);
            Controls.Add(buttonTabelaVendedor);
            Controls.Add(buttonTabelaPedido);
            Controls.Add(buttonTabelaProduto);
            Controls.Add(buttonCadastrarTabela);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}