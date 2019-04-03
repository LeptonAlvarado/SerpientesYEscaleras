using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_y_escaleras
{
    class Jugador
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

        public void Avanzar(int dado)
        {
            _pos += dado;
        }
        
        public void SubirBajar(int pos)
        {
            _pos = pos;
        }
        
        public override string ToString()
        {
            return "El jugador " + Numero.ToString() + " Se encuentra en la casilla " + Posicion.ToString();
        }
    }
}
