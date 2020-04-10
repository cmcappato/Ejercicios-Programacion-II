using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 09";
            int alturaPiramide;
            int linea;

            do
            {
                Console.Write("Ingrese altura de la piramide que desee imprimir: ");
                alturaPiramide = int.Parse(Console.ReadLine());

                if (alturaPiramide < 1)
                {
                    Console.Write("Por favor, ingrese un numero mayor o igual a 1: ");
                    Console.ReadKey();
                }

            } while (alturaPiramide < 1);

            Console.WriteLine("Piramide con altura de " + alturaPiramide + " asteriscos");

            for (linea = 1; linea <= alturaPiramide; linea++)
            {
                for (int dibujarLinea = 0; dibujarLinea < (linea * 2) - 1; dibujarLinea++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
