using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        #region Campos

        private double cantidad;
        private static double cotizRespectoDolar;

        #endregion

        #region Constructores

        private Dolar()
        {

        }

        public Dolar(double cantidad)
        {

        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {

        }

        #endregion

        #region Getters

        public double GetCantidad()
        {
            return 0;
        }

        public static double GetCotizacion()
        {
            return 0;
        }

        #endregion

        #region Sobrecargas implícitas y explícitas

        public static explicit operator Euro(Dolar d)
        {
            return d;
        }

        public static explicit operator Pesos(Dolar d)
        {
            return d;
        }

        public static implicit operator Dolar(double d)
        {
            return d;
        }

        #endregion

        #region Sobrecargas de operadores de comparación

        public static bool operator !=(Dolar d, Euro e)
        {
            return true;
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return true;
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return true;
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return true;
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return true;
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return true;
        }

        #endregion

        #region Sobrecarga de operadores de asignación

        public static Dolar operator -(Dolar d, Euro e)
        {
            return d - e;
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            return d - p;
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return d + e;
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            return d + p;
        } 

        #endregion
    }
    public class Euro
    {
        #region Campos

        private double cantidad;
        private static double cotizRespectoDolar;

        #endregion

        #region Constructores

        private Euro()
        {

        }

        public Euro(double cantidad)
        {

        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {

        }

        #endregion

        #region Getters

        public double GetCantidad()
        {
            return 0;
        }

        public static double GetCotizacion()
        {
            return 0;
        }

        #endregion

        #region Sobrecargas implícitas y explícitas

        public static explicit operator Dolar(Euro e)
        {
            return e;
        }

        public static explicit operator Pesos(Euro e)
        {
            return e;
        }

        public static implicit operator Euro(double d)
        {
            return d;
        }

        #endregion

        #region Sobrecargas de operadores de comparación

        public static bool operator !=(Euro e, Dolar d)
        {
            return true;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return true;
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return true;
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return true;
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return true;
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return true;
        }

        #endregion

        #region Sobrecarga de operadores de asignación

        public static Euro operator -(Euro e, Dolar d)
        {
            return e - d;
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            return e - p;
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return e + d;
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            return e + p;
        }

        #endregion
    }
    public class Pesos
    {
        #region Campos

        private double cantidad;
        private static double cotizRespectoDolar;

        #endregion

        #region Constructores

        private Pesos()
        {

        }

        public Pesos(double cantidad)
        {

        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {

        }

        #endregion

        #region Getters

        public double GetCantidad()
        {
            return 0;
        }

        public static double GetCotizacion()
        {
            return 0;
        }

        #endregion

        #region Sobrecargas implícitas y explícitas

        public static explicit operator Dolar(Pesos p)
        {
            return p;
        }

        public static explicit operator Euro(Pesos p)
        {
            return p;
        }

        public static implicit operator Pesos(double d)
        {
            return d;
        }

        #endregion

        #region Sobrecargas de operadores de comparación

        public static bool operator !=(Pesos p, Dolar d)
        {
            return true;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return true;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return true;
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return true;
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return true;
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return true;
        }

        #endregion


        #region Sobrecarga de operadores de asignación

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return p - d;
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            return p - e;
        }
        public static Pesos operator +(Pesos p, Dolar d)
        {
            return p + d;
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            return p + e;
        }

        #endregion
    }
}
