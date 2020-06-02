using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public float UnidadesDeEscritura
        {
            get { return tamanioMina; }
            set { tamanioMina = value; }
        }

        public ConsoleColor Color
        {
            get { return ConsoleColor.Gray; }
            set => throw new NotImplementedException();
        }

        public Lapiz(int unidades)
        {

        }

        public EscrituraWrapper Escribir(string texto)
        {
            throw new NotImplementedException();
        }

        public bool Recargar(int unidades)
        {
            return false;
        }

        public string ToString()
        {
            return base.ToString();
        }

        /*
         Dos interfaces pueden tener metodos con el mismo nombre pero hacer otra cosa
        La interfaz te obliga a implementar el método
        GENERALMENTE SE USA LA INTERFAZ EXPICITA
        Puede pasar que haya que usarlo para diferenciar el explicito
         */


    }
}
