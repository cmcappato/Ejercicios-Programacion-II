using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";

            int numero;
            int contador = 0;

            Console.Write("Ingrese un numero para buscar los numeros primos hasta el numero ingresado: ");
            numero = int.Parse(Console.ReadLine());

            while (numero <= 1)
            {
                if (numero == 1)
                {
                    Console.Write("Error, el 1 no es considerado un numero primo, por favor ingrese otro numero: ");
                    numero = int.Parse(Console.ReadLine());
                }
                else if (numero < 0)
                {
                    Console.Write("Error, los numeros por debajo de 1 no son primos, por favor ingrese otro numero: ");
                    numero = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 2; i <= numero; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    Console.Write(i + " ");
                }
                contador = 0;
            }

            Console.ReadKey();
        }
    }
}
