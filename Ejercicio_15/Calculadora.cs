using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static float Calcular(float numeroUno, float numeroDos, char operacion)
        {
            float resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado = numeroUno + numeroDos;
                    break;
                case '-':
                    resultado = numeroUno - numeroDos;
                    break;
                case '*':
                    resultado = numeroUno * numeroDos;
                    break;
                case '/':
                    if (Validar(numeroDos) == true)
                    {
                        resultado = numeroUno / numeroDos;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                    
                    break;

            }

            return resultado;
        }

        public static bool Validar(float numeroDos)
        {
            if (numeroDos == 0)
            {
                return false;
            }
            return true;
        }
    }
}
