using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 33";

            Libro miLibro = new Libro();

            Console.WriteLine(miLibro[2]);
            Console.WriteLine(miLibro[0]);
            Console.WriteLine(miLibro[5]);
            Console.WriteLine("----------------------");


            Console.ReadKey();

        }
    }
}
