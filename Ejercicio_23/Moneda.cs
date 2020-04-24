using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_23
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
            cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Getters y Setters

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static double SetCotizacion()
        {
            return cotizRespectoDolar;
        }

        #endregion

        #region Sobrecargas implícitas y explícitas

        public static explicit operator Euro(Dolar d)
        {
            Euro euro = new Euro(d.cantidad * Euro.GetCotizacion());

            return euro;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos pesos = new Pesos(d.cantidad * Pesos.GetCotizacion());

            return pesos;
        }

        public static implicit operator Dolar(double d)
        {
            Dolar dolar = new Dolar(d);

            return dolar;
        }

        #endregion

        #region Sobrecargas de operadores de comparación

        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.GetCantidad() == e.GetCantidad());
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return (d.GetCantidad() == p.GetCantidad());
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.GetCantidad() == d2.GetCantidad());
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        #endregion

        #region Sobrecarga de operadores de asignación

        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar dolar = new Dolar(d.cantidad - ((Dolar)e).cantidad);

            return dolar;
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar dolar = new Dolar(d.cantidad - ((Dolar)p).cantidad);

            return dolar;
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar dolar = new Dolar(d.cantidad + ((Dolar)e).cantidad);

            return dolar;
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar dolar = new Dolar(d.cantidad + ((Dolar)p).cantidad);

            return dolar;
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
    public class Euro
    {
        #region Campos

        private double cantidad;
        private static double cotizRespectoDolar;

        #endregion

        #region Constructores

        private Euro()
        {
            cotizRespectoDolar = 1.16;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Getters y Setters

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static double SetCotizacion()
        {
            return cotizRespectoDolar;
        }

        #endregion

        #region Sobrecargas implícitas y explícitas

        public static explicit operator Dolar(Euro e)
        {
            Dolar dolar = new Dolar(e.cantidad * Euro.GetCotizacion());

            return dolar;
        }

        public static explicit operator Pesos(Euro e)
        {
            Pesos pesos = new Pesos(e.cantidad * Euro.GetCotizacion());

            return pesos;
        }

        public static implicit operator Euro(double d)
        {
            Euro euro = new Euro(d);

            return euro;
        }

        #endregion

        #region Sobrecargas de operadores de comparación

        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.GetCantidad() == d.GetCantidad());
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return (e.GetCantidad() == p.GetCantidad());
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.GetCantidad() == e2.GetCantidad());
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        #endregion

        #region Sobrecarga de operadores de asignación

        public static Euro operator -(Euro e, Dolar d)
        {
            Euro euro = new Euro(e.cantidad - ((Euro)d).cantidad);

            return euro;
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            Euro euro = new Euro(e.cantidad + ((Euro)p).cantidad);

            return euro;
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            Euro euro = new Euro(e.cantidad - ((Euro)p).cantidad);

            return euro;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            Euro euro = new Euro(e.cantidad + ((Euro)d).cantidad);

            return euro;
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
    public class Pesos
    {
        #region Campos

        private double cantidad;
        private static double cotizRespectoDolar;

        #endregion

        #region Constructores

        private Pesos()
        {
            cotizRespectoDolar = 38.33;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        #endregion

        #region Getters y Setters

        public double GetCantidad()
        {
            return cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static double SetCotizacion()
        {
            return cotizRespectoDolar;
        }

        #endregion

        #region Sobrecargas implícitas y explícitas

        public static explicit operator Dolar(Pesos p)
        {
            Dolar dolar = new Dolar(p.cantidad * Pesos.GetCotizacion());

            return dolar;
        }

        public static explicit operator Euro(Pesos p)
        {
            Euro euro = new Euro(p.cantidad * Pesos.GetCotizacion());

            return euro;
        }

        public static implicit operator Pesos(double d)
        {
            Pesos peso = new Pesos(d);

            return peso;
        }

        #endregion

        #region Sobrecargas de operadores de comparación

        public static bool operator ==(Pesos p, Dolar d)
        {
            return (p.GetCantidad() == d.GetCantidad());
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return (p.GetCantidad() == e.GetCantidad());
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return (p1.GetCantidad() == p2.GetCantidad());
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        #endregion

        #region Sobrecarga de operadores de asignación

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos pesos = new Pesos(p.cantidad - ((Pesos)d).cantidad);

            return pesos;
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos pesos = new Pesos(p.cantidad + ((Pesos)d).cantidad);

            return pesos;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos pesos = new Pesos(p.cantidad - ((Pesos)e).cantidad);

            return pesos;
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos pesos = new Pesos(p.cantidad + ((Pesos)e).cantidad);

            return pesos;
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
