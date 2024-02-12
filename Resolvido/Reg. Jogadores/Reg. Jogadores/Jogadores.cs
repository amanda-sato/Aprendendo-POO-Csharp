using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reg.Jogadores
{
    internal class Jogador
    { //criação de atributos da classe
        private string nome;
        private string email;
        private int idade;
        private int topScore;

        public Jogador() // const. por defeito (já se inicializa com os parâmetros)
        {
            nome = "";
            email = "";
            idade = 0;
            topScore = 0;
        }

        public Jogador(string nome, string email, int idade, int topScore) //const. por parâmetros
        {
            this.nome = nome;
            this.email = email;
            this.idade = idade;
            this.topScore = topScore;
        }


        //todos os sets
        public void setNome(string nome) // o método set sempre precisa ser void e sempre precisa por dentro dos parâmetros da função o tipo e o nome
        {
            this.nome = nome;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public void setTopScore(int topScore)
        {
            this.topScore = topScore;
        }


        //todos os gets
        public string getNome()
        {
            return nome;
        }

        public string getEmail()
        {
            return email;
        }

        public int getIdade()
        {
            return idade;
        }

        public int getTopScore()
        {
            return topScore;
        }

        public override string ToString()
        {
            return nome + ": " + topScore + " pontos";        
        }
    }
}
