using System;
using System.Drawing;
using System.Windows.Forms;

namespace RGB.ClasesSistema.Programas.Utilidades
{
    public partial class Interface_Prog_Texto : Form
    {
        Color seleccionar_color = Color.Magenta;
        bool primero;
        

        public Interface_Prog_Texto()
        {
            InitializeComponent();
        }

        private void Interface_Prog_Texto_Load(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            texto.SelectionColor = seleccionar_color;
            if(primero)
            {
                texto.SelectedText = nuevo_texto.Text;           
            }
            else
            {
                texto.SelectedText = Environment.NewLine + nuevo_texto.Text;         
            }
            primero = false;
            nuevo_texto.Clear();
            nuevo_texto.Focus();
        }

        private void color_nuevo_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                seleccionar_color = colorDialog1.Color;
                color_nuevo.BackColor = seleccionar_color;
            }
        }


    }
}
