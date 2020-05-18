using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            paginas = new List<string>();
            CargarPagina();
        }

        private void CargarPagina()
        {
           
            paginas.Add("Pagina 1");
            paginas.Add("Pagina 2");
            paginas.Add("Pagina 3");
            paginas.Add("Pagina 4");
        }


        public string this[int i]
        {
            get
            {
                if (i > 0 && i <= paginas.Count)
                {
                    return paginas[i - 1]; 
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                if (i > paginas.Count)
                {
                    paginas.Add(value);
                }
                else if (i >= 0)
                {
                    paginas[i] = value;
                }
            }
        }
    }
}
