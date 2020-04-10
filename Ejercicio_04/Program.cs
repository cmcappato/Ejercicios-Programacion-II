using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";

            int numero = 0;
            int acumulador = 0;
            int i = 1;

            while (numero < 4)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        acumulador += j;
                    }
                }

                if (acumulador == i)
                {
                    if (numero == 0)
                    {
                        Console.WriteLine("Los primeros 4 numeros perfectos son: ");
                    }
                    Console.WriteLine("{0:#,###}", i);
                    numero++;
                }

                acumulador = 0;
                i++;
            }

            Console.ReadKey();
        }
    }
}
