namespace Sistema_de_Gerenciamento_de_Produtos_Challenger
{
    partial class ListagemDeProdutos
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
            this.ListView = new System.Windows.Forms.ListView();
            this.BotaoMostrarDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListView
            // 
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(100, 12);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(594, 322);
            this.ListView.TabIndex = 0;
            this.ListView.UseCompatibleStateImageBehavior = false;
            // 
            // BotaoMostrarDados
            // 
            this.BotaoMostrarDados.Location = new System.Drawing.Point(312, 365);
            this.BotaoMostrarDados.Name = "BotaoMostrarDados";
            this.BotaoMostrarDados.Size = new System.Drawing.Size(152, 42);
            this.BotaoMostrarDados.TabIndex = 1;
            this.BotaoMostrarDados.Text = "Mostrar Dados";
            this.BotaoMostrarDados.UseVisualStyleBackColor = true;
            this.BotaoMostrarDados.Click += new System.EventHandler(this.BotaoMostrarDados_Click);
            // 
            // ListagemDeProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotaoMostrarDados);
            this.Controls.Add(this.ListView);
            this.Name = "ListagemDeProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListagemDeProdutos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.Button BotaoMostrarDados;
    }
}