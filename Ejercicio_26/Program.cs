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
            int[] numero = new int[20];            
            Random random = new Random();
                      

            do
            {                
                Console.WriteLine("Numero: " + random.Next());                
              
            } while(random.Next() != 0 && numero.Length < 20);


            Console.ReadKey();
        }
    }
}
