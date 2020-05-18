using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    public class Persona
    {
		
		private long dni;
		private string nombre;


		public long Dni
		{
			get { return dni; }
			set { dni = value; }
		}

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string MostrarDatos()
		{
			return "";
		}

		public Persona(string nombre)
		{
			 
		}

		public Persona(string nombre, long dni) : this (nombre)
		{

		}

	}
}
