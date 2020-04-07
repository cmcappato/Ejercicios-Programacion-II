using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";
            int valorMinimo = -100;
            int valorMaximo = 100;
            int cantidadDeNumeros = 5;

            int valorMinimoActual = valorMaximo;
            int valorMaximoActual = valorMinimo;
            int valorTotal = 0;
            int contador = 0;

            while (contador < cantidadDeNumeros)
            {
                Console.WriteLine("Ingrese un numero entre " + valorMinimo + " y " + valorMaximo);
                int valorTemporal = int.Parse(Console.ReadLine());
                if (Validacion.Validar(valorTemporal, valorMinimo, valorMaximo))
                {
                    if (valorTemporal > valorMaximoActual)
                    {
                        valorMaximoActual = valorTemporal;
                    }
                    if (valorTemporal < valorMinimoActual)
                    {
                        valorMinimoActual = valorTemporal;
                    }                        
                    valorTotal += valorTemporal;
                    contador++;
                }
                else
                {
                    Console.WriteLine("El valor ingresado es invalido");
                }
            }

            Console.WriteLine("El valor minimo ingresado es " + valorMinimoActual);
            Console.WriteLine("El valor maximo ingresado es " + valorMaximoActual);
            Console.WriteLine("El valor promedio ingresado " + valorTotal / cantidadDeNumeros);
            Console.ReadKey();
        }
    }
}
