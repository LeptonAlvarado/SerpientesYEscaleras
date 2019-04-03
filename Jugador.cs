using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_y_escaleras
{
    class Jugador : Dado
    {
        private int _num;
        private int _pos;

        public Jugador (int num)
        {
            _num = num;
            _pos = 0;
        }

        public int Numero
        {
            get { return _num; }
        }

        public int Posicion
        {
            get { return _pos; }
        }

        new public void Avanzar()
        {
            int dado = base.Avanzar();

            _pos += dado;
        }

        public override string ToString()
        {
            return "El jugador " + Numero.ToString() + " Se encuentra en la casilla " + Posicion.ToString();
        }
    }
}
