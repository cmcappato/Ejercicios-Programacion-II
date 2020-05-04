using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Automovil : VehiculoTerrestre
    {
        #region Campos

        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        private short cantidadMarchas;
        private int cantidadPäsajeros;

        #endregion

        #region Constructor

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPäsajeros) : base (cantidadRuedas, cantidadPuertas, color)
        {            
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPäsajeros = cantidadPäsajeros;
        }

        #endregion
    }
}
