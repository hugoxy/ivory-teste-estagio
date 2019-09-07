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
            int aux = 1;
            int aux2 = 0;

            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();

            //Valida tamanho da matriz de acordo com o tamanho do nome.
            c = nome.Count() + 2;

            //Cria matriz.
            string[,] matriz = new string[l, c];



            //Preencher matriz.
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (i == 1 && j > 0 && j < c - 1)
                    {
                        if (j < c)
                        {
                            matriz[i, j] = nome.Substring(aux2++, 1);
                        }
                    }
                    else
                    {
                        matriz[i, j] = (Convert.ToString(aux++));
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


