using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_01___IVORYIT
{
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
}
