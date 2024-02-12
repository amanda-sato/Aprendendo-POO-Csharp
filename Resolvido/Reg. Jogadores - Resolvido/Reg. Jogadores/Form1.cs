using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg.Jogadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Jogador("António", "a@gmail.com", 15, 100));
            listBox1.Items.Add(new Jogador("Daniela", "d@gmail.com", 18, 90));
            listBox1.Items.Add(new Jogador("Rodrigo", "r@gmail.com", 20, 50));
            listBox1.Items.Add(new Jogador("João", "j@gmail.com", 26, 85));
            listBox1.Items.Add(new Jogador("Sandra", "s@gmail.com", 22, 120));
        }

        private void buttonRegJogador_Click(object sender, EventArgs e)
        {
            Jogador j  = new Jogador();

            j.SetNome(textBoxNome.Text);
            j.SetEmail(textBoxEmail.Text);
            j.SetIdade(int.Parse(textBoxIdade.Text));
            j.SetTopScore(int.Parse(textBoxTopScore.Text));

            listBox1.Items.Add(j);
        }

        private void registarJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonRegJogador.PerformClick();
        }

        private void médiaIdadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double media = 0, soma = 0;

            foreach(Jogador j in listBox1.Items)
            {
                soma += j.GetIdade();
            }

            media = soma/listBox1.Items.Count;

            MessageBox.Show("Media de idades: " + media, "Média");
        }

        private void melhorPontuaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int max = int.MinValue;
            Jogador jMax = new Jogador();

            foreach(Jogador j in listBox1.Items)
            {
                if(j.GetTopScore() > max)
                {
                    max = j.GetTopScore();
                    jMax = j;
                }
            }
            MessageBox.Show("Nome: " + jMax.GetNome() + "\nPontuação: " + max, "Melhor Pontuação");

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
