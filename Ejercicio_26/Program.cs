using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Numero: " + random.Next());
            }

            Console.ReadKey();
        }
    }
}
