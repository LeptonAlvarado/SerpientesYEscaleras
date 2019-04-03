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

        public int Avanzar()
        {
            int x = numAle.Next(1, 7);
            return x;
        }
    }
}
