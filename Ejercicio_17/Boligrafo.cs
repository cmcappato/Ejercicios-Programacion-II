using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {

        }

        public ConsoleColor GetColor()
        {
            return ConsoleColor.Red;
        }

        public short GetTinta()
        {
            return 0;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";

            return false;
        }

        public void Recargar()
        {

        }

        private void SetTinta(short tinta)
        {

        }
    }
}
