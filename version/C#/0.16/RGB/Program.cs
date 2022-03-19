using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RGB.Clases;

using System.IO;

using RGB.Interfaces;
using System.Windows.Forms;

using RGB.Sistema;


namespace RGB
{
    class Program
    {
        static string version = "Ver 0.14g";


        static string[] test = { "aaaaaaaaaaaaaa", "bbbbbbbbbbbbbb" };
        static char char_marco = '█';

        string[] txt_esp = { "Ingrese el nombre del nuevo usuario", "Ingrese la contrasena" };
        string[] txt_ing = { "Enter a name for the new user", "Create new password" };
        string[] txt_kor;
        public static List<Usuario> l_usuarios = new List<Usuario>();
        static public byte tamano_x = 80, tamano_y = 28;

        //Forms
        static Interface_Nuevo_Usuario form_n_usuario = new Interface_Nuevo_Usuario();


        static bool crear_n_usuario = true;



        static void Main(string[] args)
        {
            try
            {
                //Pantalla de inicio (Consola)
                Inicio.Imprimir();


                Console.SetWindowSize(tamano_x, tamano_y);

                //public Idioma idioma = Idioma.Espanol;
                //public enum Idiomaa { Espanol, Ingles, Coreano };
                //public Idiomaa idioma;

                Version();

                Ingresar.Correr();


                Marco(test);

                Console.ReadLine();
            }
            catch (Exception e)
            {
                throw new Exception("Error en metodo Main" + e);
            }
        }
        //





        private void guardar_acciones(string texto)
        {

        }

        private static void Version()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("R");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("G");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("B");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" - " + version);
            Console.WriteLine(" - - - - - - - - -\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Mensaje_Del_Sistema(string texto)
        {
            ConsoleColor tmp_fondo = Console.BackgroundColor;
            ConsoleColor tmp_texto = Console.ForegroundColor;

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("\n*   " + texto + "                 " + DateTime.Now + "\n");


            Console.BackgroundColor = tmp_fondo;
            Console.ForegroundColor = tmp_texto;
        }

        static void Marco(string linea)
        {
            try
            {
                //Texto
                byte relleno = (byte)(linea.Length - 4);
                string espacio = "";
                for (byte i = 0; i < (tamano_x - 8 - relleno); i++)
                {
                    espacio += " ";
                }
                Console.Write(char_marco + " " + linea + espacio + " " + char_marco + "\n");
            }
            catch (Exception ex)
            {
                throw new Exception("Error metodo Marco " + ex);
            }
        }
        static void Marco(string[] lineas) // █▓▒░
        {
            try
            {
                //Primera linea
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;

                Console.Clear();

                for (byte i = 0; i < tamano_x; i++)
                {
                    Console.Write(char_marco);
                }
                Console.WriteLine();
                foreach (string lineaa in lineas)
                {
                    Marco(lineaa);
                }
                //Ultima linea
                for (byte i = 0; i < tamano_x; i++)
                {
                    Console.Write(char_marco);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error en el metodo Marco - " + e);
            }
        }
    }
}