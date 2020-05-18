using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumadorUno = new Sumador(1);
            Console.WriteLine(sumadorUno.Sumar(5, 5));
            Console.WriteLine(sumadorUno.Sumar("5", "5"));

            Sumador sumadorDos = new Sumador();
            Console.WriteLine(sumadorDos.Sumar(4, 9));
            Console.WriteLine(sumadorDos.Sumar("4", "9"));
                        
            Console.ReadKey();
        }
    }
}
