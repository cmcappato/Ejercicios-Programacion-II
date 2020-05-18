using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_36
{
    public class Competencia
    {
        #region Campos

        short cantidadCompetidores;
        short cantidadVueltas;
        List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        #endregion

        #region Propiedades

        public short CantidadCompetidores
        {
            get { return cantidadCompetidores; }
            set { cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return cantidadVueltas; }
            set { cantidadVueltas = value; }
        }

        /*
        public VehiculoDeCarrera this[int i]
        {
            get
            {                
                {
                    return VehiculoDeCarrera;
                }
            }
            
        }
        */

        public TipoCompetencia Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        #endregion

        #region Constructores

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo)
        {
            this.tipo = tipo;
        }

        #endregion

        #region Métodos

        public string MostrarDatos()
        {
            return "";
        } 

        #endregion

        #region Sobrecarga de operadores

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            return false;
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            return false;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
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

    public enum TipoCompetencia
    {
        F1,
        MotoCross
    }
}
