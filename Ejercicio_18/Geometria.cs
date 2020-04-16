using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area()
        {
            return area;
        }
        public float Perimetro()
        {
            return perimetro;
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            //this.vertice1 = Math.Abs(vertice1);
        }
    }
}


