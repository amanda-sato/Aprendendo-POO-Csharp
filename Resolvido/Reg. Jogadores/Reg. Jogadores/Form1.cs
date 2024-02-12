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

        private void buttonRegJogador_Click(object sender, EventArgs e) // add os dados dos jogadores numa instância da classe Jogador();
        {
            try 
            {
                Jogador jogador = new Jogador(); //cria uma instância da classe Jogador
                    
                 string nome = textBoxNome.Text; //lembrar de add todos ao textBox correspondente a cada informação necessária
                 string email = textBoxEmail.Text;
                 int idade = int.Parse(textBoxIdade.Text); //lembrar que ele são salvos como string, então tem que usar a função parse().
                 int topScore = int.Parse(textBoxTopScore.Text); 

                 jogador.setNome(nome); // adiciona todas essas informações à nova instância criada
                 jogador.setEmail(email);
                 jogador.setIdade(idade);
                 jogador.setTopScore(topScore);

                 listBox1.Items.Add(jogador); // add a nova instância criada, junto com suas informações add, À listBox

            } 
            
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void registrarJogadorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            buttonRegJogador.PerformClick(); // ele clica no botão de registrar jogadores
        }

        private void médiaIdadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double media = 0, soma = 0;

            foreach(Jogador jogador in listBox1.Items) // aqui se adiciona todas as qnts de idade de cada jogador a variável
            {
                soma += jogador.getIdade();
            }

            media = soma/listBox1.Items.Count; // o método count serve para contar qnts elementos tem na listbox

            MessageBox.Show($"Média das idades: {media} Média");
        }

        private void melhorPontuaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int max = int.MinValue;
            Jogador jMax = new Jogador();

            foreach(Jogador jogador in listBox1.Items)
            {
                if(jogador.getTopScore() > max)
                {
                    max = jogador.getTopScore();
                    jMax = jogador;
                }
            }
            MessageBox.Show($"Melhor pontuação: \nNome: {jMax.getNome()} \nPontuação: {max}");

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ///////////////////////////////////////////////////////
        //     Teste Linguagens de Programação 2017/2018     //
        ///////////////////////////////////////////////////////



    }
}
