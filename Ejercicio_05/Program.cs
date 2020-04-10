using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";

            int numero;
            int acumuladorNeg = 0;
            int acumuladorPos = 0;
            int auxiliarAcumuladorPos = 0;

            Console.Write("Ingrese un numero para buscar centros numericos hasta el ingresado: ");
            numero = int.Parse(Console.ReadLine());

            while (numero < 1)
            {
                Console.Write("Error, el número debe ser mayor o igual a 1, por favor ingrese otro numero: ");
                numero = int.Parse(Console.ReadLine());
                Console.ReadKey();
            }

            for (int i = 1; i <= numero; i++)
            {
                while (i > 1)
                {
                    for (int j = 1; j < i; j++)
                    {
                        acumuladorNeg += j;
                    }
                    acumuladorPos = i + 1;
                    auxiliarAcumuladorPos = i + 1;

                    while (acumuladorNeg >= acumuladorPos)
                    {
                        if (acumuladorNeg == acumuladorPos)
                        {
                            Console.WriteLine("Centro numerico: 1..." + (i - 1) + " [" + i + "] " + (i + 1) + "..." + auxiliarAcumuladorPos);
                            break;
                        }
                        else
                        {
                            auxiliarAcumuladorPos += 1;
                            acumuladorPos += auxiliarAcumuladorPos;
                        }
                    }
                    acumuladorPos = 0;
                    acumuladorNeg = 0;
                    auxiliarAcumuladorPos = 0;
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
