using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg.Jogadores
{
    internal class Jogador
    {
        private string nome;
        private string email;
        private int idade;
        private int topScore;

        public Jogador() 
        {
            nome = "";
            email = "";
            idade = 0;
            topScore = 0;
        }
        public Jogador(string nome, string email, int idade, int topScore)
        {
            this.nome = nome;
            this.email = email;
            this.idade = idade;
            this.topScore = topScore;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetEmail()
        {
            return email;
        }
        public int GetIdade()
        {
            return idade;
        }
        public int GetTopScore()
        {
            return topScore;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        public void SetTopScore(int topScore)
        {
            this.topScore = topScore;
        }
        public override string ToString()
        {
            return nome + ": " + topScore + " pontos";
        }
    }
}
