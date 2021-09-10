using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp2.Control
{

    class Controller
    {
        public static double ContadorPontos(string[][] matriz, string nu)
        {
            double points = 0;
            string numProcura = "";
            bool confere = false;

            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    if (matriz[i][j] == nu[0].ToString())
                    {

                        confere = true;
                        numProcura = matriz[i][j];
                        points += 0.5;
                        i = 20;
                        break;
                    }
                }
            }

            if (confere)
            {
                for (int k = 1; k < nu.Length; k++)
                {
                    for (int i = 0; i < matriz.Length; i++)
                    {
                        for (int j = 0; j < matriz[i].Length; j++)
                        {
                            if (matriz[i][j] == numProcura)
                            {
                                List<string> lista = new List<string>();
                                try
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
                                for (int l = 0; l < lista.Count; l++)
                                {
                                    for (int m = k - 1; m > 0; m--)
                                    {
                                        if (nu[k] == nu[m])
                                        {
                                            teste2 = true;
                                            l = lista.Count - 1;
                                            break;
                                        }
                                    }

                                    if (nu[k].ToString() == lista[l] && teste2 == false)
                                    {
                                        confNumerosProx = 1;
                                        numProcura = lista[l];
                                    }
                                }
                                if (confNumerosProx == 1)
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

            return Math.Floor(points);
        }
        public static int LetraRepetida(string x)
        {
            string letra = x;
            int n = letra.Length;
            string letraDuplicada = "";
            int contador = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (letra[i] == letra[j])
                    {
                        letraDuplicada += letra[i];
                        contador++;
                    }
                }
            }
            return contador;
        }
    }
}


