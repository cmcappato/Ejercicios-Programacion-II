using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";
            int numero = 0;
            char c;

            do
            {
                Console.Write("Ingrese un numero para sumar: ");
                numero = numero + int.Parse(Console.ReadLine());

                Console.Write("Desea continuar? S/N: ");
                c = char.Parse(Console.ReadLine());

            } while (ValidarRespuesta.ValidaS_N(c));

            Console.Write("La suma es: {0}", numero);
            Console.ReadKey();
        }
    }
}
