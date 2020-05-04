using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Cliente
    {
		#region Campos

		private string nombre;
		private int numero;

		#endregion

		#region Propiedades

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public int Numero
		{
			get { return numero; }
		}

		#endregion

		#region Constructores

		public Cliente(int numero)
		{

		}

		public Cliente(int numero, string nombre)
		{

		}

		#endregion

		#region Sobrecarga de operadores

		public static bool operator ==(Cliente c1, Cliente c2)
		{
			return (c1.numero == c2.numero);
		}

		public static bool operator !=(Cliente c1, Cliente c2)
		{
			return !(c1 == c2);
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
