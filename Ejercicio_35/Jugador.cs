using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    public class Jugador
    {
        #region Campos

        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        #endregion

        #region Propiedades

        public int DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int PartidosJugados
        {
            get { return partidosJugados; }
        }


        public float PromedioDeGoles
        {
            get { return (promedioGoles = totalGoles / partidosJugados); }
        }

        public int TotalGoles
        {
            get { return totalGoles; }
        }

        #endregion

        #region Constructores

        private Jugador()
        {
            partidosJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        #endregion

        #region Métodos

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("***************************************");
            sb.AppendLine("Datos del jugador:");
            sb.AppendLine("Nombre del jugador: " + nombre);
            sb.AppendLine("DNI: " + dni);
            sb.AppendLine("Partidos que jugó: " + partidosJugados);
            sb.AppendLine("Cantidad de goles totales: " + totalGoles);
            sb.AppendLine("Promedio de goles: " + promedioGoles);
            sb.AppendLine("***************************************");

            return sb.ToString();
        }

        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.dni == j2.dni);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
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
