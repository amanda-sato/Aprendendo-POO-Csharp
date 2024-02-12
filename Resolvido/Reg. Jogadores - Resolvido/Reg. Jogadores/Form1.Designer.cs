namespace Reg.Jogadores
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegJogador = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTopScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarJogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médiaIdadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.melhorPontuaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maisNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // buttonRegJogador
            // 
            this.buttonRegJogador.Location = new System.Drawing.Point(22, 165);
            this.buttonRegJogador.Name = "buttonRegJogador";
            this.buttonRegJogador.Size = new System.Drawing.Size(165, 23);
            this.buttonRegJogador.TabIndex = 1;
            this.buttonRegJogador.Text = "Registar Jogador";
            this.buttonRegJogador.UseVisualStyleBackColor = true;
            this.buttonRegJogador.Click += new System.EventHandler(this.buttonRegJogador_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(80, 44);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(80, 70);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(80, 96);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdade.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Idade:";
            // 
            // textBoxTopScore
            // 
            this.textBoxTopScore.Location = new System.Drawing.Point(80, 122);
            this.textBoxTopScore.Name = "textBoxTopScore";
            this.textBoxTopScore.Size = new System.Drawing.Size(100, 20);
            this.textBoxTopScore.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Top Score:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(209, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(168, 238);
            this.listBox1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(392, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registarJogadorToolStripMenuItem,
            this.médiaIdadesToolStripMenuItem,
            this.melhorPontuaçãoToolStripMenuItem,
            this.fecharToolStripMenuItem,
            this.top5ToolStripMenuItem,
            this.maisNovoToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // registarJogadorToolStripMenuItem
            // 
            this.registarJogadorToolStripMenuItem.Name = "registarJogadorToolStripMenuItem";
            this.registarJogadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registarJogadorToolStripMenuItem.Text = "Registar Jogador";
            this.registarJogadorToolStripMenuItem.Click += new System.EventHandler(this.registarJogadorToolStripMenuItem_Click);
            // 
            // médiaIdadesToolStripMenuItem
            // 
            this.médiaIdadesToolStripMenuItem.Name = "médiaIdadesToolStripMenuItem";
            this.médiaIdadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.médiaIdadesToolStripMenuItem.Text = "Média Idades";
            this.médiaIdadesToolStripMenuItem.Click += new System.EventHandler(this.médiaIdadesToolStripMenuItem_Click);
            // 
            // melhorPontuaçãoToolStripMenuItem
            // 
            this.melhorPontuaçãoToolStripMenuItem.Name = "melhorPontuaçãoToolStripMenuItem";
            this.melhorPontuaçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.melhorPontuaçãoToolStripMenuItem.Text = "Melhor Pontuação";
            this.melhorPontuaçãoToolStripMenuItem.Click += new System.EventHandler(this.melhorPontuaçãoToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // top5ToolStripMenuItem
            // 
            this.top5ToolStripMenuItem.Name = "top5ToolStripMenuItem";
            this.top5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.top5ToolStripMenuItem.Text = "Top 5";
            // 
            // maisNovoToolStripMenuItem
            // 
            this.maisNovoToolStripMenuItem.Name = "maisNovoToolStripMenuItem";
            this.maisNovoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maisNovoToolStripMenuItem.Text = "Mais Novo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 297);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxTopScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonRegJogador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Reg. Jogadores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegJogador;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTopScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registarJogadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médiaIdadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem melhorPontuaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maisNovoToolStripMenuItem;
    }
}

