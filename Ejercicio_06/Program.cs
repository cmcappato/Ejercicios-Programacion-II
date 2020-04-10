using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";

            int anioInicio = 0;
            int anioFinal = 0;
            int contador = 0;

            do
            {
                while (anioInicio < 1)
                {
                    Console.Write("Ingrese año de inicio: ");
                    anioInicio = int.Parse(Console.ReadLine());

                    if (anioInicio < 1)
                    {
                        Console.WriteLine("El año ingresado debe ser mayor o igual a 1, por favor ingrese otro año: ");
                        Console.ReadKey();
                    }
                }
                while (anioFinal < 1)
                {
                    Console.Write("Ingrese año final: ");
                    anioFinal = int.Parse(Console.ReadLine());

                    if (anioFinal < 1)
                    {
                        Console.WriteLine("El año ingresado debe ser mayor o igual a 1, por favor ingrese otro año: ");
                        Console.ReadKey();
                    }
                }

                if (anioFinal < anioInicio)
                {
                    Console.WriteLine("El año final no puede ser menor que el inicial, por favor reingrese: ");
                    Console.ReadKey();
                }
            } while (anioFinal < anioInicio);

            Console.Clear();
            Console.Write("Años bisiestos: ");

            for (int i = anioInicio; i <= anioFinal; i++)
            {
                if ((i % 4) == 0 && (i % 100 != 0 || i % 400 == 0))
                {
                    contador++;
                    Console.Write("{0,7:#,###}", i);
                    contador = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
