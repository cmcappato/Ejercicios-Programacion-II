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
            this.tinta = tinta;
            Console.BackgroundColor = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short nivelTinta = GetTinta();
            short auxGasto = short.Parse((gasto * -1).ToString());

            bool validarPinto;

            dibujo = "";

            if ((nivelTinta - gasto) >= 0 && (nivelTinta - gasto) <= Boligrafo.cantidadTintaMaxima)
            {
                for (int i = 0; i < gasto; i++)
                {
                    dibujo = dibujo + "*";
                }

                SetTinta(auxGasto);

                validarPinto = true;
            }
            else
            {
                dibujo = "SIN TINTA SUFICIENTE";
                validarPinto = false;
            }

            return validarPinto;
        }

        public void Recargar()
        {
            this.tinta = Boligrafo.cantidadTintaMaxima;
        }

        private void SetTinta(short tinta)
        {
            short nivelTinta = this.tinta;

            if ((nivelTinta + tinta) >= 0 && (nivelTinta + tinta) <= Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = short.Parse((nivelTinta + tinta).ToString());
                //Console.WriteLine("QUEDAN " + this.tinta);
                //Recargar();
                //Console.WriteLine("QUEDAN " + this.tinta);
            }
        }
    }
}
