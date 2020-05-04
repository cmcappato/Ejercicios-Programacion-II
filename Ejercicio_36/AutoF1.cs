using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    public class AutoF1 : VehiculoDeCarrera
    {
        #region Campos

        private short caballosDeFuerza;
        
        #endregion

        #region Propiedades

        public short CaballosDeFuerza
        {
            get { return caballosDeFuerza; }
            set { caballosDeFuerza = value; }
        }

        #endregion

        #region Constructores

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this (numero, escuderia)
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

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return ((a1.Numero == a2.Numero) && (a1.Escuderia == a2.Escuderia));
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
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
