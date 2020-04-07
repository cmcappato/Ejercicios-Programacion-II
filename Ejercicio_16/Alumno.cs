using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        #region Campos

        private byte nota1 = 0;
        private byte nota2 = 0;
        private byte notaFinal = 0;
        public string apellido;
        public int legajo;
        public string nombre;

        #endregion

        #region Métodos

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                notaFinal = nota1 + nota2;
            }
            else
            {

            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            Console.Write("Ingrese la primera nota");
            notaUno = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda nota");
            notaDos = byte.Parse(Console.ReadLine());
        }

        public string Mostrar()
        {
            if (notaFinal == -1)
            {
                Console.WriteLine("Alumno desaprobado");
            }
            return "";
        }

        #endregion
    }
}
