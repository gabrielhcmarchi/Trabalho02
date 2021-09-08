using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencheBotao();
        }


            List<string> palavra = new List<string>();
            Model.Jogador player = new Model.Jogador();

        private void btnProcurar_Click(object sender, EventArgs e)
        {

            bool verificaPalavra = true;

            string[,] m = new string[3, 3];

            m[0, 0] = btn01.Text;
            m[0, 1] = btn02.Text;
            m[0, 2] = btn03.Text;
            m[1, 0] = btn04.Text;
            m[1, 1] = btn05.Text;
            m[1, 2] = btn06.Text;
            m[2, 0] = btn07.Text;
            m[2, 1] = btn08.Text;
            m[2, 2] = btn09.Text;

            foreach (var item in palavra)
            {
                if (item == txtProcura.Text)
                {
                    verificaPalavra = false;
                }
            }
            if (verificaPalavra == true)
            {
                palavra.Add(txtProcura.Text);
                dgInformacao.Rows.Add(txtProcura.Text);
            }
            else if (verificaPalavra == false)
            {
                MessageBox.Show("Palavra ja existe");
            }

            int repete = RepeatedCharsString(txtProcura.Text);

            if(repete > 0) 
            {
                MessageBox.Show("Letras repetidas");
            }

        }
       
        
       
        public static int RepeatedCharsString(string x)
        {
            string str = x;
            int n = str.Length;
            string dupstr = "";
            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (str[i] == str[j])
                    {
                        dupstr = dupstr + str[i];
                        cnt ++;
                    }
                }
            }
            return cnt;
        }
        public void PreencheBotao()
        {
            btn01.Text = Model.Generator.GeraLetras("A", "D");
            btn02.Text = Model.Generator.GeraLetras("E", "F");
            btn03.Text = Model.Generator.GeraLetras("B", "C");
            btn04.Text = Model.Generator.GeraLetra2("G", "I", "U");
            btn05.Text = Model.Generator.GeraLetra2("H", "J", "V");
            btn06.Text = Model.Generator.GeraLetras("K", "L");
            btn07.Text = Model.Generator.GeraLetra2("M", "O", "Q");
            btn08.Text = Model.Generator.GeraLetra2("N", "T", "P");
            btn09.Text = Model.Generator.GeraLetra2("R", "S", "Z");
        }

        private void btnRandomTabela_Click(object sender, EventArgs e)
        {
            PreencheBotao();
            txtProcura.Clear();
        }
    }



}

