namespace Sistema_de_Gerenciamento_de_Produtos_Challenger
{
    partial class AdicionarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomeProdutoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrecoProdutoBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantidadeEstoqueBox = new System.Windows.Forms.TextBox();
            this.BotaoSalvarDados = new System.Windows.Forms.Button();
            this.BotaoLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CodigoDoProdutoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NomeProdutoBox
            // 
            this.NomeProdutoBox.Location = new System.Drawing.Point(215, 154);
            this.NomeProdutoBox.Name = "NomeProdutoBox";
            this.NomeProdutoBox.Size = new System.Drawing.Size(317, 20);
            this.NomeProdutoBox.TabIndex = 0;
            this.NomeProdutoBox.Leave += new System.EventHandler(this.NomeProdutoBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Preço";
            // 
            // PrecoProdutoBox
            // 
            this.PrecoProdutoBox.Location = new System.Drawing.Point(215, 241);
            this.PrecoProdutoBox.Name = "PrecoProdutoBox";
            this.PrecoProdutoBox.Size = new System.Drawing.Size(317, 20);
            this.PrecoProdutoBox.TabIndex = 3;
            this.PrecoProdutoBox.Leave += new System.EventHandler(this.PrecoProdutoBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade em Estoque";
            // 
            // QuantidadeEstoqueBox
            // 
            this.QuantidadeEstoqueBox.Location = new System.Drawing.Point(215, 341);
            this.QuantidadeEstoqueBox.Name = "QuantidadeEstoqueBox";
            this.QuantidadeEstoqueBox.Size = new System.Drawing.Size(317, 20);
            this.QuantidadeEstoqueBox.TabIndex = 5;
            this.QuantidadeEstoqueBox.Leave += new System.EventHandler(this.QuantidadeEstoqueBox_TextChanged);
            // 
            // BotaoSalvarDados
            // 
            this.BotaoSalvarDados.Location = new System.Drawing.Point(220, 387);
            this.BotaoSalvarDados.Name = "BotaoSalvarDados";
            this.BotaoSalvarDados.Size = new System.Drawing.Size(152, 40);
            this.BotaoSalvarDados.TabIndex = 6;
            this.BotaoSalvarDados.Text = "Salvar";
            this.BotaoSalvarDados.UseVisualStyleBackColor = true;
            this.BotaoSalvarDados.Click += new System.EventHandler(this.BotaoSalvarDados_Click);
            // 
            // BotaoLimpar
            // 
            this.BotaoLimpar.Location = new System.Drawing.Point(380, 387);
            this.BotaoLimpar.Name = "BotaoLimpar";
            this.BotaoLimpar.Size = new System.Drawing.Size(152, 40);
            this.BotaoLimpar.TabIndex = 7;
            this.BotaoLimpar.Text = "Limpar";
            this.BotaoLimpar.UseVisualStyleBackColor = true;
            this.BotaoLimpar.Click += new System.EventHandler(this.BotaoLimpar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(253, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Codigo do Produto";
            // 
            // CodigoDoProdutoBox
            // 
            this.CodigoDoProdutoBox.Location = new System.Drawing.Point(220, 68);
            this.CodigoDoProdutoBox.Name = "CodigoDoProdutoBox";
            this.CodigoDoProdutoBox.Size = new System.Drawing.Size(317, 20);
            this.CodigoDoProdutoBox.TabIndex = 9;
            this.CodigoDoProdutoBox.Leave += new System.EventHandler(this.CodigoDoProdutoBox_TextChanged);
            // 
            // AdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CodigoDoProdutoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BotaoLimpar);
            this.Controls.Add(this.BotaoSalvarDados);
            this.Controls.Add(this.QuantidadeEstoqueBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrecoProdutoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeProdutoBox);
            this.Name = "AdicionarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeProdutoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrecoProdutoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuantidadeEstoqueBox;
        private System.Windows.Forms.Button BotaoSalvarDados;
        private System.Windows.Forms.Button BotaoLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CodigoDoProdutoBox;
    }
}