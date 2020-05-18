using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public int NumeroActual 
        { 
            get { return numeroActual; } 
        }

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {

        }

        public bool Atender(Cliente cli)
        {
            


            return false;
        }







    }
    public enum Puesto
    {
        Caja1,
        Caja2
    }
}
