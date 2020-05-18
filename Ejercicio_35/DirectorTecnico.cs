using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_35
{
    public class DirectorTecnico
    {
        #region Campos

        DateTime fechaNacimiento;

        #endregion

        #region Constructores

        private DirectorTecnico(string nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
        {

        }

        #endregion

        #region Métodos

        public string MostrarDatos()
        {
            return "";
        }

        #endregion

        #region Sobrecarga de operadores

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return (/*dt1.nombre == dt2.nombre &&*/ dt1.fechaNacimiento == dt2.fechaNacimiento);
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
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