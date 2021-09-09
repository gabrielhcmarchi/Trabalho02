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


        //Model.Jogador player = new Model.Jogador();

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            List<string> palavra = new List<string>();

            bool verificaPalavra = true;

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


            //bool verificaPalavra = true;

            //string[,] m = new string[3, 3];

            //m[0, 0] = btn01.Text;
            //m[0, 1] = btn02.Text;
            //m[0, 2] = btn03.Text;
            //m[1, 0] = btn04.Text;
            //m[1, 1] = btn05.Text;
            //m[1, 2] = btn06.Text;
            //m[2, 0] = btn07.Text;
            //m[2, 1] = btn08.Text;
            //m[2, 2] = btn09.Text;

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
                dgInformacao.Rows.Add(txtProcura.Text, ContadorPontos(matriz, txtProcura.Text).ToString());
            }
            else if (verificaPalavra == false)
            {
                MessageBox.Show("Palavra ja existe");
            }

            int repete = RepeatedCharsString(txtProcura.Text);

            if (repete > 0)
            {
                MessageBox.Show("Letras repetidas");

            }

            MessageBox.Show(ContadorPontos(matriz, txtProcura.Text).ToString());
            txtProcura.Clear();
        }
        public static double ContadorPontos(string[][] matriz, string nu)
            {
                //cria variaveis utilizadas
                double points = 0;
                string numProcura = "";
                bool confere = false;

                for (int i = 0; i < matriz.Length; i++)
                {
                    for (int j = 0; j < matriz[i].Length; j++)
                    {
                        if (matriz[i][j] == nu[0].ToString())
                        {
                            //se o numero esta na metriz
                            confere = true;
                            //numProcura recebe o numero atual
                            numProcura = matriz[i][j];
                            //adiciona os pontos ao usuario
                            points += 0.5;
                            i = 20;
                            break;
                        }
                    }
                }

            //int repete = RepeatedCharsString(Form1.txtProcura.Text);

      

            //confere for true
            if (confere) //&& repete < 0)
                {
                    for (int k = 1; k < nu.Length; k++)// for do numero letra a conferir
                    {
                        for (int i = 0; i < matriz.Length; i++)//for matriz
                        {
                            for (int j = 0; j < matriz[i].Length; j++)//for matriz
                            {
                                if (matriz[i][j] == numProcura)//achar o numero atual na matriz
                                {
                                    List<string> lista = new List<string>();//lista de numeros adjacentes
                                    try//try catch que adiciona na lista os numeros adjacentes
                                    {
                                        lista.Add(matriz[i - 1][j - 1]);
                                    }
                                    catch (Exception)
                                    {
                                    }
                                    try
                                    {
                                        lista.Add(matriz[i][j - 1]);
                                    }
                                    catch (Exception)
                                    {
                                    }
                                    try
                                    {
                                        lista.Add(matriz[i - 1][j]);
                                    }
                                    catch (Exception)
                                    {
                                    }
                                    try
                                    {
                                        lista.Add(matriz[i + 1][j + 1]);
                                    }
                                    catch (Exception)
                                    {
                                    }
                                    try
                                    {
                                        lista.Add(matriz[i + 1][j - 1]);
                                    }
                                    catch (Exception)
                                    {
                                    }
                                    try
                                    {
                                        lista.Add(matriz[i - 1][j + 1]);
                                    }
                                    catch (Exception)
                                    {
                                    }
                                    try
                                    {
                                        lista.Add(matriz[i + 1][j]);
                                    }
                                    catch (Exception)
                                    {
                                    }
                                    try
                                    {
                                        lista.Add(matriz[i][j + 1]);
                                    }
                                    catch (Exception)
                                    {
                                    }

                                    int confNumerosProx = 0;
                                    bool teste2 = false;
                                    for (int l = 0; l < lista.Count; l++)//for que confere se o proximo numero esta na lista de numeros adjacentes
                                    {
                                        for (int m = k - 1; m > 0; m--)//for que confere numeros repetidos
                                        {
                                            if (nu[k] == nu[m])
                                            {
                                                teste2 = true;
                                                l = lista.Count - 1;
                                                break;
                                            }
                                        }

                                        if (nu[k].ToString() == lista[l] && teste2 == false)//confere se o proximo numero esta na lista de numeros adjacentes
                                        {
                                            confNumerosProx = 1;
                                            numProcura = lista[l];
                                        }
                                    }
                                    if (confNumerosProx == 1)//adciona os pontos
                                    {
                                        points += 0.5;
                                        i = 2;
                                        break;
                                    }
                                    else
                                    {
                                        i = 2;
                                        k = 20;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {

                }

                return Math.Floor(points);//retorna o numero arredondado para baixo
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
            dgInformacao.Rows.Clear();
        }
    }



}

