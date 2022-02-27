using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGB.Interfaces
{
    public partial class Interface_Default : Form
    {
        public Interface_Default()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Interface_Default_Load(object sender, EventArgs e)
        {
            asignar_nombres();
        }
        private void asignar_nombres()
        {
            label_usuario1.Text = Program.l_usuarios[0].nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == Program.l_usuarios[0].clave)
                {
//                     Interface_Escritorio form_escritorio = new Interface_Escritorio();
//                     Application.Run(form_escritorio);

                    MessageBox.Show("   🟥🟩🟦\n\n Bienvenido " + Program.l_usuarios[0].nombre + "❗\n\n   🟥🟩🟦");

                    Program.usar_escritorio();
                }
                else
                {
                    MessageBox.Show("La clave no es valida");
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error metodo button1_Click - Interface_Default" + ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
