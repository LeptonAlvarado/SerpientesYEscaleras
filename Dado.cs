using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_y_escaleras
{
    class Dado
    {
        private static Random numAle = new Random();
        private const int MINIMO = 1;
        private const int MAXIMO = 6;

        public int Lanzar()
        {
            return numAle.Next(MINIMO, MAXIMO+1);
        }
    }
}
