using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelhaTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            var campo1 = textBox1.Text;
            var campo2 = textBox2.Text;
            var campo3 = textBox3.Text;
            var campo4 = textBox4.Text;
            var campo5 = textBox5.Text;
            var campo6 = textBox6.Text;
            var campo7 = textBox7.Text;
            var campo8 = textBox8.Text;
            var campo9 = textBox9.Text;

            // Campos O

            var primeiraLinhaBolinhaHoriz = campo1+ campo2 + campo3;
            var segundaLinhaBolinhaHoriz = campo4 + campo5 + campo6;
            var terceiraLinhaBolinhaHoriz = campo7 + campo8 + campo9;

            var primeiraLinhaBolinhaVert = campo1 + campo4 + campo7;
            var segundaLinhaBolinhaVert = campo2 + campo5 + campo8;
            var terceiraLinhaBolinhaVert = campo3 + campo6 + campo9;

            var diagonalBolinhaDireitapEsquerda = campo1 + campo5 + campo9;
            var diagonalBolinhaEsquerdapDireita = campo3 + campo5 + campo7;

            // Campos X

            var primeiraLinhaXHoriz = campo1 + campo2 + campo3;
            var segundaLinhaXHoriz = campo4 + campo5 + campo6;
            var terceiraLinhaXHoriz = campo7 + campo8 + campo9;

            var primeiraLinhaXVert = campo1 + campo4 + campo7;
            var segundaLinhaXVert = campo2 + campo5 + campo8;
            var terceiraLinhaXVert = campo3 + campo6 + campo9;

            var diagonalXDireitapEsquerda = campo1 + campo5 + campo9;
            var diagonalXEsquerdapDireita = campo3 + campo5 + campo7;

            var x = "xxx";
            var o = "ooo";

            if (primeiraLinhaBolinhaHoriz == o || segundaLinhaBolinhaHoriz == o || terceiraLinhaBolinhaHoriz == o)
                MessageBox.Show("VITÓRIA do jogador com 'O'");

            else if (primeiraLinhaBolinhaVert == o || segundaLinhaBolinhaVert == o || terceiraLinhaBolinhaVert == o)
                MessageBox.Show("VITÓRIA do jogador com 'O'");

            else if (diagonalBolinhaDireitapEsquerda == o || diagonalBolinhaEsquerdapDireita == o)
                MessageBox.Show("VITÓRIA do jogador com 'O'");

            else if (primeiraLinhaXHoriz == x || segundaLinhaXHoriz == x|| terceiraLinhaXHoriz == x)
                MessageBox.Show("VITÓRIA do jogador com 'X'");

            else if (primeiraLinhaXVert == x || segundaLinhaXVert == x || terceiraLinhaXVert == x)
                MessageBox.Show("VITÓRIA do jogador com 'X'");

            else if (diagonalXDireitapEsquerda == x|| diagonalXEsquerdapDireita == x)
                MessageBox.Show("VITÓRIA do jogador com 'X'");

            else if (campo1 == "" || campo2 == "" || campo3 == "" || campo4 == "" || campo5 == "" || 
                campo6 == "" || campo7 == "" || campo8 == "" || campo9 == "")
                MessageBox.Show("Campos não totalmente preenchidos");
            else
                MessageBox.Show("Jogo deu empate");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }
    }
}
