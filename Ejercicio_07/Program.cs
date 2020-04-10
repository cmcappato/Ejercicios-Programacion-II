using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";

            int diaNacimiento;
            int mesNacimiento;
            int anioNacimiento;
            int edadActual;

            DateTime fechaNacimiento;
            DateTime fechaActual = DateTime.Now;

            do
            {
                Console.Write("Ingrese dia de nacimiento: ");
                diaNacimiento = int.Parse(Console.ReadLine());
                if (diaNacimiento < 1 || diaNacimiento > 32)
                {
                    Console.WriteLine("Error, ingrese un día entre 1 y 31: ");
                    Console.ReadKey();
                }
            } while (diaNacimiento < 1 || diaNacimiento > 31);

            do
            {
                Console.Write("Ingrese mes de nacimiento: ");
                mesNacimiento = int.Parse(Console.ReadLine());
                if (mesNacimiento < 1 || mesNacimiento > 12)
                {
                    Console.WriteLine("Error, ingrese un mes entre 1 y 12: ");
                    Console.ReadKey();
                }
            } while (mesNacimiento < 1 || mesNacimiento > 12);

            do
            {
                Console.Write("Ingrese año de nacimiento: ");
                anioNacimiento = int.Parse(Console.ReadLine());
                if (anioNacimiento < 1)
                {
                    Console.WriteLine("Error, ingrese un año mayor a 1: ");
                    Console.ReadKey();
                }
            } while (anioNacimiento < 1);

            fechaNacimiento = new DateTime(anioNacimiento, mesNacimiento, diaNacimiento);
            edadActual = fechaActual.Subtract(fechaNacimiento).Days;

            Console.WriteLine("Fecha de nacimiento: " + diaNacimiento + "-" + mesNacimiento + "-" + anioNacimiento);
            Console.WriteLine("Fecha actual: " + DateTime.Now.ToString("dd-MM-yyyy"));
            Console.WriteLine("{0:#.###} dias de vida ", edadActual);
            Console.ReadKey();
        }
    }
}
