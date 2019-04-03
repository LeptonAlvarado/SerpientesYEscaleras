using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serpientes_y_escaleras
{
    class Tablero
    {
        protected int[] tablero = new int [101];

        public Tablero()
        {
            for(int i=1;i<tablero.Length;i++)
            {
                tablero[i] = i;
            }            
            //Escaleras, aqui se declaran que casillas tendran escaleras
            tablero[4] = 25;
            tablero[13] = 46;
            tablero[24] = 35;
            tablero[42] = 63;
            tablero[50] = 69;
            tablero[62] = 81;
            tablero[74] = 92;
            tablero[84] = 97;
            //Serpientes, aqui se declaran que caasillas tendran serpientes
            tablero[27] = 5;
            tablero[40] = 3;
            tablero[43] = 18;
            tablero[54] = 31;
            tablero[66] = 45;
            tablero[77] = 58;
            tablero[89] = 53;
            tablero[95] = 60;
        }

        public int Verificar(int i)
        {
            int j = i;
            if (i < tablero.Length)
                if (tablero[i] != i)
                    return tablero[i];
                else
                    return tablero[i];
            else
                return tablero[i];
        }

    }
}
