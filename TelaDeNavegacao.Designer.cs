namespace Sistema_de_Gerenciamento_de_Produtos_Challenger
{
    partial class TelaDeNavegação
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeNavegação));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizaçãoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeProdutosToolStripMenuItem,
            this.listagemDeProdutosToolStripMenuItem,
            this.atualizaçãoDeProdutosToolStripMenuItem,
            this.eToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // listagemDeProdutosToolStripMenuItem
            // 
            this.listagemDeProdutosToolStripMenuItem.Name = "listagemDeProdutosToolStripMenuItem";
            this.listagemDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.listagemDeProdutosToolStripMenuItem.Text = "Listagem de Produtos";
            this.listagemDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.listagemDeProdutosToolStripMenuItem_Click);
            // 
            // atualizaçãoDeProdutosToolStripMenuItem
            // 
            this.atualizaçãoDeProdutosToolStripMenuItem.Name = "atualizaçãoDeProdutosToolStripMenuItem";
            this.atualizaçãoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.atualizaçãoDeProdutosToolStripMenuItem.Text = "Atualização de Produtos";
            this.atualizaçãoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.atualizaçãoDeProdutosToolStripMenuItem_Click);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.eToolStripMenuItem.Text = "Exclusão de Produtos";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // TelaDeNavegação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaDeNavegação";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gerenciamento de Produtos";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizaçãoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
    }
}

