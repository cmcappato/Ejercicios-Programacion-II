using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    public class Equipo
    {
        #region Campos

        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        #endregion

        #region Constructores

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        #endregion

        #region Sobrecarga de operadores

        public static bool operator +(Equipo e, Jugador j)
        {
            bool agrego = false;

            if ((e.jugadores.Count < e.cantidadDeJugadores) && e.nombre.Equals(j))
            {
                e.jugadores.Add(j);
                agrego = true;
            }

            return agrego;
        }

        #endregion
    }
}
