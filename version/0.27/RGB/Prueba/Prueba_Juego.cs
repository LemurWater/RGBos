using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB.Prueba
{
    public partial class Prueba_Juego : Form
    {
        int nueva_x = 0;
        int nueva_y = 0;
        int distancia_x = 10;
        int distancia_y = 10;

        byte borde_y = 90;

        public Prueba_Juego()
        {
            InitializeComponent();
        }

        private void Prueba_Juego_Load(object sender, EventArgs e)
        {

        }





        private void Prueba_Juego_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                Arriba.Enabled = true;
            }
            if(e.KeyCode == Keys.S)
            {
                Abajo.Enabled = true;
            }
            if (e.KeyCode == Keys.A)
            {
                Izquierda.Enabled = true;
            }
            if (e.KeyCode == Keys.D)
            {
                Derecha.Enabled = true;
            }
        }

        private void Prueba_Juego_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                Arriba.Enabled = false;
            }
            if (e.KeyCode == Keys.S)
            {
                Abajo.Enabled = false;
            }
            if (e.KeyCode == Keys.A)
            {
                Izquierda.Enabled = false;
            }
            if (e.KeyCode == Keys.D)
            {
                Derecha.Enabled = false;
            }
        }





        private void Arriba_Tick(object sender, EventArgs e)
        {
            if(label1.Location.Y > 0)
            {
                nueva_y = label1.Location.Y - distancia_y;
                label1.Location = new Point(label1.Location.X, nueva_y);
            }
        }
        private void Abajo_Tick(object sender, EventArgs e)
        {
            if (label1.Location.Y < this.Height - borde_y)
            {
                nueva_y = label1.Location.Y + distancia_y;
                label1.Location = new Point(label1.Location.X, nueva_y);
            }
        }
        private void Izquierda_Tick(object sender, EventArgs e)
        {
            if(label1.Location.X > 0)
            {
                nueva_x = label1.Location.X - distancia_x;
                label1.Location = new Point(nueva_x, label1.Location.Y);
            }
        }
        private void Derecha_Tick(object sender, EventArgs e)
        {
            if (label1.Location.X < this.Width - 115)
            {
                nueva_x = label1.Location.X + distancia_x;
                label1.Location = new Point(nueva_x, label1.Location.Y);
            }
        }
    }
}
