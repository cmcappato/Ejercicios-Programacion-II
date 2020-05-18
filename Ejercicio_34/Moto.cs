using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Moto : VehiculoTerrestre
    {
        #region Campos

        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cilindrada;

        #endregion

        #region Constructor

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadPuertas = 0;
            this.cilindrada = cilindrada;
        }

        #endregion
    }
}
