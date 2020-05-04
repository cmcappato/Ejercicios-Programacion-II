using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class AutoF1
    {
        #region Campos

        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        #endregion

        #region Constructores

        public AutoF1(short numero, string escuderia)
        {

        }

        #endregion

        #region Métodos

        public string MostrarDatos()
        {
            return "";
        }

        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return ((a1.numero == a2.numero) && (a1.escuderia == a2.escuderia));
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
