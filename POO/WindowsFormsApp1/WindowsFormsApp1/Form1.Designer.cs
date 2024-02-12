namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabTurmas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listarTurmas = new System.Windows.Forms.ListBox();
            this.listarDisciplinas = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabTurmas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.opçõesToolStripMenuItem.Text = "Fechar";
            // 
            // tabTurmas
            // 
            this.tabTurmas.Controls.Add(this.tabPage1);
            this.tabTurmas.Controls.Add(this.tabPage2);
            this.tabTurmas.Location = new System.Drawing.Point(0, 27);
            this.tabTurmas.Name = "tabTurmas";
            this.tabTurmas.SelectedIndex = 0;
            this.tabTurmas.Size = new System.Drawing.Size(788, 401);
            this.tabTurmas.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listarTurmas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Turmas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listarDisciplinas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unidades Curriculares";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listarTurmas
            // 
            this.listarTurmas.FormattingEnabled = true;
            this.listarTurmas.Location = new System.Drawing.Point(34, 30);
            this.listarTurmas.Name = "listarTurmas";
            this.listarTurmas.Size = new System.Drawing.Size(191, 303);
            this.listarTurmas.TabIndex = 0;
            // 
            // listarDisciplinas
            // 
            this.listarDisciplinas.FormattingEnabled = true;
            this.listarDisciplinas.Location = new System.Drawing.Point(22, 23);
            this.listarDisciplinas.Name = "listarDisciplinas";
            this.listarDisciplinas.Size = new System.Drawing.Size(193, 316);
            this.listarDisciplinas.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabTurmas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MENU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabTurmas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabTurmas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listarTurmas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listarDisciplinas;
    }
}

