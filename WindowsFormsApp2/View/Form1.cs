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
            txtProcura.CharacterCasing = CharacterCasing.Upper;
        }

        List<string> palavra = new List<string>();
        int verifica = 0;

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            int repete = Control.Controller.LetraRepetida(txtProcura.Text);

            string[][] matriz = new string[3][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new string[3];
            }
            matriz[0][0] = btn01.Text;
            matriz[0][1] = btn02.Text;
            matriz[0][2] = btn03.Text;
            matriz[1][0] = btn04.Text;
            matriz[1][1] = btn05.Text;
            matriz[1][2] = btn06.Text;
            matriz[2][0] = btn07.Text;
            matriz[2][1] = btn08.Text;
            matriz[2][2] = btn09.Text;

            foreach (var item in palavra)
            {
                if (item == txtProcura.Text)
                {
                    verifica = 1;
                }
                if (repete > 0)
                {
                    MessageBox.Show("Letras repetidas");
                   
                    break;

                }
            }
            if (verifica == 0)
            {
                palavra.Add(txtProcura.Text);
                dgInformacao.Rows.Add(txtProcura.Text, Control.Controller.ContadorPontos(matriz, txtProcura.Text).ToString());
            }
            if (verifica == 1)
            {
                MessageBox.Show("Esta palavra já foi digitada");

            }
            txtProcura.Clear();
        }

        public int ValorTotal()
        {
            int total = 0;

            for (int i = 0; i < dgInformacao.Rows.Count; i++)
            {
                total += Convert.ToInt32(dgInformacao.Rows[i].Cells["PontosCol"].Value);
            }
            return total;
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
          
            MessageBox.Show("Pontuação Final: "+ ValorTotal().ToString());
            PreencheBotao();
            txtProcura.Clear();
            dgInformacao.Rows.Clear();
            palavra.Clear();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

