using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Boligrafo : IAcciones
    {
        #region Campos

        private ConsoleColor colorTinta;
        private float tinta;

        #endregion

        #region Propiedades

        public float UnidadesDeEscritura
        {
            get { return tinta; }
            set { tinta = value; }
        }

        public ConsoleColor Color 
        { 
            get { return colorTinta; }
            set { colorTinta = value; }
        }

        #endregion

        #region Constructor

        public Boligrafo(int unidades, ConsoleColor color)
        {

        }

        #endregion

        public EscrituraWrapper Escribir(string texto)
        {
            throw new NotImplementedException();

        }

        public bool Recargar(int unidades)
        {
            return false;
        }

        public string ToString()
        {
            return "";
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            throw new NotImplementedException();
        }
    }
}
