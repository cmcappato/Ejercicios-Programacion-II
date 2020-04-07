using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            String cadena = "";

            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = (int)(numero / 2);
                }
            }
            else
            {
                if (numero == 0)
                {
                    cadena = "0";
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros positivos");
                }
            }
            return cadena;
        }

        public static double BinarioDecimal(string cadena)
        {
            char[] array = cadena.ToCharArray();
            Array.Reverse(array);

            double numero = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    numero += (double)Math.Pow(2, i);
                }
            }
            return numero;
        }
    }
}
