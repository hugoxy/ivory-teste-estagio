using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_02___IVORYIT
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "";
            //Linhas.
            int l = 3;
            //Colunas.
            int c = 0;
            int e = 0;

            int aux = 1;
            int aux2 = 0;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            //Valida tamanho da matriz de acordo com o tamanho do nome.
            c = nome.Count() + 2;
            e = c + c + 1;

            //Cria matriz.
            string[,] matriz = new string[l, c];



            //Preencher matriz.
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    //Preenche primeira linha.
                    if (i == 0)
                    {
                        matriz[i, j] = (Convert.ToString(aux++));
                    }
                    //Preenche segunda linha.
                    else if (i == 1 && j < c)
                    {
                        //Preenche ultimo numero da segunda linha.
                        if (j == c - 1)
                        {
                            matriz[i, j] = (Convert.ToString(c + 1));
                        }
                        //Preenche primeiro numero da segunda linha.
                        else if (j == 0)
                        {
                            matriz[i, j] = (Convert.ToString(e + 1));
                        }
                        //Preenche o nome no centro da segunda linha.
                        else if (j < c && aux2 < c - 2)
                        {
                            matriz[i, j] = nome.Substring(aux2, 1);
                            aux2++;
                        }
                    }
                    //Prenche terceira linha.
                    else if (i == 2)
                    {
                        matriz[i, j] = (Convert.ToString(e));
                        e--;
                    }
                }
            }
            //Listar matriz.
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0,6}", matriz[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}
