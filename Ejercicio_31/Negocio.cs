using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class Negocio
    {
        #region Campos

        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        #endregion

        #region Propiedades

        public Cliente Cliente
        {
            get;
            set;
        } 

        #endregion

        #region Constructores

        private Negocio()
        {
            clientes = new Queue<Cliente>();
        }

        public Negocio(string nombre)
        {

        }

        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(Negocio n, Cliente c)
        {
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return false;
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            return false;
        }

        public static bool operator ~(Negocio n)
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
