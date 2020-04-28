using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Automovil
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cilindrada;




        

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cilindrada = cilindrada;
        }
    }


}
