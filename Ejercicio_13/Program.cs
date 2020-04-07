using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 13";

            double numero = 1234;
            string numeroBinario;
            double numeroDecimal;

            numeroBinario = Conversor.DecimalBinario(numero);
            numeroDecimal = Conversor.BinarioDecimal(numeroBinario);

            Console.WriteLine("El numero a convertir es: " + numero);
            Console.WriteLine("Decimal-binario: " + numeroBinario);
            Console.WriteLine("Binario-decimal: " + numeroDecimal);
            Console.ReadKey();
        }
    }
}
