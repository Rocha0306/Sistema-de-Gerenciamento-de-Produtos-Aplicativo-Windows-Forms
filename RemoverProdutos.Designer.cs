namespace Sistema_de_Gerenciamento_de_Produtos_Challenger
{
    partial class RemoverProdutos
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
            this.label4 = new System.Windows.Forms.Label();
            this.CodProdutoBox = new System.Windows.Forms.TextBox();
            this.BotaoExcluirDados = new System.Windows.Forms.Button();
            this.BotaoVerDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Digite o codigo do produto";
            // 
            // CodProdutoBox
            // 
            this.CodProdutoBox.Location = new System.Drawing.Point(311, 112);
            this.CodProdutoBox.Name = "CodProdutoBox";
            this.CodProdutoBox.Size = new System.Drawing.Size(122, 20);
            this.CodProdutoBox.TabIndex = 10;
            // 
            // BotaoExcluirDados
            // 
            this.BotaoExcluirDados.Location = new System.Drawing.Point(205, 217);
            this.BotaoExcluirDados.Name = "BotaoExcluirDados";
            this.BotaoExcluirDados.Size = new System.Drawing.Size(151, 35);
            this.BotaoExcluirDados.TabIndex = 11;
            this.BotaoExcluirDados.Text = "Excluir";
            this.BotaoExcluirDados.UseVisualStyleBackColor = true;
            this.BotaoExcluirDados.Click += new System.EventHandler(this.BotaoExcluirDados_Click);
            // 
            // BotaoVerDados
            // 
            this.BotaoVerDados.Location = new System.Drawing.Point(399, 217);
            this.BotaoVerDados.Name = "BotaoVerDados";
            this.BotaoVerDados.Size = new System.Drawing.Size(148, 35);
            this.BotaoVerDados.TabIndex = 12;
            this.BotaoVerDados.Text = "Visualizar Dados";
            this.BotaoVerDados.UseVisualStyleBackColor = true;
            this.BotaoVerDados.Click += new System.EventHandler(this.BotaoVerDados_Click);
            // 
            // RemoverProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotaoVerDados);
            this.Controls.Add(this.BotaoExcluirDados);
            this.Controls.Add(this.CodProdutoBox);
            this.Controls.Add(this.label4);
            this.Name = "RemoverProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoverProdutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CodProdutoBox;
        private System.Windows.Forms.Button BotaoExcluirDados;
        private System.Windows.Forms.Button BotaoVerDados;
    }
}