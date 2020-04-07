using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";

            double ladoCuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double diametroCirculo;
            double area;
            int opcion;

            do
            {
                Console.WriteLine("¿Qué operación desea realizar?");
                Console.WriteLine("1- Calculo de area de un cuadrado");
                Console.WriteLine("2- Calculo de area de un triángulo");
                Console.WriteLine("3- Calculo de area de un círculo");
                Console.WriteLine("4- Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el lado del cuadrado del cual desea calcular el area: ");
                        ladoCuadrado = int.Parse(Console.ReadLine());
                        area = CalculoDeArea.CalcularCuadrado(ladoCuadrado);
                        Console.WriteLine("El area del cuadrado es {0:0.00}", area);
                        break;
                    case 2:
                        Console.Write("Ingrese la base del triangulo del cual desea calcular el area: ");
                        baseTriangulo = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la atura del triangulo del cual desea calcular el area: ");
                        alturaTriangulo = int.Parse(Console.ReadLine());
                        area = CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo);
                        Console.WriteLine("El area del triangulo es {0:0.00}", area);
                        break;
                    case 3:
                        Console.Write("Ingrese el diametro del círculo del cual desea calcular el area: ");
                        diametroCirculo = int.Parse(Console.ReadLine());
                        area = CalculoDeArea.CalcularCirculo(diametroCirculo);
                        Console.WriteLine("El area del círculo es {0:0.00}", area);
                        break;
                    case 4:
                        Console.WriteLine("Usted salio del programa, gracias por utilizarlo.");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta, seleccione una opcion del 1 al 4: ");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            } while (opcion != 4);

            Console.ReadKey();
        }
    }
    }
}
