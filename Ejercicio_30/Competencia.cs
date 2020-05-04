using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class Competencia
    {
        #region Campos

        short cantidadCompetidores;
        short cantidadVueltas;
        List<AutoF1> competidores;

        #endregion

        #region Constructores

        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores)
        {

        }


        public string MostrarDatos()
        {
            return "";
        }

        #endregion

        #region Sobrecarga de operadores

        public static bool operator -(Competencia c, AutoF1 a)
        {
            return false;
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            return false;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
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
