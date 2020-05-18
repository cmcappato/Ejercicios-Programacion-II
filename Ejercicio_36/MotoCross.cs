using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    public class MotoCross : VehiculoDeCarrera
    {
        #region Campos

        private short cilindrada;

        #endregion

        #region Propiedades

        public short Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }

        #endregion

        #region Constructores

        public MotoCross(short numero, string escuderia) :base (numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this (numero, escuderia)
        {

        }

        #endregion

        #region Métodos

        public override string MostrarDatos()
        {
            return "";
        }

        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return false;
        }
        
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return false;
        }

        #endregion

        #region Invalidaciones

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
