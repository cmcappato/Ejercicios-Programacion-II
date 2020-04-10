using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";

            float numeroUno;
            float numeroDos;
            char operacion;

            do
            {
                Console.WriteLine("Ingrese el primer numero: ");
                numeroUno = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero: ");
                numeroDos = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la operacion que desea realizar [+ - * /]: ");
                operacion = char.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("{0:#,###.00}", Calculadora.Calcular(numeroUno, numeroDos, operacion));
                Console.WriteLine("Desea continuar? [S] Si - [Cualquier tecla] No: ");

            } while (Console.ReadKey().KeyChar == 's');
        }
    }
}
