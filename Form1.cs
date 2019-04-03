using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serpientes_y_escaleras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniJuego_Click(object sender, EventArgs e)
        {
            Tablero t1 = new Tablero();
            Jugador j1 = new Jugador(1);
            Jugador j2 = new Jugador(2);

            do
            {
                j1.Avanzar();
                t1.Verificar(j1.Posicion);
                j2.Avanzar();
                t1.Verificar(j2.Posicion);
                txtJuego.Text += j1.ToString() + Environment.NewLine + j2.ToString() + Environment.NewLine;
            } while (j1.Posicion < 100 && j2.Posicion < 100);

            if (j1.Posicion >= 100 && j2.Posicion >= 100)
                txtJuego.Text += "Hubo un empate" + Environment.NewLine;
            else if (j1.Posicion > j2.Posicion)
                txtJuego.Text += "Jugador 1 gano el juego";
            else
                txtJuego.Text += "Jugador 2 gano el juego";
        }
    }
}
