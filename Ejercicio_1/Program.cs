using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            float numero;
            float maximo = 0;
            float minimo = 0;
            int contador = 0;
            float acumulador = 0;

            while (contador < 5)
            {
                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());

                if (contador == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }
                else if (numero < minimo)
                {
                    minimo = numero;
                }
                else if (numero > maximo)
                {
                    maximo = numero;
                }
                acumulador = acumulador + numero;
                contador++;
            }

            float promedio = acumulador / 5;

            Console.WriteLine("Número mínimo: {0}", minimo);
            Console.WriteLine("Numero maximo: {0}", maximo);
            Console.WriteLine("Promedio: {0}", promedio);

            Console.ReadKey();
        }
    }
}
