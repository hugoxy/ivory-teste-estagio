# ivory-teste-estagio-setembro-2019


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
-
-
-
-
-
-
```


