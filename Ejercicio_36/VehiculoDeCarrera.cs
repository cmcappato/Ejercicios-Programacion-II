using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    public class VehiculoDeCarrera
    {
        #region Campos

        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        #endregion

        #region Propiedades

        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return enCompetencia; }
            set { enCompetencia = value; }
        }

        public string Escuderia
        {
            get { return escuderia; }
            set { escuderia = value; }
        }

        public short Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { vueltasRestantes = value; }
        }

        #endregion
        
        #region Constructores

        public VehiculoDeCarrera(short numero, string escuderia)
        {

        }

        #endregion

        #region Métodos

        public virtual string MostrarDatos()
        {
            return "";
        }

        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return false;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
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
