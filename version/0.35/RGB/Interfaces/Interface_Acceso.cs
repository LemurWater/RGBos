using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RGB.ClasesSistema;
using RGB.ClasesSistema.Usuarios;

using RGB.ClasesSistema._Complementario;

namespace RGB.Interfaces
{
    public partial class Interface_Acceso : Form
    {
        //Atributos
        public Usuario usuario_activo;
        //Constructor
        public Interface_Acceso()
        {
            InitializeComponent();
        }


        //Metodos

        private void cargar_imagen()
        {
            nombre_principal.Text = Program.l_usuarios[0].Nombre;

            imagen_principal_caracter.Text = Program.l_usuarios[0].Avatar_usuario.Caracter.ToString();
            imagen_principal_caracter.ForeColor = Program.l_usuarios[0].Avatar_usuario.Color_caracter;
            imagen_principal_caracter.BackColor = Program.l_usuarios[0].Avatar_usuario.Color_fondo;

            imagen_principal_marco.BackColor = Program.l_usuarios[0].Avatar_usuario.Color_marco;
        }
        public void Cambiar_Usuario(Usuario usuario)
        {
            try
            {
                usuario_activo = usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la CLASE Interface_Acceso - METODO Cambiar_Usuario(Usuario) + " + ex);
            }
        }
        //Metodos GUI
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Interface_Default_Load(object sender, EventArgs e)
        {           
            try
            {
                //
                cargar_imagen();
                //               
                Location = new Point((Screen.PrimaryScreen.Bounds.Width / 2) - (Size.Width / 2) + 5, (Screen.PrimaryScreen.Bounds.Height / 2) - (Size.Height / 2) - 35);
                Console.SetWindowPosition(Location.X, Location.Y);
            }
            catch(Exception ex)
            {
                throw new Exception("Error en la CLASE Interface_Acceso - METODO Interface_Default_Load() + " + ex);
            }
        }

        private void Click_Acceder(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == Program.l_usuarios[0].Clave_usuario.Clave_texto)
                {
                    Program.Mensaje_Del_Sistema("Acceso: " + Program.l_usuarios[0].Nombre);

                    MessageBox.Show("   🟥🟩🟦\n\n Bienvenido " + Program.l_usuarios[0].Nombre + "❗\n\n   🟥🟩🟦");

                    Hide();
                    Complementario.Usar_Escritorio();
                }
                else
                {
                    MessageBox.Show("La clave no es valida - INTENTOS: " + Programa.Cantidad_Intentos() + "/" + Complementario.Obtener_Usuario_Bloqueo_Intentos());
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
