# ivory-teste-estagio-setembro-2019

<p align="center">
  <img src="https://user-images.githubusercontent.com/36079471/64477946-ca7cca00-d177-11e9-8af5-3ce15a73826b.png">
</p>

## Questão 01

Codigo melhorado de acordo com as recomendações do detetive:

```
class Program
    {
        static void Main(string[] args)
        {
            var numero = 5;

            var resultado = Calcular(numero);

            Console.WriteLine($"Resultado:{resultado}");
            Console.ReadKey();

        }
        //Função calcular fatorial.
        static int Calcular(int numero)
        {
            var resultado = 0;

            if (numero <= 1)
            {
                return (1);
            }
            else
            {
                resultado = numero*Calcular(numero - 1);
                return (resultado);
            }
        }
    }
```

## Questão 02

```
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
```


