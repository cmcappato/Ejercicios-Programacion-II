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
        private float notaFinal = 0;
        public string apellido;
        public string nombre;
        public int legajo;

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
                notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            Console.Write("Ingrese la primera nota");
            nota1 = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda nota");
            nota2 = byte.Parse(Console.ReadLine());
        }

        public string Mostrar()
        {
            if (notaFinal == -1)
            {
                return "Alumno desaprobado";
            }
            return "";
        }

        #endregion
    }
}
