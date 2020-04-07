using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 10";

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
                for (int dibujarEspacio = 0; dibujarEspacio < (alturaPiramide - linea); dibujarEspacio++)
                {
                    Console.Write(" ");
                }
                for (int dibujarAsterisco = 0; dibujarAsterisco < (linea * 2) - 1; dibujarAsterisco++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
