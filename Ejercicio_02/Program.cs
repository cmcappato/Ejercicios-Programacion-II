using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";

            int numero;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.Write("Error. Reingresar numero: ");
                numero = int.Parse(Console.ReadLine());
            }

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El cuadrado del numero ingresado es: {0}", cuadrado);
            Console.WriteLine("El cubo del numero ingresado es: {0}", cubo);

            Console.ReadKey();
        }
    }
}
